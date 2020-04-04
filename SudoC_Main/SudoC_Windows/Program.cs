using SudoC_Main.Compiler;

namespace SudoC_Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.StartCompiler(args);
        }
    }
}
