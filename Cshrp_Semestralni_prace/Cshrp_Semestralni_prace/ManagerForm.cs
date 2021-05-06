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
using System.Diagnostics;

namespace Cshrp_Semestralni_prace
{
    public partial class ManagerForm : Form
    {
        /*LEFT*/
        private string driveLeft;
        private string pathLeft;
        private string fullPathLeft;
        private string selectedFileLeft;
        private bool   isFileLeft = false;

        /*RIGHT*/
        private string driveRight;
        private string pathRight;
        private string fullPathRight;
        private string selectedFileRight;
        private bool   isFileRight = false;

        /*STATIC*/
        public static string LogFileLeft { get; } = "LeftWindowLogs.txt";
        public static string LogFileRight { get; } = "RightWindowLogs.txt";

        private static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

        static private string ConvertSize(long length)
        {
            int counter = 0;
            decimal number = length;
            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }
            return string.Format("{0:n1} {1}", number, suffixes[counter]);
        }

        public ManagerForm()
        {            
            InitializeComponent();

            pathtextBoxLeft.KeyPress += new KeyPressEventHandler(TextBoxEnterHandler);
            pathtextBoxRight.KeyPress += new KeyPressEventHandler(TextBoxEnterHandler);

            historyMenuItemLeft.Click += new EventHandler(OpenHistoryDialog);
            historyMenuItemRight.Click  += new EventHandler(OpenHistoryDialog);

            cleanMenuItemLeft.Click += new EventHandler(CleanHistory);
            cleanMenuItemRight.Click += new EventHandler(CleanHistory);

            comboBoxDriveLeft.SelectedIndexChanged += new EventHandler(RefreshDriveSelection);
            comboBoxDriveRight.SelectedIndexChanged += new EventHandler(RefreshDriveSelection);
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEnviroment();
            RefreshSide(true, false);
            RefreshSide(false, false);
        }       

        private void ListViewLeft_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {            
            ItemSelection(e, fullPathLeft, pathLeft, ref selectedFileLeft, pathtextBoxLeft, detailsBoxLeft, ref isFileLeft);            
        }

        private void ListViewRight_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelection(e, fullPathRight, pathRight, ref selectedFileRight, pathtextBoxRight, detailsBoxRight, ref isFileRight);
        }

        private void ListViewLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {           
            RefreshSide(true, false);       
        }

        private void ListViewRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            RefreshSide(false, false);           
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Semestrální práce C# 2021 - Fráňa Tomáš | st58229", "About.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void ListBoxHistoryLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RefreshHistoryFromTab(sender);
        }

        private void ListBoxHistoryRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RefreshHistoryFromTab(sender);
        }

        /*BUTTONS*/

        private void BackButtonLeft_Click(object sender, EventArgs e)
        {
            Back(sender, pathtextBoxLeft, ref isFileLeft);
            pathLeft = pathtextBoxLeft.Text;
        }

        private void BackButtonRight_Click(object sender, EventArgs e)
        {
            Back(sender, pathtextBoxRight, ref isFileRight);
            pathRight = pathtextBoxRight.Text;
        }

        private void BtnRemoveLeft_Click(object sender, EventArgs e)
        {            
            RemoveFile(fullPathLeft, ref selectedFileLeft);            
        }        

        private void BtnRemoveRight_Click(object sender, EventArgs e)
        {
            RemoveFile(fullPathRight, ref selectedFileRight);            
        }

        private void BtnRenameLeft_Click(object sender, EventArgs e)
        {            
            RenameFile(fullPathLeft, ref selectedFileLeft);           
        }

        private void BtnRenameRight_Click(object sender, EventArgs e)
        {
            RenameFile(fullPathRight, ref selectedFileRight);
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {            
            MoveFile(fullPathLeft, ref selectedFileLeft, fullPathRight);           
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            MoveFile(fullPathRight, ref selectedFileRight, fullPathLeft);
        }

        private void BtnCopyLeft_Click(object sender, EventArgs e)
        {
            CopyFile(fullPathLeft, selectedFileLeft, fullPathRight);
        }       

        private void BtnCopyRight_Click(object sender, EventArgs e)
        {
            CopyFile(fullPathRight, selectedFileRight, fullPathLeft);
        }
    }
}
