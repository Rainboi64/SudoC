using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudoC_Studio.Subforms
{
    public partial class OptionDialog : Form
    {
        public OptionDialog()
        {
            InitializeComponent();
            tbCompilerFile.Text = StudioStatics.Settings.sCCompilerPath;
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            StudioStatics.Settings.sCCompilerPath = tbCompilerFile.Text;
            this.Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                tbCompilerFile.Text = openFileDialog.FileName; 
            }
        }
    }
}
