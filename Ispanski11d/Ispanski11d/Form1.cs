using System.Security.Cryptography;

namespace Ispanski11d
{
    public partial class Form1 : Form
    {
        string lastSeavedFileName = "unknow";
        public Form1()
        {
            InitializeComponent();
        }

        private void nowWindouToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            lastSeavedFileName = "unknow";
            richTextBox1.Modified = false;

        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu New");
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (lastSeavedFileName == "unknow")
            {
                menuSaveAs_Click(sender, e);
            }
            else
            {
                richTextBox1.SaveFile(lastSeavedFileName, RichTextBoxStreamType.RichText);
            }
        }

        private void menuNow_Click(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = true;
            }
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void menuUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void menuRedu_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            openDLG.Title = "Select your filr";
            openDLG.Multiselect = false;
            openDLG.Filter = "All files(.)|*.*|Text Files(.txt)|*.txt";
            if (openDLG.ShowDialog() == DialogResult.OK)
            {
                StreamReader randomFile = new StreamReader(openDLG.FileName);
                richTextBox1.Text = randomFile.ReadToEnd();
                randomFile.Close();
            }

            //1.Podgotovka
            openDLG.Filter = "Text Files|*.txt|Rich Text Format|*.rtf|Word files|*.docx;*.doc|All file|*.*";
            openDLG.FilterIndex = 2;
            openDLG.Title = "Text Pad-Open files";
            openDLG.InitialDirectory = "C:\\Users\\STUDENTS-1212-7\\Desktop\\TextPad File Directory";
            openDLG.FileName = "";

            //2.ShowDialog
            openDLG.ShowDialog();

            //3.Rezultat
            this.Text = "Text Pad-" + openDLG.SafeFileName;

            richTextBox1.LoadFile(openDLG.FileName, RichTextBoxStreamType.RichText);



        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            //1.Podgotovka
            saveDLG.Filter = "Text Files|*.txt|Rich Text Format|*.rtf|Word files|*.docx|All file|*.*";
            saveDLG.FilterIndex = 2;
            saveDLG.Title = "Text Pad-Save files";
            saveDLG.InitialDirectory = "C:\\Users\\STUDENTS-1212-7\\Desktop\\TextPad File Directory";
            saveDLG.FileName = "";

            //2.ShowDialog

            DialogResult resultDLG = saveDLG.ShowDialog();
            //3.Rezultat
            this.Text = "Text Pad-" + saveDLG.FileName;
            if (resultDLG == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveDLG.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            fontDLG.ShowColor = true;
            fontDLG.ShowEffects = true;
            fontDLG.ShowApply = true;
            fontDLG.ShowDialog();
            richTextBox1.SelectionFont = fontDLG.Font;
            richTextBox1.SelectionColor = fontDLG.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified==true)
            {
                DialogResult answer =
                    MessageBox.Show("Do you want to save changes?", "Prompt to SAVE",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.Yes)
                {
                  menuSave_Click(sender, e);
                }
                if (answer==DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
