using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudoC_Studio
{
    public static class StudioStatics
    {
       public static Settings Settings = new Settings();

    }
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (!Directory.Exists(@".\jsonDatabase"))
            {
                Directory.CreateDirectory(@".\jsonDatabase");

                StudioStatics.Settings.sMold = @".\Resources\DefaultMold.c";
                StudioStatics.Settings.sCCompilerPath = "gcc";
                StudioStatics.Settings.bHideRibbon = false;
                StudioStatics.Settings.bHideCTab = false;

                JsonManager.Serialize(StudioStatics.Settings);

            }
            else
            {
                var settings = JsonManager.Deserialize(@".\jsonDatabase\SudoC_Studio.Settings.json");
                StudioStatics.Settings = settings;
            }
            //Run
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {

                Application.Run(new Form1(args[0]));

            }
            catch (Exception)
            {
                Application.Run(new Form1(""));
            }
         
            
       }
    }
}
