using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main.Modules
{
  public class PrintModule
    {  /// <summary>
       /// Lexxes Print Bracks
       /// </summary>
       /// <param name="sInBracks"> Input Brackets</param>
       /// <returns></returns>
        public SudoC_Pair[] pPrintBracksLexxer(string sInBracks)
        {
            bool bInDQs = false;
            bool bInOuts = false;
            string sBuilder = string.Empty;
            string sConstructor = string.Empty;
            char LastChar = '.';
            List<SudoC_Pair> Instructions = new List<SudoC_Pair>();
            List<SudoC_Pair> printInstructions = new List<SudoC_Pair>();
            foreach (char Char in sInBracks)
            {    //Qoutes End
                if ((Char == '\"' && bInDQs) || (Char == '\'' && !bInOuts))
                {
                    bInDQs = false;
                    if (sConstructor != string.Empty)
                    {
                        printInstructions.Add(new SudoC_Pair(SudoCInnerCode.print, new string[] { "\"" + sConstructor + "\"" }));
                    }
                    sConstructor = string.Empty;
                }

                //Out End
                if (Char == '\'' && bInOuts)
                {
                    bInOuts = false;
                    bInDQs = true;
                    foreach (SudoC_Pair sudoC_Pair in pStringProccessor_Print(new string[1] { sBuilder }))
                    {
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
       
        /// <summary>
        /// Lexxes string input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private SudoC_Pair[] pStringProccessor_Print(string[] input)
        {
            bool bDoInput = false;
            string sBuilder = string.Empty;
            string sConstructer = string.Empty;
            bool bGenerateName = false;
            var sVarName = "Input" + Statics.iStringNameCounter;
            List<SudoC_Pair> sudoC_Pairs = new List<SudoC_Pair>();
            foreach (char Char in input[0])
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
                        if (!Statics.lVars.Contains(sVarName))
                        {
                            sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.vstring, new string[2] { sVarName, string.Empty }));
                            Statics.iStringNameCounter++;
                        }
                        sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.scan, new string[1] { sVarName }));
                        sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.print, new string[1] { sVarName }));
                        Statics.lVars.Add(sVarName);
                    }
                    else
                    {
                        sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.print, new string[1] { input[0] }));
                    }
            return sudoC_Pairs.ToArray();
        }
    }
}
