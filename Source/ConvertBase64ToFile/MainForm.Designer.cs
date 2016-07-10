namespace ConvertBase64ToFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comFileType = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGeneratedFilePath = new System.Windows.Forms.TextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base64 file path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(116, 17);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(305, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.White;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectFile.Location = new System.Drawing.Point(428, 17);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(25, 19);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Snow;
            this.btnGenerate.Location = new System.Drawing.Point(382, 143);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(72, 39);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save as file name";
            // 
            // comFileType
            // 
            this.comFileType.BackColor = System.Drawing.SystemColors.Window;
            this.comFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFileType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comFileType.FormattingEnabled = true;
            this.comFileType.Items.AddRange(new object[] {
            "Pdf",
            "Zip",
            "Gif"});
            this.comFileType.Location = new System.Drawing.Point(350, 50);
            this.comFileType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comFileType.Name = "comFileType";
            this.comFileType.Size = new System.Drawing.Size(70, 21);
            this.comFileType.TabIndex = 5;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(116, 50);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(230, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generated File Path";
            // 
            // txtGeneratedFilePath
            // 
            this.txtGeneratedFilePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGeneratedFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeneratedFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedFilePath.Location = new System.Drawing.Point(116, 88);
            this.txtGeneratedFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGeneratedFilePath.Multiline = true;
            this.txtGeneratedFilePath.Name = "txtGeneratedFilePath";
            this.txtGeneratedFilePath.ReadOnly = true;
            this.txtGeneratedFilePath.Size = new System.Drawing.Size(340, 37);
            this.txtGeneratedFilePath.TabIndex = 8;
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.Transparent;
            this.picLoading.Image = global::ConvertBase64ToFile.Properties.Resources.Spinner;
            this.picLoading.Location = new System.Drawing.Point(334, 150);
            this.picLoading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(26, 24);
            this.picLoading.TabIndex = 9;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.txtFileName);
            this.panelControls.Controls.Add(this.txtGeneratedFilePath);
            this.panelControls.Controls.Add(this.comFileType);
            this.panelControls.Controls.Add(this.txtFilePath);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.btnSelectFile);
            this.panelControls.Location = new System.Drawing.Point(4, 4);
            this.panelControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(465, 133);
            this.panelControls.TabIndex = 10;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(476, 188);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panelControls);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Convert Base64 To File";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comFileType;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGeneratedFilePath;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Panel panelControls;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

