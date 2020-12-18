using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PnPFile_Prerunner.Modules
{
    public partial class Exporter : Form
    {
        public Exporter(ref List<Part> _parts)
        {
            InitializeComponent();

            parts = _parts;
        }

        private List<Part> parts;

        private void Exporter_Load(object sender, EventArgs e)
        {
            cmbPreset.Items.Insert(0,"JLC BOM");
            cmbPreset.Items.Insert(0,"JLC CPL");


            // Create the ToolTip and associate with the Form container.
            ToolTip t = new ToolTip();

            // Set up the delays for the ToolTip.
            t.AutoPopDelay = 999999;
            t.InitialDelay = 1000;
            t.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            t.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            t.SetToolTip(this.lblPreferValueOverName, "This will only write the \"Description\" Field if no \"Value\" field exist.");
            t.SetToolTip(this.chkPreferValueOverName, "This will only write the \"Description\" Field if no \"Value\" field exist.");


        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void cmdExport_Click(object sender, EventArgs e)
        {
            bool CollapseNameAndValue = chkMergeValueAndName.Checked;
            bool PreferValue = chkPreferValueOverName.Checked;

            saveCSVFile.Filter = "csv files (*.csv)|*.csv";
            if (saveCSVFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String sFile = saveCSVFile.FileName;

            StreamWriter sw = new StreamWriter(sFile);

            //See https://github.com/openpnp/openpnp/wiki/Importing-Centroid-Data

            //openPnP wants to have "Designator", "Value" (instead of "Name" or "comment"), "X", "Y", "Layer", "Rotation"
            //they MUST be surronded with "...
            //that means we will either "Name(Value)" if collapsing is enabled, or we only use "Name"


            //we will write that style into the first line:
            // "designator"
            string s = "\"" + Constants.ColumnNames[0];

            //Value
            if (chkExportValue.Checked || chkExportName.Checked)
            {
                s += "\",\"" + Constants.ColumnNames[(int)Constants.NameIDs.VALUE];
            }

            if (chkExportFootprint.Checked)
            {
                s += "\",\"" + Constants.ColumnNames[(int)Constants.NameIDs.FOOTPRINT];
            }

            if (chkExportCX.Checked)
            {
                if (chkJLCStyleMidXY.Checked)
                {
                    s += "\",\"" + "Mid X";
                }
                else
                {
                    s += "\",\"" + Constants.ColumnNames[(int)Constants.NameIDs.CENTERX];
                }

                
            }

            if (chkExportCY.Checked)
            {
                if (chkJLCStyleMidXY.Checked)
                {
                    s += "\",\"" + "Mid Y";
                }
                else
                {
                    s += "\",\"" + Constants.ColumnNames[(int)Constants.NameIDs.CENTERY];
                }
            }

            if (chkExportLayer.Checked)
            {
                s += "\",\"" + Constants.ColumnNames[(int)Constants.NameIDs.LAYER];
            }

            if (chkExportRotation.Checked)
            {
                s += "\",\"" + Constants.ColumnNames[(int)Constants.NameIDs.ROTATION];
            }

            s += "\"";

            //we will write that style into the first line:
            //sw.WriteLine("\"" + Constants.ColumnNames[0] + "\",\"" + Constants.ColumnNames[2] + "\",\"" + Constants.ColumnNames[3] + "\",\"" +
            //              Constants.ColumnNames[4] + "\",\"" + Constants.ColumnNames[5] + "\",\"" + Constants.ColumnNames[6] + "\"");

            sw.WriteLine(s);


            //write a blank line
            sw.WriteLine();
            sw.WriteLine();

            //now, write each Part!

            foreach (Part p in parts)
            {
                                        //                                  Name field                                      //Footprint-field           //CenterX-Field      //CenterY-Field        //Layer-Field         //Rotation-Field             //add mm Suffix
                sw.WriteLine(p.ToExport(CollapseNameAndValue, PreferValue, (chkExportValue.Checked || chkExportName.Checked), chkExportFootprint.Checked, chkExportCX.Checked, chkExportCY.Checked, chkExportLayer.Checked, chkExportRotation.Checked, chkAddmmSuffix.Checked));
            }

            sw.Close();
            sw.Dispose();

            this.Close();
            this.Dispose();

        }

        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            //preset for JLC BOM
            if ((string)cmbPreset.SelectedItem == "JLC BOM")
            {
                chkPreferValueOverName.Enabled = true;
                chkExportDesignator.Checked = true;
                chkExportName.Checked = true;
                chkExportValue.Checked = true;
                chkExportFootprint.Checked = true;
                chkExportLayer.Checked = false;
                chkExportRotation.Checked = false;
                chkMergeValueAndName.Checked = false;
                chkPreferValueOverName.Checked = true;
                chkExportCY.Checked = false;
                chkExportCX.Checked = false;

            }

            if ((string)cmbPreset.SelectedItem == "JLC CPL")
            {
                chkPreferValueOverName.Enabled = false;
                chkExportDesignator.Checked = true;
                chkExportName.Checked = false;
                chkExportValue.Checked = false;
                chkExportFootprint.Checked = false;
                chkExportLayer.Checked = true;
                chkExportRotation.Checked = true;
                chkMergeValueAndName.Checked = false;
                chkPreferValueOverName.Checked = false;
                chkExportCY.Checked = true;
                chkExportCX.Checked = true;
                chkJLCStyleMidXY.Checked = true;
                chkAddmmSuffix.Checked = true;

            }


        }


        #region Visuals

        private void chkMergeValueAndName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMergeValueAndName.Checked)
            {
                chkPreferValueOverName.Enabled = false;
                lblPreferValueOverName.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            }
            else
            {
                chkPreferValueOverName.Enabled = true;
                lblPreferValueOverName.ForeColor = Color.FromKnownColor(KnownColor.ControlLight);

            }
            chkPreferValueOverName.Checked = false;


        }


        private void chkExportName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkExportValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExportValue.Checked == false)
            {
                chkMergeValueAndName.Enabled = false;
                chkPreferValueOverName.Enabled = false;
                chkMergeValueAndName.Checked = false;
                chkPreferValueOverName.Checked = false;

                lblPreferValueOverName.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                lblMergeValueAndName.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            }
            else
            {
                chkMergeValueAndName.Enabled = true;
                chkPreferValueOverName.Enabled = true;

                lblPreferValueOverName.ForeColor = Color.FromKnownColor(KnownColor.ControlLight);
                lblMergeValueAndName.ForeColor = Color.FromKnownColor(KnownColor.ControlLight);
            }

        }

        private void chkExportFootprint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkExportCX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkExportCY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkExportLayer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkExportRotation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPreferValueOverName_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
