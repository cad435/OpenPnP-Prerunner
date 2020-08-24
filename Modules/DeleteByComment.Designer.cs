namespace PnPFile_Prerunner.Modules
{
    partial class DeleteByComment
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.checkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(515, 10);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 26;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(434, 10);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 25;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filter Text";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(71, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(249, 20);
            this.txtText.TabIndex = 27;
            this.txtText.Text = "dnp";
            // 
            // checkCaseSensitive
            // 
            this.checkCaseSensitive.AutoSize = true;
            this.checkCaseSensitive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkCaseSensitive.Location = new System.Drawing.Point(332, 14);
            this.checkCaseSensitive.Name = "checkCaseSensitive";
            this.checkCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.checkCaseSensitive.TabIndex = 28;
            this.checkCaseSensitive.Text = "Case Sensitive";
            this.checkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // DeleteByComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(606, 42);
            this.Controls.Add(this.checkCaseSensitive);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label2);
            this.Name = "DeleteByComment";
            this.Text = "DeleteByComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.CheckBox checkCaseSensitive;
    }
}