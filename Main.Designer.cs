namespace PnPFile_Prerunner
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPnPCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEditqueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadEditqueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPnPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetFootprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByFootprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByCommentOrValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openGithubRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVFile = new System.Windows.Forms.OpenFileDialog();
            this.partTable = new System.Windows.Forms.DataGridView();
            this.lblLoadedparts = new System.Windows.Forms.Label();
            this.saveCSVFile = new System.Windows.Forms.SaveFileDialog();
            this.mergeValueIntoNameOnExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferValueOverDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.offsetToolStripMenuItem,
            this.openGithubRepoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1436, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPnPCSVToolStripMenuItem,
            this.saveEditqueueToolStripMenuItem,
            this.loadEditqueueToolStripMenuItem,
            this.exportPnPFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // openPnPCSVToolStripMenuItem
            // 
            this.openPnPCSVToolStripMenuItem.Name = "openPnPCSVToolStripMenuItem";
            this.openPnPCSVToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openPnPCSVToolStripMenuItem.Text = "Open PnP CSV";
            this.openPnPCSVToolStripMenuItem.Click += new System.EventHandler(this.openPnPCSVToolStripMenuItem_Click);
            // 
            // saveEditqueueToolStripMenuItem
            // 
            this.saveEditqueueToolStripMenuItem.Enabled = false;
            this.saveEditqueueToolStripMenuItem.Name = "saveEditqueueToolStripMenuItem";
            this.saveEditqueueToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveEditqueueToolStripMenuItem.Text = "Save edit-queue";
            // 
            // loadEditqueueToolStripMenuItem
            // 
            this.loadEditqueueToolStripMenuItem.Enabled = false;
            this.loadEditqueueToolStripMenuItem.Name = "loadEditqueueToolStripMenuItem";
            this.loadEditqueueToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadEditqueueToolStripMenuItem.Text = "Load edit-queue";
            // 
            // exportPnPFileToolStripMenuItem
            // 
            this.exportPnPFileToolStripMenuItem.Name = "exportPnPFileToolStripMenuItem";
            this.exportPnPFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exportPnPFileToolStripMenuItem.Text = "Export PnP-File";
            this.exportPnPFileToolStripMenuItem.Click += new System.EventHandler(this.exportPnPFileToolStripMenuItem_Click);
            // 
            // offsetToolStripMenuItem
            // 
            this.offsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offsetPartToolStripMenuItem,
            this.offsetFootprintToolStripMenuItem,
            this.deleteByFootprintToolStripMenuItem,
            this.deleteByCommentOrValueToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportPreferencesToolStripMenuItem,
            this.mergeValueIntoNameOnExportToolStripMenuItem,
            this.preferValueOverDescriptionToolStripMenuItem});
            this.offsetToolStripMenuItem.Name = "offsetToolStripMenuItem";
            this.offsetToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.offsetToolStripMenuItem.Text = "Edit...";
            // 
            // offsetPartToolStripMenuItem
            // 
            this.offsetPartToolStripMenuItem.Name = "offsetPartToolStripMenuItem";
            this.offsetPartToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.offsetPartToolStripMenuItem.Text = "Apply position offset by Part";
            this.offsetPartToolStripMenuItem.Click += new System.EventHandler(this.offsetPartToolStripMenuItem_Click);
            // 
            // offsetFootprintToolStripMenuItem
            // 
            this.offsetFootprintToolStripMenuItem.Name = "offsetFootprintToolStripMenuItem";
            this.offsetFootprintToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.offsetFootprintToolStripMenuItem.Text = "Apply position offset by Footprint";
            this.offsetFootprintToolStripMenuItem.Click += new System.EventHandler(this.offsetFootprintToolStripMenuItem_Click);
            // 
            // deleteByFootprintToolStripMenuItem
            // 
            this.deleteByFootprintToolStripMenuItem.Name = "deleteByFootprintToolStripMenuItem";
            this.deleteByFootprintToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.deleteByFootprintToolStripMenuItem.Text = "Delete by Footprint";
            this.deleteByFootprintToolStripMenuItem.ToolTipText = "Usually used to remove through-hole footprints";
            this.deleteByFootprintToolStripMenuItem.Click += new System.EventHandler(this.deleteByFootprintToolStripMenuItem_Click);
            // 
            // deleteByCommentOrValueToolStripMenuItem
            // 
            this.deleteByCommentOrValueToolStripMenuItem.Name = "deleteByCommentOrValueToolStripMenuItem";
            this.deleteByCommentOrValueToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.deleteByCommentOrValueToolStripMenuItem.Text = "Delete by Comment or Value";
            this.deleteByCommentOrValueToolStripMenuItem.ToolTipText = "usually used to delete all parts marked as \"do not populate\" or \"dnp\"";
            this.deleteByCommentOrValueToolStripMenuItem.Click += new System.EventHandler(this.deleteByCommentOrValueToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // openGithubRepoToolStripMenuItem
            // 
            this.openGithubRepoToolStripMenuItem.Name = "openGithubRepoToolStripMenuItem";
            this.openGithubRepoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.openGithubRepoToolStripMenuItem.Text = "Open Github Repo";
            this.openGithubRepoToolStripMenuItem.Click += new System.EventHandler(this.openGithubRepoToolStripMenuItem_Click);
            // 
            // openCSVFile
            // 
            this.openCSVFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openCSVFile_FileOk);
            // 
            // partTable
            // 
            this.partTable.AllowUserToResizeColumns = false;
            this.partTable.AllowUserToResizeRows = false;
            this.partTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.partTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.partTable.Location = new System.Drawing.Point(0, 24);
            this.partTable.Name = "partTable";
            this.partTable.Size = new System.Drawing.Size(1436, 640);
            this.partTable.TabIndex = 1;
            // 
            // lblLoadedparts
            // 
            this.lblLoadedparts.AutoSize = true;
            this.lblLoadedparts.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoadedparts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoadedparts.Location = new System.Drawing.Point(12, 667);
            this.lblLoadedparts.Name = "lblLoadedparts";
            this.lblLoadedparts.Size = new System.Drawing.Size(73, 13);
            this.lblLoadedparts.TabIndex = 2;
            this.lblLoadedparts.Text = "Loaded Parts:";
            // 
            // mergeValueIntoNameOnExportToolStripMenuItem
            // 
            this.mergeValueIntoNameOnExportToolStripMenuItem.Checked = true;
            this.mergeValueIntoNameOnExportToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mergeValueIntoNameOnExportToolStripMenuItem.Name = "mergeValueIntoNameOnExportToolStripMenuItem";
            this.mergeValueIntoNameOnExportToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.mergeValueIntoNameOnExportToolStripMenuItem.Text = "Merge \"Value\" into \"Name\" on Export";
            this.mergeValueIntoNameOnExportToolStripMenuItem.Click += new System.EventHandler(this.mergeValueIntoNameOnExportToolStripMenuItem_Click);
            this.mergeValueIntoNameOnExportToolStripMenuItem.MouseEnter += new System.EventHandler(this.mergeValueIntoNameOnExportToolStripMenuItem_MouseEnter);
            this.mergeValueIntoNameOnExportToolStripMenuItem.MouseLeave += new System.EventHandler(this.mergeValueIntoNameOnExportToolStripMenuItem_MouseLeave);
            // 
            // exportPreferencesToolStripMenuItem
            // 
            this.exportPreferencesToolStripMenuItem.Enabled = false;
            this.exportPreferencesToolStripMenuItem.Name = "exportPreferencesToolStripMenuItem";
            this.exportPreferencesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.exportPreferencesToolStripMenuItem.Text = "Export Preferences";
            // 
            // preferValueOverDescriptionToolStripMenuItem
            // 
            this.preferValueOverDescriptionToolStripMenuItem.Checked = true;
            this.preferValueOverDescriptionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preferValueOverDescriptionToolStripMenuItem.Name = "preferValueOverDescriptionToolStripMenuItem";
            this.preferValueOverDescriptionToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.preferValueOverDescriptionToolStripMenuItem.Text = "Prefer \"Value\" over \"Name\"";
            this.preferValueOverDescriptionToolStripMenuItem.ToolTipText = "This will dump the \"Description\" Field and writes the \"Value\" field on export if " +
    "such exist\r\nThis will only affect if Merging is NOT enabled\r\n";
            this.preferValueOverDescriptionToolStripMenuItem.Click += new System.EventHandler(this.preferValueOverDescriptionToolStripMenuItem_Click);
            this.preferValueOverDescriptionToolStripMenuItem.MouseEnter += new System.EventHandler(this.preferValueOverDescriptionToolStripMenuItem_MouseEnter);
            this.preferValueOverDescriptionToolStripMenuItem.MouseLeave += new System.EventHandler(this.preferValueOverDescriptionToolStripMenuItem_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1436, 916);
            this.Controls.Add(this.lblLoadedparts);
            this.Controls.Add(this.partTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Open PnP Prerunner";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPnPCSVToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openCSVFile;
        private System.Windows.Forms.ToolStripMenuItem offsetToolStripMenuItem;
        private System.Windows.Forms.DataGridView partTable;
        private System.Windows.Forms.ToolStripMenuItem saveEditqueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadEditqueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPnPFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteByFootprintToolStripMenuItem;
        private System.Windows.Forms.Label lblLoadedparts;
        private System.Windows.Forms.ToolStripMenuItem offsetPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetFootprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openGithubRepoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveCSVFile;
        private System.Windows.Forms.ToolStripMenuItem deleteByCommentOrValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeValueIntoNameOnExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferValueOverDescriptionToolStripMenuItem;
    }
}

