using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ConvertBase64ToFile
{
    public partial class MainForm : Form
    {
        string Content { get; set; }
        Util util = new Util();
        Util.ConvertTo convertTo;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            comFileType.SelectedIndex = 0;
            convertTo = Util.ConvertTo.File;
        }
        
        private void tabMain_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabMain.SelectedTab.Name)
            {
                case "tConvertToFile":
                    convertTo = Util.ConvertTo.File;
                    break;
                case "tConvertToBase64":
                    convertTo = Util.ConvertTo.Base64;
                    break;
                default:
                    break;
            }
        }
        
        private void IsLoading(bool isLoading)
        {
            picFileLoading.Invoke(new Action(() => { picFileLoading.Visible = isLoading; }));
            panelControls.Invoke(new Action(() => { panelControls.Enabled = !isLoading; }));
            btnGenerateFile.Invoke(new Action(() => { btnGenerateFile.Enabled = !isLoading; }));
        }

        private void ShowErrorMessage(string text)
        {
            IsLoading(false);
            MessageBox.Show(text, "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
        }

        private void ShowInformationMessage(string text)
        {
            IsLoading(false);
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelectBase64File_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                SetFilePath(ofdFile.FileName);
            }
        }

        private void SetFilePath(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) return;

            switch (convertTo)
            {
                case Util.ConvertTo.File:
                    txtBase64FilePath.Text = filePath;
                    txtFileName.Text = Path.GetFileNameWithoutExtension(filePath);
                    tabBase64.SelectedIndex = 0;
                    break;
                case Util.ConvertTo.Base64:
                    txtFilePath.Text = filePath;
                    break;
                default:
                    break;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofdFile.FileName;
            }
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            convertTo = Util.ConvertTo.File;
            bgWorker.RunWorkerAsync();
        }
        
        private void btnGenerateBase64_Click(object sender, EventArgs e)
        {
            convertTo = Util.ConvertTo.Base64;
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (convertTo)
            {
                case Util.ConvertTo.File:
                    ConverstionToFile();
                    break;
                case Util.ConvertTo.Base64:
                    ConversionToBase64();
                    break;
                default:
                    break;
            }            
        }
                
        void ConverstionToFile()
        {
            IsLoading(true);
            string fileName = string.Empty;
            string fileType = string.Empty;
            string filePath = string.Empty;
            string selectedTab = string.Empty;

            Invoke((Action)(() => {
                fileName = txtFileName.Text;
                fileType = comFileType.Text.ToLower();
                filePath = txtBase64FilePath.Text;
                selectedTab = tabBase64.SelectedTab.Name;
            }));

            switch (selectedTab)
            {
                case "tFile":

                    if (string.IsNullOrEmpty(filePath))
                    {
                        ShowErrorMessage("Please select a valid file");
                        return;
                    }

                    if (!File.Exists(filePath))
                    {
                        ShowErrorMessage("Invalid file path:  " + filePath);
                        return;
                    }

                    Content = File.ReadAllText(filePath);
                    
                    Invoke((Action)(() => { txtBase64Text.Text = string.Empty; }));


                    break;
                case "tText":

                    if (string.IsNullOrEmpty(filePath))
                    {
                        filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    }

                    break;
                default:
                    ShowErrorMessage("Unknown tab selected");
                    return;
            }
            
            if (string.IsNullOrEmpty(fileName))
            {
                ShowErrorMessage("Please enter a file name");
                return;
            }

            if (!fileName.Contains("."))
            {
                fileName = String.Format("{0}.{1}", fileName, fileType);
            }

            string base64String = util.GetBase64String(Content);

            string saveFilePath = Path.GetDirectoryName(filePath) + "\\" + fileName;
            saveFilePath = saveFilePath.Replace("\\\\", "\\");

            if (string.IsNullOrEmpty(base64String))
            {
                ShowErrorMessage("No valid base64String found");
                return;
            }

            try
            {
                util.ConvertBase64ToFile(saveFilePath, base64String);
                Process.Start(Path.GetDirectoryName(saveFilePath)); //Open folder
            }
            catch (Exception ex)
            {
                ShowErrorMessage(String.Format("Error Message: {0}", ex.Message));
                return;
            }

            txtGeneratedFilePath.Invoke(new Action(() => { txtGeneratedFilePath.Text = saveFilePath; }));

            IsLoading(false);
        }

        void ConversionToBase64()
        {
            string filePath = string.Empty;
            Invoke((Action)(() => { filePath = txtFilePath.Text; }));

            if (string.IsNullOrEmpty(filePath))
            {
                ShowErrorMessage("Please select a valid file");
                return;
            }

            if (!File.Exists(filePath))
            {
                ShowErrorMessage("Invalid file path:  " + filePath);
                return;
            }

            try
            {
                string base64 = util.ConvertFileToBase64(filePath);

                if (string.IsNullOrEmpty(base64))
                {
                    ShowErrorMessage("Oops ... Some thing went wrog");
                }

                Invoke((Action)(() => { Clipboard.SetText(base64); }));
            }
            catch(Exception ex)
            {
                ShowErrorMessage(String.Format("Error Message: {0}", ex.Message));
                return;
            }

            ShowInformationMessage("Base64 message copied to clipboard");

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (FileList.Length > 0)
            {
                SetFilePath(FileList[0]);
            }
        }        

        private void btnPaste_Click(object sender, EventArgs e)
        {
            Content = Clipboard.GetText();
            if (Content.Length > 500)
            {
                txtBase64Text.Text = "-- Long content copied to memory --";
            }
            else
            {
                txtBase64Text.Text = Content.Trim();
            }
        }

    }
}
