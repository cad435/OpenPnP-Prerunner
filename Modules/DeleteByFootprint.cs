using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PnPFile_Prerunner.Modules
{
    public partial class DeleteByFootprint : Form
    {
        public DeleteByFootprint(ref List<Part> _parts, List<String> footprints)
        {
            InitializeComponent();

            foreach (String s in footprints)
            {
                listBoxFootprints.Items.Add(s);
            }

            parts = _parts;
        }

        private List<Part> parts;

        private void DeleteByFootprint_Load(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            if (listBoxFootprints.SelectedItem != null)
            {
                String selFootprint = listBoxFootprints.SelectedItem.ToString();
                parts.RemoveAll(Part => Part.Footprint == selFootprint);
            }


            this.Close();
            this.Dispose();

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
