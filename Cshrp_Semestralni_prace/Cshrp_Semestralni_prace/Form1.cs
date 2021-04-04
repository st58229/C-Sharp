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
        public Interface Interface { get; set; } = new Interface();
        private string Path_def { get; } = "C:/";
        
        /*LEFT*/
        private string Path_left { get; set; }
        private string SelectedFile_left;
        private bool isFile_left = false;

        /*RIGHT*/
        private string Path_right { get; set; }
        private string SelectedFile_right;
        private bool isFile_right = false;

        public Form1()
        {
            Interface.UpdateInterface += new Interface.UpdatedInterfaceEventHandler(UpdateHandler);
            InitializeComponent();
        }

        private void UpdateHandler(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            PathtextBox_left.Text = Path_def;
            PathtextBox_right.Text = Path_def;

            Path_left = Path_def;
            Path_right = Path_def;

            Interface.loadDirectory(ref listView_left, ref DetailsBox_left, Path_left, SelectedFile_left, ref isFile_left, ref iconList);
            loadDirectory(listView_right, DetailsBox_right, Path_right, SelectedFile_right, ref isFile_right);
        }

        private void PathtextBox_left_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathtextBox_right_TextChanged(object sender, EventArgs e)
        {

        }        

        private void loadDirectory(ListView listView, RichTextBox richTextBox, string path, string selectedFile, ref bool isFile)
        {
            DirectoryInfo fileList;
            string tempFilePath = "";

            FileAttributes fileatr;
            try
            {
                if (isFile)
                {
                    tempFilePath = path + "/" + selectedFile;
                    FileInfo filedetails = new FileInfo(tempFilePath);
                    richTextBox.Text = filedetails.ToString();
                    fileatr = File.GetAttributes(tempFilePath);

                    Process.Start(tempFilePath);
                }
                else
                {
                    fileatr = File.GetAttributes(path);                    
                }

                if ((fileatr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(Path_left);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listView.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        iconList.Images.Add(Icon.ExtractAssociatedIcon(files[i].FullName));
                        listView.Items.Add(files[i].Name, iconList.Images.Count-1);
                    }
                    
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        iconList.Images.Add(SystemIcons.Information); //TODO - Ikony složek
                        listView.Items.Add(dirs[i].Name, iconList.Images.Count - 1);
                    }
                }
                else 
                {
                    tempFilePath = path + "/" + selectedFile;
                    FileInfo filedetails = new FileInfo(tempFilePath);
                    richTextBox.Text = filedetails.ToString();
                }

            }
            catch (Exception)
            {
                
            }
        }

        private void GoButton_left_Click(object sender, EventArgs e)
        {
            Path_left = PathtextBox_left.Text;
            loadDirectory(listView_left, DetailsBox_left, Path_left, SelectedFile_left, ref isFile_left);
        }
        private void GoButton_right_Click(object sender, EventArgs e)
        {
            Path_right = PathtextBox_right.Text;
            loadDirectory(listView_right, DetailsBox_right, Path_right, SelectedFile_right, ref isFile_right);
        }

        private void listView_left_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {            
            ItemSelection(sender, e, Path_left, ref SelectedFile_left, PathtextBox_left, ref isFile_left);            
        }

        private void listView_right_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelection(sender, e, Path_right, ref SelectedFile_right, PathtextBox_right, ref isFile_right);
        }

        private void ItemSelection(object sender, ListViewItemSelectionChangedEventArgs e, string path, ref string selectedFile, TextBox textBox, ref bool isFile)
        {
            selectedFile = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(path + "/" + selectedFile);

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                textBox.Text = path + "/" + selectedFile;
            }
            else
            {
                isFile = true;
            }

        }

        private void listView_left_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Path_left = PathtextBox_left.Text;
            loadDirectory(listView_left, DetailsBox_left, Path_left, SelectedFile_left, ref isFile_left);
        }

        private void listView_right_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Path_right = PathtextBox_right.Text;
            loadDirectory(listView_right, DetailsBox_right, Path_right, SelectedFile_right, ref isFile_right);
        }

        private void Back(TextBox textBox, ListView listView, RichTextBox richTextBox, string path, string selectedFile, ref bool isFile)
        {
            isFile = false;
            textBox.Text = textBox.Text.Substring(0, textBox.Text.LastIndexOf("/"));
            loadDirectory(listView, richTextBox, path, selectedFile, ref isFile);
        }

        private void BackButton_left_Click(object sender, EventArgs e)
        {
            Back(PathtextBox_left, listView_left, DetailsBox_left, Path_left, SelectedFile_left, ref isFile_left);            
        }

        private void BackButton_right_Click(object sender, EventArgs e)
        {
            Back(PathtextBox_right, listView_right, DetailsBox_right, Path_right, SelectedFile_right, ref isFile_right);
        }

        private void btnRemove_left_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path_left + "/" + SelectedFile_left;
            FileInfo temp = new FileInfo(tempFilePath);
            temp.Delete();            
        }

        private void btnRename_left_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path_left + "/" + SelectedFile_left;
            FileInfo temp = new FileInfo(tempFilePath);
            string newPath = Path_left + "/" + "TEST.txt"; //TODO
            temp.MoveTo(newPath);
        }

        private void btnRemove_right_Click(object sender, EventArgs e)
        {

        }

        private void btnRename_right_Click(object sender, EventArgs e)
        {

        }

        private void btnMove_left_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path_left + "/" + SelectedFile_left;
            FileInfo temp = new FileInfo(tempFilePath);
            string newPath = Path_right + "/" + SelectedFile_left;
            temp.MoveTo(newPath);
        }

        private void btnMove_right_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_left_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path_left + "/" + SelectedFile_left;
            FileInfo temp = new FileInfo(tempFilePath);
            string newPath = Path_right + "/" + SelectedFile_left;
            temp.CopyTo(newPath);
        }

        private void btnCopy_right_Click(object sender, EventArgs e)
        {

        }
    }
}
