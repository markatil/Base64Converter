using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertBase64ToFile
{
    public partial class MainForm : Form
    {
        private string Content { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            comFileType.SelectedIndex = 0;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                SetFilePath(ofdFile.FileName);
            }
        }

        private void SetFilePath(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                txtFilePath.Text = filePath;
                txtFileName.Text = Path.GetFileNameWithoutExtension(filePath);
                string fileText = File.ReadAllText(filePath);
                if (fileText.IndexOf(@"""zip""", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    comFileType.SelectedItem = "Zip";
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            bgWorker.RunWorkerAsync();
        }


        private string GetLongestMatchingString(string xmlString)
        {
            if (string.IsNullOrWhiteSpace(xmlString))
            {
                return xmlString;
            }

            string longestString = string.Empty;
            int longestStringLength = 0;
                        
            xmlString = Regex.Replace(xmlString, @"\t|\n|\r|\s+", "");

            Regex rx = new Regex(@"(?<=\>)(.*?)(?=\<)");

            foreach (Match match in rx.Matches(xmlString))
            {
                if (match.Value.Length > longestStringLength)
                {
                    longestString = match.Value;
                    longestStringLength = match.Value.Length;
                }
            }

            if (string.IsNullOrWhiteSpace(xmlString))
            {
                //If we reach here then input sting is not xml and therefore returning input string
                return xmlString;
            }

            return longestString;

        }

        private void IsLoading(bool isLoading)
        {
            picLoading.Invoke(new Action(() => { picLoading.Visible = isLoading; }));
            panelControls.Invoke(new Action(() => { panelControls.Enabled = !isLoading; }));
            btnGenerate.Invoke(new Action(() => { btnGenerate.Enabled = !isLoading; }));
        }

        private void ShowErrorMessage(string text)
        {
            IsLoading(false);
            MessageBox.Show(text, "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IsLoading(true);
            string fileName = string.Empty;
            string fileType = string.Empty;
            string filePath = string.Empty;
            string selectedTab = string.Empty;
            
            txtFileName.Invoke(new Action(() => {
                fileName = txtFileName.Text;
                fileType = comFileType.Text.ToLower();
                filePath = txtFilePath.Text;
                selectedTab = tabBase64.SelectedTab.Text;
            }));

            switch (selectedTab)
            {
                case "File":

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
                    txtBase64Text.Invoke(new Action(() => {txtBase64Text.Text = string.Empty;}));
                    

                    break;
                case "Text":
                    
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
            
            string base64String = GetLongestMatchingString(Content);
            
            string saveFilePath = Path.GetDirectoryName(filePath) + "\\" + fileName;
            saveFilePath = saveFilePath.Replace("\\\\","\\");

            if (string.IsNullOrEmpty(base64String))
            {
                ShowErrorMessage("No valid base64String found");
                return;
            }

            try
            {
                File.WriteAllBytes(saveFilePath, Convert.FromBase64String(base64String));
            }catch(Exception ex)
            {
                ShowErrorMessage(String.Format("Error Message: {0}", ex.Message));
                return;
            }

            

            txtGeneratedFilePath.Invoke(new Action(() => { txtGeneratedFilePath.Text = saveFilePath; }));
            
            IsLoading(false);
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (FileList.Length > 0)
            {
                SetFilePath(FileList[0]);
                tabBase64.SelectedIndex = 0;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
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
