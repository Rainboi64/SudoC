using SudoC_Main.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudoC_Main.Compiler
{
    public class SudoC_Lexxer
    {

        public string sConstructor { private set; get; }
        public string sBuilder { private set; get; }
        public bool bCaptureSpaces { private set; get; }
        public bool bCaptureValue { private set; get; }
        public int iCounter { private set; get; }
        public string sCompleteName { private set; get; }
        public bool bInScope { private set; get; }
        public string sRepeater { private set; get; }
        public int iTaskIndex { private set; get; }
        public int iBracketsLevel { private set; get; }
        public bool bFinishedCapture { private set; get; }
        private List<SudoC_Pair> Lexxed_Code = new List<SudoC_Pair>();
        public SudoC_Lexxer()
        {
            sConstructor = string.Empty;
            sBuilder = string.Empty;
            bCaptureSpaces = false;
            bCaptureValue = false;
            iCounter = 0;
            sCompleteName = string.Empty;
            bInScope = false;
            iTaskIndex = 0;
            sRepeater = "";
            iBracketsLevel = 0;
            bFinishedCapture = false;
        }


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


                if (sBuilder.EndsWith(";") && iTaskIndex == 0)
                {
                    string[] Arguments = sBuilder.Split('=');
                    Arguments[0] = Arguments[0].TrimStart(new char[] { '\n',')', ';', '}', ' ', });
                    Arguments[0] = Arguments[0].TrimEnd(new char[] { '\r', ' '});
                    Arguments[1] = Arguments[1].TrimEnd(new char[] { '\r', ' ',';' });
                    
                    Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.equalize,Arguments));

                    sBuilder = "";
                }

                if ((sBuilder.Contains("</") && iTaskIndex == 0) || iTaskIndex == 1)
                {
                    iTaskIndex = 1;
                    if (Char == '\\' && Code[iCounter] == '>')
                    {
                        bInScope = false;
                        sConstructor = sConstructor.TrimStart(new char[] { ')', ';', '}' });
                        Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.copy,new string[1] { sConstructor }));
                        sConstructor = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }
                    if (bInScope)
                     sConstructor += Char;
                    if (Char == '/' && Code[iCounter - 2] == '<')
                        bInScope = true;
                    goto cycleEnd;
                }
                if ((sBuilder.Contains("print") && iTaskIndex == 0) || iTaskIndex == 2)
                {
                    iTaskIndex = 2;
                    if (Char == ')')
                    {
                        bInScope = false;
                        PrintModule printModule = new PrintModule();
                        foreach (SudoC_Pair SudoC_Pair in printModule.pPrintBracksLexxer(sConstructor))
                            Lexxed_Code.Add(SudoC_Pair);
                        sConstructor = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }

                    if (bInScope)
                    {
                        sConstructor += Char;
                    }

                    if (Char == '(')
                    {
                        bInScope = true;
                    }
                }

                if ((sBuilder.Contains("var") && iTaskIndex == 0) || iTaskIndex == 3)
                {
                    iTaskIndex = 3;
                    if (Char == ';')
                    {
                        sCompleteName = sCompleteName.TrimStart(new char[] { ')', ';', '}' });
                        sCompleteName = sCompleteName.TrimStart('r');
                        sCompleteName = sCompleteName.TrimEnd('=');
                        VarModule varModule = new VarModule();
                        foreach (SudoC_Pair sudoC_Pair in varModule.pStringProccessor_Var(new string[] { sConstructor, sCompleteName }, SudoCInnerCode.vstring))
                        {
                            Lexxed_Code.Add(sudoC_Pair);
                        }

                        bCaptureValue = false;
                        bCaptureSpaces = false;

                        sConstructor = string.Empty;
                        sCompleteName = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }
                    if (Char != ' ' || bCaptureSpaces)
                    {
                        sConstructor += Char;
                    }
                    if (bCaptureValue)
                    {
                        sCompleteName = sConstructor;
                        sConstructor = string.Empty;
                        bCaptureSpaces = true;
                        bCaptureValue = false;
                    }
                    if (Char == '=')
                    {
                        bCaptureValue = true;
                    }
                    goto cycleEnd;
                }
                if ((sBuilder.Contains("def") && iTaskIndex == 0) || iTaskIndex == 4)
                {
                    iTaskIndex = 4;
                    if (Char == ';')
                    {
                        sCompleteName = sCompleteName.TrimStart(new char[] { ')', ';', '}' });
                        sCompleteName = sCompleteName.TrimStart('f');
                        sCompleteName = sCompleteName.TrimEnd('=');
                 //       sConstructor.Replace(@"\;",";");

                        Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.def, new string[2] {sConstructor, sCompleteName}));

                        bCaptureValue = false;
                        bCaptureSpaces = false;

                        sConstructor = string.Empty;
                        sCompleteName = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }
                    if (Char != ' ' || bCaptureSpaces)
                    {
                        sConstructor += Char;
                    }
                    if (bCaptureValue)
                    {
                        sCompleteName = sConstructor;
                        sConstructor = string.Empty;
                        bCaptureSpaces = true;
                        bCaptureValue = false;
                    }
                    if (Char == '=')
                    {
                        bCaptureValue = true;
                    }
                    goto cycleEnd;
                }
                if ((sBuilder.Contains("context") && iTaskIndex == 0) || iTaskIndex == 5)
                {
                    iTaskIndex = 5;
                    if (Char == '{' && iBracketsLevel >= 1)
                    {
                        iBracketsLevel++;
                    }
                    if (Char == '}' && iBracketsLevel == 1)
                    {
                        sCompleteName = sCompleteName.TrimStart(new char[] { ')', ';', '}' });
                        sCompleteName = sCompleteName.TrimStart('t');
                        sCompleteName = sCompleteName.TrimEnd('\r','\n','{');
                        //     sConstructor.Replace(@"\;", ";");
                        var sudoc_lexxerSecondary = new SudoC_Lexxer();
                        var soduc_assemblerSecondary = new SudoC_Assembler();
                        sConstructor = soduc_assemblerSecondary.Assemble(sudoc_lexxerSecondary.Lex(sConstructor), true);
                        Statics.dContexts.Add(sCompleteName, sConstructor);
                        Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.context, new string[2] {sConstructor, sCompleteName }));

                        bCaptureValue = false;
                        bCaptureSpaces = false;

                        sConstructor = string.Empty;
                        sCompleteName = string.Empty;
                        sBuilder = string.Empty;
                        iBracketsLevel = 0;
                        iTaskIndex = 0;
                    }
                    if (Char != ' ' || bCaptureSpaces)
                    {
                        sConstructor += Char;
                    }
                    if (bCaptureValue)
                    {
                        sCompleteName = sConstructor;
                        sConstructor = string.Empty;
                        bCaptureSpaces = true;
                        bCaptureValue = false;
                    }
                    if (Char == '}' && iBracketsLevel > 1)
                    {
                        iBracketsLevel--;
                    }
                    if (Char == '{' && iBracketsLevel == 0)
                    {
                        bCaptureValue = true;
                        iBracketsLevel++;
                    }
                    goto cycleEnd;
                }
                if ((sBuilder.Contains("fetch") && iTaskIndex == 0) || iTaskIndex == 6)
                {
                    iTaskIndex = 6;
                    if (Char == ')')
                    {
                        sConstructor = sConstructor.TrimStart(new char[] {')',';','}'});
                        bInScope = false;
                        Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.fetch, new string[1] {sConstructor} ));
                        sConstructor = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }

                    if (bInScope)
                    {
                        sConstructor += Char;
                    }

                    if (Char == '(')
                    {
                        bInScope = true;
                    }
                }
                if ((sBuilder.Contains("include") && iTaskIndex == 0) || iTaskIndex == 7)
                {
                    iTaskIndex = 7;
                    if (Char == ')')
                    {
                        sConstructor = sConstructor.TrimStart(new char[] { ')', ';', '}' });
                        bInScope = false;
                        var sudoc_lexxerSecondary = new SudoC_Lexxer();
                        var soduc_assemblerSecondary = new SudoC_Assembler();
                        soduc_assemblerSecondary.Assemble(sudoc_lexxerSecondary.Lex(File.ReadAllText(sConstructor)), true);
                        sConstructor = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }

                    if (bInScope)
                    {
                        sConstructor += Char;
                    }

                    if (Char == '(')
                    {
                        bInScope = true;
                    }
                }
                if ((sBuilder.Contains(@"//") && iTaskIndex == 0) || iTaskIndex == 8)
                {
                    iTaskIndex = 8;
                    if (Char == '\n')
                    {
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }
                    goto cycleEnd;
                }
                if ((sBuilder.Contains("repeat") && iTaskIndex == 0) || iTaskIndex == 9)
                {
                    iTaskIndex = 9;
                    if (Char == ')' && !bFinishedCapture)
                    {
                        sConstructor = sConstructor.TrimStart(new char[] { ')', ';', '}' });
                        sCompleteName = sCompleteName.TrimStart('t');
                        bInScope = false;
                        bFinishedCapture = true;
                        sRepeater = sConstructor;
                        sConstructor = string.Empty;
                    }

                    if (bInScope && !bFinishedCapture)
                    {
                        sConstructor += Char;
                    }

                    if (Char == '(' && !bFinishedCapture)
                    {
                        bInScope = true;
                    }

                    if (bFinishedCapture)
                    {
                        if (Char == '{' && iBracketsLevel >= 1)
                        {
                            iBracketsLevel++;
                        }
                        if (Char == '}' && iBracketsLevel == 1 )
                        {
                            sCompleteName = sCompleteName.TrimStart(new char[] { ')', ';', '}' });
                            sCompleteName = sCompleteName.TrimStart(sRepeater[sRepeater.Length - 1]);
                            sCompleteName = sCompleteName.TrimEnd('\r', '\n', '{');
                            LoopModule loopModule = new LoopModule();
                            foreach (SudoC_Pair sudoC_Pair in loopModule.Loop(sCompleteName, sRepeater, sConstructor))
                                Lexxed_Code.Add(sudoC_Pair);
                            bFinishedCapture = false;
                            bCaptureValue = false;
                            bCaptureSpaces = false;
                            sRepeater = string.Empty;
                            sConstructor = string.Empty;
                            sCompleteName = string.Empty;
                            sBuilder = string.Empty;
                            iBracketsLevel = 0;
                            iTaskIndex = 0;
                        }
                        if ((Char != ' ' || bCaptureSpaces))
                        {
                            sConstructor += Char;
                        }
                        if (bCaptureValue)
                        {
                            sCompleteName = sConstructor;
                            sConstructor = string.Empty;
                            bCaptureSpaces = true;
                            bCaptureValue = false;
                        }
                        if (Char == '}' && iBracketsLevel > 1 )
                        {
                            iBracketsLevel--;
                        }
                        if (Char == '{' && iBracketsLevel == 0)
                        {
                            bCaptureValue = true;
                            iBracketsLevel++;
                        }
                    }
                  
                    goto cycleEnd;
                }
                if ((sBuilder.Contains("use") && iTaskIndex == 0) || iTaskIndex == 10)
                {
                    iTaskIndex = 10;
                    if (Char == ')')
                    {
                        bInScope = false;
                        Statics.AddImports(sConstructor);
                        sConstructor = string.Empty;
                        sBuilder = string.Empty;
                        iTaskIndex = 0;
                    }

                    if (bInScope)
                    {
                        sConstructor += Char;
                    }

                    if (Char == '(')
                    {
                        bInScope = true;
                    }
                }
            cycleEnd:;
            }

            return Lexxed_Code.ToArray();
        }

    }
}
