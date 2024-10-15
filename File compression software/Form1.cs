using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace File_compression_software
{
    public partial class Form1 : Form
    {
        private string selectedFilesPath; 
        private string zipFilePath; 
        private string unzipFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilesPath = Path.GetDirectoryName(openFileDialog.FileNames[0]);
                    txtZipPath.Text = selectedFilesPath;
                }
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputZipFile = folderBrowserDialog.SelectedPath + "\\compressed.zip";

                    try
                    {
                        ZipFile.CreateFromDirectory(selectedFilesPath, outputZipFile);
                        MessageBox.Show("Я ваши файлы в зипку затолкал", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtZipPath.Text = outputZipFile;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сжатии: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ZIP файлы (*.zip)|*.zip";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    zipFilePath = openFileDialog.FileName;
                    txtUnzipPath.Text = zipFilePath;

                    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                    {
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            unzipFolderPath = folderBrowserDialog.SelectedPath;

                            try
                            {
                                ZipFile.ExtractToDirectory(zipFilePath, unzipFolderPath);
                                MessageBox.Show("Я твои файлы раскпаковал!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при распаковке: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
