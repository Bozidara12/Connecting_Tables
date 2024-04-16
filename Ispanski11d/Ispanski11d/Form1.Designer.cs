namespace Ispanski11d
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuNow = new ToolStripMenuItem();
            menuNew = new ToolStripMenuItem();
            nowWindowToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuSave = new ToolStripMenuItem();
            menuSaveAs = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menuPageSetUp = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuPrint = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuCut = new ToolStripMenuItem();
            menuCopy = new ToolStripMenuItem();
            menuPaste = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuSelectAll = new ToolStripMenuItem();
            menuUndo = new ToolStripMenuItem();
            menuRedu = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuFont = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            openDLG = new OpenFileDialog();
            saveDLG = new SaveFileDialog();
            fontDLG = new FontDialog();
            colorDLG = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuNow, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(865, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuNow
            // 
            menuNow.DropDownItems.AddRange(new ToolStripItem[] { menuNew, nowWindowToolStripMenuItem, menuOpen, toolStripSeparator3, menuSave, menuSaveAs, toolStripSeparator4, menuPageSetUp, menuExit, menuPrint });
            menuNow.Name = "menuNow";
            menuNow.Size = new Size(37, 20);
            menuNow.Text = "&File";
            menuNow.Click += menuNow_Click;
            // 
            // menuNew
            // 
            menuNew.Name = "menuNew";
            menuNew.ShortcutKeys = Keys.Control | Keys.N;
            menuNew.Size = new Size(180, 22);
            menuNew.Text = "New";
            menuNew.Click += menuNew_Click;
            // 
            // nowWindowToolStripMenuItem
            // 
            nowWindowToolStripMenuItem.Name = "nowWindowToolStripMenuItem";
            nowWindowToolStripMenuItem.Size = new Size(180, 22);
            nowWindowToolStripMenuItem.Text = "Now Window";
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.ShortcutKeys = Keys.Control | Keys.N;
            menuOpen.Size = new Size(180, 22);
            menuOpen.Text = "Open";
            menuOpen.Click += menuOpen_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.ShortcutKeys = Keys.Control | Keys.S;
            menuSave.Size = new Size(180, 22);
            menuSave.Text = "Save";
            menuSave.Click += menuSave_Click;
            // 
            // menuSaveAs
            // 
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.Size = new Size(180, 22);
            menuSaveAs.Text = "Save As";
            menuSaveAs.Click += menuSaveAs_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // menuPageSetUp
            // 
            menuPageSetUp.Name = "menuPageSetUp";
            menuPageSetUp.Size = new Size(180, 22);
            menuPageSetUp.Text = "Page Setup";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuExit.Size = new Size(180, 22);
            menuExit.Text = "Exit";
            menuExit.Click += menuExit_Click;
            // 
            // menuPrint
            // 
            menuPrint.Name = "menuPrint";
            menuPrint.Size = new Size(180, 22);
            menuPrint.Text = "Print";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuCut, menuCopy, menuPaste, toolStripSeparator1, menuSelectAll, menuUndo, menuRedu, toolStripSeparator2, menuFont });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // menuCut
            // 
            menuCut.Name = "menuCut";
            menuCut.ShortcutKeys = Keys.Control | Keys.X;
            menuCut.Size = new Size(180, 22);
            menuCut.Text = "Cut";
            menuCut.Click += menuCut_Click;
            // 
            // menuCopy
            // 
            menuCopy.Name = "menuCopy";
            menuCopy.ShortcutKeys = Keys.Control | Keys.C;
            menuCopy.Size = new Size(180, 22);
            menuCopy.Text = "Copy";
            menuCopy.Click += menuCopy_Click;
            // 
            // menuPaste
            // 
            menuPaste.Name = "menuPaste";
            menuPaste.ShortcutKeys = Keys.Control | Keys.V;
            menuPaste.Size = new Size(180, 22);
            menuPaste.Text = "Paste";
            menuPaste.Click += menuPaste_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // menuSelectAll
            // 
            menuSelectAll.Name = "menuSelectAll";
            menuSelectAll.ShortcutKeys = Keys.Control | Keys.A;
            menuSelectAll.Size = new Size(180, 22);
            menuSelectAll.Text = "Select All";
            menuSelectAll.Click += menuSelectAll_Click;
            // 
            // menuUndo
            // 
            menuUndo.Name = "menuUndo";
            menuUndo.ShortcutKeys = Keys.Control | Keys.Z;
            menuUndo.Size = new Size(180, 22);
            menuUndo.Text = "Undo";
            menuUndo.Click += menuUndo_Click;
            // 
            // menuRedu
            // 
            menuRedu.Name = "menuRedu";
            menuRedu.ShortcutKeys = Keys.Control | Keys.Y;
            menuRedu.Size = new Size(180, 22);
            menuRedu.Text = "Redu";
            menuRedu.Click += menuRedu_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // menuFont
            // 
            menuFont.Name = "menuFont";
            menuFont.Size = new Size(180, 22);
            menuFont.Text = "Font";
            menuFont.Click += menuFont_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wordWrapToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Checked = true;
            wordWrapToolStripMenuItem.CheckState = CheckState.Checked;
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(180, 22);
            wordWrapToolStripMenuItem.Text = "Word wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(865, 426);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(865, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // openDLG
            // 
            openDLG.FileName = "openFileDialog1";
            // 
            // fontDLG
            // 
            fontDLG.Apply += fontDialog1_Apply;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Text Pad";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuNow;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuSaveAs;
        private ToolStripMenuItem menuPageSetUp;
        private ToolStripMenuItem menuPrint;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuCut;
        private ToolStripMenuItem menuCopy;
        private ToolStripMenuItem menuPaste;
        private ToolStripMenuItem menuSelectAll;
        private ToolStripMenuItem menuUndo;
        private ToolStripMenuItem menuRedu;
        private ToolStripMenuItem menuFont;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem nowWindowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private OpenFileDialog openDLG;
        private SaveFileDialog saveDLG;
        private FontDialog fontDLG;
        private ColorDialog colorDLG;
    }
}
