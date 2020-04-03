using System;
using System.Collections.Generic;
using System.IO;

namespace SudoC
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args[0].EndsWith(".sudoc")) args[0] += ".sudoc";
            SudoC_Main.SudoC_Lexxer easyC_Lexxer = new SudoC_Main.SudoC_Lexxer();
            SudoC_Main.sudoC_Assembler easyC_Assembler = new SudoC_Main.sudoC_Assembler();
            File.WriteAllText(".\\Output.c", easyC_Assembler.Assemble(easyC_Lexxer.Lex(File.ReadAllText(args[0]))));
        }
    }
    public static class SudoC_Main
    {
        public enum SudoCInnerCode
        {
            print,
            vstring,
            scan
        }
        public class SudoC_Pair
        {
            public SudoC_Pair(SudoCInnerCode innerCode, string[] args)
            {
                InnerCode = innerCode;
                Args = args;
               
            }
            public SudoCInnerCode InnerCode { get; private set; }
            public string[] Args { get; private set; }
        }
        public class SudoC_Lexxer
        {
            private string sConstructor = string.Empty;
            private string sBuilder = string.Empty;
            private int iCounter = 0;
            private bool bInBrackets = false;
            private List<string> dVars = new List<string>();
            private List<SudoC_Pair> Lexxed_Code = new List<SudoC_Pair>();
            /// <summary>
            /// Main Lexxer Function
            /// </summary>
            /// <param name="Code">Code from user.</param>
            /// <returns>Inner_EasyC Output</returns>
            public SudoC_Pair[] Lex(string Code)
            {
                foreach (char Char in Code)
                {
                    iCounter++;
                    sBuilder += Char;
                    if (sBuilder.Contains("print"))
                    {

                        if (Char == ')')
                        {
                            bInBrackets = false;
                            foreach (SudoC_Pair SudoC_Pair in pPrintBracksLexxer(sConstructor))
                                Lexxed_Code.Add(SudoC_Pair);
                            sConstructor = string.Empty;
                            sBuilder = string.Empty;
                        }

                        if (bInBrackets)
                        {
                            sConstructor += Char;
                        }

                        if (Char == '(')
                        {
                            bInBrackets = true;
                        }
                    }
                }
                return Lexxed_Code.ToArray();
            }
            /// <summary>
            /// Lexxes Print Bracks
            /// </summary>
            /// <param name="sInBracks"> Input Brackets</param>
            /// <returns></returns>
            private SudoC_Pair[] pPrintBracksLexxer(string sInBracks)
            {
                bool bInDQs = false;
                bool bInOuts = false;
                string sBuilder = string.Empty;
                string sConstructor = string.Empty;
                char LastChar = '.';
                List<SudoC_Pair> Instructions = new List<SudoC_Pair>();
                List<SudoC_Pair> printInstructions = new List<SudoC_Pair>();
                foreach (char Char in sInBracks)
                {    //Qoutes E
                    if ((Char == '\"' && bInDQs) || (Char == '\'' && !bInOuts))
                    {
                        bInDQs = false;
                        printInstructions.Add(new SudoC_Pair(SudoCInnerCode.print, new string[] { "\"" + sConstructor + "\"" }));
                        sConstructor = string.Empty;
                    }

                    //Out End
                    if (Char == '\'' && bInOuts)
                    {
                        bInOuts = false;
                        bInDQs = true;
                        foreach (SudoC_Pair sudoC_Pair in pStringProccessor(sBuilder)) {
                            if (!(sudoC_Pair.InnerCode == SudoCInnerCode.print))
                            {
                                Instructions.Add(sudoC_Pair);
                            }
                            else
                            {
                            printInstructions.Add(sudoC_Pair);
                            }
                        }
                        sBuilder = string.Empty;
                    }


                    if (bInDQs)
                    {
                        if (Char != '\'')
                        {
                            sConstructor += Char;
                        }

                    }

                    if (bInOuts)
                    {
                        sBuilder += Char;
                    }

                    if (Char == '\"')
                    {
                        bInDQs = true;
                    }

                    if (Char == '\'')
                    {
                        bInOuts = true;
                    }
                    LastChar = Char;
                }
                foreach (SudoC_Pair sudoC_Pair in printInstructions) Instructions.Add(sudoC_Pair);
                return Instructions.ToArray();
            }
            private static int iStringNameCounter = 0;
            //print("your name is 'input()' means ur gay")
            /// <summary>
            /// 
            /// </summary>
            /// <param name="input"></param>
            /// <returns></returns>
            private SudoC_Pair[] pStringProccessor(string input)
            {
                bool bDoInput = false;
                string sBuilder = string.Empty;
                string sConstructer = string.Empty;
                bool bGenerateName = false;
                var sVarName = "Input" + iStringNameCounter;
                List<SudoC_Pair> sudoC_Pairs = new List<SudoC_Pair>();
                foreach (char Char in input)
                {
                    sBuilder += Char;
                    if (sBuilder.Contains("input"))
                    {
                        //scanf("%s", myString);
                        bDoInput = true;
                        if (Char == '>')
                        {
                            bGenerateName = false;
                            sVarName = sConstructer;
                        }
                        if (bGenerateName)
                        {
                            sConstructer += Char;
                        }
                        if (Char == '<')
                        {
                            bGenerateName = true;
                        }

                    }

                }
                if (bDoInput)
                {
                    if (!dVars.Contains(sVarName))
                    {
                        sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.vstring, new string[2] { sVarName, string.Empty }));
                    }
                    sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.scan, new string[1] { sVarName }));
                    sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.print, new string[1] { sVarName }));
                    dVars.Add(sVarName);
                    iStringNameCounter++;
                }
                return sudoC_Pairs.ToArray();
            }
        }
        public class sudoC_Assembler
        {
            private string Assembled = string.Empty;
            /// <summary>
            /// Converts InnerEzC to C
            /// </summary>
            /// <param name="Lexxed_Code"></param>
            /// <returns>C Code</returns>
            public string Assemble(SudoC_Pair[] Lexxed_Code)
            {
                foreach (SudoC_Pair Pair in Lexxed_Code)
                {
                    switch (Pair.InnerCode)
                    {
                        ///Print Function
                        case SudoCInnerCode.print:
                            Assembled += "printf(" + Pair.Args[0] + ");";
                            Assembled += Environment.NewLine;
                            break;
                        case SudoCInnerCode.vstring:
                            if (Pair.Args[1] != string.Empty)
                            {
                                Assembled += "string " + Pair.Args[0] + " = \"" + Pair.Args[1] + "\";";
                            }
                            else
                            {
                                Assembled += "string " + Pair.Args[0] + "[32];";
                            }
                            Assembled += Environment.NewLine;
                            break;
                        case SudoCInnerCode.scan:
                            //scanf("%s", myString);
                            Assembled += "scanf(\"%s\"," + Pair.Args[0] + ");";
                            Assembled += Environment.NewLine;
                            break;
                    }

                }
                return Assembled;
            }
        }
    }

}
