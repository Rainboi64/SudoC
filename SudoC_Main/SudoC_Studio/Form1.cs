using SudoC_Main;
using SudoC_Main.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudoC_Studio
{
    public partial class Form1 :Form
    {
        static string filename = string.Empty;
        static string Mold=string.Empty;
        public Form1(string InputArg)
        {
            InitializeComponent();
            Mold = File.ReadAllText(StudioStatics.Settings.sMold);
            ribbon1.Minimized = StudioStatics.Settings.bHideRibbon;
            ribbonCheckBox2.Checked = StudioStatics.Settings.bHideRibbon;
            splitContainer1.Panel2Collapsed = StudioStatics.Settings.bHideCTab;
            ribbonCheckBox3.Checked = StudioStatics.Settings.bHideCTab;
            if (InputArg != "")
            {
               fastColoredTextBox1.Text= File.ReadAllText(InputArg);
                filename = InputArg;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
            fastColoredTextBox2.Language = FastColoredTextBoxNS.Language.CSharp;
            fastColoredTextBox2.Text = Mold.Replace("SudoC();",string.Empty);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonManager.Serialize(StudioStatics.Settings);
        }
        private void TAutoCompiler_Tick(object sender, EventArgs e)
        {
            try
            {
                Statics.dVars.Clear();
                Statics.iStringNameCounter = 0;
                SudoC_Lexxer easyC_Lexxer = new SudoC_Lexxer();
                sudoC_Assembler easyC_Assembler = new sudoC_Assembler();
                fastColoredTextBox2.Text =Mold.Replace("SudoC();", easyC_Assembler.Assemble(easyC_Lexxer.Lex(fastColoredTextBox1.Text)));
            }
            catch (Exception ex)
            {
                tslStatus.Text = ex.Message;
            }
        }

        private void FastColoredTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            tAutoCompiler.Start();
            tslStatus.Text=("Compiling...");
        }

        private void FastColoredTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            tAutoCompiler.Stop();
            tslStatus.Text = ("Finished!");
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RibbonButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Zoom += 10;
            fastColoredTextBox2.Zoom += 10;
        }

        private void RibbonButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Zoom -= 10;
            fastColoredTextBox2.Zoom -= 10;
        }

        private void RibbonCheckBox2_CheckBoxCheckChanged(object sender, EventArgs e)
        {
          
           ribbon1.Minimized = ribbonCheckBox2.Checked;
           StudioStatics.Settings.bHideRibbon = ribbonCheckBox2.Checked;
        }

        private void RibbonCheckBox3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = ribbonCheckBox3.Checked;
            StudioStatics.Settings.bHideCTab = ribbonCheckBox3.Checked;
        }

        private void RibbonButton3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Zoom = 100;
            fastColoredTextBox2.Zoom = 100;
        }

        private void RibbonButton17_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.CollapseBlock(fastColoredTextBox1.Selection.Start.iLine,
               fastColoredTextBox1.Selection.End.iLine);
        }

        private void RibbonButton14_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void RibbonButton15_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void RibbonButton16_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();

        }

        private void RibbonButton18_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void RibbonButton13_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C Files (*.c)|*.c|All files (*.*)|*.*";
           var ofgresult = openFileDialog.ShowDialog();
            if (ofgresult == DialogResult.OK)
            {
                StudioStatics.Settings.sMold = openFileDialog.FileName;
                Mold = File.ReadAllText(StudioStatics.Settings.sMold); 
            }
        }

        private void RibbonButton13_Click_1(object sender, EventArgs e)
        {
            StudioStatics.Settings.sMold = @".\Resources\DefaultMold.c";
            Mold = File.ReadAllText(StudioStatics.Settings.sMold);
            fastColoredTextBox2.Text = Mold.Replace("SudoC();", string.Empty);
        }

        private void RibbonButton8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
           var sfd= saveFileDialog.ShowDialog();
            if (sfd == DialogResult.OK)
            {
                File.WriteAllText(@".\mold.c", Mold);
                File.WriteAllText(saveFileDialog.FileName,fastColoredTextBox1.Text);
                filename = saveFileDialog.FileName;
            }
        }

        private void RibbonButton9_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "C Files (*.c)|*.c|All files (*.*)|*.*";
            var sfd = saveFileDialog.ShowDialog();
            if (sfd == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox2.Text);
         
            }
        }

        private void RibbonOrbMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
            var ofgresult = openFileDialog.ShowDialog();
            if (ofgresult == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                fastColoredTextBox1.Text = File.ReadAllText(filename);
                tAutoCompiler.Start();
            }
        }

        private void RibbonButton20_Click(object sender, EventArgs e)
        {
            if (filename=="")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
                var sfd = saveFileDialog.ShowDialog();
                if (sfd == DialogResult.OK)
                {
                    File.WriteAllText(@".\mold.c", Mold);
                    File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox1.Text);
                    filename = saveFileDialog.FileName;
                }
            }
            else
            {
                File.WriteAllText(filename, fastColoredTextBox1.Text);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                ribbonButton20.PerformClick();
            }

            if (keyData == (Keys.Control | Keys.O))
            {
                ribbonButton12.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RibbonButton5_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
                var sfd = saveFileDialog.ShowDialog();
                if (sfd == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox1.Text);
                    filename = saveFileDialog.FileName;
                    File.WriteAllText(@".\mold.c", Mold);
                    Process.Start(@".\SudoC_Windows.exe", filename);
                }
            }
            else
            {
                File.WriteAllText(filename, fastColoredTextBox1.Text);
                File.WriteAllText(@".\mold.c",Mold);
                Process.Start(@".\SudoC_Windows.exe", filename);
            }
            
        }
    }
}
