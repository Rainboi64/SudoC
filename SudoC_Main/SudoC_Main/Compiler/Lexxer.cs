using SudoC_Main.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudoC_Main.Compiler
{
    public class SudoC_Lexxer
    {
        private string sConstructor = string.Empty;
        private string sBuilder = string.Empty;
        private bool bCaptureSpaces = false;
        private bool bCaptureValue = false;
        private int iCounter = 0;
        private string sCompleteName = string.Empty;
        private bool bInScope = false;
        private int iTaskIndex = 0;
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
                    if (Char == '}')
                    {
                        sCompleteName = sCompleteName.TrimStart(new char[] { ')', ';', '}' });
                        sCompleteName = sCompleteName.TrimStart('t');
                        sCompleteName = sCompleteName.TrimEnd('\r','\n','{');
                        //     sConstructor.Replace(@"\;", ";");
                        var sudoc_lexxerSecondary = new SudoC_Lexxer();
                        var soduc_assemblerSecondary = new sudoC_Assembler();
                        Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.context, new string[2] { soduc_assemblerSecondary.Assemble(sudoc_lexxerSecondary.Lex(sConstructor)), sCompleteName }));

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
                    if (Char == '{')
                    {
                        bCaptureValue = true;
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
                        var soduc_assemblerSecondary = new sudoC_Assembler();
                        soduc_assemblerSecondary.Assemble(sudoc_lexxerSecondary.Lex(File.ReadAllText(sConstructor)));
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
            cycleEnd:;
            }

            return Lexxed_Code.ToArray();
        }

    }
}
