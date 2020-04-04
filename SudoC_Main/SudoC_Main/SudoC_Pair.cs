using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main
{
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
}
