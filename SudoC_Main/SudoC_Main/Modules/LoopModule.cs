using SudoC_Main.Compiler;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main.Modules
{
    public class LoopModule
    {
        public SudoC_Pair[] Loop(string sCompleteName, string sRepeater,string sConstructor)
        {
            //     sConstructor.Replace(@"\;", ";");
            List<SudoC_Pair> Lexxed_Code = new List<SudoC_Pair>();
            bool bDoInput = false;
            bool bGenerateName = false;
            string sPrivateConstructor="";
            var sVarName = "Input" + Statics.iStringNameCounter;
            string sBuilder = "";
            if (sRepeater.Contains("input"))
            {
                foreach (char Char in sRepeater)
                {
                    sBuilder += Char;
                    if (sBuilder.Contains("input"))
                    {
                        bDoInput = true;
                        if (Char == '>')
                        {
                            if (sPrivateConstructor != string.Empty)
                            {
                                sVarName = sPrivateConstructor;
                            }
                            else
                            {
                                sVarName = "Input" + Statics.iStringNameCounter;
                            }
                        }
                        if (bGenerateName)
                        {
                            sPrivateConstructor += Char;
                        }
                        if (Char == '<')
                        {
                            bGenerateName = true;
                        }
                    }
                }
            }
            if (bDoInput)
            {
                if (!Statics.dVars.Contains(sVarName))
                {
                    Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.vstring, new string[2] { sVarName, string.Empty }));
                    Statics.iStringNameCounter++;
                }
                Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.scan, new string[1] { sVarName }));
                Statics.dVars.Add(sVarName);
                var sudoc_lexxerSecondary = new SudoC_Lexxer();
                var soduc_assemblerSecondary = new sudoC_Assembler();
                Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.foreachloop, new string[3] { sVarName, sCompleteName, soduc_assemblerSecondary.Assemble(sudoc_lexxerSecondary.Lex(sConstructor)) }));
            }
            else
            {
            var sudoc_lexxerSecondary = new SudoC_Lexxer();
            var soduc_assemblerSecondary = new sudoC_Assembler();
            Lexxed_Code.Add(new SudoC_Pair(SudoCInnerCode.foreachloop, new string[3] { sRepeater, sCompleteName, soduc_assemblerSecondary.Assemble(sudoc_lexxerSecondary.Lex(sConstructor)) }));
            }
            return Lexxed_Code.ToArray();
        }
    }
}
