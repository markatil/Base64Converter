using System;
using System.IO;
using System.Windows.Forms;

namespace ConvertBase64ToFile
{
    public partial class ConfigureForm : Form
    {
        public ConfigureForm()
        {
            InitializeComponent();
        }
        
        private void ConfigureForm_Load(object sender, EventArgs e)
        {
            txtDefaultFolder.Text = Properties.Settings.Default.DefaultFolderToSave;

            txtFileType.Text = Properties.Settings.Default.FileTypes;

            cbRandoFileName.Checked = Properties.Settings.Default.RandomFileNameIfNotSpecified;

            var openGeneratedFileType = (Util.OpenGeneratedFileType)Enum.Parse(typeof(Util.OpenGeneratedFileType), Properties.Settings.Default.OpenGeneratedFileType);
                        
            switch (openGeneratedFileType)
            {
                case Util.OpenGeneratedFileType.Folder:
                    rbOpenFolder.Checked = true;
                    break;
                case Util.OpenGeneratedFileType.File:
                    rbOpenFile.Checked = true;
                    break;
                default:
                    rbNone.Checked = true;
                    break;
            }
        }

        private void btnSelectDefaultFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDefaultFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string folderPath = txtDefaultFolder.Text;

            if (!string.IsNullOrWhiteSpace(folderPath))
            {
                if (!Directory.Exists(folderPath))
                {
                    string errorMessage = string.Format("Invalid folder paht: {0}", folderPath);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Properties.Settings.Default.DefaultFolderToSave = folderPath;
            }

            Properties.Settings.Default.FileTypes = txtFileType.Text;
            Properties.Settings.Default.RandomFileNameIfNotSpecified = cbRandoFileName.Checked;

            if(rbOpenFolder.Checked)
                Properties.Settings.Default.OpenGeneratedFileType = Util.OpenGeneratedFileType.Folder.ToString();
            else if(rbOpenFile.Checked)
                Properties.Settings.Default.OpenGeneratedFileType = Util.OpenGeneratedFileType.File.ToString();
            else
                Properties.Settings.Default.OpenGeneratedFileType = Util.OpenGeneratedFileType.None.ToString();

            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

    }
}
