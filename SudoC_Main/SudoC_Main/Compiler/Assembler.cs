using System;
using System.Collections.Generic;
using System.Text;

namespace SudoC_Main.Compiler
{
    public class SudoC_Assembler
    {
        private string Assembled = string.Empty;
        /// <summary>
        /// Converts InnerSudoC to C without DisableImports
        /// </summary>
        /// <param name="Lexxed_Code"></param>
        /// <returns></returns>
        public string Assemble(SudoC_Pair[] Lexxed_Code)
        {
          return Assemble(Lexxed_Code, false);
        }

        /// <summary>
        /// Converts InnerEzC to C
        /// </summary>
        /// <param name="Lexxed_Code"></param>
        /// <returns>C Code</returns>
        public string Assemble(SudoC_Pair[] Lexxed_Code,bool disableImports)
        {

            foreach (SudoC_Pair Pair in Lexxed_Code)
            {
                switch (Pair.InnerCode)
                {
                    case SudoCInnerCode.copy:
                        Assembled += Pair.Args[0];
                        break;
                    ///Print Function
                    case SudoCInnerCode.print:
                        if (Pair.Args[0].StartsWith("\"") && Pair.Args[0].EndsWith("\""))
                        {
                            Statics.AddImports("<stdio.h>");
                            Assembled += "printf(" + Pair.Args[0] + ");";
                        }
                        // printf("%s", variable);
                        else
                        {
                            Assembled += "printf(\"%s\", " + Pair.Args[0] + ");";
                        }
                        Assembled += Environment.NewLine;
                        break;
                    case SudoCInnerCode.vstring:
                        if (Pair.Args[1] != string.Empty)
                        {
                            Assembled += "char " + Pair.Args[0] + "[2056] = \"" + Pair.Args[1] + "\";";
                        }
                        else
                        {
                            Assembled += "char " + Pair.Args[0] + "[2056];";
                        }
                        Assembled += Environment.NewLine;
                        break;
                    case SudoCInnerCode.scan:
                        //scanf("%s", myString);
                        Statics.AddImports("<stdio.h>");    
                        Assembled += "scanf(\"%s\"," + Pair.Args[0] + ");";
                        Assembled += Environment.NewLine;
                        break;
                    case SudoCInnerCode.equalize:
                        Statics.AddImports("<string.h>");
                        Assembled += "strcpy("+Pair.Args[0] + ", " + Pair.Args[1] + ");";
                        Assembled += Environment.NewLine;
                        break;
                    case SudoCInnerCode.def:
                        Statics.dDefines.Add(Pair.Args[1], Pair.Args[0]);
                        break;
                    case SudoCInnerCode.context:
                        if (Pair.Args[1] == "program")
                        {
                            Assembled += "\nint main()\n{\n";
                            Assembled += Pair.Args[0];
                            Assembled += "\nreturn 0;\n}\n";
                        }

                        break;
                    case SudoCInnerCode.fetch:
                        Assembled+=Statics.dContexts[Pair.Args[0]];
                        break;
                    case SudoCInnerCode.foreachloop:
                        if (!Statics.lVars.Contains(Pair.Args[0]))
                        {
                            if (Pair.Args[0] == "infinite")
                            {
                                Assembled += "int _" + Pair.Args[1] + " = 0;\nwhile(1)\n{\nchar " + Pair.Args[1] + "[2056];\n _"+Pair.Args[1]+"++;\n sprintf(" + Pair.Args[1] + ", \"%d\", _" + Pair.Args[1] + ");\n" + Pair.Args[2] + "\n}\n";
                            }
                            else
                            Assembled += "for(int _" + Pair.Args[1] + " = 0;_" + Pair.Args[1] + " <= " + Pair.Args[0] + ";_" + Pair.Args[1] + "++)\n{\n char " + Pair.Args[1] + "[2056];\n sprintf(" + Pair.Args[1] + ", \"%d\", _" + Pair.Args[1] + ");\n" + Pair.Args[2] + "\n}\n";
                        }
                        else
                        {
                            Statics.AddImports("<stdlib.h>");
                            Assembled += "for(int _" + Pair.Args[1] + " = 0;_" + Pair.Args[1] + " <= atoi(" + Pair.Args[0] + ");_" + Pair.Args[1] + "++)\n{\n char " + Pair.Args[1] + "[2056];\n sprintf(" + Pair.Args[1] + ", \"%d\", _" + Pair.Args[1] + ");\n" + Pair.Args[2] + "\n}\n";
                        }
                        break;

                }
            }
            if (!disableImports)
            {
                foreach (string Import in Statics.lImports)
                {
                    Assembled = ("#include " + Import + "\n") + Assembled;
                }

            }
            foreach (KeyValuePair<string, string> defs in Statics.dDefines)
            {
                Assembled = Assembled.Replace(defs.Key, defs.Value);
            }
            return Assembled;
        }
    }
}
