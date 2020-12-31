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
            partTable.ColumnCount = Constants.NumRelevantColumns;

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
                    parts.Add(new Part(Row.Cells[(int)Constants.NameIDs.DESIGNATOR].Value.ToString(),
                                        Row.Cells[(int)Constants.NameIDs.NAME].Value.ToString(),
                                        Row.Cells[(int)Constants.NameIDs.VALUE].Value.ToString(),
                                        Row.Cells[(int)Constants.NameIDs.FOOTPRINT].Value.ToString(),
                                        double.Parse(Row.Cells[(int)Constants.NameIDs.CENTERX].Value.ToString()),
                                        double.Parse(Row.Cells[(int)Constants.NameIDs.CENTERY].Value.ToString()),
                                        Row.Cells[(int)Constants.NameIDs.LAYER].Value.ToString(),
                                        double.Parse(Row.Cells[(int)Constants.NameIDs.ROTATION].Value.ToString())
                                        ));
                }

            }

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

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //updates parts in case anything was changed inside table
            RefreshPartsList();

            //instance of the Exporter Window, the ref parts is for exporting the parts...
            Exporter exporter = new Exporter(ref parts);
            //open the Exporter window and block the code on parent window
            exporter.ShowDialog();

            

        }


        private void mergeValueIntoNameOnExportToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = false;
        }

        private void mergeValueIntoNameOnExportToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = true;
        }

        private void preferValueOverDescriptionToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = false;
        }

        private void preferValueOverDescriptionToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            offsetToolStripMenuItem.DropDown.AutoClose = true;
        }

        private void exportPartsCountToolStripMenuItem_Click(object sender, EventArgs e)
        {


            RefreshPartsList();

            savePartsCount.Filter = "csv files (*.csv)|*.csv";
            if (savePartsCount.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            CountParts cParts = new CountParts(parts);

            int SumParts = parts.Count();

            cParts.Count();


            String sFile = savePartsCount.FileName;
            StreamWriter sw = new StreamWriter(sFile);



            //we will write Headline:
            sw.WriteLine("Part; Footprint; Amount");

            //write a blank line
            sw.WriteLine();
            sw.WriteLine();

            bool CollapseNameAndValue = true;
            bool PreferValue = true;

            String s;

            while ((s = cParts.ExportNext(CollapseNameAndValue, PreferValue)) != "")
            {
                sw.WriteLine(s);
            }

            //write blank lines
            sw.WriteLine();
            sw.WriteLine("================================================================================================================");

            sw.WriteLine("SUM; SUM; " + SumParts);

            sw.Close();
            sw.Dispose();

        }
    }
}
