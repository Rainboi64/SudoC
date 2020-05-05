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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudoC_Studio
{
    public partial class Form1 : Form
    {
        static string filename = string.Empty;
        AutocompleteMenu popupMenu;
        Style KeywordsStyle = new TextStyle(Brushes.DeepPink, null, FontStyle.Regular);
        Style FunctionNameStyle = new TextStyle(Brushes.Teal, null, FontStyle.Regular);
        Style NamesNameStyle = new TextStyle(Brushes.DarkRed, null, FontStyle.Regular);

        string[] keywords = { "var = ;"};
        string[] methods = { "fetch()","input<>","print()"};
        string[] snippets = { "if(^)\n{\n;\n}", "if(^)\n{\n;\n}\nelse\n{\n;\n}", "for(^;;)\n{\n;\n}", "while(^)\n{\n;\n}", "do${\n^;\n}while();", "switch(^)\n{\n\n}" ,"repeat(^) "+ "Input" + Statics.iStringNameCounter + "\n{\n\n}"};
        string[] declarationSnippets = {
               "context ^\n{\n}"
               };
        bool bThrow = false;
        JsonTreeView jsonTreeView = new JsonTreeView();
        public Form1(string InputArg)
        {
            InitializeComponent();
            fastColoredTextBox2.Language = Language.CSharp;
            popupMenu = new AutocompleteMenu(fastColoredTextBox1);
            popupMenu.AllowTabKey = true;
            jsonTreeView.Dock = DockStyle.Fill;
            jsonTreeView.ImageList.TransparentColor = Color.White;
            jsonTreeView.ImageList.ColorDepth = ColorDepth.Depth32Bit;

            jsonTreeView.BackColor = Color.FromArgb(30, 30, 30);
            jsonTreeView.BorderStyle = BorderStyle.None;
            jsonTreeView.ForeColor = Color.FromArgb(250, 250, 250);
            jsonTreeView.NodeMouseClick += JsonTreeView_NodeMouseClick;
            splitContainer5.Panel1.Controls.Add(jsonTreeView);

            if (InputArg != "")
            {
                fastColoredTextBox1.Text = File.ReadAllText(InputArg);
                filename = InputArg;
            }
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
                    nodes.Children.Add(item.Text.Split(':')[0], item.Text.Split(':')[item.Text.Split(':').Length - 1]);
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
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;

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
                File.WriteAllText(saveFileDialog.FileName,fastColoredTextBox1.Text);
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
                File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox2.Text);
         
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
                fastColoredTextBox1.Text = File.ReadAllText(filename);
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
                    File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox1.Text);
                    filename = saveFileDialog.FileName;
                }
            }
            else
            {
                File.WriteAllText(filename, fastColoredTextBox1.Text);
            }
        }

        private void Run_Click(object sender, EventArgs e)
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
                    Process.Start(@".\SudoC_Windows.exe", filename);
                }
            }
            else
            {
                File.WriteAllText(filename, fastColoredTextBox1.Text);
                Process.Start(@".\SudoC_Windows.exe", filename);
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
            //clear styles
            fastColoredTextBox1.Range.ClearStyle(KeywordsStyle, FunctionNameStyle);
            //highlight keywords of LISP
            fastColoredTextBox1.Range.SetStyle(KeywordsStyle, @"\b(context)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            fastColoredTextBox1.Range.SetStyle(FunctionNameStyle, @"\b(print|fetch|include|repeat|def|=|var)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
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
            SudoC_Lexxer sudoC_Lexxer = new SudoC_Lexxer();
            SudoC_Assembler sudoC_Assembler = new SudoC_Assembler();
            CompilerStats compilerStats = new CompilerStats();
            try
            {
                 fastColoredTextBox1.Range.SetStyle(NamesNameStyle, Names, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                 Statics.reset();
                 var CurrentTime0 = DateTime.Now;
                 var Lexxed = sudoC_Lexxer.Lex(fastColoredTextBox1.Text);
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

                 fastColoredTextBox2.Text = Assembled;
                 
                 label1.Text = ("Finished!");


             BuildAutocompleteMenu();

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                if (bThrow) throw;
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
            fastColoredTextBox3.Text = JsonConvert.SerializeObject(compilerValues, Formatting.Indented);
            fastColoredTextBox5.Text = JsonConvert.SerializeObject(compilerStats, Formatting.Indented);
            jsonTreeView.ShowJson(fastColoredTextBox3.Text); 
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void TMemStat_Tick(object sender, EventArgs e)
        {
            Process thisProc = Process.GetCurrentProcess();
            currentMemoryUsageToolStripMenuItem.Text = "Memory Usage: "+thisProc.PagedMemorySize64 / 1000000 +"MB";
        }

        private void FastColoredTextBox2_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            //clear styles
            fastColoredTextBox2.Range.ClearStyle(KeywordsStyle, FunctionNameStyle);
            //highlight keywords of LISP
            fastColoredTextBox2.Range.SetStyle(KeywordsStyle, @"\b(int|var|char|int)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            fastColoredTextBox2.Range.SetStyle(FunctionNameStyle, @"\b(printf|scanf|#|include|atoi|var|char|int|for|while)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }


        private void SplitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void FastColoredTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear styles
            fastColoredTextBox2.Range.ClearStyle(KeywordsStyle, FunctionNameStyle);
            //highlight keywords of LISP
            fastColoredTextBox2.Range.SetStyle(KeywordsStyle, @"\b(int|var|char|int)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            fastColoredTextBox2.Range.SetStyle(FunctionNameStyle, @"\b(printf|scanf|#|include|atoi|var|char|int|for|while)\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
    }

    }
    
