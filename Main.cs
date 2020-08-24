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
            openCSVFile.Filter = "csv files (*.csv)|*.csv";
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

        private void offsetPartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void offsetFootprintToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            RefreshPartsList();
        }

        private void deleteByFootprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //write changes from Table to list
            RefreshPartsList();
            List<String> footprints = new List<String>();
            //get all Footprints 
            foreach (Part p in parts)
            {
                if (!footprints.Contains(p.Footprint))
                {
                    footprints.Add(p.Footprint);
                }
            }

            //instance of the Importer Window, the ref parts is for having a return list with all the parts listed
            DeleteByFootprint dbf = new DeleteByFootprint(ref parts, footprints);
            //open the Importer window and block the code on parent window
            //this will delete the selected footprints and modify the parts-list.
            dbf.ShowDialog();

            //display the new parts
            DisplayParts();

        }

        private void mergeValueIntoNameOnExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mergeValueIntoNameOnExportToolStripMenuItem.Checked = !mergeValueIntoNameOnExportToolStripMenuItem.Checked;
        }

        private void openGithubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //you must not remove this line or this tool-strip Item!. If you want to add a link to your own repo, make a new tab!
            System.Diagnostics.Process.Start("https://github.com/cad435/OpenPnP-Prerunner");
        }
    }
}
