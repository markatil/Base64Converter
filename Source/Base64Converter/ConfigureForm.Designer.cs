namespace Base64Converter
{
    partial class ConfigureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefaultFolder = new System.Windows.Forms.TextBox();
            this.btnSelectDefaultFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbOpenFile = new System.Windows.Forms.RadioButton();
            this.rbOpenFolder = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbRandoFileName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default Save To Folder";
            // 
            // txtDefaultFolder
            // 
            this.txtDefaultFolder.Location = new System.Drawing.Point(9, 35);
            this.txtDefaultFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtDefaultFolder.Name = "txtDefaultFolder";
            this.txtDefaultFolder.Size = new System.Drawing.Size(362, 20);
            this.txtDefaultFolder.TabIndex = 3;
            // 
            // btnSelectDefaultFolder
            // 
            this.btnSelectDefaultFolder.BackColor = System.Drawing.Color.White;
            this.btnSelectDefaultFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDefaultFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDefaultFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectDefaultFolder.Location = new System.Drawing.Point(374, 36);
            this.btnSelectDefaultFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectDefaultFolder.Name = "btnSelectDefaultFolder";
            this.btnSelectDefaultFolder.Size = new System.Drawing.Size(25, 19);
            this.btnSelectDefaultFolder.TabIndex = 4;
            this.btnSelectDefaultFolder.Text = "...";
            this.btnSelectDefaultFolder.UseVisualStyleBackColor = false;
            this.btnSelectDefaultFolder.Click += new System.EventHandler(this.btnSelectDefaultFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "After file created";
            // 
            // rbOpenFile
            // 
            this.rbOpenFile.AutoSize = true;
            this.rbOpenFile.Location = new System.Drawing.Point(111, 158);
            this.rbOpenFile.Name = "rbOpenFile";
            this.rbOpenFile.Size = new System.Drawing.Size(70, 17);
            this.rbOpenFile.TabIndex = 6;
            this.rbOpenFile.TabStop = true;
            this.rbOpenFile.Text = "Open File";
            this.rbOpenFile.UseVisualStyleBackColor = true;
            // 
            // rbOpenFolder
            // 
            this.rbOpenFolder.AutoSize = true;
            this.rbOpenFolder.Location = new System.Drawing.Point(9, 158);
            this.rbOpenFolder.Name = "rbOpenFolder";
            this.rbOpenFolder.Size = new System.Drawing.Size(83, 17);
            this.rbOpenFolder.TabIndex = 7;
            this.rbOpenFolder.TabStop = true;
            this.rbOpenFolder.Text = "Open Folder";
            this.rbOpenFolder.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(318, 178);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbRandoFileName
            // 
            this.cbRandoFileName.AutoSize = true;
            this.cbRandoFileName.Location = new System.Drawing.Point(9, 112);
            this.cbRandoFileName.Name = "cbRandoFileName";
            this.cbRandoFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRandoFileName.Size = new System.Drawing.Size(182, 17);
            this.cbRandoFileName.TabIndex = 9;
            this.cbRandoFileName.Text = "Random file name if not specified";
            this.cbRandoFileName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Type (comma seperated value)";
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(9, 84);
            this.txtFileType.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(362, 20);
            this.txtFileType.TabIndex = 11;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(200, 158);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 12;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(405, 211);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRandoFileName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbOpenFolder);
            this.Controls.Add(this.rbOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDefaultFolder);
            this.Controls.Add(this.btnSelectDefaultFolder);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefaultFolder;
        private System.Windows.Forms.Button btnSelectDefaultFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOpenFile;
        private System.Windows.Forms.RadioButton rbOpenFolder;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox cbRandoFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.RadioButton rbNone;
    }
}