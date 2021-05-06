using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Cshrp_Semestralni_prace
{
    public partial class HistoryForm : Form
    {
        public string SelectedLog { get; set; } = "";

        private string logFilePath;

        public HistoryForm(string pathToLogFile)
        {
            logFilePath = pathToLogFile;
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(logFilePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    ListBoxLogs.Items.Add(s);
                }
            }
        }

        private void ListBoxLogs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectedLog = ListBoxLogs.SelectedItem.ToString();
            this.Close();
        }
    }
}
