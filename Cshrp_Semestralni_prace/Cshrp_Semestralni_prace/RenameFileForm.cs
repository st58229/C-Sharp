using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshrp_Semestralni_prace
{
    public partial class RenameFileForm : Form
    {
        public string NewName { get; set; }

        public RenameFileForm(string odlName)
        {
            NewName = odlName;            
            InitializeComponent();
            textBoxNewName.Text = NewName;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            NewName = textBoxNewName.Text;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
