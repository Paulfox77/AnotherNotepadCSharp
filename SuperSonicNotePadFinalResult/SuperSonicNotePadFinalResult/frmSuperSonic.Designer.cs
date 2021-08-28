namespace SuperSonicNotePadFinalResult
{
    partial class frmSuperSonic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuperSonic));
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tstCommands = new System.Windows.Forms.ToolStrip();
            this.tstDefault = new System.Windows.Forms.ToolStripButton();
            this.tstNew_Font = new System.Windows.Forms.ToolStripButton();
            this.tstRed = new System.Windows.Forms.ToolStripButton();
            this.tstBold = new System.Windows.Forms.ToolStripButton();
            this.tstItalic = new System.Windows.Forms.ToolStripButton();
            this.tstCopy = new System.Windows.Forms.ToolStripButton();
            this.tstPaste = new System.Windows.Forms.ToolStripButton();
            this.tstOpen = new System.Windows.Forms.ToolStripButton();
            this.tstSave = new System.Windows.Forms.ToolStripButton();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rtfBox = new System.Windows.Forms.RichTextBox();
            this.dtpMenu = new System.Windows.Forms.DateTimePicker();
            this.mnuOptions.SuspendLayout();
            this.tstCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(864, 24);
            this.mnuOptions.TabIndex = 0;
            this.mnuOptions.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuFileOpen,
            this.mnuFileClose,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(38, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(152, 22);
            this.mnuNew.Text = "New";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOpen.Text = "Open_File";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(152, 22);
            this.mnuFileClose.Text = "Save_File";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDefault,
            this.mnuFont,
            this.mnuRed,
            this.mnuBold,
            this.mnuItalic,
            this.mnuCopy,
            this.mnuPaste});
            this.mnuEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(40, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuDefault
            // 
            this.mnuDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuDefault.Name = "mnuDefault";
            this.mnuDefault.Size = new System.Drawing.Size(127, 22);
            this.mnuDefault.Text = "Default";
            this.mnuDefault.Click += new System.EventHandler(this.mnuDefault_Click);
            // 
            // mnuFont
            // 
            this.mnuFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(127, 22);
            this.mnuFont.Text = "New_Font";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuRed
            // 
            this.mnuRed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuRed.Name = "mnuRed";
            this.mnuRed.Size = new System.Drawing.Size(127, 22);
            this.mnuRed.Text = "Red";
            this.mnuRed.Click += new System.EventHandler(this.mnuRed_Click);
            // 
            // mnuBold
            // 
            this.mnuBold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuBold.Name = "mnuBold";
            this.mnuBold.Size = new System.Drawing.Size(127, 22);
            this.mnuBold.Text = "Bold";
            this.mnuBold.Click += new System.EventHandler(this.mnuBold_Click);
            // 
            // mnuItalic
            // 
            this.mnuItalic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuItalic.Name = "mnuItalic";
            this.mnuItalic.Size = new System.Drawing.Size(127, 22);
            this.mnuItalic.Text = "Italic";
            this.mnuItalic.Click += new System.EventHandler(this.mnuItalic_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(127, 22);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(127, 22);
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // tstCommands
            // 
            this.tstCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstDefault,
            this.tstNew_Font,
            this.tstRed,
            this.tstBold,
            this.tstItalic,
            this.tstCopy,
            this.tstPaste,
            this.tstOpen,
            this.tstSave});
            this.tstCommands.Location = new System.Drawing.Point(0, 24);
            this.tstCommands.Name = "tstCommands";
            this.tstCommands.Size = new System.Drawing.Size(864, 25);
            this.tstCommands.TabIndex = 1;
            this.tstCommands.Text = "toolStrip1";
            // 
            // tstDefault
            // 
            this.tstDefault.AutoSize = false;
            this.tstDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstDefault.Image = ((System.Drawing.Image)(resources.GetObject("tstDefault.Image")));
            this.tstDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstDefault.Name = "tstDefault";
            this.tstDefault.Size = new System.Drawing.Size(63, 22);
            this.tstDefault.Text = "Default";
            this.tstDefault.Click += new System.EventHandler(this.tstDefault_Click);
            // 
            // tstNew_Font
            // 
            this.tstNew_Font.AutoSize = false;
            this.tstNew_Font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstNew_Font.Image = ((System.Drawing.Image)(resources.GetObject("tstNew_Font.Image")));
            this.tstNew_Font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstNew_Font.Name = "tstNew_Font";
            this.tstNew_Font.Size = new System.Drawing.Size(63, 22);
            this.tstNew_Font.Text = "New_Font";
            this.tstNew_Font.Click += new System.EventHandler(this.tstNew_Font_Click);
            // 
            // tstRed
            // 
            this.tstRed.AutoSize = false;
            this.tstRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstRed.Image = ((System.Drawing.Image)(resources.GetObject("tstRed.Image")));
            this.tstRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstRed.Name = "tstRed";
            this.tstRed.Size = new System.Drawing.Size(63, 22);
            this.tstRed.Text = "Red";
            this.tstRed.Click += new System.EventHandler(this.tstRed_Click);
            // 
            // tstBold
            // 
            this.tstBold.AutoSize = false;
            this.tstBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstBold.Image = ((System.Drawing.Image)(resources.GetObject("tstBold.Image")));
            this.tstBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBold.Name = "tstBold";
            this.tstBold.Size = new System.Drawing.Size(63, 22);
            this.tstBold.Text = "Bold";
            this.tstBold.Click += new System.EventHandler(this.tstBold_Click);
            // 
            // tstItalic
            // 
            this.tstItalic.AutoSize = false;
            this.tstItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstItalic.Image = ((System.Drawing.Image)(resources.GetObject("tstItalic.Image")));
            this.tstItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstItalic.Name = "tstItalic";
            this.tstItalic.Size = new System.Drawing.Size(63, 22);
            this.tstItalic.Text = "Italic";
            this.tstItalic.Click += new System.EventHandler(this.tstItalic_Click);
            // 
            // tstCopy
            // 
            this.tstCopy.AutoSize = false;
            this.tstCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstCopy.Image = ((System.Drawing.Image)(resources.GetObject("tstCopy.Image")));
            this.tstCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstCopy.Name = "tstCopy";
            this.tstCopy.Size = new System.Drawing.Size(63, 22);
            this.tstCopy.Text = "Copy";
            this.tstCopy.Click += new System.EventHandler(this.tstCopy_Click);
            // 
            // tstPaste
            // 
            this.tstPaste.AutoSize = false;
            this.tstPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstPaste.Image = ((System.Drawing.Image)(resources.GetObject("tstPaste.Image")));
            this.tstPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstPaste.Name = "tstPaste";
            this.tstPaste.Size = new System.Drawing.Size(63, 22);
            this.tstPaste.Text = "Paste";
            this.tstPaste.Click += new System.EventHandler(this.tstPaste_Click);
            // 
            // tstOpen
            // 
            this.tstOpen.AutoSize = false;
            this.tstOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstOpen.Image = ((System.Drawing.Image)(resources.GetObject("tstOpen.Image")));
            this.tstOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstOpen.Name = "tstOpen";
            this.tstOpen.Size = new System.Drawing.Size(63, 22);
            this.tstOpen.Text = "Open_File";
            this.tstOpen.Click += new System.EventHandler(this.tstOpen_Click);
            // 
            // tstSave
            // 
            this.tstSave.AutoSize = false;
            this.tstSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSave.Image = ((System.Drawing.Image)(resources.GetObject("tstSave.Image")));
            this.tstSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSave.Name = "tstSave";
            this.tstSave.Size = new System.Drawing.Size(63, 22);
            this.tstSave.Text = "Save_File";
            this.tstSave.Click += new System.EventHandler(this.tstSave_Click);
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog1";
            // 
            // rtfBox
            // 
            this.rtfBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfBox.Location = new System.Drawing.Point(0, 49);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.Size = new System.Drawing.Size(864, 431);
            this.rtfBox.TabIndex = 2;
            this.rtfBox.Text = "";
            this.rtfBox.TextChanged += new System.EventHandler(this.rtfBox_TextChanged);
            // 
            // dtpMenu
            // 
            this.dtpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMenu.Location = new System.Drawing.Point(664, 27);
            this.dtpMenu.Name = "dtpMenu";
            this.dtpMenu.Size = new System.Drawing.Size(200, 20);
            this.dtpMenu.TabIndex = 3;
            // 
            // frmSuperSonic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 480);
            this.Controls.Add(this.dtpMenu);
            this.Controls.Add(this.rtfBox);
            this.Controls.Add(this.tstCommands);
            this.Controls.Add(this.mnuOptions);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmSuperSonic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSonicNotepad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSuperSonic_Load);
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.tstCommands.ResumeLayout(false);
            this.tstCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDefault;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuRed;
        private System.Windows.Forms.ToolStripMenuItem mnuBold;
        private System.Windows.Forms.ToolStripMenuItem mnuItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStrip tstCommands;
        private System.Windows.Forms.ToolStripButton tstDefault;
        private System.Windows.Forms.ToolStripButton tstNew_Font;
        private System.Windows.Forms.ToolStripButton tstRed;
        private System.Windows.Forms.ToolStripButton tstBold;
        private System.Windows.Forms.ToolStripButton tstItalic;
        private System.Windows.Forms.ToolStripButton tstCopy;
        private System.Windows.Forms.ToolStripButton tstPaste;
        private System.Windows.Forms.ToolStripButton tstOpen;
        private System.Windows.Forms.ToolStripButton tstSave;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.RichTextBox rtfBox;
        private System.Windows.Forms.DateTimePicker dtpMenu;
    }
}

