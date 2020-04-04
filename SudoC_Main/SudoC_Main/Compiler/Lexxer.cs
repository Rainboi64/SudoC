using SudoC_Main.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main.Compiler
{
    public class SudoC_Lexxer
    {
        private string sConstructor = string.Empty;
        private string sBuilder = string.Empty;
        private bool bCaptureSpaces = false;
        private bool bCaptureVarVal = false;
        private int iCounter = 0;
        private string sCompleteName = string.Empty;
        private bool bInBrackets = false;
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
                        PrintModule printModule = new PrintModule();
                        foreach (SudoC_Pair SudoC_Pair in printModule.pPrintBracksLexxer(sConstructor))
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
                if (sBuilder.Contains("var"))
                {
                    if (Char == ';')
                    {
                        sCompleteName = sCompleteName.TrimStart('r');
                        sCompleteName = sCompleteName.TrimEnd('=');
                        VarModule varModule = new VarModule();
                        foreach (SudoC_Pair sudoC_Pair in varModule.pStringProccessor_Var(new string[] { sConstructor, sCompleteName }, SudoCInnerCode.vstring))
                        {
                            Lexxed_Code.Add(sudoC_Pair);
                        }

                        bCaptureVarVal = false;
                        bCaptureSpaces = false;

                        sConstructor = string.Empty;
                        sCompleteName = string.Empty;
                        sBuilder = string.Empty;
                    }
                    if (Char != ' ' || bCaptureSpaces)
                    {
                        sConstructor += Char;
                    }
                    if (bCaptureVarVal)
                    {
                        sCompleteName = sConstructor;
                        sConstructor = string.Empty;
                        bCaptureSpaces = true;
                        bCaptureVarVal = false;
                    }
                    if (Char == '=')
                    {
                        bCaptureVarVal = true;

                    }
                }
            }
            return Lexxed_Code.ToArray();
        }

    }
}
