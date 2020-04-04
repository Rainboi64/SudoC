using SudoC_Main.Compiler;

namespace SudoC_Dotnet
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
