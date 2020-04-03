using System;
using System.Collections.Generic;
using System.IO;

namespace EasyC
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args[0].EndsWith(".ezc")) args[0] += ".ezc";
            EasyC_Main.EasyC_Lexxer easyC_Lexxer = new EasyC_Main.EasyC_Lexxer();
            EasyC_Main.EasyC_Assembler easyC_Assembler = new EasyC_Main.EasyC_Assembler();
            File.WriteAllText(".\\Output.c", easyC_Assembler.Assemble(easyC_Lexxer.Lex(File.ReadAllText(args[0]))));
        }
    }
    public static class EasyC_Main
    {
        public enum EasyCInnerCode
        {
            print,
            vstring,
            scan
        }
        public class EasyC_Pair
        {
            public EasyC_Pair(EasyCInnerCode innerCode, string[] args)
            {
                InnerCode = innerCode;
                Args = args;
            }
            public EasyCInnerCode InnerCode { get; private set; }
            public string[] Args { get; private set; }
        }
        public class EasyC_Lexxer
        {
            private string sConstructor = string.Empty;
            private string sBuilder = string.Empty;
            private int iCounter = 0;
            private bool bInBrackets = false;
            private List<string> dVars = new List<string>();
            private List<EasyC_Pair> Lexxed_Code = new List<EasyC_Pair>();
            /// <summary>
            /// Main Lexxer Function
            /// </summary>
            /// <param name="Code">Code from user.</param>
            /// <returns>Inner_EasyC Output</returns>
            public EasyC_Pair[] Lex(string Code)
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
                            foreach (EasyC_Pair easyC_Pair in pPrintBracksLexxer(sConstructor))
                                Lexxed_Code.Add(easyC_Pair);
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
            private EasyC_Pair[] pPrintBracksLexxer(string sInBracks)
            {
                bool bInDQs = false;
                bool bInOuts = false;
                bool bFinishedOuts = false;
                string sBuilder = string.Empty;
                string sConstructor = string.Empty;
                char LastChar = '.';
                List<EasyC_Pair> Instructions = new List<EasyC_Pair>();
                List<EasyC_Pair> printInstructions = new List<EasyC_Pair>();
                foreach (char Char in sInBracks)
                {    //Qoutes E
                    if ((Char == '\"' && bInDQs) || (Char == '\'' && !bInOuts))
                    {
                        bInDQs = false;
                        printInstructions.Add(new EasyC_Pair(EasyCInnerCode.print, new string[] { "\"" + sConstructor + "\"" }));
                        sConstructor = string.Empty;
                    }

                    //Out End
                    if (Char == '\'' && bInOuts)
                    {
                        bInOuts = false;
                        bInDQs = true;
                        foreach (EasyC_Pair easyC_Pair in pStringProccessor(sBuilder)) Instructions.Add(easyC_Pair);
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
                foreach (EasyC_Pair easyC_Pair in printInstructions) Instructions.Add(easyC_Pair);
                return Instructions.ToArray();
            }
            private static int iStringNameCounter = 0;
            //print("your name is 'input()' means ur gay")
            /// <summary>
            /// 
            /// </summary>
            /// <param name="input"></param>
            /// <returns></returns>
            private EasyC_Pair[] pStringProccessor(string input)
            {
                bool bDoInput = false;
                string sBuilder = string.Empty;
                string sConstructer = string.Empty;
                bool bGenerateName = false;
                var sVarName = "Input" + iStringNameCounter;
                List<EasyC_Pair> easyC_Pairs = new List<EasyC_Pair>();
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
                        easyC_Pairs.Add(new EasyC_Pair(EasyCInnerCode.vstring, new string[2] { sVarName, string.Empty }));
                    }
                    easyC_Pairs.Add(new EasyC_Pair(EasyCInnerCode.scan, new string[1] { sVarName }));
                    easyC_Pairs.Add(new EasyC_Pair(EasyCInnerCode.print, new string[1] { sVarName }));
                    dVars.Add(sVarName);
                    iStringNameCounter++;
                }
                return easyC_Pairs.ToArray();
            }
        }
        public class EasyC_Assembler
        {
            private string Assembled = string.Empty;
            /// <summary>
            /// Converts InnerEzC to C
            /// </summary>
            /// <param name="Lexxed_Code"></param>
            /// <returns>C Code</returns>
            public string Assemble(EasyC_Pair[] Lexxed_Code)
            {
                foreach (EasyC_Pair Pair in Lexxed_Code)
                {
                    switch (Pair.InnerCode)
                    {
                        ///Print Function
                        case EasyCInnerCode.print:
                            Assembled += "printf(" + Pair.Args[0] + ");";
                            Assembled += Environment.NewLine;
                            break;
                        case EasyCInnerCode.vstring:
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
                        case EasyCInnerCode.scan:
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
