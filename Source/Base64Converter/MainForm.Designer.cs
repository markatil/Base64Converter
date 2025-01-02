namespace Base64Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectBase64File = new System.Windows.Forms.Button();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comFileType = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGeneratedFilePath = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.tabBase64 = new System.Windows.Forms.TabControl();
            this.tText = new System.Windows.Forms.TabPage();
            this.btnPaste = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tFile = new System.Windows.Forms.TabPage();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tConvertToFile = new System.Windows.Forms.TabPage();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.picFileLoading = new System.Windows.Forms.PictureBox();
            this.tConvertToBase64 = new System.Windows.Forms.TabPage();
            this.picBase64Loading = new System.Windows.Forms.PictureBox();
            this.btnGenerateBase64 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBase64FilePath = new System.Windows.Forms.TextBox();
            this.txtBase64Text = new System.Windows.Forms.RichTextBox();
            this.panelControls.SuspendLayout();
            this.tabBase64.SuspendLayout();
            this.tText.SuspendLayout();
            this.tFile.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tConvertToFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileLoading)).BeginInit();
            this.tConvertToBase64.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBase64Loading)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base64 file path";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // btnSelectBase64File
            // 
            this.btnSelectBase64File.BackColor = System.Drawing.Color.White;
            this.btnSelectBase64File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectBase64File.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectBase64File.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectBase64File.Location = new System.Drawing.Point(414, 18);
            this.btnSelectBase64File.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectBase64File.Name = "btnSelectBase64File";
            this.btnSelectBase64File.Size = new System.Drawing.Size(51, 22);
            this.btnSelectBase64File.TabIndex = 2;
            this.btnSelectBase64File.Text = "...";
            this.btnSelectBase64File.UseVisualStyleBackColor = false;
            this.btnSelectBase64File.Click += new System.EventHandler(this.btnSelectBase64File_Click);
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGenerateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateFile.ForeColor = System.Drawing.Color.Snow;
            this.btnGenerateFile.Location = new System.Drawing.Point(390, 186);
            this.btnGenerateFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(105, 39);
            this.btnGenerateFile.TabIndex = 8;
            this.btnGenerateFile.Text = "Generate File";
            this.btnGenerateFile.UseVisualStyleBackColor = false;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save as file name";
            // 
            // comFileType
            // 
            this.comFileType.BackColor = System.Drawing.SystemColors.Window;
            this.comFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFileType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comFileType.FormattingEnabled = true;
            this.comFileType.Location = new System.Drawing.Point(347, 93);
            this.comFileType.Margin = new System.Windows.Forms.Padding(2);
            this.comFileType.Name = "comFileType";
            this.comFileType.Size = new System.Drawing.Size(70, 24);
            this.comFileType.TabIndex = 7;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(126, 93);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(217, 22);
            this.txtFileName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generated File Path";
            // 
            // txtGeneratedFilePath
            // 
            this.txtGeneratedFilePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGeneratedFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeneratedFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedFilePath.Location = new System.Drawing.Point(141, 131);
            this.txtGeneratedFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtGeneratedFilePath.Multiline = true;
            this.txtGeneratedFilePath.Name = "txtGeneratedFilePath";
            this.txtGeneratedFilePath.ReadOnly = true;
            this.txtGeneratedFilePath.Size = new System.Drawing.Size(344, 37);
            this.txtGeneratedFilePath.TabIndex = 100;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.tabBase64);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.txtFileName);
            this.panelControls.Controls.Add(this.txtGeneratedFilePath);
            this.panelControls.Controls.Add(this.comFileType);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Location = new System.Drawing.Point(2, 10);
            this.panelControls.Margin = new System.Windows.Forms.Padding(2);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(495, 172);
            this.panelControls.TabIndex = 10;
            // 
            // tabBase64
            // 
            this.tabBase64.Controls.Add(this.tText);
            this.tabBase64.Controls.Add(this.tFile);
            this.tabBase64.Location = new System.Drawing.Point(3, 3);
            this.tabBase64.Name = "tabBase64";
            this.tabBase64.SelectedIndex = 0;
            this.tabBase64.Size = new System.Drawing.Size(486, 77);
            this.tabBase64.TabIndex = 11;
            // 
            // tText
            // 
            this.tText.Controls.Add(this.txtBase64Text);
            this.tText.Controls.Add(this.btnPaste);
            this.tText.Controls.Add(this.label4);
            this.tText.Location = new System.Drawing.Point(4, 25);
            this.tText.Name = "tText";
            this.tText.Padding = new System.Windows.Forms.Padding(3);
            this.tText.Size = new System.Drawing.Size(478, 48);
            this.tText.TabIndex = 1;
            this.tText.Text = "Paste Base64 Text";
            this.tText.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Location = new System.Drawing.Point(416, 18);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(51, 22);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Base64 Text";
            // 
            // tFile
            // 
            this.tFile.Controls.Add(this.txtBase64FilePath);
            this.tFile.Controls.Add(this.btnSelectBase64File);
            this.tFile.Controls.Add(this.label1);
            this.tFile.Location = new System.Drawing.Point(4, 25);
            this.tFile.Name = "tFile";
            this.tFile.Padding = new System.Windows.Forms.Padding(3);
            this.tFile.Size = new System.Drawing.Size(478, 48);
            this.tFile.TabIndex = 0;
            this.tFile.Text = "Select Base64 Text File";
            this.tFile.UseVisualStyleBackColor = true;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tConvertToFile);
            this.tabMain.Controls.Add(this.tConvertToBase64);
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(505, 261);
            this.tabMain.TabIndex = 11;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
            // 
            // tConvertToFile
            // 
            this.tConvertToFile.Controls.Add(this.btnConfigure);
            this.tConvertToFile.Controls.Add(this.panelControls);
            this.tConvertToFile.Controls.Add(this.picFileLoading);
            this.tConvertToFile.Controls.Add(this.btnGenerateFile);
            this.tConvertToFile.Location = new System.Drawing.Point(4, 25);
            this.tConvertToFile.Name = "tConvertToFile";
            this.tConvertToFile.Padding = new System.Windows.Forms.Padding(3);
            this.tConvertToFile.Size = new System.Drawing.Size(497, 232);
            this.tConvertToFile.TabIndex = 0;
            this.tConvertToFile.Text = "Convert to File";
            this.tConvertToFile.UseVisualStyleBackColor = true;
            // 
            // btnConfigure
            // 
            this.btnConfigure.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfigure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnConfigure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigure.Image = global::Base64Converter.Properties.Resources.cog;
            this.btnConfigure.Location = new System.Drawing.Point(6, 194);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(25, 25);
            this.btnConfigure.TabIndex = 3;
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // picFileLoading
            // 
            this.picFileLoading.BackColor = System.Drawing.Color.Transparent;
            this.picFileLoading.Image = global::Base64Converter.Properties.Resources.loading;
            this.picFileLoading.Location = new System.Drawing.Point(331, 190);
            this.picFileLoading.Margin = new System.Windows.Forms.Padding(2);
            this.picFileLoading.Name = "picFileLoading";
            this.picFileLoading.Size = new System.Drawing.Size(30, 30);
            this.picFileLoading.TabIndex = 9;
            this.picFileLoading.TabStop = false;
            this.picFileLoading.Visible = false;
            // 
            // tConvertToBase64
            // 
            this.tConvertToBase64.Controls.Add(this.picBase64Loading);
            this.tConvertToBase64.Controls.Add(this.btnGenerateBase64);
            this.tConvertToBase64.Controls.Add(this.panel1);
            this.tConvertToBase64.Location = new System.Drawing.Point(4, 25);
            this.tConvertToBase64.Name = "tConvertToBase64";
            this.tConvertToBase64.Padding = new System.Windows.Forms.Padding(3);
            this.tConvertToBase64.Size = new System.Drawing.Size(497, 232);
            this.tConvertToBase64.TabIndex = 1;
            this.tConvertToBase64.Text = "Convert to Base64";
            this.tConvertToBase64.UseVisualStyleBackColor = true;
            // 
            // picBase64Loading
            // 
            this.picBase64Loading.BackColor = System.Drawing.Color.Transparent;
            this.picBase64Loading.Image = global::Base64Converter.Properties.Resources.loading;
            this.picBase64Loading.Location = new System.Drawing.Point(286, 193);
            this.picBase64Loading.Margin = new System.Windows.Forms.Padding(2);
            this.picBase64Loading.Name = "picBase64Loading";
            this.picBase64Loading.Size = new System.Drawing.Size(30, 30);
            this.picBase64Loading.TabIndex = 10;
            this.picBase64Loading.TabStop = false;
            this.picBase64Loading.Visible = false;
            // 
            // btnGenerateBase64
            // 
            this.btnGenerateBase64.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGenerateBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBase64.ForeColor = System.Drawing.Color.Snow;
            this.btnGenerateBase64.Location = new System.Drawing.Point(343, 186);
            this.btnGenerateBase64.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateBase64.Name = "btnGenerateBase64";
            this.btnGenerateBase64.Size = new System.Drawing.Size(150, 39);
            this.btnGenerateBase64.TabIndex = 7;
            this.btnGenerateBase64.Text = "Base64 to Clipboard";
            this.btnGenerateBase64.UseVisualStyleBackColor = false;
            this.btnGenerateBase64.Click += new System.EventHandler(this.btnGenerateBase64_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnSelectFile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 58);
            this.panel1.TabIndex = 6;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(83, 19);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(349, 22);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.White;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectFile.Location = new System.Drawing.Point(433, 19);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(25, 19);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "File path";
            // 
            // txtBase64FilePath
            // 
            this.txtBase64FilePath.Location = new System.Drawing.Point(119, 18);
            this.txtBase64FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtBase64FilePath.Name = "txtBase64FilePath";
            this.txtBase64FilePath.Size = new System.Drawing.Size(291, 22);
            this.txtBase64FilePath.TabIndex = 1;
            // 
            // txtBase64Text
            // 
            this.txtBase64Text.Location = new System.Drawing.Point(119, 18);
            this.txtBase64Text.Name = "txtBase64Text";
            this.txtBase64Text.Size = new System.Drawing.Size(291, 22);
            this.txtBase64Text.TabIndex = 3;
            this.txtBase64Text.Text = "";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(510, 266);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.tabBase64.ResumeLayout(false);
            this.tText.ResumeLayout(false);
            this.tText.PerformLayout();
            this.tFile.ResumeLayout(false);
            this.tFile.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tConvertToFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFileLoading)).EndInit();
            this.tConvertToBase64.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBase64Loading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnSelectBase64File;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comFileType;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGeneratedFilePath;
        private System.Windows.Forms.PictureBox picFileLoading;
        private System.Windows.Forms.Panel panelControls;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.TabControl tabBase64;
        private System.Windows.Forms.TabPage tFile;
        private System.Windows.Forms.TabPage tText;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tConvertToFile;
        private System.Windows.Forms.TabPage tConvertToBase64;
        private System.Windows.Forms.Button btnGenerateBase64;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBase64Loading;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.RichTextBox txtBase64Text;
        private System.Windows.Forms.TextBox txtBase64FilePath;
    }
}

