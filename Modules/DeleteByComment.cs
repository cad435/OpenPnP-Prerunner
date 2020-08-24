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
    public partial class DeleteByComment : Form
    {
        public DeleteByComment(ref List<Part> _parts)
        {
            InitializeComponent();

            parts = _parts;

        }

        private List<Part> parts;

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            //String.Compare third argument is "ignore Case", thus the opposite of "Case Sensitive"
            //removes all parts in the list wich Name or Value is the same as given from the textfiles
            parts.RemoveAll(Part => String.Compare(txtText.Text.Trim(), Part.Value, !checkCaseSensitive.Checked) == 0);
            parts.RemoveAll(Part => String.Compare(txtText.Text.Trim(), Part.Name, !checkCaseSensitive.Checked) == 0);


            this.Close();
            this.Dispose();
        }
    }
}
