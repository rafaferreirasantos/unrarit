namespace UnRarIt
{
    partial class SettingsForm
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
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonOK = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.RenameDirectory = new System.Windows.Forms.RadioButton();
      this.Rename = new System.Windows.Forms.RadioButton();
      this.Ask = new System.Windows.Forms.RadioButton();
      this.Overwrite = new System.Windows.Forms.RadioButton();
      this.Skip = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.Nesting = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.OwnDirectoryLimit = new System.Windows.Forms.NumericUpDown();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.SuccessRemove = new System.Windows.Forms.RadioButton();
      this.SuccessRename = new System.Windows.Forms.RadioButton();
      this.SuccesNothing = new System.Windows.Forms.RadioButton();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.RemoveAll = new System.Windows.Forms.RadioButton();
      this.RemoveDone = new System.Windows.Forms.RadioButton();
      this.RemoveNone = new System.Windows.Forms.RadioButton();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.LowPriority = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Threads = new System.Windows.Forms.NumericUpDown();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.btnPassFileSearch = new System.Windows.Forms.Button();
      this.lblPassFile = new System.Windows.Forms.Label();
      this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.btnDefaultSourceFolderSearch = new System.Windows.Forms.Button();
      this.lblDefaultSourceFolder = new System.Windows.Forms.Label();
      this.BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.rbtnPasswordExportSimple = new System.Windows.Forms.RadioButton();
      this.rbtnPasswordExportDetailed = new System.Windows.Forms.RadioButton();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.OwnDirectoryLimit)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Threads)).BeginInit();
      this.groupBox6.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(343, 416);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 0;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // buttonOK
      // 
      this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOK.Location = new System.Drawing.Point(262, 416);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 1;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.RenameDirectory);
      this.groupBox1.Controls.Add(this.Rename);
      this.groupBox1.Controls.Add(this.Ask);
      this.groupBox1.Controls.Add(this.Overwrite);
      this.groupBox1.Controls.Add(this.Skip);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 119);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "When a file exists...";
      // 
      // RenameDirectory
      // 
      this.RenameDirectory.AutoSize = true;
      this.RenameDirectory.Location = new System.Drawing.Point(88, 65);
      this.RenameDirectory.Name = "RenameDirectory";
      this.RenameDirectory.Size = new System.Drawing.Size(67, 17);
      this.RenameDirectory.TabIndex = 5;
      this.RenameDirectory.TabStop = true;
      this.RenameDirectory.Text = "Directory";
      this.RenameDirectory.UseVisualStyleBackColor = true;
      // 
      // Rename
      // 
      this.Rename.AutoSize = true;
      this.Rename.Location = new System.Drawing.Point(17, 65);
      this.Rename.Name = "Rename";
      this.Rename.Size = new System.Drawing.Size(65, 17);
      this.Rename.TabIndex = 4;
      this.Rename.TabStop = true;
      this.Rename.Text = "Rename";
      this.Rename.UseVisualStyleBackColor = true;
      // 
      // Ask
      // 
      this.Ask.AutoSize = true;
      this.Ask.Location = new System.Drawing.Point(17, 88);
      this.Ask.Name = "Ask";
      this.Ask.Size = new System.Drawing.Size(43, 17);
      this.Ask.TabIndex = 3;
      this.Ask.TabStop = true;
      this.Ask.Text = "Ask";
      this.Ask.UseVisualStyleBackColor = true;
      // 
      // Overwrite
      // 
      this.Overwrite.AutoSize = true;
      this.Overwrite.Location = new System.Drawing.Point(17, 42);
      this.Overwrite.Name = "Overwrite";
      this.Overwrite.Size = new System.Drawing.Size(70, 17);
      this.Overwrite.TabIndex = 2;
      this.Overwrite.TabStop = true;
      this.Overwrite.Text = "Overwrite";
      this.Overwrite.UseVisualStyleBackColor = true;
      // 
      // Skip
      // 
      this.Skip.AutoSize = true;
      this.Skip.Location = new System.Drawing.Point(17, 19);
      this.Skip.Name = "Skip";
      this.Skip.Size = new System.Drawing.Size(46, 17);
      this.Skip.TabIndex = 1;
      this.Skip.TabStop = true;
      this.Skip.Text = "Skip";
      this.Skip.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.Nesting);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.OwnDirectoryLimit);
      this.groupBox2.Location = new System.Drawing.Point(12, 137);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(200, 110);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Directories and archives...";
      // 
      // Nesting
      // 
      this.Nesting.AutoSize = true;
      this.Nesting.Location = new System.Drawing.Point(17, 83);
      this.Nesting.Name = "Nesting";
      this.Nesting.Size = new System.Drawing.Size(137, 17);
      this.Nesting.TabIndex = 7;
      this.Nesting.Text = "Extract nested archives";
      this.Nesting.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(14, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(135, 53);
      this.label1.TabIndex = 1;
      this.label1.Text = "Create a directory when more than this files aren\'t contained within a directory";
      // 
      // OwnDirectoryLimit
      // 
      this.OwnDirectoryLimit.Location = new System.Drawing.Point(155, 23);
      this.OwnDirectoryLimit.Name = "OwnDirectoryLimit";
      this.OwnDirectoryLimit.Size = new System.Drawing.Size(39, 20);
      this.OwnDirectoryLimit.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.SuccessRemove);
      this.groupBox3.Controls.Add(this.SuccessRename);
      this.groupBox3.Controls.Add(this.SuccesNothing);
      this.groupBox3.Location = new System.Drawing.Point(218, 12);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(200, 119);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Processed archives will be...";
      // 
      // SuccessRemove
      // 
      this.SuccessRemove.AutoSize = true;
      this.SuccessRemove.Location = new System.Drawing.Point(17, 65);
      this.SuccessRemove.Name = "SuccessRemove";
      this.SuccessRemove.Size = new System.Drawing.Size(60, 17);
      this.SuccessRemove.TabIndex = 3;
      this.SuccessRemove.TabStop = true;
      this.SuccessRemove.Text = "deleted";
      this.SuccessRemove.UseVisualStyleBackColor = true;
      // 
      // SuccessRename
      // 
      this.SuccessRename.AutoSize = true;
      this.SuccessRename.Location = new System.Drawing.Point(17, 42);
      this.SuccessRename.Name = "SuccessRename";
      this.SuccessRename.Size = new System.Drawing.Size(66, 17);
      this.SuccessRename.TabIndex = 2;
      this.SuccessRename.TabStop = true;
      this.SuccessRename.Text = "renamed";
      this.SuccessRename.UseVisualStyleBackColor = true;
      // 
      // SuccesNothing
      // 
      this.SuccesNothing.AutoSize = true;
      this.SuccesNothing.Location = new System.Drawing.Point(17, 19);
      this.SuccesNothing.Name = "SuccesNothing";
      this.SuccesNothing.Size = new System.Drawing.Size(68, 17);
      this.SuccesNothing.TabIndex = 1;
      this.SuccesNothing.TabStop = true;
      this.SuccesNothing.Text = "left alone";
      this.SuccesNothing.UseVisualStyleBackColor = true;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.RemoveAll);
      this.groupBox4.Controls.Add(this.RemoveDone);
      this.groupBox4.Controls.Add(this.RemoveNone);
      this.groupBox4.Location = new System.Drawing.Point(218, 137);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(200, 100);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Remove on completion...";
      // 
      // RemoveAll
      // 
      this.RemoveAll.AutoSize = true;
      this.RemoveAll.Location = new System.Drawing.Point(17, 65);
      this.RemoveAll.Name = "RemoveAll";
      this.RemoveAll.Size = new System.Drawing.Size(64, 17);
      this.RemoveAll.TabIndex = 6;
      this.RemoveAll.TabStop = true;
      this.RemoveAll.Text = "Clear list";
      this.RemoveAll.UseVisualStyleBackColor = true;
      // 
      // RemoveDone
      // 
      this.RemoveDone.AutoSize = true;
      this.RemoveDone.Location = new System.Drawing.Point(17, 42);
      this.RemoveDone.Name = "RemoveDone";
      this.RemoveDone.Size = new System.Drawing.Size(113, 17);
      this.RemoveDone.TabIndex = 5;
      this.RemoveDone.TabStop = true;
      this.RemoveDone.Text = "Extracted archives";
      this.RemoveDone.UseVisualStyleBackColor = true;
      // 
      // RemoveNone
      // 
      this.RemoveNone.AutoSize = true;
      this.RemoveNone.Location = new System.Drawing.Point(17, 19);
      this.RemoveNone.Name = "RemoveNone";
      this.RemoveNone.Size = new System.Drawing.Size(91, 17);
      this.RemoveNone.TabIndex = 4;
      this.RemoveNone.TabStop = true;
      this.RemoveNone.Text = "No items at all";
      this.RemoveNone.UseVisualStyleBackColor = true;
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.LowPriority);
      this.groupBox5.Controls.Add(this.label2);
      this.groupBox5.Controls.Add(this.Threads);
      this.groupBox5.Location = new System.Drawing.Point(12, 253);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(199, 104);
      this.groupBox5.TabIndex = 9;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Performance";
      // 
      // LowPriority
      // 
      this.LowPriority.AutoSize = true;
      this.LowPriority.Location = new System.Drawing.Point(17, 46);
      this.LowPriority.Name = "LowPriority";
      this.LowPriority.Size = new System.Drawing.Size(99, 17);
      this.LowPriority.TabIndex = 12;
      this.LowPriority.Text = "Low I/O Priority";
      this.LowPriority.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 21);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(98, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "Number of Threads";
      // 
      // Threads
      // 
      this.Threads.Location = new System.Drawing.Point(154, 19);
      this.Threads.Name = "Threads";
      this.Threads.Size = new System.Drawing.Size(39, 20);
      this.Threads.TabIndex = 9;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.btnPassFileSearch);
      this.groupBox6.Controls.Add(this.lblPassFile);
      this.groupBox6.Location = new System.Drawing.Point(218, 243);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(200, 54);
      this.groupBox6.TabIndex = 7;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Pass File:";
      // 
      // btnPassFileSearch
      // 
      this.btnPassFileSearch.Location = new System.Drawing.Point(139, 27);
      this.btnPassFileSearch.Margin = new System.Windows.Forms.Padding(2);
      this.btnPassFileSearch.Name = "btnPassFileSearch";
      this.btnPassFileSearch.Size = new System.Drawing.Size(56, 19);
      this.btnPassFileSearch.TabIndex = 1;
      this.btnPassFileSearch.Text = "Search";
      this.btnPassFileSearch.UseVisualStyleBackColor = true;
      this.btnPassFileSearch.Click += new System.EventHandler(this.btnPassFileSearch_Click);
      // 
      // lblPassFile
      // 
      this.lblPassFile.AutoSize = true;
      this.lblPassFile.Location = new System.Drawing.Point(14, 28);
      this.lblPassFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblPassFile.Name = "lblPassFile";
      this.lblPassFile.Size = new System.Drawing.Size(80, 13);
      this.lblPassFile.TabIndex = 0;
      this.lblPassFile.Text = "No file selected";
      // 
      // OpenDialog
      // 
      this.OpenDialog.Filter = "Text Files|*.txt|All Files|*.*";
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.btnDefaultSourceFolderSearch);
      this.groupBox7.Controls.Add(this.lblDefaultSourceFolder);
      this.groupBox7.Location = new System.Drawing.Point(218, 303);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(200, 54);
      this.groupBox7.TabIndex = 8;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Default Source Folder:";
      // 
      // btnDefaultSourceFolderSearch
      // 
      this.btnDefaultSourceFolderSearch.Location = new System.Drawing.Point(139, 27);
      this.btnDefaultSourceFolderSearch.Margin = new System.Windows.Forms.Padding(2);
      this.btnDefaultSourceFolderSearch.Name = "btnDefaultSourceFolderSearch";
      this.btnDefaultSourceFolderSearch.Size = new System.Drawing.Size(56, 19);
      this.btnDefaultSourceFolderSearch.TabIndex = 1;
      this.btnDefaultSourceFolderSearch.Text = "Search";
      this.btnDefaultSourceFolderSearch.UseVisualStyleBackColor = true;
      this.btnDefaultSourceFolderSearch.Click += new System.EventHandler(this.btnDefaultSourceFolderSearch_Click);
      // 
      // lblDefaultSourceFolder
      // 
      this.lblDefaultSourceFolder.AutoSize = true;
      this.lblDefaultSourceFolder.Location = new System.Drawing.Point(14, 28);
      this.lblDefaultSourceFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblDefaultSourceFolder.Name = "lblDefaultSourceFolder";
      this.lblDefaultSourceFolder.Size = new System.Drawing.Size(80, 13);
      this.lblDefaultSourceFolder.TabIndex = 0;
      this.lblDefaultSourceFolder.Text = "No file selected";
      // 
      // BrowserDialog
      // 
      this.BrowserDialog.SelectedPath = "v";
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.rbtnPasswordExportDetailed);
      this.groupBox8.Controls.Add(this.rbtnPasswordExportSimple);
      this.groupBox8.Location = new System.Drawing.Point(12, 363);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(200, 76);
      this.groupBox8.TabIndex = 6;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Password Export:";
      // 
      // rbtnPasswordExportSimple
      // 
      this.rbtnPasswordExportSimple.AutoSize = true;
      this.rbtnPasswordExportSimple.Location = new System.Drawing.Point(17, 19);
      this.rbtnPasswordExportSimple.Name = "rbtnPasswordExportSimple";
      this.rbtnPasswordExportSimple.Size = new System.Drawing.Size(56, 17);
      this.rbtnPasswordExportSimple.TabIndex = 6;
      this.rbtnPasswordExportSimple.TabStop = true;
      this.rbtnPasswordExportSimple.Text = "Simple";
      this.rbtnPasswordExportSimple.UseVisualStyleBackColor = true;
      // 
      // rbtnPasswordExportDetailed
      // 
      this.rbtnPasswordExportDetailed.AutoSize = true;
      this.rbtnPasswordExportDetailed.Location = new System.Drawing.Point(17, 42);
      this.rbtnPasswordExportDetailed.Name = "rbtnPasswordExportDetailed";
      this.rbtnPasswordExportDetailed.Size = new System.Drawing.Size(64, 17);
      this.rbtnPasswordExportDetailed.TabIndex = 7;
      this.rbtnPasswordExportDetailed.TabStop = true;
      this.rbtnPasswordExportDetailed.Text = "Detailed";
      this.rbtnPasswordExportDetailed.UseVisualStyleBackColor = true;
      // 
      // SettingsForm
      // 
      this.AcceptButton = this.buttonOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(430, 447);
      this.Controls.Add(this.groupBox8);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.buttonOK);
      this.Controls.Add(this.buttonCancel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SettingsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Preferences";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.OwnDirectoryLimit)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Threads)).EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ask;
        private System.Windows.Forms.RadioButton Overwrite;
        private System.Windows.Forms.RadioButton Skip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OwnDirectoryLimit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton SuccessRemove;
        private System.Windows.Forms.RadioButton SuccessRename;
        private System.Windows.Forms.RadioButton SuccesNothing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RemoveAll;
        private System.Windows.Forms.RadioButton RemoveDone;
        private System.Windows.Forms.RadioButton RemoveNone;
        private System.Windows.Forms.RadioButton Rename;
        private System.Windows.Forms.RadioButton RenameDirectory;
        private System.Windows.Forms.CheckBox Nesting;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Threads;
        private System.Windows.Forms.CheckBox LowPriority;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Label lblPassFile;
    private System.Windows.Forms.OpenFileDialog OpenDialog;
    private System.Windows.Forms.Button btnPassFileSearch;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Button btnDefaultSourceFolderSearch;
    private System.Windows.Forms.Label lblDefaultSourceFolder;
    private System.Windows.Forms.FolderBrowserDialog BrowserDialog;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.RadioButton rbtnPasswordExportDetailed;
    private System.Windows.Forms.RadioButton rbtnPasswordExportSimple;
  }
}