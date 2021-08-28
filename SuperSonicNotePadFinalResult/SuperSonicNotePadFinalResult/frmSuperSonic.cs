using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSonicNotePadFinalResult
{
    public partial class frmSuperSonic : Form
    {
        public frmSuperSonic()
        {
            InitializeComponent();
        }

        private void frmSuperSonic_Load(object sender, EventArgs e)
        {
            mySaveFileDialog.Filter = "RTF Files|*.rtf";
            mySaveFileDialog.DefaultExt = "*.rtf";
            myOpenFileDialog.Filter = "RTF Files|*.rtf";
            myOpenFileDialog.DefaultExt = "*.rtf";

            string strCurrentDate = dtpMenu.Value.ToLongDateString();
            rtfBox.Text = strCurrentDate + ":   ";

            rtfBox.SelectionStart = rtfBox.TextLength;

        }
        private void Default()
        {
            rtfBox.SelectionFont = new Font("Arial", 12F, FontStyle.Regular);
            rtfBox.SelectionColor = Color.Black;
        }

        private void tstDefault_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void mnuDefault_Click(object sender, EventArgs e)
        {
            Default();
        }

        // New Font Method to be used / called
        private void NewFont()
        {
            FontDialog myFontDialog = new FontDialog();
            myFontDialog.ShowColor = true;

            DialogResult FontResult = myFontDialog.ShowDialog();

            if (FontResult != DialogResult.Cancel)
            {
                rtfBox.SelectionFont = myFontDialog.Font;
                rtfBox.SelectionColor = myFontDialog.Color;
            }
        }


        private void tstNew_Font_Click(object sender, EventArgs e)
        {
            NewFont();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            NewFont();
        }

        // main red text method
        private void RedText()
        {
            rtfBox.SelectionColor = Color.Red;
        }

        private void tstRed_Click(object sender, EventArgs e)
        {
            RedText();
        }

        private void mnuRed_Click(object sender, EventArgs e)
        {
            RedText();
        }

        // main Bold method
        private void BoldText()
        {
            rtfBox.SelectionFont = new Font(rtfBox.SelectionFont, FontStyle.Bold);
        }
        private void tstBold_Click(object sender, EventArgs e)
        {
            BoldText();
        }

        private void mnuBold_Click(object sender, EventArgs e)
        {
            BoldText();
        }

        // main method for Italics
        private void ItalicText()
        {
            rtfBox.SelectionFont = new Font(rtfBox.SelectionFont, FontStyle.Italic);
        }

        private void tstItalic_Click(object sender, EventArgs e)
        {
            ItalicText();
        }

        private void mnuItalic_Click(object sender, EventArgs e)
        {
            ItalicText();
        }

        //Main method for Copy
        private void CopyMethod()
        {
            rtfBox.Copy();
        }

        private void tstCopy_Click(object sender, EventArgs e)
        {
            CopyMethod();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            CopyMethod();
        }

        // Main method for Paste
        private void PasteMethod()
        {
            rtfBox.Paste();
        }

        private void tstPaste_Click(object sender, EventArgs e)
        {
            PasteMethod();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            PasteMethod();
        }

        // OpenFile method for dialog box to appear
        private void OpenFile()
        {
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    string strFilePath = myOpenFileDialog.FileName;
                    rtfBox.LoadFile(strFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void tstOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        // Main Method for SaveFile
        private void SaveFile()
        {
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    string strFilePath = mySaveFileDialog.FileName;
                    rtfBox.SaveFile(strFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void tstSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void rtfBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
