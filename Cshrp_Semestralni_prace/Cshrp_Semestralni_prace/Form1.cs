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
    public partial class Form1 : Form
    {
        private string Path_def { get; } = "C:/";

        private string Path_left { get; set; }

        private string Path_right { get; set; }

        private bool isFile = false;



        private string SelectedFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void PathtextBox_left_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathtextBox_right_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PathtextBox_left.Text = Path_def;

            Path_left = Path_def;
            Path_right = Path_def;

            loadDirectory();

        }

        private void loadDirectory()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";

            FileAttributes fileatr;

            try
            {
                if (isFile)
                {
                    tempFilePath = Path_left + "/" + SelectedFile;
                    FileInfo filedetails = new FileInfo(tempFilePath);
                    DetailsBox_left.Text = filedetails.ToString();
                    fileatr = File.GetAttributes(tempFilePath);

                    Process.Start(tempFilePath);
                }
                else
                {
                    fileatr = File.GetAttributes(Path_left);                    
                }

                if ((fileatr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(Path_left);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listView_left.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        listView_left.Items.Add(files[i].Name);
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView_left.Items.Add(dirs[i].Name);
                    }
                }
                else 
                {
                    tempFilePath = Path_left + "/" + SelectedFile;
                    FileInfo filedetails = new FileInfo(tempFilePath);
                    DetailsBox_left.Text = filedetails.ToString();
                }

            }
            catch (Exception e)
            {
                
            }
        }

        private void GoButton_left_Click(object sender, EventArgs e)
        {
            Path_left = PathtextBox_left.Text;
            loadDirectory();
            
        }

        private void listView_left_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectedFile = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(Path_left + "/" + SelectedFile);

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                PathtextBox_left.Text = Path_left + "/" + SelectedFile;
            }
            else 
            {
                isFile = true;
            }
        }

        private void listView_right_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void listView_left_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Path_left = PathtextBox_left.Text;
            loadDirectory();
        }

        private void goUp()
        {
            isFile = false;
            PathtextBox_left.Text = PathtextBox_left.Text.Substring(0, PathtextBox_left.Text.LastIndexOf("/"));
            loadDirectory();
        }

        private void BackButton_left_Click(object sender, EventArgs e)
        {

        }
    }
}
