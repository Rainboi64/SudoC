using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main
{
    public enum SudoCInnerCode
    {
        print,
        vstring,
        scan,
        equalize
    }

    public class Statics
    {
        public static List<string> dVars = new List<string>();
        public static int iStringNameCounter = 0;
        public static float fVersionNumber = 0.01f;
    }
}
