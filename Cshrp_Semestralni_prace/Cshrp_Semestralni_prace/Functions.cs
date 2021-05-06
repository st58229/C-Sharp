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

        private void LoadEnviroment()
        {
            List<DriveInfo> driveInfos = DriveInfo.GetDrives().ToList();

            driveInfos.ForEach(i =>
            {
                ComboBoxDriveLeft.Items.Add(i.Name);
                ComboBoxDriveRight.Items.Add(i.Name);
            });

            ComboBoxDriveLeft.SelectedIndex = 0;
            ComboBoxDriveRight.SelectedIndex = 0;

            driveLeft = driveInfos[0].Name;
            driveRight = driveInfos[0].Name;
        }

        private void RefreshSide(bool isLeft, bool reloadPath)
        {
            if (isLeft)
            {
                if (!reloadPath) pathLeft = PathtextBoxLeft.Text;
                fullPathLeft = driveLeft + pathLeft;
                PathtextBoxLeft.Text = pathLeft;
                LoadDirectory(listViewLeft, DetailsBoxLeft, fullPathLeft, selectedFileLeft, ref isFileLeft);
            }
            else 
            {
                if (!reloadPath) pathRight = PathtextBoxRight.Text;
                fullPathRight = driveRight + pathRight;
                PathtextBoxRight.Text = pathRight;
                LoadDirectory(listViewRight, DetailsBoxRight, fullPathRight, selectedFileRight, ref isFileRight);
            }
        }

        private void LoadDirectory(ListView listView, RichTextBox richTextBox, string path, string selectedFile, ref bool isFile)
        {
            bool isLeft = listView == listViewLeft;

            DirectoryInfo fileList;
            FileAttributes fileAtr;
            try
            {
                string tempFilePath;
                if (isFile)
                {
                    tempFilePath = path + @"\" + selectedFile;
                    FileInfo filedetails = new FileInfo(tempFilePath);
                    richTextBox.Text = filedetails.ToString();
                    fileAtr = File.GetAttributes(tempFilePath);              

                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAtr = File.GetAttributes(path);
                }

                if ((fileAtr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(path);                    

                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listView.Clear();                    

                    for (int i = 0; i < files.Length; i++)
                    {
                        iconList.Images.Add(Icon.ExtractAssociatedIcon(files[i].FullName));
                        listView.Items.Add(files[i].Name, iconList.Images.Count - 1);
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView.Items.Add(dirs[i].Name, 0);
                    }

                    LogHistory(isLeft, path);
                    RefreshHistoryInTab(isLeft);
                }
                else
                {
                    tempFilePath = path + @"\" + selectedFile;
                    LoadFileDetails(tempFilePath, richTextBox);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went wrong while refreshing.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (isLeft)
                {
                    Back(BackButtonLeft, PathtextBoxLeft, ref isFileLeft);
                    pathLeft = PathtextBoxLeft.Text;
                }
                else
                {
                    Back(BackButtonRight, PathtextBoxRight, ref isFileRight);
                    pathRight = PathtextBoxRight.Text;
                }
            }
        }       

        private void LogHistory(bool isLeft, string path)
        {
            if (path.Contains(@"\\")) path = path.Replace(@"\\", @"\");

            string logFile = isLeft ? LogFileLeft : LogFileRight;

            using (StreamWriter sw = File.AppendText(logFile))
            {
                sw.WriteLine(path);
            }         
        }

        private void RefreshHistoryInTab(bool isLeft)
        {
            string logFile = isLeft ? LogFileLeft : LogFileRight;
            ListBox historyBox = isLeft ? listBoxHistoryLeft : listBoxHistoryRight;

            using (StreamReader sr = File.OpenText(logFile))
            {
                historyBox.Items.Clear();
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    historyBox.Items.Add(s);
                }
            }
        }

        private void LoadFileDetails(string tempFilePath, RichTextBox richTextBox)
        {
            FileInfo filedetails = new FileInfo(tempFilePath);
            StringBuilder details = new StringBuilder();
            details.AppendLine("Name:\t\t" + filedetails.Name);
            details.AppendLine("Directory:\t\t" + filedetails.DirectoryName);
            details.AppendLine("Created:\t\t" + filedetails.CreationTimeUtc);
            details.AppendLine("Last acces:\t" + filedetails.LastAccessTimeUtc);
            details.AppendLine("Last write:\t" + filedetails.LastWriteTimeUtc);
            details.AppendLine("Size:\t\t" + ConvertSize(filedetails.Length));

            richTextBox.Text = details.ToString();
        }        

        private void ItemSelection(ListViewItemSelectionChangedEventArgs e, string fullPath, string path, ref string selectedFile, TextBox textBox, RichTextBox richTextBox, ref bool isFile)
        {

            selectedFile = e.Item.Text;
            string relativePath = @"\" + selectedFile;
            string tempFilePath = fullPath + relativePath;

            FileAttributes fileAttr = File.GetAttributes(tempFilePath);

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                path += relativePath;
                textBox.Text = path;                
            }
            else
            {                
                LoadFileDetails(tempFilePath, richTextBox);
                isFile = true;
            }

        }
        
        private void Back(object sender, TextBox textBox, ref bool isFile)
        {
            isFile = false;

            if (textBox.Text == "") return;

            bool isLeft = sender == BackButtonLeft;
            string path =  isLeft ? pathLeft : pathRight;
            string drive = isLeft ? driveLeft : driveRight;


            if (!textBox.Text.Contains(@"\"))
            {
                textBox.Text = path;
                MessageBox.Show("Wrong path.", "Something went wrong while going back.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            string parentPath = textBox.Text.Substring(0, textBox.Text.LastIndexOf(@"\"));

            if (Directory.Exists(drive + parentPath) || parentPath.Equals(""))
            {
                if (isLeft)
                {
                    pathLeft = parentPath;
                    RefreshSide(true, true);
                }
                else 
                {
                    pathRight = parentPath;
                    RefreshSide(false, true);
                }                       
            }
            else
            {
                textBox.Text = path;
                MessageBox.Show("Wrong path.", "Something went wrong while going back.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }     
        }
        
        private void RemoveFile(string dirPath, ref string selectedfile)
        {
            if (dirPath.Equals("") || dirPath == null || selectedfile.Equals("") || selectedfile == null) return;

            try
            {
                FileInfo temp = new FileInfo(dirPath+@"\"+selectedfile);
                string name = temp.Name;
                string message = $"Are you sure you want to delete {name}?";
                string title = "Confirmation";
                DialogResult res = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {
                    temp.Delete();                    
                    selectedfile = "";

                    isFileLeft = false;
                    RefreshSide(true, true);
                    isFileRight = false;
                    RefreshSide(false, true);
                }

            }
            catch (Exception e)                            
            {
                MessageBox.Show(e.Message, "Something went wrong while removing.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void RenameFile(string dirPath, ref string selectedfile)
        {
            if (dirPath.Equals("") || dirPath == null || selectedfile.Equals("") || selectedfile == null) return;

            try
            {
                FileInfo temp = new FileInfo(dirPath+@"\"+selectedfile);

                RenameFileForm dialog = new RenameFileForm(selectedfile);
                dialog.ShowDialog();

                if (dialog.NewName.Equals(selectedfile)) return;

                string newPath = dirPath+@"\"+ dialog.NewName;
                temp.MoveTo(newPath);
                selectedfile = dialog.NewName;

                isFileLeft = false;
                RefreshSide(true, true);
                isFileRight = false;
                RefreshSide(false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went wrong while renaming.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void MoveFile(string dirPath, ref string selectedfile, string newPath)
        {
            if (dirPath.Equals("") || dirPath == null || selectedfile.Equals("") || selectedfile == null) return;

            try
            {
                FileInfo temp = new FileInfo(dirPath+@"\"+selectedfile);

                temp.MoveTo(newPath+@"\"+selectedfile);                
                selectedfile = "";

                isFileLeft = false;
                RefreshSide(true, true);
                isFileRight = false;
                RefreshSide(false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went wrong while moving.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }          
        }
       
        private void CopyFile(string dirPath, string selectedfile, string newPath)
        {
            if (dirPath.Equals("") || dirPath == null || selectedfile.Equals("") || selectedfile == null) return;

            try
            {
                FileInfo temp = new FileInfo(dirPath + @"\" + selectedfile);
                temp.CopyTo(newPath + @"\" + selectedfile);

                isFileLeft = false;
                RefreshSide(true, true);
                isFileRight = false;
                RefreshSide(false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went wrong while copying.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
          
        }

        private void RefreshHistoryFromTab(object sender)
        {
            string fullPath = ((ListBox)sender).SelectedItem.ToString();

            bool isDrive = fullPath.LastIndexOf(@":\") == fullPath.Length;

            if (sender == listBoxHistoryLeft)
            {
                isFileLeft = false;

                if (isDrive) driveLeft = fullPath;
                else driveLeft = fullPath.Substring(0, fullPath.IndexOf(@"\") + 1);

                ComboBoxDriveLeft.SelectedItem = driveLeft;

                fullPathLeft = fullPath;

                if (fullPath != driveLeft) pathLeft = fullPath.Substring(fullPath.IndexOf(@"\"));
                else pathLeft = "";
                PathtextBoxLeft.Text = pathLeft;

                RefreshSide(true, false);
            }
            else 
            {
                isFileRight = false;

                if (isDrive) driveRight = fullPath;
                else driveRight = fullPath.Substring(0, fullPath.IndexOf(@"\") + 1);

                ComboBoxDriveRight.SelectedItem = driveRight;

                fullPathRight = fullPath;

                if (fullPath != driveRight) pathRight = fullPath.Substring(fullPath.IndexOf(@"\"));
                else pathRight = "";
                PathtextBoxRight.Text = pathRight;

                RefreshSide(false, false);
            }
        }

        // Delegované funkce
        
        private void TextBoxEnterHandler(object sender, KeyPressEventArgs e)
        {
            bool isLeft = sender == PathtextBoxLeft;

            if (e.KeyChar == (char)Keys.Enter)
            {
                string path = isLeft ? driveLeft + PathtextBoxLeft.Text : driveRight + PathtextBoxRight.Text; ;

                if (!Directory.Exists(path))
                {
                    ((TextBox)sender).Text = isLeft ? pathLeft : pathRight;
                    MessageBox.Show("Directory do not exist.", "Something went wrong while goint to new path.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }

                if (isLeft)
                { 
                    pathLeft = PathtextBoxLeft.Text;
                    isFileLeft = false;
                    selectedFileLeft = "";
                    RefreshSide(true, false);
                }
                else
                {
                    pathRight = PathtextBoxRight.Text;
                    isFileRight = false;
                    selectedFileRight = "";
                    RefreshSide(false, false);
                }                
            }
        }
        
        private void OpenHistoryDialog(object sender, EventArgs e)
        {
            string logFile = sender == HistoryMenuItemLeft ? LogFileLeft : LogFileRight;            

            HistoryForm dialog = new HistoryForm(logFile);
            dialog.ShowDialog();

            string fullPath = dialog.SelectedLog;
            if (fullPath.Equals("")) return;

            bool isDrive = fullPath.LastIndexOf(@":\") == fullPath.Length;

            if (logFile == LogFileLeft)
            {
                isFileLeft = false;

                if (isDrive) driveLeft = fullPath;
                else driveLeft = fullPath.Substring(0, fullPath.IndexOf(@"\") + 1);

                ComboBoxDriveLeft.SelectedItem = driveLeft;

                fullPathLeft = fullPath;

                if (fullPath != driveLeft) pathLeft = fullPath.Substring(fullPath.IndexOf(@"\"));
                else pathLeft = "";
                PathtextBoxLeft.Text = pathLeft;

                RefreshSide(true, false);
            }
            else 
            {
                isFileRight = false;

                if (isDrive) driveRight = fullPath;
                else driveRight = fullPath.Substring(0, fullPath.IndexOf(@"\") + 1);

                ComboBoxDriveRight.SelectedItem = driveRight;

                fullPathRight = fullPath;

                if (fullPath != driveRight) pathRight = fullPath.Substring(fullPath.IndexOf(@"\"));
                else pathRight = "";
                PathtextBoxRight.Text = pathRight;

                RefreshSide(false, false);
            }
        }
        
        private void RefreshDriveSelection(object sender, EventArgs e)
        {
            bool isLeft = sender == ComboBoxDriveLeft;

            List<DriveInfo> driveInfos = DriveInfo.GetDrives().ToList();

            foreach (DriveInfo drive in driveInfos)
            {
                if (drive.Name.Equals(((ComboBox)sender).SelectedItem.ToString()) && !drive.IsReady)
                {
                    ((ComboBox)sender).SelectedItem = isLeft ? driveLeft : driveRight;
                    MessageBox.Show("Drive is not ready.", "Something went wrong while goint to new path.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }

            if (isLeft)
            { 
                PathtextBoxLeft.Text = "";
                driveLeft = ((ComboBox)sender).SelectedItem.ToString();
                pathLeft = "";
                selectedFileLeft = "";
                isFileLeft = false;
                RefreshSide(true, false);
            }
            else
            { 
                PathtextBoxRight.Text = "";
                driveRight = ((ComboBox)sender).SelectedItem.ToString();
                pathRight = "";
                selectedFileRight = "";
                isFileRight = false;
                RefreshSide(false, false);
            }           
        }

        private void CleanHistory(object sender, EventArgs e)
        {
            bool isLeft = sender == CleanMenuItemLeft;
            string logFile = isLeft ? LogFileLeft : LogFileRight; 

            FileInfo history = new FileInfo(logFile);
            history.Delete();
            RefreshSide(isLeft, false);
        }
    }
}
