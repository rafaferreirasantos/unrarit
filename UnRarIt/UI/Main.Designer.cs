﻿using UnRarIt.UI;
namespace UnRarIt
{
    partial class Main
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
            if (disposing) {
  if (components != null) {
    components.Dispose();
  }
  if (overwritePromptMutex != null) {
    overwritePromptMutex.Dispose();
    overwritePromptMutex = null;
  }
  if (passwords != null) {
    passwords.Dispose();
    passwords = null;
  }
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
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Rar archives", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("7zip archives", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Zip archives", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Split archives", System.Windows.Forms.HorizontalAlignment.Left);
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.FilesCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.CtxOpenDirectory = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.CtxClearSelected = new System.Windows.Forms.ToolStripMenuItem();
      this.CtxClearList = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.CtxDeleteFiles = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.requeueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.requeueFailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.StateIcons = new System.Windows.Forms.ImageList(this.components);
      this.Statusbar = new System.Windows.Forms.StatusStrip();
      this.Progress = new System.Windows.Forms.ToolStripProgressBar();
      this.Details = new System.Windows.Forms.ToolStripStatusLabel();
      this.StatusPasswords = new System.Windows.Forms.ToolStripStatusLabel();
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.Exit = new System.Windows.Forms.ToolStripMenuItem();
      this.passwordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ImportPasswords = new System.Windows.Forms.ToolStripMenuItem();
      this.ExportPasswords = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.ClearAllPasswords = new System.Windows.Forms.ToolStripMenuItem();
      this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.Homepage = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.License = new System.Windows.Forms.ToolStripMenuItem();
      this.About = new System.Windows.Forms.ToolStripMenuItem();
      this.BrowseDestDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
      this.GroupDest = new System.Windows.Forms.GroupBox();
      this.DestsCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.clearDestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DecompressDirectory = new System.Windows.Forms.Button();
      this.Dests = new UnRarIt.UI.LRUComboBox();
      this.BrowseDest = new System.Windows.Forms.Button();
      this.AddPassword = new System.Windows.Forms.Button();
      this.UnrarIt = new System.Windows.Forms.Button();
      this.Files = new UnRarIt.UI.ListView();
      this.columnFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FilesCtx.SuspendLayout();
      this.Statusbar.SuspendLayout();
      this.MainMenu.SuspendLayout();
      this.GroupDest.SuspendLayout();
      this.DestsCtx.SuspendLayout();
      this.SuspendLayout();
      // 
      // FilesCtx
      // 
      this.FilesCtx.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.FilesCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxOpenDirectory,
            this.toolStripSeparator2,
            this.CtxClearSelected,
            this.CtxClearList,
            this.toolStripMenuItem4,
            this.CtxDeleteFiles,
            this.toolStripMenuItem3,
            this.requeueToolStripMenuItem,
            this.requeueFailedToolStripMenuItem});
      this.FilesCtx.Name = "FilesCtx";
      this.FilesCtx.Size = new System.Drawing.Size(190, 178);
      this.FilesCtx.Opening += new System.ComponentModel.CancelEventHandler(this.FilesCtx_Opening);
      // 
      // CtxOpenDirectory
      // 
      this.CtxOpenDirectory.Name = "CtxOpenDirectory";
      this.CtxOpenDirectory.Size = new System.Drawing.Size(189, 26);
      this.CtxOpenDirectory.Text = "Open Directory";
      this.CtxOpenDirectory.Click += new System.EventHandler(this.CtxOpenDirectory_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
      // 
      // CtxClearSelected
      // 
      this.CtxClearSelected.Image = global::UnRarIt.Properties.Resources.clearselected;
      this.CtxClearSelected.Name = "CtxClearSelected";
      this.CtxClearSelected.Size = new System.Drawing.Size(189, 26);
      this.CtxClearSelected.Text = "Clear selected";
      this.CtxClearSelected.Click += new System.EventHandler(this.CtxClearSelected_Click);
      // 
      // CtxClearList
      // 
      this.CtxClearList.Image = global::UnRarIt.Properties.Resources.clearlist;
      this.CtxClearList.Name = "CtxClearList";
      this.CtxClearList.Size = new System.Drawing.Size(189, 26);
      this.CtxClearList.Text = "Clear list";
      this.CtxClearList.Click += new System.EventHandler(this.CtxClearList_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 6);
      // 
      // CtxDeleteFiles
      // 
      this.CtxDeleteFiles.Image = global::UnRarIt.Properties.Resources.deletefiles;
      this.CtxDeleteFiles.Name = "CtxDeleteFiles";
      this.CtxDeleteFiles.Size = new System.Drawing.Size(189, 26);
      this.CtxDeleteFiles.Text = "Delete file(s)";
      this.CtxDeleteFiles.Click += new System.EventHandler(this.CtxDeleteFiles_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 6);
      // 
      // requeueToolStripMenuItem
      // 
      this.requeueToolStripMenuItem.Image = global::UnRarIt.Properties.Resources.run;
      this.requeueToolStripMenuItem.Name = "requeueToolStripMenuItem";
      this.requeueToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
      this.requeueToolStripMenuItem.Text = "Re-queue items";
      this.requeueToolStripMenuItem.Click += new System.EventHandler(this.requeueToolStripMenuItem_Click);
      // 
      // requeueFailedToolStripMenuItem
      // 
      this.requeueFailedToolStripMenuItem.Image = global::UnRarIt.Properties.Resources.reqerror;
      this.requeueFailedToolStripMenuItem.Name = "requeueFailedToolStripMenuItem";
      this.requeueFailedToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
      this.requeueFailedToolStripMenuItem.Text = "Re-queue Failed";
      this.requeueFailedToolStripMenuItem.Click += new System.EventHandler(this.requeueFailedToolStripMenuItem_Click);
      // 
      // StateIcons
      // 
      this.StateIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.StateIcons.ImageSize = new System.Drawing.Size(16, 16);
      this.StateIcons.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // Statusbar
      // 
      this.Statusbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.Statusbar.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.Statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progress,
            this.Details,
            this.StatusPasswords});
      this.Statusbar.Location = new System.Drawing.Point(0, 614);
      this.Statusbar.Name = "Statusbar";
      this.Statusbar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.Statusbar.Size = new System.Drawing.Size(1043, 25);
      this.Statusbar.TabIndex = 2;
      this.Statusbar.Text = "Status Strip";
      // 
      // Progress
      // 
      this.Progress.Name = "Progress";
      this.Progress.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
      this.Progress.Size = new System.Drawing.Size(667, 17);
      this.Progress.Visible = false;
      // 
      // Details
      // 
      this.Details.Name = "Details";
      this.Details.Size = new System.Drawing.Size(315, 19);
      this.Details.Spring = true;
      this.Details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // StatusPasswords
      // 
      this.StatusPasswords.Name = "StatusPasswords";
      this.StatusPasswords.Size = new System.Drawing.Size(0, 19);
      // 
      // MainMenu
      // 
      this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.passwordsToolStripMenuItem,
            this.HelpMenu});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
      this.MainMenu.Size = new System.Drawing.Size(1043, 28);
      this.MainMenu.TabIndex = 4;
      this.MainMenu.Text = "Main Menu";
      // 
      // FileMenu
      // 
      this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSettings,
            this.toolStripMenuItem2,
            this.Exit});
      this.FileMenu.Name = "FileMenu";
      this.FileMenu.Size = new System.Drawing.Size(46, 24);
      this.FileMenu.Text = "File";
      // 
      // OpenSettings
      // 
      this.OpenSettings.Image = global::UnRarIt.Properties.Resources.preferences;
      this.OpenSettings.Name = "OpenSettings";
      this.OpenSettings.Size = new System.Drawing.Size(168, 26);
      this.OpenSettings.Text = "Preferences";
      this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
      // 
      // Exit
      // 
      this.Exit.Image = global::UnRarIt.Properties.Resources.close;
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(168, 26);
      this.Exit.Text = "Exit";
      this.Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // passwordsToolStripMenuItem
      // 
      this.passwordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportPasswords,
            this.ExportPasswords,
            this.toolStripMenuItem1,
            this.ClearAllPasswords});
      this.passwordsToolStripMenuItem.Name = "passwordsToolStripMenuItem";
      this.passwordsToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
      this.passwordsToolStripMenuItem.Text = "Passwords";
      // 
      // ImportPasswords
      // 
      this.ImportPasswords.Image = global::UnRarIt.Properties.Resources.import;
      this.ImportPasswords.Name = "ImportPasswords";
      this.ImportPasswords.Size = new System.Drawing.Size(213, 26);
      this.ImportPasswords.Text = "Import";
      this.ImportPasswords.Click += new System.EventHandler(this.AddPassword_Click);
      // 
      // ExportPasswords
      // 
      this.ExportPasswords.Image = global::UnRarIt.Properties.Resources.export;
      this.ExportPasswords.Name = "ExportPasswords";
      this.ExportPasswords.Size = new System.Drawing.Size(213, 26);
      this.ExportPasswords.Text = "Export";
      this.ExportPasswords.Click += new System.EventHandler(this.ExportPasswords_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
      // 
      // ClearAllPasswords
      // 
      this.ClearAllPasswords.Image = global::UnRarIt.Properties.Resources.delete;
      this.ClearAllPasswords.Name = "ClearAllPasswords";
      this.ClearAllPasswords.Size = new System.Drawing.Size(213, 26);
      this.ClearAllPasswords.Text = "Clear all password";
      this.ClearAllPasswords.Click += new System.EventHandler(this.ClearAllPasswords_Click);
      // 
      // HelpMenu
      // 
      this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Homepage,
            this.toolStripSeparator1,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.License,
            this.About});
      this.HelpMenu.Name = "HelpMenu";
      this.HelpMenu.Size = new System.Drawing.Size(30, 24);
      this.HelpMenu.Text = "?";
      // 
      // Homepage
      // 
      this.Homepage.Image = global::UnRarIt.Properties.Resources.homepage;
      this.Homepage.Name = "Homepage";
      this.Homepage.Size = new System.Drawing.Size(211, 26);
      this.Homepage.Text = "Homepage";
      this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
      // 
      // checkForUpdatesToolStripMenuItem
      // 
      this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
      this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
      this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
      this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(208, 6);
      // 
      // License
      // 
      this.License.Image = global::UnRarIt.Properties.Resources.license;
      this.License.Name = "License";
      this.License.Size = new System.Drawing.Size(211, 26);
      this.License.Text = "License";
      this.License.Click += new System.EventHandler(this.License_Click);
      // 
      // About
      // 
      this.About.Name = "About";
      this.About.Size = new System.Drawing.Size(211, 26);
      this.About.Text = "About";
      this.About.Click += new System.EventHandler(this.About_Click);
      // 
      // ExportDialog
      // 
      this.ExportDialog.DefaultExt = "txt";
      this.ExportDialog.Filter = "Text Files|*.txt|All Files|*.*";
      // 
      // GroupDest
      // 
      this.GroupDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.GroupDest.ContextMenuStrip = this.DestsCtx;
      this.GroupDest.Controls.Add(this.DecompressDirectory);
      this.GroupDest.Controls.Add(this.Dests);
      this.GroupDest.Controls.Add(this.BrowseDest);
      this.GroupDest.Location = new System.Drawing.Point(505, 543);
      this.GroupDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.GroupDest.Name = "GroupDest";
      this.GroupDest.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.GroupDest.Size = new System.Drawing.Size(521, 65);
      this.GroupDest.TabIndex = 8;
      this.GroupDest.TabStop = false;
      this.GroupDest.Text = "Destination";
      // 
      // DestsCtx
      // 
      this.DestsCtx.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.DestsCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDestsToolStripMenuItem});
      this.DestsCtx.Name = "DestsCtx";
      this.DestsCtx.Size = new System.Drawing.Size(113, 28);
      // 
      // clearDestsToolStripMenuItem
      // 
      this.clearDestsToolStripMenuItem.Name = "clearDestsToolStripMenuItem";
      this.clearDestsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.clearDestsToolStripMenuItem.Text = "Clear";
      this.clearDestsToolStripMenuItem.Click += new System.EventHandler(this.clearDestsToolStripMenuItem_Click);
      // 
      // DecompressDirectory
      // 
      this.DecompressDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.DecompressDirectory.Location = new System.Drawing.Point(483, 23);
      this.DecompressDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DecompressDirectory.Name = "DecompressDirectory";
      this.DecompressDirectory.Size = new System.Drawing.Size(31, 25);
      this.DecompressDirectory.TabIndex = 10;
      this.DecompressDirectory.Text = "Decompress Directory";
      this.DecompressDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.DecompressDirectory.UseVisualStyleBackColor = true;
      this.DecompressDirectory.Click += new System.EventHandler(this.DecompressDirectory_Click);
      // 
      // Dests
      // 
      this.Dests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Dests.FormattingEnabled = true;
      this.Dests.Location = new System.Drawing.Point(8, 23);
      this.Dests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Dests.Name = "Dests";
      this.Dests.Size = new System.Drawing.Size(425, 24);
      this.Dests.TabIndex = 4;
      // 
      // BrowseDest
      // 
      this.BrowseDest.Location = new System.Drawing.Point(443, 23);
      this.BrowseDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.BrowseDest.Name = "BrowseDest";
      this.BrowseDest.Size = new System.Drawing.Size(32, 25);
      this.BrowseDest.TabIndex = 3;
      this.BrowseDest.Text = "...";
      this.BrowseDest.UseVisualStyleBackColor = true;
      this.BrowseDest.Click += new System.EventHandler(this.BrowseDest_Click);
      // 
      // AddPassword
      // 
      this.AddPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.AddPassword.Image = global::UnRarIt.Properties.Resources.addpassword;
      this.AddPassword.Location = new System.Drawing.Point(184, 543);
      this.AddPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.AddPassword.Name = "AddPassword";
      this.AddPassword.Size = new System.Drawing.Size(160, 42);
      this.AddPassword.TabIndex = 2;
      this.AddPassword.Text = "Add password";
      this.AddPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.AddPassword.UseVisualStyleBackColor = true;
      this.AddPassword.Click += new System.EventHandler(this.AddPassword_Click);
      // 
      // UnrarIt
      // 
      this.UnrarIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.UnrarIt.Image = global::UnRarIt.Properties.Resources.extract;
      this.UnrarIt.Location = new System.Drawing.Point(16, 543);
      this.UnrarIt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.UnrarIt.Name = "UnrarIt";
      this.UnrarIt.Size = new System.Drawing.Size(160, 42);
      this.UnrarIt.TabIndex = 1;
      this.UnrarIt.Text = "Extract files";
      this.UnrarIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.UnrarIt.UseVisualStyleBackColor = true;
      this.UnrarIt.Click += new System.EventHandler(this.UnRarIt_Click);
      // 
      // Files
      // 
      this.Files.AllowDrop = true;
      this.Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFile,
            this.columnSize,
            this.columnStatus});
      this.Files.ContextMenuStrip = this.FilesCtx;
      listViewGroup1.Header = "Rar archives";
      listViewGroup1.Name = "GroupRar";
      listViewGroup2.Header = "7zip archives";
      listViewGroup2.Name = "GroupSevenZip";
      listViewGroup3.Header = "Zip archives";
      listViewGroup3.Name = "GroupZip";
      listViewGroup4.Header = "Split archives";
      listViewGroup4.Name = "GroupSplit";
      this.Files.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
      this.Files.HideSelection = false;
      this.Files.Location = new System.Drawing.Point(16, 33);
      this.Files.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Files.Name = "Files";
      this.Files.Size = new System.Drawing.Size(1009, 501);
      this.Files.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.Files.StateImageList = this.StateIcons;
      this.Files.TabIndex = 0;
      this.Files.UseCompatibleStateImageBehavior = false;
      this.Files.View = System.Windows.Forms.View.Details;
      this.Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.Files_DragDrop);
      this.Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.Files_DragEnter);
      this.Files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Files_KeyDown);
      // 
      // columnFile
      // 
      this.columnFile.Text = "Archive file";
      this.columnFile.Width = 200;
      // 
      // columnSize
      // 
      this.columnSize.Text = "Size";
      this.columnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnSize.Width = 100;
      // 
      // columnStatus
      // 
      this.columnStatus.Text = "Status";
      this.columnStatus.Width = 400;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1043, 639);
      this.Controls.Add(this.GroupDest);
      this.Controls.Add(this.Statusbar);
      this.Controls.Add(this.MainMenu);
      this.Controls.Add(this.Files);
      this.Controls.Add(this.AddPassword);
      this.Controls.Add(this.UnrarIt);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.MainMenu;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "UnRarIt.Net";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
      this.Shown += new System.EventHandler(this.Main_Shown);
      this.FilesCtx.ResumeLayout(false);
      this.Statusbar.ResumeLayout(false);
      this.Statusbar.PerformLayout();
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.GroupDest.ResumeLayout(false);
      this.DestsCtx.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private UnRarIt.UI.ListView Files;
        private System.Windows.Forms.Button UnrarIt;
        private System.Windows.Forms.ColumnHeader columnFile;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.StatusStrip Statusbar;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.ToolStripStatusLabel Details;
        private System.Windows.Forms.ToolStripStatusLabel StatusPasswords;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button AddPassword;
        private System.Windows.Forms.FolderBrowserDialog BrowseDestDialog;
        private System.Windows.Forms.ToolStripMenuItem Homepage;
        private System.Windows.Forms.ImageList StateIcons;
        private System.Windows.Forms.ToolStripMenuItem OpenSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem passwordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportPasswords;
        private System.Windows.Forms.ToolStripMenuItem ExportPasswords;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClearAllPasswords;
        private System.Windows.Forms.GroupBox GroupDest;
        private System.Windows.Forms.Button BrowseDest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem License;
        private System.Windows.Forms.ContextMenuStrip FilesCtx;
        private System.Windows.Forms.ToolStripMenuItem CtxClearSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxClearList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem requeueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CtxDeleteFiles;
        private System.Windows.Forms.ToolStripMenuItem requeueFailedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtxOpenDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private LRUComboBox Dests;
        private System.Windows.Forms.ContextMenuStrip DestsCtx;
        private System.Windows.Forms.ToolStripMenuItem clearDestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Button DecompressDirectory;
    }
}

