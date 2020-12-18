namespace PnPFile_Prerunner.Modules
{
    partial class Exporter
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblPartsCount = new System.Windows.Forms.Label();
            this.LoadProgressBar = new System.Windows.Forms.ProgressBar();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.chkExportDesignator = new System.Windows.Forms.CheckBox();
            this.chkExportName = new System.Windows.Forms.CheckBox();
            this.chkExportValue = new System.Windows.Forms.CheckBox();
            this.chkExportFootprint = new System.Windows.Forms.CheckBox();
            this.chkExportCX = new System.Windows.Forms.CheckBox();
            this.chkExportCY = new System.Windows.Forms.CheckBox();
            this.chkExportLayer = new System.Windows.Forms.CheckBox();
            this.chkExportRotation = new System.Windows.Forms.CheckBox();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkMergeValueAndName = new System.Windows.Forms.CheckBox();
            this.chkPreferValueOverName = new System.Windows.Forms.CheckBox();
            this.lblPreferValueOverName = new System.Windows.Forms.Label();
            this.lblMergeValueAndName = new System.Windows.Forms.Label();
            this.saveCSVFile = new System.Windows.Forms.SaveFileDialog();
            this.chkAddmmSuffix = new System.Windows.Forms.CheckBox();
            this.chkJLCStyleMidXY = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(539, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Layer";
            // 
            // lblPartsCount
            // 
            this.lblPartsCount.AutoSize = true;
            this.lblPartsCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPartsCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPartsCount.Location = new System.Drawing.Point(13, 187);
            this.lblPartsCount.Name = "lblPartsCount";
            this.lblPartsCount.Size = new System.Drawing.Size(88, 13);
            this.lblPartsCount.TabIndex = 56;
            this.lblPartsCount.Text = "Lines to Process:";
            // 
            // LoadProgressBar
            // 
            this.LoadProgressBar.Location = new System.Drawing.Point(14, 203);
            this.LoadProgressBar.Name = "LoadProgressBar";
            this.LoadProgressBar.Size = new System.Drawing.Size(848, 23);
            this.LoadProgressBar.TabIndex = 55;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(138, 158);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(121, 23);
            this.cmdCancel.TabIndex = 54;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(204, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Value";
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(14, 158);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(121, 23);
            this.cmdExport.TabIndex = 51;
            this.cmdExport.Text = "Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Choose Columns:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(601, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Rotation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(477, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Center Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(415, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Center X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(353, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Footprint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Designator";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Namelbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Namelbl.Location = new System.Drawing.Point(135, 46);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(57, 13);
            this.Namelbl.TabIndex = 39;
            this.Namelbl.Text = "Part Name";
            // 
            // chkExportDesignator
            // 
            this.chkExportDesignator.AutoSize = true;
            this.chkExportDesignator.Checked = true;
            this.chkExportDesignator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportDesignator.Enabled = false;
            this.chkExportDesignator.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportDesignator.Location = new System.Drawing.Point(14, 62);
            this.chkExportDesignator.Name = "chkExportDesignator";
            this.chkExportDesignator.Size = new System.Drawing.Size(56, 17);
            this.chkExportDesignator.TabIndex = 58;
            this.chkExportDesignator.Text = "Export";
            this.chkExportDesignator.UseVisualStyleBackColor = true;
            // 
            // chkExportName
            // 
            this.chkExportName.AutoSize = true;
            this.chkExportName.Checked = true;
            this.chkExportName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportName.Location = new System.Drawing.Point(138, 62);
            this.chkExportName.Name = "chkExportName";
            this.chkExportName.Size = new System.Drawing.Size(56, 17);
            this.chkExportName.TabIndex = 59;
            this.chkExportName.Text = "Export";
            this.chkExportName.UseVisualStyleBackColor = true;
            this.chkExportName.CheckedChanged += new System.EventHandler(this.chkExportName_CheckedChanged);
            // 
            // chkExportValue
            // 
            this.chkExportValue.AutoSize = true;
            this.chkExportValue.Checked = true;
            this.chkExportValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportValue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportValue.Location = new System.Drawing.Point(203, 62);
            this.chkExportValue.Name = "chkExportValue";
            this.chkExportValue.Size = new System.Drawing.Size(56, 17);
            this.chkExportValue.TabIndex = 60;
            this.chkExportValue.Text = "Export";
            this.chkExportValue.UseVisualStyleBackColor = true;
            this.chkExportValue.CheckedChanged += new System.EventHandler(this.chkExportValue_CheckedChanged);
            // 
            // chkExportFootprint
            // 
            this.chkExportFootprint.AutoSize = true;
            this.chkExportFootprint.Checked = true;
            this.chkExportFootprint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportFootprint.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportFootprint.Location = new System.Drawing.Point(356, 62);
            this.chkExportFootprint.Name = "chkExportFootprint";
            this.chkExportFootprint.Size = new System.Drawing.Size(56, 17);
            this.chkExportFootprint.TabIndex = 61;
            this.chkExportFootprint.Text = "Export";
            this.chkExportFootprint.UseVisualStyleBackColor = true;
            this.chkExportFootprint.CheckedChanged += new System.EventHandler(this.chkExportFootprint_CheckedChanged);
            // 
            // chkExportCX
            // 
            this.chkExportCX.AutoSize = true;
            this.chkExportCX.Checked = true;
            this.chkExportCX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportCX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportCX.Location = new System.Drawing.Point(418, 62);
            this.chkExportCX.Name = "chkExportCX";
            this.chkExportCX.Size = new System.Drawing.Size(56, 17);
            this.chkExportCX.TabIndex = 62;
            this.chkExportCX.Text = "Export";
            this.chkExportCX.UseVisualStyleBackColor = true;
            this.chkExportCX.CheckedChanged += new System.EventHandler(this.chkExportCX_CheckedChanged);
            // 
            // chkExportCY
            // 
            this.chkExportCY.AutoSize = true;
            this.chkExportCY.Checked = true;
            this.chkExportCY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportCY.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportCY.Location = new System.Drawing.Point(480, 62);
            this.chkExportCY.Name = "chkExportCY";
            this.chkExportCY.Size = new System.Drawing.Size(56, 17);
            this.chkExportCY.TabIndex = 63;
            this.chkExportCY.Text = "Export";
            this.chkExportCY.UseVisualStyleBackColor = true;
            this.chkExportCY.CheckedChanged += new System.EventHandler(this.chkExportCY_CheckedChanged);
            // 
            // chkExportLayer
            // 
            this.chkExportLayer.AutoSize = true;
            this.chkExportLayer.Checked = true;
            this.chkExportLayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportLayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportLayer.Location = new System.Drawing.Point(542, 62);
            this.chkExportLayer.Name = "chkExportLayer";
            this.chkExportLayer.Size = new System.Drawing.Size(56, 17);
            this.chkExportLayer.TabIndex = 64;
            this.chkExportLayer.Text = "Export";
            this.chkExportLayer.UseVisualStyleBackColor = true;
            this.chkExportLayer.CheckedChanged += new System.EventHandler(this.chkExportLayer_CheckedChanged);
            // 
            // chkExportRotation
            // 
            this.chkExportRotation.AutoSize = true;
            this.chkExportRotation.Checked = true;
            this.chkExportRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportRotation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkExportRotation.Location = new System.Drawing.Point(604, 62);
            this.chkExportRotation.Name = "chkExportRotation";
            this.chkExportRotation.Size = new System.Drawing.Size(56, 17);
            this.chkExportRotation.TabIndex = 65;
            this.chkExportRotation.Text = "Export";
            this.chkExportRotation.UseVisualStyleBackColor = true;
            this.chkExportRotation.CheckedChanged += new System.EventHandler(this.chkExportRotation_CheckedChanged);
            // 
            // cmbPreset
            // 
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(741, 62);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(121, 21);
            this.cmbPreset.TabIndex = 66;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(738, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Preset";
            // 
            // chkMergeValueAndName
            // 
            this.chkMergeValueAndName.AutoSize = true;
            this.chkMergeValueAndName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkMergeValueAndName.Location = new System.Drawing.Point(138, 101);
            this.chkMergeValueAndName.Name = "chkMergeValueAndName";
            this.chkMergeValueAndName.Size = new System.Drawing.Size(15, 14);
            this.chkMergeValueAndName.TabIndex = 68;
            this.chkMergeValueAndName.UseVisualStyleBackColor = true;
            this.chkMergeValueAndName.CheckedChanged += new System.EventHandler(this.chkMergeValueAndName_CheckedChanged);
            // 
            // chkPreferValueOverName
            // 
            this.chkPreferValueOverName.AutoSize = true;
            this.chkPreferValueOverName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkPreferValueOverName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkPreferValueOverName.Location = new System.Drawing.Point(138, 124);
            this.chkPreferValueOverName.Name = "chkPreferValueOverName";
            this.chkPreferValueOverName.Size = new System.Drawing.Size(15, 14);
            this.chkPreferValueOverName.TabIndex = 69;
            this.chkPreferValueOverName.UseVisualStyleBackColor = false;
            // 
            // lblPreferValueOverName
            // 
            this.lblPreferValueOverName.AutoSize = true;
            this.lblPreferValueOverName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPreferValueOverName.Location = new System.Drawing.Point(153, 125);
            this.lblPreferValueOverName.Name = "lblPreferValueOverName";
            this.lblPreferValueOverName.Size = new System.Drawing.Size(140, 13);
            this.lblPreferValueOverName.TabIndex = 70;
            this.lblPreferValueOverName.Text = "Prefer \"Value\" over \"Name\"";
            this.lblPreferValueOverName.Click += new System.EventHandler(this.lblPreferValueOverName_Click);
            // 
            // lblMergeValueAndName
            // 
            this.lblMergeValueAndName.AutoSize = true;
            this.lblMergeValueAndName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMergeValueAndName.Location = new System.Drawing.Point(153, 102);
            this.lblMergeValueAndName.Name = "lblMergeValueAndName";
            this.lblMergeValueAndName.Size = new System.Drawing.Size(186, 13);
            this.lblMergeValueAndName.TabIndex = 71;
            this.lblMergeValueAndName.Text = "Merge \"Value\" into \"Name\" on Export";
            // 
            // chkAddmmSuffix
            // 
            this.chkAddmmSuffix.AutoSize = true;
            this.chkAddmmSuffix.Checked = true;
            this.chkAddmmSuffix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddmmSuffix.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkAddmmSuffix.Location = new System.Drawing.Point(375, 102);
            this.chkAddmmSuffix.Name = "chkAddmmSuffix";
            this.chkAddmmSuffix.Size = new System.Drawing.Size(132, 17);
            this.chkAddmmSuffix.TabIndex = 72;
            this.chkAddmmSuffix.Text = "suffix \"mm\" to X and Y";
            this.chkAddmmSuffix.UseVisualStyleBackColor = true;
            // 
            // chkJLCStyleMidXY
            // 
            this.chkJLCStyleMidXY.AutoSize = true;
            this.chkJLCStyleMidXY.Checked = true;
            this.chkJLCStyleMidXY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJLCStyleMidXY.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkJLCStyleMidXY.Location = new System.Drawing.Point(375, 123);
            this.chkJLCStyleMidXY.Name = "chkJLCStyleMidXY";
            this.chkJLCStyleMidXY.Size = new System.Drawing.Size(274, 17);
            this.chkJLCStyleMidXY.TabIndex = 73;
            this.chkJLCStyleMidXY.Text = "JLC-Style \"Mid X/Y\" instead of OpenPnP \"X/Y(mm)\"";
            this.chkJLCStyleMidXY.UseVisualStyleBackColor = true;
            // 
            // Exporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(881, 233);
            this.Controls.Add(this.chkJLCStyleMidXY);
            this.Controls.Add(this.chkAddmmSuffix);
            this.Controls.Add(this.lblMergeValueAndName);
            this.Controls.Add(this.lblPreferValueOverName);
            this.Controls.Add(this.chkPreferValueOverName);
            this.Controls.Add(this.chkMergeValueAndName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPreset);
            this.Controls.Add(this.chkExportRotation);
            this.Controls.Add(this.chkExportLayer);
            this.Controls.Add(this.chkExportCY);
            this.Controls.Add(this.chkExportCX);
            this.Controls.Add(this.chkExportFootprint);
            this.Controls.Add(this.chkExportValue);
            this.Controls.Add(this.chkExportName);
            this.Controls.Add(this.chkExportDesignator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPartsCount);
            this.Controls.Add(this.LoadProgressBar);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Namelbl);
            this.Name = "Exporter";
            this.Text = "Exporter";
            this.Load += new System.EventHandler(this.Exporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPartsCount;
        private System.Windows.Forms.ProgressBar LoadProgressBar;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.CheckBox chkExportDesignator;
        private System.Windows.Forms.CheckBox chkExportName;
        private System.Windows.Forms.CheckBox chkExportValue;
        private System.Windows.Forms.CheckBox chkExportFootprint;
        private System.Windows.Forms.CheckBox chkExportCX;
        private System.Windows.Forms.CheckBox chkExportCY;
        private System.Windows.Forms.CheckBox chkExportLayer;
        private System.Windows.Forms.CheckBox chkExportRotation;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkMergeValueAndName;
        private System.Windows.Forms.CheckBox chkPreferValueOverName;
        private System.Windows.Forms.Label lblPreferValueOverName;
        private System.Windows.Forms.Label lblMergeValueAndName;
        private System.Windows.Forms.SaveFileDialog saveCSVFile;
        private System.Windows.Forms.CheckBox chkAddmmSuffix;
        private System.Windows.Forms.CheckBox chkJLCStyleMidXY;
    }
}