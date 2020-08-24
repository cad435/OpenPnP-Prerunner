using PnPFile_Prerunner.Modules;
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

namespace PnPFile_Prerunner
{
    public partial class Main : Form
    {


        List<Part> parts = new List<Part>();


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            partTable.ColumnCount = 7;

            for (int i = 0; i < Constants.NumRelevantColumns; i++)
            {
                partTable.Columns[i].HeaderText = Constants.ColumnNames[i];
            }
        }

        private void openCSVFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openPnPCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCSVFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openCSVFile.ShowDialog() == DialogResult.OK)
            {
                //get the string to the loaded file
                String openFile = openCSVFile.FileName;
                //instance of the Importer Window, the ref parts is for having a return list with all the parts listed
                Importer importer = new Importer(openFile, ref parts);
                //open the Importer window and block the code on parent window
                importer.ShowDialog();

                //and here we have a list of ALL parts inside the PnP-CSV! Hooray!!
                //We now have to display all of them....
                DisplayParts();


            }
        }


        private void DisplayParts()
        {
            partTable.Rows.Clear();
            foreach (Part p in parts)
            {
                partTable.Rows.Add(p.ToTable());
                
            }
            foreach (DataGridViewRow Row in partTable.Rows)
            {
                Row.HeaderCell.Value = String.Format("{0}", Row.Index + 1);
            }

            //Row headers should be resized, so that Numbers are shown
            partTable.AutoResizeRowHeadersWidth(partTable.Rows.Count-1, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            lblLoadedparts.Text = "Loaded Parts: " + parts.Count.ToString();

        }

        private void RefreshPartsList()
        {
            parts.Clear();
            foreach (DataGridViewRow Row in partTable.Rows)
            {
                if (Row.Cells[0].Value != null)
                {
                    parts.Add(new Part(Row.Cells[0].Value.ToString(),
                                        Row.Cells[1].Value.ToString(),
                                        Row.Cells[2].Value.ToString(),
                                        Row.Cells[3].Value.ToString(),
                                        double.Parse(Row.Cells[4].Value.ToString()),
                                        double.Parse(Row.Cells[5].Value.ToString()),
                                        double.Parse(Row.Cells[6].Value.ToString())
                                        ));
                }

            }

        }

        private void exportPnPFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool CollapseNameAndValue = mergeValueIntoNameOnExportToolStripMenuItem.Checked;
            bool DoubleNameToValue = doubleNameToValueOnEmptyValueToolStripMenuItem.Checked;

            RefreshPartsList();

            saveCSVFile.Filter = "csv files (*.csv)|*.csv";
            if (saveCSVFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String sFile = saveCSVFile.FileName;

            StreamWriter sw = new StreamWriter(sFile);

            //first, write the Designator, followed by a comma and the name
            sw.Write(Constants.ColumnNames[0] + "," + Constants.ColumnNames[1] + ",");

            //if "Value" should be exported as a separate column, write that column. Otherwise skip it
            if (!CollapseNameAndValue)
            {
                sw.Write(Constants.ColumnNames[2] + ",");
            }

            //then, write footprint, CenterX, CenterY and Rotation
            sw.Write(Constants.ColumnNames[3] + "," + Constants.ColumnNames[4] + "," + Constants.ColumnNames[5] + "," + Constants.ColumnNames[6]);

            //end the line and write a blank line
            sw.WriteLine();
            sw.WriteLine();

            //now, write each Part!

            foreach (Part p in parts)
            {
                sw.WriteLine(p.ToExport(CollapseNameAndValue, DoubleNameToValue));
            }

            sw.Close();
            sw.Dispose();



        }

        private void deleteByFootprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //write changes from Table to list
            RefreshPartsList();

            //instance of the Importer Window, the ref parts is for having a return list with all the parts listed
            DeleteByFootprint dbf = new DeleteByFootprint(ref parts);
            //open the Importer window and block the code on parent window
            //this will delete the selected footprints and modify the parts-list.
            dbf.ShowDialog();

            //display the new parts
            DisplayParts();

        }


        #region Edit-Tab 

        private void offsetPartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void offsetFootprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mergeValueIntoNameOnExportToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            mergeValueIntoNameOnExportToolStripMenuItem.Checked = !mergeValueIntoNameOnExportToolStripMenuItem.Checked;

            //if "merging" is checked, there is no need to double the value...
            //the "double" operation will be greyed out
            doubleNameToValueOnEmptyValueToolStripMenuItem.Enabled = !mergeValueIntoNameOnExportToolStripMenuItem.Checked;



        }

       

        private void mergeValueIntoNameOnExportToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = false;
        }

        private void mergeValueIntoNameOnExportToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = true;
        }

        private void doubleNameToValueOnEmptyValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubleNameToValueOnEmptyValueToolStripMenuItem.Checked = !doubleNameToValueOnEmptyValueToolStripMenuItem.Checked;
        }

        private void doubleNameToValueOnEmptyValueToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = false;
        }

        private void doubleNameToValueOnEmptyValueToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = true;
        }

        #endregion
        private void openGithubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //you must not remove this line or this tool-strip Item!. If you want to add a link to your own repo, make a new tab!
            System.Diagnostics.Process.Start("https://github.com/cad435/OpenPnP-Prerunner");
        }

        private void deleteByCommentOrValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instance of the Importer Window, the ref parts is for having a return list with all the parts listed
            DeleteByComment dbc = new DeleteByComment(ref parts);
            //open the Importer window and block the code on parent window
            //this will delete the selected footprints and modify the parts-list.
            dbc.ShowDialog();

            //display the new parts
            DisplayParts();
        }
    }
}
