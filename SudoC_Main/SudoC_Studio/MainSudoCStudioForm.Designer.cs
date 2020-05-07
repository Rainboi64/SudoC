namespace SudoC_Studio
{
    partial class MainSudoCStudioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSudoCStudioForm));
            this.tMemStat = new System.Windows.Forms.Timer(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMemoryViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLeftPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideConsoleWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.foldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSudoCStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSudoCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMainPreview = new System.Windows.Forms.SplitContainer();
            this.scEditorConsole = new System.Windows.Forms.SplitContainer();
            this.scEditorDM = new System.Windows.Forms.SplitContainer();
            this.fctbMainEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsMainEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmMainEditor = new FastColoredTextBoxNS.DocumentMap();
            this.fctbConsole = new FastColoredTextBoxNS.FastColoredTextBox();
            this.msConsoleTag = new System.Windows.Forms.MenuStrip();
            this.msiConsolePrev = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_ConsoleBox = new System.Windows.Forms.TextBox();
            this.rMainEditor = new FastColoredTextBoxNS.Ruler();
            this.scCViewStats = new System.Windows.Forms.SplitContainer();
            this.scCViewDM = new System.Windows.Forms.SplitContainer();
            this.fctbCWindow = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsCView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cViewcopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cViewZoomInStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cViewZoomOutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cViewFindlStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmCView = new FastColoredTextBoxNS.DocumentMap();
            this.rCView = new FastColoredTextBoxNS.Ruler();
            this.scTabsPanels = new System.Windows.Forms.SplitContainer();
            this.lStatus = new System.Windows.Forms.Label();
            this.bCompStatsTabButton = new System.Windows.Forms.Button();
            this.bMemViewCodeTabButton = new System.Windows.Forms.Button();
            this.bMemViewTabButton = new System.Windows.Forms.Button();
            this.pMemViewCode = new System.Windows.Forms.Panel();
            this.fctbCompilerValues = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pMemView = new System.Windows.Forms.Panel();
            this.scTreePreview = new System.Windows.Forms.SplitContainer();
            this.fastColoredTextBox4 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.msCodePreviewName = new System.Windows.Forms.MenuStrip();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCompStats = new System.Windows.Forms.Panel();
            this.fctbCompilerStats = new FastColoredTextBoxNS.FastColoredTextBox();
            this.msCodeTag = new System.Windows.Forms.MenuStrip();
            this.currentMemoryUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.bwRunWorker = new System.ComponentModel.BackgroundWorker();
            this.ilPreviewTree = new System.Windows.Forms.ImageList(this.components);
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainPreview)).BeginInit();
            this.scMainPreview.Panel1.SuspendLayout();
            this.scMainPreview.Panel2.SuspendLayout();
            this.scMainPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scEditorConsole)).BeginInit();
            this.scEditorConsole.Panel1.SuspendLayout();
            this.scEditorConsole.Panel2.SuspendLayout();
            this.scEditorConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scEditorDM)).BeginInit();
            this.scEditorDM.Panel1.SuspendLayout();
            this.scEditorDM.Panel2.SuspendLayout();
            this.scEditorDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbMainEditor)).BeginInit();
            this.cmsMainEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbConsole)).BeginInit();
            this.msConsoleTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCViewStats)).BeginInit();
            this.scCViewStats.Panel1.SuspendLayout();
            this.scCViewStats.Panel2.SuspendLayout();
            this.scCViewStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCViewDM)).BeginInit();
            this.scCViewDM.Panel1.SuspendLayout();
            this.scCViewDM.Panel2.SuspendLayout();
            this.scCViewDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCWindow)).BeginInit();
            this.cmsCView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTabsPanels)).BeginInit();
            this.scTabsPanels.Panel1.SuspendLayout();
            this.scTabsPanels.Panel2.SuspendLayout();
            this.scTabsPanels.SuspendLayout();
            this.pMemViewCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCompilerValues)).BeginInit();
            this.pMemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTreePreview)).BeginInit();
            this.scTreePreview.Panel2.SuspendLayout();
            this.scTreePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox4)).BeginInit();
            this.msCodePreviewName.SuspendLayout();
            this.pCompStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCompilerStats)).BeginInit();
            this.msCodeTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // tMemStat
            // 
            this.tMemStat.Tick += new System.EventHandler(this.TMemStat_Tick);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tabsToolStripMenuItem,
            this.editorToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1663, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.runToolStripMenuItem,
            this.exportCToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.Run_Click);
            // 
            // exportCToolStripMenuItem
            // 
            this.exportCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exportCToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.exportCToolStripMenuItem.Name = "exportCToolStripMenuItem";
            this.exportCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.exportCToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exportCToolStripMenuItem.Text = "Export C";
            this.exportCToolStripMenuItem.Click += new System.EventHandler(this.ExportC_Click);
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidePreviewToolStripMenuItem,
            this.hideMemoryViewToolStripMenuItem,
            this.hideLeftPanelToolStripMenuItem,
            this.hideConsoleWindowToolStripMenuItem});
            this.tabsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // hidePreviewToolStripMenuItem
            // 
            this.hidePreviewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hidePreviewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.hidePreviewToolStripMenuItem.Name = "hidePreviewToolStripMenuItem";
            this.hidePreviewToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hidePreviewToolStripMenuItem.Text = "Hide Preview";
            this.hidePreviewToolStripMenuItem.Click += new System.EventHandler(this.HidePreviewToolStripMenuItem_Click);
            // 
            // hideMemoryViewToolStripMenuItem
            // 
            this.hideMemoryViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hideMemoryViewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.hideMemoryViewToolStripMenuItem.Name = "hideMemoryViewToolStripMenuItem";
            this.hideMemoryViewToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hideMemoryViewToolStripMenuItem.Text = "Hide Memory View";
            this.hideMemoryViewToolStripMenuItem.Click += new System.EventHandler(this.HideMemoryViewToolStripMenuItem_Click);
            // 
            // hideLeftPanelToolStripMenuItem
            // 
            this.hideLeftPanelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hideLeftPanelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.hideLeftPanelToolStripMenuItem.Name = "hideLeftPanelToolStripMenuItem";
            this.hideLeftPanelToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hideLeftPanelToolStripMenuItem.Text = "Hide Left Panel";
            this.hideLeftPanelToolStripMenuItem.Click += new System.EventHandler(this.HideLeftPanelToolStripMenuItem_Click);
            // 
            // hideConsoleWindowToolStripMenuItem
            // 
            this.hideConsoleWindowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hideConsoleWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.hideConsoleWindowToolStripMenuItem.Name = "hideConsoleWindowToolStripMenuItem";
            this.hideConsoleWindowToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hideConsoleWindowToolStripMenuItem.Text = "Hide Console Window";
            this.hideConsoleWindowToolStripMenuItem.Click += new System.EventHandler(this.HideConsoleWindowToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.pasteToolStripMenuItem1,
            this.zoomInToolStripMenuItem1,
            this.zoomOutToolStripMenuItem1,
            this.findToolStripMenuItem1,
            this.replaceToolStripMenuItem1,
            this.foldToolStripMenuItem1});
            this.editorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem1.Text = "Copy";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem2.Text = "Cut";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pasteToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem1
            // 
            this.zoomInToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zoomInToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.zoomInToolStripMenuItem1.Name = "zoomInToolStripMenuItem1";
            this.zoomInToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.zoomInToolStripMenuItem1.Text = "Zoom In";
            this.zoomInToolStripMenuItem1.Click += new System.EventHandler(this.ZoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem1
            // 
            this.zoomOutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zoomOutToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.zoomOutToolStripMenuItem1.Name = "zoomOutToolStripMenuItem1";
            this.zoomOutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.zoomOutToolStripMenuItem1.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem1.Click += new System.EventHandler(this.ZoomOutToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.findToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.findToolStripMenuItem1.Text = "Find";
            this.findToolStripMenuItem1.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem1
            // 
            this.replaceToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.replaceToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.replaceToolStripMenuItem1.Name = "replaceToolStripMenuItem1";
            this.replaceToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.replaceToolStripMenuItem1.Text = "Replace";
            this.replaceToolStripMenuItem1.Click += new System.EventHandler(this.ReplaceToolStripMenuItem_Click);
            // 
            // foldToolStripMenuItem1
            // 
            this.foldToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.foldToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.foldToolStripMenuItem1.Name = "foldToolStripMenuItem1";
            this.foldToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.foldToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.foldToolStripMenuItem1.Text = "Fold";
            this.foldToolStripMenuItem1.Click += new System.EventHandler(this.FoldToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSudoCStudioToolStripMenuItem,
            this.aboutSudoCToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSudoCStudioToolStripMenuItem
            // 
            this.aboutSudoCStudioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.aboutSudoCStudioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.aboutSudoCStudioToolStripMenuItem.Name = "aboutSudoCStudioToolStripMenuItem";
            this.aboutSudoCStudioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutSudoCStudioToolStripMenuItem.Text = "About SudoC Studio";
            this.aboutSudoCStudioToolStripMenuItem.Click += new System.EventHandler(this.AboutSudoCStudioToolStripMenuItem_Click);
            // 
            // aboutSudoCToolStripMenuItem
            // 
            this.aboutSudoCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.aboutSudoCToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.aboutSudoCToolStripMenuItem.Name = "aboutSudoCToolStripMenuItem";
            this.aboutSudoCToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutSudoCToolStripMenuItem.Text = "About SudoC";
            this.aboutSudoCToolStripMenuItem.Click += new System.EventHandler(this.AboutSudoCToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.CreditsToolStripMenuItem_Click);
            // 
            // scMainPreview
            // 
            this.scMainPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.scMainPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainPreview.Location = new System.Drawing.Point(0, 24);
            this.scMainPreview.Name = "scMainPreview";
            // 
            // scMainPreview.Panel1
            // 
            this.scMainPreview.Panel1.Controls.Add(this.scEditorConsole);
            this.scMainPreview.Panel1.Controls.Add(this.rMainEditor);
            // 
            // scMainPreview.Panel2
            // 
            this.scMainPreview.Panel2.Controls.Add(this.scCViewStats);
            this.scMainPreview.Size = new System.Drawing.Size(1663, 929);
            this.scMainPreview.SplitterDistance = 970;
            this.scMainPreview.TabIndex = 5;
            // 
            // scEditorConsole
            // 
            this.scEditorConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scEditorConsole.Location = new System.Drawing.Point(0, 24);
            this.scEditorConsole.Name = "scEditorConsole";
            this.scEditorConsole.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scEditorConsole.Panel1
            // 
            this.scEditorConsole.Panel1.Controls.Add(this.scEditorDM);
            // 
            // scEditorConsole.Panel2
            // 
            this.scEditorConsole.Panel2.Controls.Add(this.fctbConsole);
            this.scEditorConsole.Panel2.Controls.Add(this.msConsoleTag);
            this.scEditorConsole.Panel2.Controls.Add(this.tb_ConsoleBox);
            this.scEditorConsole.Size = new System.Drawing.Size(970, 905);
            this.scEditorConsole.SplitterDistance = 658;
            this.scEditorConsole.TabIndex = 3;
            // 
            // scEditorDM
            // 
            this.scEditorDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scEditorDM.Location = new System.Drawing.Point(0, 0);
            this.scEditorDM.Name = "scEditorDM";
            // 
            // scEditorDM.Panel1
            // 
            this.scEditorDM.Panel1.Controls.Add(this.fctbMainEditor);
            // 
            // scEditorDM.Panel2
            // 
            this.scEditorDM.Panel2.Controls.Add(this.dmMainEditor);
            this.scEditorDM.Size = new System.Drawing.Size(970, 658);
            this.scEditorDM.SplitterDistance = 771;
            this.scEditorDM.TabIndex = 2;
            // 
            // fctbMainEditor
            // 
            this.fctbMainEditor.AutoCompleteBrackets = true;
            this.fctbMainEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbMainEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.fctbMainEditor.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctbMainEditor.BackBrush = null;
            this.fctbMainEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctbMainEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbMainEditor.CharHeight = 14;
            this.fctbMainEditor.CharWidth = 8;
            this.fctbMainEditor.ContextMenuStrip = this.cmsMainEditor;
            this.fctbMainEditor.CurrentLineColor = System.Drawing.Color.Gray;
            this.fctbMainEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbMainEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbMainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbMainEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbMainEditor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fctbMainEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fctbMainEditor.IsReplaceMode = false;
            this.fctbMainEditor.LeftBracket = '(';
            this.fctbMainEditor.LeftBracket2 = '{';
            this.fctbMainEditor.Location = new System.Drawing.Point(0, 0);
            this.fctbMainEditor.Name = "fctbMainEditor";
            this.fctbMainEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbMainEditor.RightBracket = ')';
            this.fctbMainEditor.RightBracket2 = '}';
            this.fctbMainEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbMainEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbMainEditor.ServiceColors")));
            this.fctbMainEditor.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctbMainEditor.ShowFoldingLines = true;
            this.fctbMainEditor.Size = new System.Drawing.Size(771, 658);
            this.fctbMainEditor.TabIndex = 0;
            this.fctbMainEditor.WordWrap = true;
            this.fctbMainEditor.Zoom = 100;
            this.fctbMainEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.FastColoredTextBox1_TextChanged);
            this.fctbMainEditor.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.FastColoredTextBox1_TextChangedDelayed);
            // 
            // cmsMainEditor
            // 
            this.cmsMainEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmsMainEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.foldToolStripMenuItem});
            this.cmsMainEditor.Name = "cmsMainEditor";
            this.cmsMainEditor.ShowImageMargin = false;
            this.cmsMainEditor.Size = new System.Drawing.Size(198, 180);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.ZoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.ZoomOutToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.ReplaceToolStripMenuItem_Click);
            // 
            // foldToolStripMenuItem
            // 
            this.foldToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.foldToolStripMenuItem.Name = "foldToolStripMenuItem";
            this.foldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.foldToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.foldToolStripMenuItem.Text = "Fold";
            this.foldToolStripMenuItem.Click += new System.EventHandler(this.FoldToolStripMenuItem_Click);
            // 
            // dmMainEditor
            // 
            this.dmMainEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dmMainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmMainEditor.ForeColor = System.Drawing.Color.Maroon;
            this.dmMainEditor.Location = new System.Drawing.Point(0, 0);
            this.dmMainEditor.Name = "dmMainEditor";
            this.dmMainEditor.Size = new System.Drawing.Size(195, 658);
            this.dmMainEditor.TabIndex = 0;
            this.dmMainEditor.Target = this.fctbMainEditor;
            this.dmMainEditor.Text = "documentMap1";
            // 
            // fctbConsole
            // 
            this.fctbConsole.AutoCompleteBrackets = true;
            this.fctbConsole.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbConsole.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fctbConsole.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctbConsole.BackBrush = null;
            this.fctbConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctbConsole.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbConsole.CharHeight = 14;
            this.fctbConsole.CharWidth = 8;
            this.fctbConsole.CommentPrefix = "--";
            this.fctbConsole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbConsole.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbConsole.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbConsole.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fctbConsole.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fctbConsole.IsReplaceMode = false;
            this.fctbConsole.Language = FastColoredTextBoxNS.Language.Lua;
            this.fctbConsole.LeftBracket = '(';
            this.fctbConsole.LeftBracket2 = '{';
            this.fctbConsole.Location = new System.Drawing.Point(0, 24);
            this.fctbConsole.Name = "fctbConsole";
            this.fctbConsole.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbConsole.ReadOnly = true;
            this.fctbConsole.RightBracket = ')';
            this.fctbConsole.RightBracket2 = '}';
            this.fctbConsole.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbConsole.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbConsole.ServiceColors")));
            this.fctbConsole.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctbConsole.Size = new System.Drawing.Size(970, 197);
            this.fctbConsole.TabIndex = 8;
            this.fctbConsole.VirtualSpace = true;
            this.fctbConsole.WideCaret = true;
            this.fctbConsole.WordWrap = true;
            this.fctbConsole.Zoom = 100;
            this.fctbConsole.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.FctbConsole_TextChangedDelayed);
            // 
            // msConsoleTag
            // 
            this.msConsoleTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msConsoleTag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiConsolePrev});
            this.msConsoleTag.Location = new System.Drawing.Point(0, 0);
            this.msConsoleTag.Name = "msConsoleTag";
            this.msConsoleTag.Size = new System.Drawing.Size(970, 24);
            this.msConsoleTag.TabIndex = 7;
            this.msConsoleTag.Text = "menuStrip4";
            // 
            // msiConsolePrev
            // 
            this.msiConsolePrev.Enabled = false;
            this.msiConsolePrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.msiConsolePrev.Name = "msiConsolePrev";
            this.msiConsolePrev.Size = new System.Drawing.Size(109, 20);
            this.msiConsolePrev.Text = "Console Window";
            // 
            // tb_ConsoleBox
            // 
            this.tb_ConsoleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_ConsoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ConsoleBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_ConsoleBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConsoleBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_ConsoleBox.Location = new System.Drawing.Point(0, 221);
            this.tb_ConsoleBox.Name = "tb_ConsoleBox";
            this.tb_ConsoleBox.Size = new System.Drawing.Size(970, 22);
            this.tb_ConsoleBox.TabIndex = 1;
            this.tb_ConsoleBox.Text = "Enter Your Command Here";
            this.tb_ConsoleBox.Enter += new System.EventHandler(this.Tb_ConsoleBox_Enter);
            this.tb_ConsoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_ConsoleBox_KeyDown);
            this.tb_ConsoleBox.Leave += new System.EventHandler(this.Tb_ConsoleBox_Leave);
            // 
            // rMainEditor
            // 
            this.rMainEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rMainEditor.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rMainEditor.CaretTickColor = System.Drawing.Color.White;
            this.rMainEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.rMainEditor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.rMainEditor.Location = new System.Drawing.Point(0, 0);
            this.rMainEditor.MaximumSize = new System.Drawing.Size(1073741824, 24);
            this.rMainEditor.MinimumSize = new System.Drawing.Size(0, 24);
            this.rMainEditor.Name = "rMainEditor";
            this.rMainEditor.Size = new System.Drawing.Size(970, 24);
            this.rMainEditor.TabIndex = 1;
            this.rMainEditor.Target = this.fctbMainEditor;
            this.rMainEditor.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // scCViewStats
            // 
            this.scCViewStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCViewStats.Location = new System.Drawing.Point(0, 0);
            this.scCViewStats.Name = "scCViewStats";
            this.scCViewStats.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCViewStats.Panel1
            // 
            this.scCViewStats.Panel1.Controls.Add(this.scCViewDM);
            this.scCViewStats.Panel1.Controls.Add(this.rCView);
            // 
            // scCViewStats.Panel2
            // 
            this.scCViewStats.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.scCViewStats.Panel2.Controls.Add(this.scTabsPanels);
            this.scCViewStats.Size = new System.Drawing.Size(689, 929);
            this.scCViewStats.SplitterDistance = 561;
            this.scCViewStats.TabIndex = 4;
            // 
            // scCViewDM
            // 
            this.scCViewDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCViewDM.Location = new System.Drawing.Point(0, 24);
            this.scCViewDM.Name = "scCViewDM";
            // 
            // scCViewDM.Panel1
            // 
            this.scCViewDM.Panel1.Controls.Add(this.fctbCWindow);
            // 
            // scCViewDM.Panel2
            // 
            this.scCViewDM.Panel2.Controls.Add(this.dmCView);
            this.scCViewDM.Size = new System.Drawing.Size(689, 537);
            this.scCViewDM.SplitterDistance = 548;
            this.scCViewDM.TabIndex = 6;
            // 
            // fctbCWindow
            // 
            this.fctbCWindow.AutoCompleteBrackets = true;
            this.fctbCWindow.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbCWindow.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fctbCWindow.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctbCWindow.BackBrush = null;
            this.fctbCWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctbCWindow.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbCWindow.CharHeight = 14;
            this.fctbCWindow.CharWidth = 8;
            this.fctbCWindow.CommentPrefix = "--";
            this.fctbCWindow.ContextMenuStrip = this.cmsCView;
            this.fctbCWindow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCWindow.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbCWindow.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbCWindow.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fctbCWindow.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fctbCWindow.IsReplaceMode = false;
            this.fctbCWindow.Language = FastColoredTextBoxNS.Language.Lua;
            this.fctbCWindow.LeftBracket = '(';
            this.fctbCWindow.LeftBracket2 = '{';
            this.fctbCWindow.Location = new System.Drawing.Point(0, 0);
            this.fctbCWindow.Name = "fctbCWindow";
            this.fctbCWindow.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCWindow.ReadOnly = true;
            this.fctbCWindow.RightBracket = ')';
            this.fctbCWindow.RightBracket2 = '}';
            this.fctbCWindow.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCWindow.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCWindow.ServiceColors")));
            this.fctbCWindow.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctbCWindow.ShowFoldingLines = true;
            this.fctbCWindow.Size = new System.Drawing.Size(548, 537);
            this.fctbCWindow.TabIndex = 5;
            this.fctbCWindow.VirtualSpace = true;
            this.fctbCWindow.WideCaret = true;
            this.fctbCWindow.WordWrap = true;
            this.fctbCWindow.Zoom = 100;
            this.fctbCWindow.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.FastColoredTextBox2_TextChanged);
            // 
            // cmsCView
            // 
            this.cmsCView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmsCView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cViewcopyToolStripMenuItem,
            this.cViewZoomInStripMenuItem,
            this.cViewZoomOutStripMenuItem,
            this.cViewFindlStripMenuItem});
            this.cmsCView.Name = "cmsMainEditor";
            this.cmsCView.ShowImageMargin = false;
            this.cmsCView.Size = new System.Drawing.Size(198, 92);
            // 
            // cViewcopyToolStripMenuItem
            // 
            this.cViewcopyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cViewcopyToolStripMenuItem.Name = "cViewcopyToolStripMenuItem";
            this.cViewcopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cViewcopyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cViewcopyToolStripMenuItem.Text = "Copy";
            this.cViewcopyToolStripMenuItem.Click += new System.EventHandler(this.CViewToolStripMenuItem3_Click);
            // 
            // cViewZoomInStripMenuItem
            // 
            this.cViewZoomInStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cViewZoomInStripMenuItem.Name = "cViewZoomInStripMenuItem";
            this.cViewZoomInStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.cViewZoomInStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cViewZoomInStripMenuItem.Text = "Zoom In";
            this.cViewZoomInStripMenuItem.Click += new System.EventHandler(this.CViewZoomInStripMenuItem_Click);
            // 
            // cViewZoomOutStripMenuItem
            // 
            this.cViewZoomOutStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cViewZoomOutStripMenuItem.Name = "cViewZoomOutStripMenuItem";
            this.cViewZoomOutStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.cViewZoomOutStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cViewZoomOutStripMenuItem.Text = "Zoom Out";
            this.cViewZoomOutStripMenuItem.Click += new System.EventHandler(this.CViewZoomOutStripMenuItem_Click);
            // 
            // cViewFindlStripMenuItem
            // 
            this.cViewFindlStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cViewFindlStripMenuItem.Name = "cViewFindlStripMenuItem";
            this.cViewFindlStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.cViewFindlStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cViewFindlStripMenuItem.Text = "Find";
            this.cViewFindlStripMenuItem.Click += new System.EventHandler(this.CViewFindlStripMenuItem_Click);
            // 
            // dmCView
            // 
            this.dmCView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dmCView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmCView.ForeColor = System.Drawing.Color.Maroon;
            this.dmCView.Location = new System.Drawing.Point(0, 0);
            this.dmCView.Name = "dmCView";
            this.dmCView.Size = new System.Drawing.Size(137, 537);
            this.dmCView.TabIndex = 0;
            this.dmCView.Target = this.fctbCWindow;
            this.dmCView.Text = "documentMap2";
            // 
            // rCView
            // 
            this.rCView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rCView.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rCView.CaretTickColor = System.Drawing.Color.SeaShell;
            this.rCView.Dock = System.Windows.Forms.DockStyle.Top;
            this.rCView.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.rCView.Location = new System.Drawing.Point(0, 0);
            this.rCView.MaximumSize = new System.Drawing.Size(1073741824, 24);
            this.rCView.MinimumSize = new System.Drawing.Size(0, 24);
            this.rCView.Name = "rCView";
            this.rCView.Size = new System.Drawing.Size(689, 24);
            this.rCView.TabIndex = 5;
            this.rCView.Target = this.fctbCWindow;
            // 
            // scTabsPanels
            // 
            this.scTabsPanels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.scTabsPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTabsPanels.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scTabsPanels.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scTabsPanels.IsSplitterFixed = true;
            this.scTabsPanels.Location = new System.Drawing.Point(0, 0);
            this.scTabsPanels.Name = "scTabsPanels";
            this.scTabsPanels.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scTabsPanels.Panel1
            // 
            this.scTabsPanels.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scTabsPanels.Panel1.Controls.Add(this.lStatus);
            this.scTabsPanels.Panel1.Controls.Add(this.bCompStatsTabButton);
            this.scTabsPanels.Panel1.Controls.Add(this.bMemViewCodeTabButton);
            this.scTabsPanels.Panel1.Controls.Add(this.bMemViewTabButton);
            // 
            // scTabsPanels.Panel2
            // 
            this.scTabsPanels.Panel2.Controls.Add(this.pMemViewCode);
            this.scTabsPanels.Panel2.Controls.Add(this.pMemView);
            this.scTabsPanels.Panel2.Controls.Add(this.pCompStats);
            this.scTabsPanels.Size = new System.Drawing.Size(689, 364);
            this.scTabsPanels.SplitterDistance = 29;
            this.scTabsPanels.TabIndex = 11;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.Transparent;
            this.lStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lStatus.Location = new System.Drawing.Point(318, 6);
            this.lStatus.Name = "lStatus";
            this.lStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lStatus.Size = new System.Drawing.Size(0, 23);
            this.lStatus.TabIndex = 3;
            // 
            // bCompStatsTabButton
            // 
            this.bCompStatsTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bCompStatsTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCompStatsTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bCompStatsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCompStatsTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bCompStatsTabButton.Location = new System.Drawing.Point(220, 0);
            this.bCompStatsTabButton.Name = "bCompStatsTabButton";
            this.bCompStatsTabButton.Size = new System.Drawing.Size(98, 29);
            this.bCompStatsTabButton.TabIndex = 2;
            this.bCompStatsTabButton.Text = "Compiler Stats";
            this.bCompStatsTabButton.UseVisualStyleBackColor = false;
            this.bCompStatsTabButton.Click += new System.EventHandler(this.CompStatsTabButton_Click);
            // 
            // bMemViewCodeTabButton
            // 
            this.bMemViewCodeTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bMemViewCodeTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bMemViewCodeTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bMemViewCodeTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMemViewCodeTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bMemViewCodeTabButton.Location = new System.Drawing.Point(96, 0);
            this.bMemViewCodeTabButton.Name = "bMemViewCodeTabButton";
            this.bMemViewCodeTabButton.Size = new System.Drawing.Size(124, 29);
            this.bMemViewCodeTabButton.TabIndex = 1;
            this.bMemViewCodeTabButton.Text = "Memory View (Code)";
            this.bMemViewCodeTabButton.UseVisualStyleBackColor = false;
            this.bMemViewCodeTabButton.Click += new System.EventHandler(this.MemViewCodeTabButton_Click);
            // 
            // bMemViewTabButton
            // 
            this.bMemViewTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bMemViewTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bMemViewTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bMemViewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMemViewTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bMemViewTabButton.Location = new System.Drawing.Point(0, 0);
            this.bMemViewTabButton.Name = "bMemViewTabButton";
            this.bMemViewTabButton.Size = new System.Drawing.Size(96, 29);
            this.bMemViewTabButton.TabIndex = 0;
            this.bMemViewTabButton.Text = "Memory View";
            this.bMemViewTabButton.UseVisualStyleBackColor = false;
            this.bMemViewTabButton.Click += new System.EventHandler(this.MemViewTabButton_Click);
            // 
            // pMemViewCode
            // 
            this.pMemViewCode.Controls.Add(this.fctbCompilerValues);
            this.pMemViewCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMemViewCode.Location = new System.Drawing.Point(0, 0);
            this.pMemViewCode.Name = "pMemViewCode";
            this.pMemViewCode.Size = new System.Drawing.Size(689, 331);
            this.pMemViewCode.TabIndex = 12;
            this.pMemViewCode.Visible = false;
            // 
            // fctbCompilerValues
            // 
            this.fctbCompilerValues.AutoCompleteBrackets = true;
            this.fctbCompilerValues.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbCompilerValues.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.fctbCompilerValues.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctbCompilerValues.BackBrush = null;
            this.fctbCompilerValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctbCompilerValues.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbCompilerValues.CharHeight = 14;
            this.fctbCompilerValues.CharWidth = 8;
            this.fctbCompilerValues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCompilerValues.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCompilerValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbCompilerValues.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbCompilerValues.ForeColor = System.Drawing.Color.LawnGreen;
            this.fctbCompilerValues.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fctbCompilerValues.IsReplaceMode = false;
            this.fctbCompilerValues.Language = FastColoredTextBoxNS.Language.JS;
            this.fctbCompilerValues.LeftBracket = '(';
            this.fctbCompilerValues.LeftBracket2 = '{';
            this.fctbCompilerValues.Location = new System.Drawing.Point(0, 0);
            this.fctbCompilerValues.Name = "fctbCompilerValues";
            this.fctbCompilerValues.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCompilerValues.ReadOnly = true;
            this.fctbCompilerValues.RightBracket = ')';
            this.fctbCompilerValues.RightBracket2 = '}';
            this.fctbCompilerValues.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCompilerValues.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCompilerValues.ServiceColors")));
            this.fctbCompilerValues.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctbCompilerValues.Size = new System.Drawing.Size(689, 331);
            this.fctbCompilerValues.TabIndex = 9;
            this.fctbCompilerValues.VirtualSpace = true;
            this.fctbCompilerValues.WideCaret = true;
            this.fctbCompilerValues.WordWrap = true;
            this.fctbCompilerValues.Zoom = 100;
            // 
            // pMemView
            // 
            this.pMemView.Controls.Add(this.scTreePreview);
            this.pMemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMemView.Location = new System.Drawing.Point(0, 0);
            this.pMemView.Name = "pMemView";
            this.pMemView.Size = new System.Drawing.Size(689, 331);
            this.pMemView.TabIndex = 12;
            // 
            // scTreePreview
            // 
            this.scTreePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTreePreview.Location = new System.Drawing.Point(0, 0);
            this.scTreePreview.Name = "scTreePreview";
            // 
            // scTreePreview.Panel2
            // 
            this.scTreePreview.Panel2.Controls.Add(this.fastColoredTextBox4);
            this.scTreePreview.Panel2.Controls.Add(this.msCodePreviewName);
            this.scTreePreview.Size = new System.Drawing.Size(689, 331);
            this.scTreePreview.SplitterDistance = 158;
            this.scTreePreview.TabIndex = 11;
            // 
            // fastColoredTextBox4
            // 
            this.fastColoredTextBox4.AutoCompleteBrackets = true;
            this.fastColoredTextBox4.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox4.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox4.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fastColoredTextBox4.BackBrush = null;
            this.fastColoredTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fastColoredTextBox4.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox4.CharHeight = 14;
            this.fastColoredTextBox4.CharWidth = 8;
            this.fastColoredTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox4.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox4.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox4.ForeColor = System.Drawing.Color.LawnGreen;
            this.fastColoredTextBox4.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fastColoredTextBox4.IsReplaceMode = false;
            this.fastColoredTextBox4.Language = FastColoredTextBoxNS.Language.JS;
            this.fastColoredTextBox4.LeftBracket = '(';
            this.fastColoredTextBox4.LeftBracket2 = '{';
            this.fastColoredTextBox4.Location = new System.Drawing.Point(0, 24);
            this.fastColoredTextBox4.Name = "fastColoredTextBox4";
            this.fastColoredTextBox4.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox4.RightBracket = ')';
            this.fastColoredTextBox4.RightBracket2 = '}';
            this.fastColoredTextBox4.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox4.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox4.ServiceColors")));
            this.fastColoredTextBox4.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fastColoredTextBox4.Size = new System.Drawing.Size(527, 307);
            this.fastColoredTextBox4.TabIndex = 1;
            this.fastColoredTextBox4.WordWrap = true;
            this.fastColoredTextBox4.Zoom = 100;
            // 
            // msCodePreviewName
            // 
            this.msCodePreviewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msCodePreviewName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
            this.msCodePreviewName.Location = new System.Drawing.Point(0, 0);
            this.msCodePreviewName.Name = "msCodePreviewName";
            this.msCodePreviewName.Size = new System.Drawing.Size(527, 24);
            this.msCodePreviewName.TabIndex = 2;
            this.msCodePreviewName.Text = "menuStrip3";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Enabled = false;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // pCompStats
            // 
            this.pCompStats.Controls.Add(this.fctbCompilerStats);
            this.pCompStats.Controls.Add(this.msCodeTag);
            this.pCompStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCompStats.Location = new System.Drawing.Point(0, 0);
            this.pCompStats.Name = "pCompStats";
            this.pCompStats.Size = new System.Drawing.Size(689, 331);
            this.pCompStats.TabIndex = 10;
            this.pCompStats.Visible = false;
            // 
            // fctbCompilerStats
            // 
            this.fctbCompilerStats.AutoCompleteBrackets = true;
            this.fctbCompilerStats.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbCompilerStats.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fctbCompilerStats.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctbCompilerStats.BackBrush = null;
            this.fctbCompilerStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctbCompilerStats.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbCompilerStats.CharHeight = 14;
            this.fctbCompilerStats.CharWidth = 8;
            this.fctbCompilerStats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCompilerStats.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCompilerStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbCompilerStats.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbCompilerStats.ForeColor = System.Drawing.Color.LawnGreen;
            this.fctbCompilerStats.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fctbCompilerStats.IsReplaceMode = false;
            this.fctbCompilerStats.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctbCompilerStats.LeftBracket = '(';
            this.fctbCompilerStats.LeftBracket2 = '{';
            this.fctbCompilerStats.Location = new System.Drawing.Point(0, 24);
            this.fctbCompilerStats.Name = "fctbCompilerStats";
            this.fctbCompilerStats.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCompilerStats.ReadOnly = true;
            this.fctbCompilerStats.RightBracket = ')';
            this.fctbCompilerStats.RightBracket2 = '}';
            this.fctbCompilerStats.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCompilerStats.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCompilerStats.ServiceColors")));
            this.fctbCompilerStats.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctbCompilerStats.Size = new System.Drawing.Size(689, 307);
            this.fctbCompilerStats.TabIndex = 11;
            this.fctbCompilerStats.VirtualSpace = true;
            this.fctbCompilerStats.WideCaret = true;
            this.fctbCompilerStats.WordWrap = true;
            this.fctbCompilerStats.Zoom = 100;
            // 
            // msCodeTag
            // 
            this.msCodeTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msCodeTag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentMemoryUsageToolStripMenuItem});
            this.msCodeTag.Location = new System.Drawing.Point(0, 0);
            this.msCodeTag.Name = "msCodeTag";
            this.msCodeTag.Size = new System.Drawing.Size(689, 24);
            this.msCodeTag.TabIndex = 10;
            this.msCodeTag.Text = "menuStrip2";
            // 
            // currentMemoryUsageToolStripMenuItem
            // 
            this.currentMemoryUsageToolStripMenuItem.Enabled = false;
            this.currentMemoryUsageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.currentMemoryUsageToolStripMenuItem.Name = "currentMemoryUsageToolStripMenuItem";
            this.currentMemoryUsageToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.currentMemoryUsageToolStripMenuItem.Text = "Current Memory Usage : 0";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(525, 24);
            this.miniToolStrip.TabIndex = 2;
            // 
            // bwRunWorker
            // 
            this.bwRunWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwRunWorker_DoWork);
            this.bwRunWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwRunWorker_RunWorkerCompleted);
            // 
            // ilPreviewTree
            // 
            this.ilPreviewTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPreviewTree.ImageStream")));
            this.ilPreviewTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPreviewTree.Images.SetKeyName(0, "Array");
            this.ilPreviewTree.Images.SetKeyName(1, "Boolean");
            this.ilPreviewTree.Images.SetKeyName(2, "Date");
            this.ilPreviewTree.Images.SetKeyName(3, "Float");
            this.ilPreviewTree.Images.SetKeyName(4, "Guid");
            this.ilPreviewTree.Images.SetKeyName(5, "Integer");
            this.ilPreviewTree.Images.SetKeyName(6, "None");
            this.ilPreviewTree.Images.SetKeyName(7, "Null");
            this.ilPreviewTree.Images.SetKeyName(8, "Object");
            this.ilPreviewTree.Images.SetKeyName(9, "String");
            this.ilPreviewTree.Images.SetKeyName(10, "TimeSpan");
            // 
            // MainSudoCStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 953);
            this.Controls.Add(this.scMainPreview);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "MainSudoCStudioForm";
            this.ShowIcon = false;
            this.Text = "SudoC Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.scMainPreview.Panel1.ResumeLayout(false);
            this.scMainPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainPreview)).EndInit();
            this.scMainPreview.ResumeLayout(false);
            this.scEditorConsole.Panel1.ResumeLayout(false);
            this.scEditorConsole.Panel2.ResumeLayout(false);
            this.scEditorConsole.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scEditorConsole)).EndInit();
            this.scEditorConsole.ResumeLayout(false);
            this.scEditorDM.Panel1.ResumeLayout(false);
            this.scEditorDM.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scEditorDM)).EndInit();
            this.scEditorDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbMainEditor)).EndInit();
            this.cmsMainEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbConsole)).EndInit();
            this.msConsoleTag.ResumeLayout(false);
            this.msConsoleTag.PerformLayout();
            this.scCViewStats.Panel1.ResumeLayout(false);
            this.scCViewStats.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCViewStats)).EndInit();
            this.scCViewStats.ResumeLayout(false);
            this.scCViewDM.Panel1.ResumeLayout(false);
            this.scCViewDM.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCViewDM)).EndInit();
            this.scCViewDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbCWindow)).EndInit();
            this.cmsCView.ResumeLayout(false);
            this.scTabsPanels.Panel1.ResumeLayout(false);
            this.scTabsPanels.Panel1.PerformLayout();
            this.scTabsPanels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTabsPanels)).EndInit();
            this.scTabsPanels.ResumeLayout(false);
            this.pMemViewCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbCompilerValues)).EndInit();
            this.pMemView.ResumeLayout(false);
            this.scTreePreview.Panel2.ResumeLayout(false);
            this.scTreePreview.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTreePreview)).EndInit();
            this.scTreePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox4)).EndInit();
            this.msCodePreviewName.ResumeLayout(false);
            this.msCodePreviewName.PerformLayout();
            this.pCompStats.ResumeLayout(false);
            this.pCompStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCompilerStats)).EndInit();
            this.msCodeTag.ResumeLayout(false);
            this.msCodeTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tMemStat;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMainPreview;
        private System.Windows.Forms.SplitContainer scEditorDM;
        private FastColoredTextBoxNS.FastColoredTextBox fctbMainEditor;
        private FastColoredTextBoxNS.DocumentMap dmMainEditor;
        private FastColoredTextBoxNS.Ruler rMainEditor;
        private System.Windows.Forms.SplitContainer scCViewStats;
        private System.Windows.Forms.SplitContainer scCViewDM;
        private FastColoredTextBoxNS.FastColoredTextBox fctbCWindow;
        private FastColoredTextBoxNS.DocumentMap dmCView;
        private FastColoredTextBoxNS.Ruler rCView;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.SplitContainer scTabsPanels;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bCompStatsTabButton;
        private System.Windows.Forms.Button bMemViewCodeTabButton;
        private System.Windows.Forms.Button bMemViewTabButton;
        private System.Windows.Forms.Panel pMemViewCode;
        private FastColoredTextBoxNS.FastColoredTextBox fctbCompilerValues;
        private System.Windows.Forms.Panel pMemView;
        private System.Windows.Forms.SplitContainer scTreePreview;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox4;
        private System.Windows.Forms.MenuStrip msCodePreviewName;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.Panel pCompStats;
        private FastColoredTextBoxNS.FastColoredTextBox fctbCompilerStats;
        private System.Windows.Forms.MenuStrip msCodeTag;
        private System.Windows.Forms.ToolStripMenuItem currentMemoryUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMemoryViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLeftPanelToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scEditorConsole;
        private System.Windows.Forms.MenuStrip msConsoleTag;
        private System.Windows.Forms.ToolStripMenuItem msiConsolePrev;
        private System.ComponentModel.BackgroundWorker bwRunWorker;
        private FastColoredTextBoxNS.FastColoredTextBox fctbConsole;
        private System.Windows.Forms.TextBox tb_ConsoleBox;
        private System.Windows.Forms.ToolStripMenuItem hideConsoleWindowToolStripMenuItem;
        private System.Windows.Forms.ImageList ilPreviewTree;
        private System.Windows.Forms.ContextMenuStrip cmsMainEditor;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem foldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSudoCStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSudoCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCView;
        private System.Windows.Forms.ToolStripMenuItem cViewcopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cViewZoomInStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cViewZoomOutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cViewFindlStripMenuItem;
    }
}

