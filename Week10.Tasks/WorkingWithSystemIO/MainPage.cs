using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithSystemIO
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string[] files;
        public string[] folders;
        public string directory;
        string openedFile;
        public Form()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
          
            if (folderBrowserDialogOpenFile.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialogOpenFile.SelectedPath))
            {
                directory = folderBrowserDialogOpenFile.SelectedPath;
                files = Directory.GetFiles(directory);
                folders = Directory.GetDirectories(directory);


                foreach (var item in folders)
                {
                    var name = Path.GetFileName(item);
                    dataGridViewFileTable.Rows.Add(name,"Folder");
                }
                foreach (var item in files)
                {
                    var name = Path.GetFileName(item);
                    var extension = Path.GetExtension(item);
                    // dataGridViewFileTable.Rows.Add(name.Split('.')[0], name.Split('.')[1]);//her columna uygun add elemek 
                    //dataGridViewFileTable.Rows.Add(name,"FILE is :    "+ extension);
                    dataGridViewFileTable.Rows.Add(name,"File");
                }
               
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFileName.Text))
            {
                string fileName = textBoxFileName.Text; // extension buna daxildir...
                string newfile = directory + "\\" + fileName;

                try
                {
                    if (!File.Exists(newfile) && !Directory.Exists(newfile))
                    {
                        FileStream fileStream = File.Create(newfile);
                        fileStream.Close();
                        dataGridViewFileTable.Rows.Add(fileName, "File");
                    }
                    else
                    {
                        MessageBox.Show("Same name of file or folder is already exist.");
                    }

                    textBoxFileName.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Give FILE name, it cannot be empty");

            }





        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFolderName.Text))
            {
                string folderName = textBoxFolderName.Text;
                string newFolder = directory + "\\" + folderName;
                try
                {
                    if (!Directory.Exists(newFolder))
                    {
                        Directory.CreateDirectory(newFolder);
                        dataGridViewFileTable.Rows.Add(folderName, "Folder");

                    }
                    else
                    {
                        MessageBox.Show("This folder is already exist.");
                    }
                    textBoxFolderName.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Give FOLDER name, it cannot be empty");
            }
            

        }

        private void dataGridViewFileTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewFileTable.Rows[e.RowIndex];
                openedFile = directory + "\\" + row.Cells["Name"].Value.ToString();

                if (File.Exists(openedFile))
                {
                  richTextBox1.LoadFile(openedFile,RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile(openedFile, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Changes saved in same file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
