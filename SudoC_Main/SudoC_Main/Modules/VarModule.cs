using System;
using System.Collections.Generic;
using System.Text;


namespace SudoC_Main.Modules
{
    public class VarModule
    {
        public SudoC_Pair[] pStringProccessor_Var(string[] input, SudoCInnerCode Context)
        {
            bool bDoInput = false;
            string sBuilder = string.Empty;
            string sConstructer = string.Empty;
            List<SudoC_Pair> sudoC_Pairs = new List<SudoC_Pair>();
            foreach (char Char in input[0])
            {
                sBuilder += Char;
                if (sBuilder == ("input<>"))
                {
                    bDoInput = true;
                }
            }
            if (bDoInput)
            {
                sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.vstring, new string[2] { input[1], string.Empty }));
                sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.scan, new string[1] { input[1] }));
            }
            else
            {
                sudoC_Pairs.Add(new SudoC_Pair(SudoCInnerCode.vstring, new string[2] { input[1], input[0] }));
            }
            Statics.lVars.Add(input[1]);
            return sudoC_Pairs.ToArray();
        }
    }
}
