using System;
using SudoC_Main.Compiler;
using SudoC_Main;
using System.Diagnostics;
using System.IO;
namespace SudoC_Main.Compiler
{
   public class App
    {
        public void StartCompiler(string[] args)
        {
            Console.Title = "SudoC Assembler " + Statics.fVersionNumber;

            Console.WriteLine("Started SudoC Assembler " + Statics.fVersionNumber + " @ " + DateTime.Now);

            if (!args[0].EndsWith(".sudoc")) args[0] += ".sudoc";
            SudoC_Lexxer easyC_Lexxer = new SudoC_Lexxer();
            SudoC_Assembler easyC_Assembler = new SudoC_Assembler();
            string sMold = string.Empty;


            Console.WriteLine("Generating C Code..... " + " @ " + DateTime.Now);
            File.WriteAllText(".\\Output.c", easyC_Assembler.Assemble(easyC_Lexxer.Lex(File.ReadAllText(args[0]))));


            Console.WriteLine("Finished SudoC Assembler " + Statics.fVersionNumber + " @ " + DateTime.Now);

            Process gccProcess = new Process();

            ProcessStartInfo gccProcessStartInfo = new ProcessStartInfo("gcc", "Output.c -o Output.exe");
            gccProcess.OutputDataReceived += GccProcess_OutputDataReceived;
            gccProcessStartInfo.UseShellExecute = false;
            gccProcessStartInfo.CreateNoWindow = false;
            gccProcessStartInfo.RedirectStandardOutput = true;
            gccProcess.StartInfo = gccProcessStartInfo;

            try
            {
                gccProcess.Start();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                Console.WriteLine("ggc not found, you can call it by typing 'gcc' in the cmd.");
                goto Finished;
            }
            Console.WriteLine("Started gcc @ " + DateTime.Now);

            gccProcess.BeginOutputReadLine();

            gccProcess.WaitForExit();

            Console.WriteLine("gcc ended @ " + DateTime.Now);
        Finished:
            Console.WriteLine("");
            Console.WriteLine("Program ended @ " + DateTime.Now);
            Console.WriteLine("Do you like to start the program\n(y)es? || (*)No");
            Char Input = Console.ReadKey().KeyChar;
            switch (Input)
            {
                case 'y':
                    Console.Clear();
                    Process.Start("Output.exe");
                    break;
            }

        }

        private static void GccProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            Console.WriteLine("gcc reported @ " + DateTime.Now + " : " + e.Data);
        }
    }
}
