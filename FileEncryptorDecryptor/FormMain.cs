using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace File_Encryptor_Decryptor
{
    public partial class FormMain : Form
    {
        private string[] _fileNames;
        private bool nonEmptyKey = false;
        private bool targetFilesExistence = false;

        private string encryptDecryptText(string fileName)
        {
            string key = keyBox.Text;
            string retValue = "";
            string text = File.ReadAllText(fileName);
            int i = 0;
            int x = 0;

            int[] cipher = new int[text.Length];
            x = 0;

            for (i = 0; i < text.Length; i++)
            {
                retValue = retValue + (char)((text[i] ^ key[x]));
                cipher[i] = (text[i] ^ key[x]);
                x++;

                if (x >= key.Length)
                    x = 0;
            }
            return retValue;
        }

        private byte[] encryptDecryptBinary(string fileName)
        {
            byte[] fileBytes = File.ReadAllBytes(fileName);
            byte[] keyBytes = Encoding.Default.GetBytes(keyBox.Text);
            for (Int32 i = 0; i < fileBytes.Length - 1; i++)
            {
                fileBytes[i] ^= keyBytes[i % keyBytes.Length];
            }
            return fileBytes;
        }


        public FormMain()
        {
            InitializeComponent();
            targetFileDialog.Filter = "All Files|*.*";
            targetFileDialog.Multiselect = true;

        }

        private void openFilesDialog_FileOkClick(object sender, CancelEventArgs e)
        {

        }

        private void openFileButtonClick(object sender, EventArgs e)
        {

            DialogResult result = targetFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this._fileNames = targetFileDialog.FileNames;
                targetFilesExistence = true;
                openFilesButton.BackColor = System.Drawing.Color.ForestGreen;
                saveFilesButton.Enabled = nonEmptyKey && targetFilesExistence;
            }
        }

        private void saveFileButtonClick(object sender, EventArgs e)
        {
            DialogResult result = destinationFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string fileName in this._fileNames)
                {
                    if (fileName.EndsWith(".txt"))
                    {
                        string xoredText = encryptDecryptText(fileName);
                        File.WriteAllText(Path.Combine(destinationFolderDialog.SelectedPath, Path.GetFileName(fileName)), xoredText);
                    }
                    else
                    {
                        byte[] xoredBytes = encryptDecryptBinary(fileName);
                        FileStream file = File.Open(Path.Combine(destinationFolderDialog.SelectedPath, Path.GetFileName(fileName)), FileMode.Create);
                        file.Write(xoredBytes, 0, xoredBytes.Length);
                        file.Close();
                    }
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            keyBox.UseSystemPasswordChar = !keyBox.UseSystemPasswordChar;
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            this._fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
            targetFilesExistence = _fileNames != null && _fileNames.Length > 0;
            openFilesButton.BackColor = System.Drawing.Color.ForestGreen;
            saveFilesButton.Enabled = nonEmptyKey && targetFilesExistence;
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {
            nonEmptyKey = keyBox.Text.Length > 0;
            saveFilesButton.Enabled = nonEmptyKey && targetFilesExistence;
        }
    }
}
