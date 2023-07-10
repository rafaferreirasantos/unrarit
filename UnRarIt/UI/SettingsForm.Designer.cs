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
      this.lblPassFile = new System.Windows.Forms.Label();
      this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
      this.btnPassFileSearch = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.OwnDirectoryLimit)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Threads)).BeginInit();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(457, 375);
      this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(100, 28);
      this.buttonCancel.TabIndex = 0;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // buttonOK
      // 
      this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOK.Location = new System.Drawing.Point(349, 375);
      this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(100, 28);
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
      this.groupBox1.Location = new System.Drawing.Point(16, 15);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(267, 146);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "When a file exists...";
      // 
      // RenameDirectory
      // 
      this.RenameDirectory.AutoSize = true;
      this.RenameDirectory.Location = new System.Drawing.Point(117, 80);
      this.RenameDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.RenameDirectory.Name = "RenameDirectory";
      this.RenameDirectory.Size = new System.Drawing.Size(82, 20);
      this.RenameDirectory.TabIndex = 5;
      this.RenameDirectory.TabStop = true;
      this.RenameDirectory.Text = "Directory";
      this.RenameDirectory.UseVisualStyleBackColor = true;
      // 
      // Rename
      // 
      this.Rename.AutoSize = true;
      this.Rename.Location = new System.Drawing.Point(23, 80);
      this.Rename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Rename.Name = "Rename";
      this.Rename.Size = new System.Drawing.Size(80, 20);
      this.Rename.TabIndex = 4;
      this.Rename.TabStop = true;
      this.Rename.Text = "Rename";
      this.Rename.UseVisualStyleBackColor = true;
      // 
      // Ask
      // 
      this.Ask.AutoSize = true;
      this.Ask.Location = new System.Drawing.Point(23, 108);
      this.Ask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Ask.Name = "Ask";
      this.Ask.Size = new System.Drawing.Size(51, 20);
      this.Ask.TabIndex = 3;
      this.Ask.TabStop = true;
      this.Ask.Text = "Ask";
      this.Ask.UseVisualStyleBackColor = true;
      // 
      // Overwrite
      // 
      this.Overwrite.AutoSize = true;
      this.Overwrite.Location = new System.Drawing.Point(23, 52);
      this.Overwrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Overwrite.Name = "Overwrite";
      this.Overwrite.Size = new System.Drawing.Size(84, 20);
      this.Overwrite.TabIndex = 2;
      this.Overwrite.TabStop = true;
      this.Overwrite.Text = "Overwrite";
      this.Overwrite.UseVisualStyleBackColor = true;
      // 
      // Skip
      // 
      this.Skip.AutoSize = true;
      this.Skip.Location = new System.Drawing.Point(23, 23);
      this.Skip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Skip.Name = "Skip";
      this.Skip.Size = new System.Drawing.Size(55, 20);
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
      this.groupBox2.Location = new System.Drawing.Point(16, 169);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Size = new System.Drawing.Size(267, 135);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Directories and archives...";
      // 
      // Nesting
      // 
      this.Nesting.AutoSize = true;
      this.Nesting.Location = new System.Drawing.Point(23, 102);
      this.Nesting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Nesting.Name = "Nesting";
      this.Nesting.Size = new System.Drawing.Size(167, 20);
      this.Nesting.TabIndex = 7;
      this.Nesting.Text = "Extract nested archives";
      this.Nesting.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(19, 28);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(180, 65);
      this.label1.TabIndex = 1;
      this.label1.Text = "Create a directory when more than this files aren\'t contained within a directory";
      // 
      // OwnDirectoryLimit
      // 
      this.OwnDirectoryLimit.Location = new System.Drawing.Point(207, 28);
      this.OwnDirectoryLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.OwnDirectoryLimit.Name = "OwnDirectoryLimit";
      this.OwnDirectoryLimit.Size = new System.Drawing.Size(52, 22);
      this.OwnDirectoryLimit.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.SuccessRemove);
      this.groupBox3.Controls.Add(this.SuccessRename);
      this.groupBox3.Controls.Add(this.SuccesNothing);
      this.groupBox3.Location = new System.Drawing.Point(291, 15);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Size = new System.Drawing.Size(267, 146);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Processed archives will be...";
      // 
      // SuccessRemove
      // 
      this.SuccessRemove.AutoSize = true;
      this.SuccessRemove.Location = new System.Drawing.Point(23, 80);
      this.SuccessRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SuccessRemove.Name = "SuccessRemove";
      this.SuccessRemove.Size = new System.Drawing.Size(74, 20);
      this.SuccessRemove.TabIndex = 3;
      this.SuccessRemove.TabStop = true;
      this.SuccessRemove.Text = "deleted";
      this.SuccessRemove.UseVisualStyleBackColor = true;
      // 
      // SuccessRename
      // 
      this.SuccessRename.AutoSize = true;
      this.SuccessRename.Location = new System.Drawing.Point(23, 52);
      this.SuccessRename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SuccessRename.Name = "SuccessRename";
      this.SuccessRename.Size = new System.Drawing.Size(82, 20);
      this.SuccessRename.TabIndex = 2;
      this.SuccessRename.TabStop = true;
      this.SuccessRename.Text = "renamed";
      this.SuccessRename.UseVisualStyleBackColor = true;
      // 
      // SuccesNothing
      // 
      this.SuccesNothing.AutoSize = true;
      this.SuccesNothing.Location = new System.Drawing.Point(23, 23);
      this.SuccesNothing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SuccesNothing.Name = "SuccesNothing";
      this.SuccesNothing.Size = new System.Drawing.Size(82, 20);
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
      this.groupBox4.Location = new System.Drawing.Point(291, 169);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox4.Size = new System.Drawing.Size(267, 123);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Remove on completion...";
      // 
      // RemoveAll
      // 
      this.RemoveAll.AutoSize = true;
      this.RemoveAll.Location = new System.Drawing.Point(23, 80);
      this.RemoveAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.RemoveAll.Name = "RemoveAll";
      this.RemoveAll.Size = new System.Drawing.Size(79, 20);
      this.RemoveAll.TabIndex = 6;
      this.RemoveAll.TabStop = true;
      this.RemoveAll.Text = "Clear list";
      this.RemoveAll.UseVisualStyleBackColor = true;
      // 
      // RemoveDone
      // 
      this.RemoveDone.AutoSize = true;
      this.RemoveDone.Location = new System.Drawing.Point(23, 52);
      this.RemoveDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.RemoveDone.Name = "RemoveDone";
      this.RemoveDone.Size = new System.Drawing.Size(138, 20);
      this.RemoveDone.TabIndex = 5;
      this.RemoveDone.TabStop = true;
      this.RemoveDone.Text = "Extracted archives";
      this.RemoveDone.UseVisualStyleBackColor = true;
      // 
      // RemoveNone
      // 
      this.RemoveNone.AutoSize = true;
      this.RemoveNone.Location = new System.Drawing.Point(23, 23);
      this.RemoveNone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.RemoveNone.Name = "RemoveNone";
      this.RemoveNone.Size = new System.Drawing.Size(112, 20);
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
      this.groupBox5.Location = new System.Drawing.Point(16, 311);
      this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox5.Size = new System.Drawing.Size(265, 94);
      this.groupBox5.TabIndex = 9;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Performance";
      // 
      // LowPriority
      // 
      this.LowPriority.AutoSize = true;
      this.LowPriority.Location = new System.Drawing.Point(23, 57);
      this.LowPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.LowPriority.Name = "LowPriority";
      this.LowPriority.Size = new System.Drawing.Size(117, 20);
      this.LowPriority.TabIndex = 12;
      this.LowPriority.Text = "Low I/O Priority";
      this.LowPriority.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 26);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 16);
      this.label2.TabIndex = 10;
      this.label2.Text = "Number of Threads";
      // 
      // Threads
      // 
      this.Threads.Location = new System.Drawing.Point(205, 23);
      this.Threads.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Threads.Name = "Threads";
      this.Threads.Size = new System.Drawing.Size(52, 22);
      this.Threads.TabIndex = 9;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.btnPassFileSearch);
      this.groupBox6.Controls.Add(this.lblPassFile);
      this.groupBox6.Location = new System.Drawing.Point(293, 300);
      this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox6.Size = new System.Drawing.Size(267, 67);
      this.groupBox6.TabIndex = 7;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Pass File...";
      // 
      // lblPassFile
      // 
      this.lblPassFile.AutoSize = true;
      this.lblPassFile.Location = new System.Drawing.Point(18, 34);
      this.lblPassFile.Name = "lblPassFile";
      this.lblPassFile.Size = new System.Drawing.Size(100, 16);
      this.lblPassFile.TabIndex = 0;
      this.lblPassFile.Text = "No file selected";
      // 
      // OpenDialog
      // 
      this.OpenDialog.Filter = "Text Files|*.txt|All Files|*.*";
      // 
      // btnPassFileSearch
      // 
      this.btnPassFileSearch.Location = new System.Drawing.Point(185, 33);
      this.btnPassFileSearch.Name = "btnPassFileSearch";
      this.btnPassFileSearch.Size = new System.Drawing.Size(75, 23);
      this.btnPassFileSearch.TabIndex = 1;
      this.btnPassFileSearch.Text = "Search";
      this.btnPassFileSearch.UseVisualStyleBackColor = true;
      this.btnPassFileSearch.Click += new System.EventHandler(this.btnPassFileSearch_Click);
      // 
      // SettingsForm
      // 
      this.AcceptButton = this.buttonOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(573, 414);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.buttonOK);
      this.Controls.Add(this.buttonCancel);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
  }
}