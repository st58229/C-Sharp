using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshrp_Semestralni_prace
{
    public class Interface
    {
        public delegate void UpdatedInterfaceEventHandler(object sender, EventArgs e);
        //private ref ImageList IconList { get; }
        private string Path_def { get; } = "C:/";

        /*LEFT*/
        private string Path_left { get; set; }
        private string SelectedFile_left { get; set; }
        private bool isFile_left { get; set; } = false;

        /*RIGHT*/
        private string Path_right { get; set; }
        private string SelectedFile_right { get; set; }
        private bool isFile_right { get; set; } = false;

        public event UpdatedInterfaceEventHandler UpdateInterface;

        /*public Interface(ref ImageList iList)
        {
            iconList = iList;            
        }*/

        private void OnUpdateInterfrace()
        {
            UpdateInterface?.Invoke(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
           
            OnUpdateInterfrace();
        }

        public void loadDirectory(ref ListView listView, ref RichTextBox richTextBox, string path, string selectedFile, ref bool isFile, ref ImageList iconList)
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
                        listView.Items.Add(files[i].Name, iconList.Images.Count - 1);
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
    }
}
