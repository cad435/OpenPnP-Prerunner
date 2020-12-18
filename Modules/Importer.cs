using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PnPFile_Prerunner.Modules
{
    public partial class Importer : Form
    {
        public Importer(String _openFile, ref List<Part> _parts)
        {
            openFile = _openFile;
            InitializeComponent();


            SelectorBoxes[0] = ListCNameDesignator;
            SelectorBoxes[1] = ListCNameName;
            SelectorBoxes[2] = ListCNameValue;
            SelectorBoxes[3] = ListCNameFootprint;
            SelectorBoxes[4] = ListCNameCenterX;
            SelectorBoxes[5] = ListCNameCenterY;
            SelectorBoxes[6] = ListCNameLayer;
            SelectorBoxes[7] = ListCNameRotation;



            parts = _parts;

        }

        private List<Part> parts;

        //Path to opened file
        private String openFile = "";
        //number of lines wich have to be processed
        private int NumLines = 0;
        //attay of the boxes 
        private ComboBox[] SelectorBoxes = new ComboBox[Constants.NumRelevantColumns];
        //stores wich Column of the CSV corresponds to wich value inside the programm
        //Values inside the Programm are stored in the order defined in constants 
        private int[] NewColumnIndex = new int[Constants.NumRelevantColumns] { -1, -1, -1, -1, -1, -1, -1 , -1};


        private void Importer_Load(object sender, EventArgs e)
        {
            LoadDescriptions();
        }


        //loads descriptions and lets the user choose wich column of the given CSV corresponds to wich internal values
        private void LoadDescriptions()
        {
            //open File 
            StreamReader sr = File.OpenText(openFile);
            //get first line with all the Descriptions of the columns
            String line = sr.ReadLine();
            String[] Descriptions = line.Split(Constants.splitDelimiters);

            //add all Items from description to each box

            foreach (String s in Descriptions)
            {

                foreach (ComboBox Box in SelectorBoxes)
                {
                    Box.Items.Add(s);
                }
            }

            //estimate the correct column for each box
            foreach (String s in Descriptions)
            {
                if (s.ToLower().Contains("name") || s.ToLower().Contains("comment"))
                    ListCNameName.SelectedItem = s;
                if (s.ToLower().Contains("designator"))
                    ListCNameDesignator.SelectedItem = s;
                if (s.ToLower().Contains("value"))
                    ListCNameValue.SelectedItem = s;
                if (s.ToLower().Contains("rot"))
                    ListCNameRotation.SelectedItem = s;
                if (s.ToLower().Contains("footpr"))
                    ListCNameFootprint.SelectedItem = s;
                if (s.ToLower().Contains("cen") && s.ToLower().Contains("x"))
                    ListCNameCenterX.SelectedItem = s;
                if (s.ToLower().Contains("cen") && s.ToLower().Contains("y"))
                    ListCNameCenterY.SelectedItem = s;
                if (s.ToLower().Contains("layer"))
                    ListCNameLayer.SelectedItem = s;


            }

            //now, read the entire file, but only count the lines to show it on screen and for the bar estimation
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                i++;
            }

            //save the value
            NumLines = i;

            lblPartsCount.Text = "Lines Processed: 0/" + NumLines.ToString();



            sr.Close();
            sr.Dispose();
        }

        private void cmdLoadColumns_Click(object sender, EventArgs e)
        {

            //new set of parts will be loaded
            parts.Clear();

            //get the selected index from each box.
            //this corresponds to the column in wich the data is stored in the csv
            for (int i = 0; i < NewColumnIndex.Length; i++)
            {
                NewColumnIndex[i] = SelectorBoxes[i].SelectedIndex;
            }

            //actually add the Parts:

            //open File 
            StreamReader sr = File.OpenText(openFile);
            //get first line with all the Descriptions of the columns
            String line = sr.ReadLine(); //this doesnt matter at all now.

            //line Counter to estimate the Progress-Bar
            int ProcessedLines = 0;

            while ((line = sr.ReadLine())  != null)
            {
                //skip any empty lines
                if (line != "")
                {
                    //this will get the Columns, already sorted in the order stated above at the declaration of "NewColumnIndex".
                    String[] Columns = GetColumnsfromLine(line);
                    //get Part-Objects from column set and add them to the list
                    parts.AddRange(ParseLine(Columns));
                }

                ProcessedLines++;

                //set the text on the form
                lblPartsCount.Text = "Lines Processed: " + ProcessedLines.ToString() +"/" + NumLines.ToString();
                //update the progress bar
                LoadProgressBar.Value = 100 * ProcessedLines / NumLines;

                //refresh the form for visual updates
                LoadProgressBar.Refresh();
                lblPartsCount.Refresh();

            }

            this.Close();
            this.Dispose();

        }

        private String[] GetColumnsfromLine(String Line)
        {

            //get every group inside of "..." and write it to a array
            var pattern = "\"(.*?)\"";
            var matches = Regex.Matches(Line, pattern);

            List<String> Colums = new List<String>();

            foreach (Match m in matches)
            {
                Colums.Add(m.Groups[1].ToString());
            }

            String[] sColumns = Colums.ToArray();
            //now we have to sort the columns into the correct order stated above at the declaration of "NewColumnIndex".

            String[] Sorted = new String[Constants.NumRelevantColumns] {sColumns[NewColumnIndex[0]],
                                                            sColumns[NewColumnIndex[1]],
                                                            sColumns[NewColumnIndex[2]],
                                                            sColumns[NewColumnIndex[3]],
                                                            sColumns[NewColumnIndex[4]],
                                                            sColumns[NewColumnIndex[5]],
                                                            sColumns[NewColumnIndex[6]],
                                                            sColumns[NewColumnIndex[7]]
                                                            };

            return Sorted;
        }

        private List<Part> ParseLine(String[] Columns)
        {
            List<Part> parts = new List<Part>();

            //first, get the Number of designators. This indicates how much parts we need to build.
            //for this we need to spilt the String given in the "Designator" column 
            String[] Designators = Columns[(int)Constants.NameIDs.DESIGNATOR].Split(Constants.splitDelimiters);
            int NumParts = Designators.Length;

            //Name and Footprint must only be one per line
            String Name = Columns[(int)Constants.NameIDs.NAME].Trim();
            String Footprint = Columns[(int)Constants.NameIDs.FOOTPRINT].Trim();

            //we also definately need to split CenterXY & Rotation
            //this single lines will also take care of the conversation from string to double --> not bad!
            double[] CenterX = Array.ConvertAll<String,double>(Columns[(int)Constants.NameIDs.CENTERX].Split(Constants.splitDelimiters), double.Parse);
            double[] CenterY = Array.ConvertAll<String, double>(Columns[(int)Constants.NameIDs.CENTERY].Split(Constants.splitDelimiters), double.Parse);
            double[] Rotations = Array.ConvertAll<String, double>(Columns[(int)Constants.NameIDs.ROTATION].Split(Constants.splitDelimiters), double.Parse);

            //Get values
            String[] Values = Columns[(int)Constants.NameIDs.VALUE].Split(Constants.splitDelimiters);
            //get Layer
            String[] Layers = Columns[(int)Constants.NameIDs.LAYER].Split(Constants.splitDelimiters);


            for (int i = 0; i < NumParts; i++)
            {
                Part p = new Part();
                //Name and Footprint must only be one per line
                p.Name = Name;
                p.Footprint = Footprint;
                //Designator must be different for each part!
                p.Designator = Designators[i].Trim();

                //Value CAN be different, but can also be the same for all parts
                if (Values.Length == NumParts)
                    //get the specific Value
                    p.Value = Values[i].Trim();
                else
                    //Only one Value available, use this one for every part
                    p.Value = Values[0].Trim();

                //XY-Position CAN be different, but can also be the same for all parts
                if (CenterX.Length == NumParts)
                    //get the specific CenterX
                    p.CenterX = CenterX[i];
                else
                    //Only one CenterX available, use this one for every part
                    p.CenterX = CenterX[0];

                if (CenterY.Length == NumParts)
                    //get the specific CenterX
                    p.CenterY = CenterY[i];
                else
                    //Only one CenterX available, use this one for every part
                    p.CenterY = CenterY[0];

                //Rotation CAN be different, but can also be the same for all parts
                if (Rotations.Length == NumParts)
                    //get the specific Rotation
                    p.Rotation = Rotations[i];
                else
                    //Only one Rotation available, use this one for every part
                    p.Rotation = Rotations[0];


                //Layer CAN be different, but can also be the same for all parts
                if (Layers.Length == NumParts)
                    //get the specific Rotation
                    p.Layer = Layers[i];
                else
                    //Only one Rotation available, use this one for every part
                    p.Layer = Layers[0];

                parts.Add(p);
            }

            return parts;

        }

        private void cmdCancelCSVLoad_Click(object sender, EventArgs e)
        {
            foreach (ComboBox box in SelectorBoxes)
            {
                box.Items.Clear();
            }

            this.Close();
            this.Dispose();
        }
    }
}
