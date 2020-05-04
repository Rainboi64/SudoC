using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main
{
    public enum SudoCInnerCode
    {
        copy,
        print,
        vstring,
        scan,
        def,
        equalize,
        context,
        fetch,
        include,
        foreachloop
    }

    public class Statics
    {
        public static List<string> lVars = new List<string>();
        public static List<string> lImports = new List<string>();
        public static Dictionary<string, string> dDefines = new Dictionary<string, string>();
        public static Dictionary<string, string> dContexts = new Dictionary<string, string>();
        public static int iStringNameCounter = 0;
        public static float fVersionNumber = 0.01f;
        public static void AddImports(string ImportName)
        {
            if (!lImports.Contains(ImportName))
            {
                lImports.Add(ImportName);
            }
        }
        public static void reset()
        {
            lVars.Clear();
            lImports.Clear();
            dDefines.Clear();
            dContexts.Clear();
            iStringNameCounter = 0;
        }
    }
}
