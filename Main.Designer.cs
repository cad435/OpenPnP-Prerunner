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
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPartsCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetFootprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByFootprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByCommentOrValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGithubRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVFile = new System.Windows.Forms.OpenFileDialog();
            this.partTable = new System.Windows.Forms.DataGridView();
            this.lblLoadedparts = new System.Windows.Forms.Label();
            this.savePartsCount = new System.Windows.Forms.SaveFileDialog();
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
            this.exportToolStripMenuItem,
            this.exportPartsCountToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // openPnPCSVToolStripMenuItem
            // 
            this.openPnPCSVToolStripMenuItem.Name = "openPnPCSVToolStripMenuItem";
            this.openPnPCSVToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openPnPCSVToolStripMenuItem.Text = "Open PnP CSV";
            this.openPnPCSVToolStripMenuItem.Click += new System.EventHandler(this.openPnPCSVToolStripMenuItem_Click);
            // 
            // saveEditqueueToolStripMenuItem
            // 
            this.saveEditqueueToolStripMenuItem.Enabled = false;
            this.saveEditqueueToolStripMenuItem.Name = "saveEditqueueToolStripMenuItem";
            this.saveEditqueueToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveEditqueueToolStripMenuItem.Text = "Save edit-queue";
            // 
            // loadEditqueueToolStripMenuItem
            // 
            this.loadEditqueueToolStripMenuItem.Enabled = false;
            this.loadEditqueueToolStripMenuItem.Name = "loadEditqueueToolStripMenuItem";
            this.loadEditqueueToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loadEditqueueToolStripMenuItem.Text = "Load edit-queue";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportPartsCountToolStripMenuItem
            // 
            this.exportPartsCountToolStripMenuItem.Name = "exportPartsCountToolStripMenuItem";
            this.exportPartsCountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportPartsCountToolStripMenuItem.Text = "Export Parts Count";
            this.exportPartsCountToolStripMenuItem.Click += new System.EventHandler(this.exportPartsCountToolStripMenuItem_Click);
            // 
            // offsetToolStripMenuItem
            // 
            this.offsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offsetPartToolStripMenuItem,
            this.offsetFootprintToolStripMenuItem,
            this.deleteByFootprintToolStripMenuItem,
            this.deleteByCommentOrValueToolStripMenuItem});
            this.offsetToolStripMenuItem.Name = "offsetToolStripMenuItem";
            this.offsetToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.offsetToolStripMenuItem.Text = "Edit...";
            // 
            // offsetPartToolStripMenuItem
            // 
            this.offsetPartToolStripMenuItem.Name = "offsetPartToolStripMenuItem";
            this.offsetPartToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.offsetPartToolStripMenuItem.Text = "Apply position offset by Part";
            this.offsetPartToolStripMenuItem.Click += new System.EventHandler(this.offsetPartToolStripMenuItem_Click);
            // 
            // offsetFootprintToolStripMenuItem
            // 
            this.offsetFootprintToolStripMenuItem.Name = "offsetFootprintToolStripMenuItem";
            this.offsetFootprintToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.offsetFootprintToolStripMenuItem.Text = "Apply position offset by Footprint";
            this.offsetFootprintToolStripMenuItem.Click += new System.EventHandler(this.offsetFootprintToolStripMenuItem_Click);
            // 
            // deleteByFootprintToolStripMenuItem
            // 
            this.deleteByFootprintToolStripMenuItem.Name = "deleteByFootprintToolStripMenuItem";
            this.deleteByFootprintToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.deleteByFootprintToolStripMenuItem.Text = "Delete by Footprint";
            this.deleteByFootprintToolStripMenuItem.ToolTipText = "Usually used to remove through-hole footprints";
            this.deleteByFootprintToolStripMenuItem.Click += new System.EventHandler(this.deleteByFootprintToolStripMenuItem_Click);
            // 
            // deleteByCommentOrValueToolStripMenuItem
            // 
            this.deleteByCommentOrValueToolStripMenuItem.Name = "deleteByCommentOrValueToolStripMenuItem";
            this.deleteByCommentOrValueToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.deleteByCommentOrValueToolStripMenuItem.Text = "Delete by Comment or Value";
            this.deleteByCommentOrValueToolStripMenuItem.ToolTipText = "usually used to delete all parts marked as \"do not populate\" or \"dnp\"";
            this.deleteByCommentOrValueToolStripMenuItem.Click += new System.EventHandler(this.deleteByCommentOrValueToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem deleteByFootprintToolStripMenuItem;
        private System.Windows.Forms.Label lblLoadedparts;
        private System.Windows.Forms.ToolStripMenuItem offsetPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetFootprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGithubRepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteByCommentOrValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPartsCountToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog savePartsCount;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

