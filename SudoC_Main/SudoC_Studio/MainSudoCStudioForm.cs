using Alex75.JsonViewer.WindowsForm;
using FastColoredTextBoxNS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudoC_Studio
{
    public partial class MainSudoCStudioForm : Form
    {
        SudoC_SDK SDK = new SudoC_SDK();
        static string filename = string.Empty;
        AutocompleteMenu popupMenu;
        Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
        Style KeywordsStyle = new TextStyle(Brushes.DeepPink, null, FontStyle.Regular);
        Style FunctionNameStyle = new TextStyle(Brushes.Teal, null, FontStyle.Regular);
        Style NamesNameStyle = new TextStyle(new SolidBrush(Color.FromArgb(205, 120, 0)), null, FontStyle.Regular);

        string[] keywords = { "var = ;"};
        string[] methods = { "fetch()","input<>","print()"};
        string[] snippets = { "if(^)\n{\n;\n}", "if(^)\n{\n;\n}\nelse\n{\n;\n}", "for(^;;)\n{\n;\n}", "while(^)\n{\n;\n}", "do${\n^;\n}while();", "switch(^)\n{\n\n}" ,"repeat(^) "+ "Input" + Statics.iStringNameCounter + "\n{\n\n}"};
        string[] declarationSnippets = {
               "context ^\n{\n}"
               };
        bool bThrow = false;
        JsonTreeView jsonTreeView = new JsonTreeView();
        public MainSudoCStudioForm(string InputArg)
        {
            InitializeComponent();

            scCViewStats.Panel1Collapsed = 
            StudioStatics.Settings.PreviewCollapsed;
            scCViewStats.Panel2Collapsed = 
            StudioStatics.Settings.MemoryViewCollapsed;
            scMainPreview.Panel2Collapsed =
            StudioStatics.Settings.LeftPanelCollapsed;
            scEditorConsole.Panel2Collapsed =
            StudioStatics.Settings.ConsoleCollapsed;

            fctbCWindow.Language = Language.CSharp;
            popupMenu = new AutocompleteMenu(fctbMainEditor);
            popupMenu.AllowTabKey = true;

            jsonTreeView.Dock = DockStyle.Fill;
            jsonTreeView.ImageList.TransparentColor = Color.White;
            jsonTreeView.ImageList.ColorDepth = ColorDepth.Depth32Bit;
            jsonTreeView.BackColor = Color.FromArgb(30, 30, 30);
            jsonTreeView.BorderStyle = BorderStyle.None;
            jsonTreeView.ForeColor = Color.FromArgb(250, 250, 250);
            jsonTreeView.NodeMouseClick += JsonTreeView_NodeMouseClick;

            scTreePreview.Panel1.Controls.Add(jsonTreeView);

            if (InputArg != "")
            {
                fctbMainEditor.Text = File.ReadAllText(InputArg);
                filename = InputArg;
            }

            popupMenu.BackColor = Color.FromArgb(35, 35, 35);
            popupMenu.HoveredColor = Color.FromArgb(100,100,100);
            popupMenu.SelectedColor = Color.Teal;
            popupMenu.ForeColor = Color.WhiteSmoke;

            BuildAutocompleteMenu();
        }
        class Nodes
        {
           public string Value = "";
           public Dictionary<string,string> Children = new Dictionary<string, string>();
        }
        private void JsonTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Nodes nodes = new Nodes();
            nodes.Value = e.Node.Text;
                foreach (TreeNode item in e.Node.Nodes)
                {
                  try
                  {
                      nodes.Children.Add(item.Text.Split(':')[0], item.Text.Split(':')[item.Text.Split(':').Length - 1]);
                  }
                  catch (Exception)
                  {

                  }
                }
                fastColoredTextBox4.Text = JsonConvert.SerializeObject(nodes, Formatting.Indented);
            noneToolStripMenuItem.Text = e.Node.Text.Split(':')[0];
        }

        private void BuildAutocompleteMenu()
        {
            List<AutocompleteItem> items = new List<AutocompleteItem>();
            foreach (var item in snippets)
                items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });
            foreach (var item in declarationSnippets)
                items.Add(new DeclarationSnippet(item) { ImageIndex = 0 });
            foreach (var item in methods)
                items.Add(new MethodAutocompleteItem(item) { ImageIndex = 2 });
            foreach (var item in keywords)
                items.Add(new AutocompleteItem(item));
            foreach (var item in Statics.dContexts)
                items.Add(new AutocompleteItem(item.Key));

            items.Add(new InsertEnterSnippet());
            items.Add(new InsertSpaceSnippet());
            items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
            //set as autocomplete source
            popupMenu.Items.SetAutocompleteItems(items);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tMemStat.Start();
            fctbMainEditor.Language = FastColoredTextBoxNS.Language.JS;

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonManager.Serialize(StudioStatics.Settings);
        }
        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
           var sfd= saveFileDialog.ShowDialog();
            if (sfd == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName,fctbMainEditor.Text);
                filename = saveFileDialog.FileName;
            }
        }

        private void ExportC_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "C Files (*.c)|*.c|All files (*.*)|*.*";
            var sfd = saveFileDialog.ShowDialog();
            if (sfd == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, fctbCWindow.Text);
         
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
            var ofgresult = openFileDialog.ShowDialog();
            if (ofgresult == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                fctbMainEditor.Text = File.ReadAllText(filename);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (filename=="")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
                var sfd = saveFileDialog.ShowDialog();
                if (sfd == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, fctbMainEditor.Text);
                    filename = saveFileDialog.FileName;
                }
            }
            else
            {
                File.WriteAllText(filename, fctbMainEditor.Text);
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            lStatus.Text = "Started compiler...";
            if (filename == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SudoC Files (*.sudoc)|*.sudoc|All files (*.*)|*.*";
                var sfd = saveFileDialog.ShowDialog();
                if (sfd == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, fctbMainEditor.Text);
                    filename = saveFileDialog.FileName;
                    bwRunWorker.RunWorkerAsync();
                }
            }
            else
            {
                File.WriteAllText(filename, fctbMainEditor.Text);
                bwRunWorker.RunWorkerAsync();
            }
        }


        private class LocalStatics
        {
            public List<string> lVars = new List<string>();
            public List<string> lImports = new List<string>();
            public Dictionary<string, string> dDefines = new Dictionary<string, string>();
            public Dictionary<string, string> dContexts = new Dictionary<string, string>();
            public int iStringNameCounter = 0;
            public float fVersionNumber = 0.01f;
        }

        private class CompilerStats
        {
            public DateTime LexxerStartTime = new DateTime();
            public DateTime LexxerEndTime = new DateTime();
            public TimeSpan LexxerTime = new TimeSpan();
            public DateTime AssemblerStartTime = new DateTime();
            public DateTime AssemblerEndTime = new DateTime();
            public TimeSpan AssemblerTime = new TimeSpan();
        }

        private class CompilerValues
        {
            public LocalStatics LocalStatics = new LocalStatics();
            public SudoC_Lexxer SudoC_Lexxer = new SudoC_Lexxer();
            public SudoC_Assembler SudoC_Assembler = new SudoC_Assembler();
        }

        private void FastColoredTextBox1_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
           SudoC_Lexxer sudoC_Lexxer = new SudoC_Lexxer();
            SudoC_Assembler sudoC_Assembler = new SudoC_Assembler();
            CompilerStats compilerStats = new CompilerStats();
            try
            {
                 Statics.reset();
                 var CurrentTime0 = DateTime.Now;
                 var Lexxed = sudoC_Lexxer.Lex(fctbMainEditor.Text);
                 var CurrentTime1 = DateTime.Now;

                 var CurrentTime2 = DateTime.Now;
                 var Assembled = sudoC_Assembler.Assemble(Lexxed);
                 var CurrentTime3 = DateTime.Now;
                 compilerStats.LexxerStartTime = CurrentTime0;
                 compilerStats.LexxerEndTime = CurrentTime1;
                 compilerStats.LexxerTime = CurrentTime1.Subtract(CurrentTime0);
                 compilerStats.AssemblerStartTime = CurrentTime2;
                 compilerStats.AssemblerEndTime = CurrentTime3;
                 compilerStats.AssemblerTime = CurrentTime3.Subtract(CurrentTime2);

                 fctbCWindow.Text = Assembled;
                 
                 lStatus.Text = ("Finished!");


             BuildAutocompleteMenu();

            }
            catch (Exception ex)
            {
                lStatus.Text = ex.Message;
                if (bThrow)
                    throw;
            }
            var statics = new LocalStatics();
            statics.fVersionNumber = Statics.fVersionNumber;
            statics.dContexts = Statics.dContexts;
            statics.dDefines = Statics.dDefines;
            statics.lImports = Statics.lImports;
            statics.lVars = Statics.lVars;
            statics.iStringNameCounter = Statics.iStringNameCounter;
            CompilerValues compilerValues = new CompilerValues();
            compilerValues.LocalStatics = statics;
            compilerValues.SudoC_Assembler = sudoC_Assembler;
            compilerValues.SudoC_Lexxer = sudoC_Lexxer;
            fctbCompilerValues.Text = JsonConvert.SerializeObject(compilerValues, Formatting.Indented);
            fctbCompilerStats.Text = JsonConvert.SerializeObject(compilerStats, Formatting.Indented);
            jsonTreeView.ShowJson(fctbCompilerValues.Text); 
        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (bThrow == true)
            {
                bThrow = false;
            }
            else
            {
                bThrow = true;
            }
        }

        private void TMemStat_Tick(object sender, EventArgs e)
        {
            Process thisProc = Process.GetCurrentProcess();
            currentMemoryUsageToolStripMenuItem.Text = "Memory Usage: "+thisProc.PagedMemorySize64 / 1000000 +"MB";
        }

        private void FastColoredTextBox2_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            //clear styles
            fctbCWindow.Range.ClearStyle(KeywordsStyle, FunctionNameStyle);
            //highlight keywords of LISP
            fctbCWindow.Range.SetStyle(KeywordsStyle, @"\b(int|var|char|int)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            fctbCWindow.Range.SetStyle(FunctionNameStyle, @"\b(printf|scanf|#|include|atoi|var|char|int|for|while)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        private void MemViewTabButton_Click(object sender, EventArgs e)
        {
            pCompStats.Visible = false;
            pMemViewCode.Visible = false;
            pMemView.Visible = true;
        }

        private void MemViewCodeTabButton_Click(object sender, EventArgs e)
        {
            pCompStats.Visible = false;
            pMemViewCode.Visible = true;
            pMemView.Visible = false;
        }

        private void CompStatsTabButton_Click(object sender, EventArgs e)
        {
            pCompStats.Visible = true;
            pMemViewCode.Visible = false;
            pMemView.Visible = false;
        }

        private void FastColoredTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear styles
            fctbCWindow.Range.ClearStyle(KeywordsStyle, FunctionNameStyle);
            //highlight keywords of LISP
            fctbCWindow.Range.SetStyle(KeywordsStyle, @"\b(int|var|char|int)\b", System.Text.RegularExpressions.RegexOptions.None);
            fctbCWindow.Range.SetStyle(FunctionNameStyle, @"\b(printf|scanf|#|include|atoi|var|char|int|for|while)\b", System.Text.RegularExpressions.RegexOptions.None);
        }

        private void FastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //comment highlighting
            fctbMainEditor.Range.ClearStyle(GreenStyle);
            //clear styles
            fctbMainEditor.Range.ClearStyle(KeywordsStyle, FunctionNameStyle);
            //highlight keywords of LISP
            fctbMainEditor.Range.SetStyle(KeywordsStyle, @"\b(context)\b", System.Text.RegularExpressions.RegexOptions.None);
            fctbMainEditor.Range.SetStyle(FunctionNameStyle, @"\b(print|input<>|fetch|include|repeat|def|=|var)\b", System.Text.RegularExpressions.RegexOptions.None);
            var Names = @"\b(";
            foreach (string name in Statics.dContexts.Keys)
            {
                Names += name + "|";
            }
            foreach (string name in Statics.dDefines.Keys)
            {
                Names += name + "|";
            }

            foreach (string name in Statics.lVars)
            {
                Names += name + "|";
            }
            Names.TrimEnd('|');
            Names += @")\b";
            fctbMainEditor.Range.SetStyle(NamesNameStyle, Names, RegexOptions.Singleline);
            //clear style of changed range
            fctbMainEditor.Range.SetStyle(GreenStyle, @"//*$", RegexOptions.None);
        }

        private void Tb_ConsoleBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fctbConsole.AppendText(tb_ConsoleBox.Text+"\n"+ SDK.Do(tb_ConsoleBox.Text.Split(' ')[0], tb_ConsoleBox.Text.Split(' ').Skip(1).ToArray()) +"\n");
                tb_ConsoleBox.Clear();
            
            }
        }

        private void BwRunWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var Output = "";
            Output = SDK.Do("open", new string[1] { filename });
            fctbConsole.AppendText(tb_ConsoleBox.Text + "\n" + Output);
        }

        private void BwRunWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lStatus.Text = "Finished";
        }

        private void FctbConsole_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            fctbConsole.GoEnd();
        }

        private void Tb_ConsoleBox_Enter(object sender, EventArgs e)
        {
            if (tb_ConsoleBox.Text == "Enter Your Command Here")
            {
                tb_ConsoleBox.Text = "";
                tb_ConsoleBox.ForeColor = Color.FromArgb(150,150,150);
            }
        }

        private void Tb_ConsoleBox_Leave(object sender, EventArgs e)
        {
            if (tb_ConsoleBox.Text.Length == 0)
            {
                tb_ConsoleBox.Text = "Enter Your Command Here";
                tb_ConsoleBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void HidePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!scCViewStats.Panel1Collapsed)
            {
                scCViewStats.Panel1Collapsed = true;
                StudioStatics.Settings.PreviewCollapsed = true;
            }
            else
            {
                scCViewStats.Panel1Collapsed = false;
                StudioStatics.Settings.PreviewCollapsed = false;
            }
        }

        private void HideMemoryViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!scCViewStats.Panel2Collapsed)
            {
                scCViewStats.Panel2Collapsed = true;
                StudioStatics.Settings.MemoryViewCollapsed = true;
            }
            else
            {
                scCViewStats.Panel2Collapsed = false;
                StudioStatics.Settings.MemoryViewCollapsed = false;

            }
        }

        private void HideLeftPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!scMainPreview.Panel2Collapsed)
            {
                scMainPreview.Panel2Collapsed = true;
                StudioStatics.Settings.LeftPanelCollapsed = true;
            }
            else
            {
                scMainPreview.Panel2Collapsed = false;
                StudioStatics.Settings.LeftPanelCollapsed = false;
            }
        }

        private void HideConsoleWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!scEditorConsole.Panel2Collapsed)
            {
                scEditorConsole.Panel2Collapsed = true;
                StudioStatics.Settings.ConsoleCollapsed = true;
            }
            else
            {
                scEditorConsole.Panel2Collapsed = false;
                StudioStatics.Settings.ConsoleCollapsed = false;
            }
        }
    }
}
    
