using SudoC_Main;
using SudoC_Main.Compiler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoC_Studio
{
    public class SudoC_SDK
    {

        public string Do(string Command)
        {
           return Do(Command, new string[0]);
        }
        string sBuilder = string.Empty;
        string sOutput = string.Empty;
        public string Do(string Command,string[] Args)
        {
            switch (Command)
            {
                case "compile":
                    SudoC_Lexxer Sdk_Lexxer = new SudoC_Lexxer();
                    SudoC_Assembler Sdk_Assembler = new SudoC_Assembler();
                    return Sdk_Assembler.Assemble(Sdk_Lexxer.Lex(Args[0]));
                case "clr":
                    Statics.reset();
                    return "true";
                case "open":
                    try
                    {
                        Process compilerProcces = new Process();

                        ProcessStartInfo compilerProcessStartInfo = new ProcessStartInfo("SudoC_Windows.exe", Args[0]+@" \o");
                        compilerProcces.OutputDataReceived += GccProcess_OutputDataReceived; ;
                        compilerProcessStartInfo.UseShellExecute = false;
                        compilerProcessStartInfo.CreateNoWindow = true;
                        compilerProcessStartInfo.RedirectStandardOutput = true;
                        compilerProcces.StartInfo = compilerProcessStartInfo;
                        compilerProcces.Start();
                        compilerProcces.BeginOutputReadLine();
                        compilerProcces.WaitForExit();
                        sOutput = sBuilder;
                        sBuilder = "";
                        return sOutput;
                    }
                    catch (Exception x)
                    {
                        return x.Message;
                    }
                default:
                    return "Can't Recognize Command";
            }
        }

        private void GccProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            sBuilder+=e.Data+"\n";
        }
    }
}
