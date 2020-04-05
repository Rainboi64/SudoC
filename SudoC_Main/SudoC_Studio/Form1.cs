using SudoC_Main;
using SudoC_Main.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudoC_Studio
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            fastColoredTextBox2.Language = FastColoredTextBoxNS.Language.CSharp;
            tAutoCompiler.Start();
        }

        private void TAutoCompiler_Tick(object sender, EventArgs e)
        {
            try
            {
                Statics.dVars.Clear();
                SudoC_Lexxer easyC_Lexxer = new SudoC_Lexxer();
                sudoC_Assembler easyC_Assembler = new sudoC_Assembler();
                fastColoredTextBox2.Text = easyC_Assembler.Assemble(easyC_Lexxer.Lex(fastColoredTextBox1.Text));
            }
            catch (Exception)
            {

            }
        }
    }
}
