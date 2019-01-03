namespace WavToMP3
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
            this.TotalFiles = new System.Windows.Forms.TextBox();
            this.SaveFilesPath = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OpenWavFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveMP3FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BitrateComboBox = new System.Windows.Forms.ComboBox();
            this.SamplingrateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalFiles
            // 
            this.TotalFiles.Enabled = false;
            this.TotalFiles.Location = new System.Drawing.Point(12, 12);
            this.TotalFiles.Name = "TotalFiles";
            this.TotalFiles.ReadOnly = true;
            this.TotalFiles.Size = new System.Drawing.Size(720, 20);
            this.TotalFiles.TabIndex = 0;
            // 
            // SaveFilesPath
            // 
            this.SaveFilesPath.Enabled = false;
            this.SaveFilesPath.Location = new System.Drawing.Point(12, 58);
            this.SaveFilesPath.Name = "SaveFilesPath";
            this.SaveFilesPath.ReadOnly = true;
            this.SaveFilesPath.Size = new System.Drawing.Size(720, 20);
            this.SaveFilesPath.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(747, 10);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 40);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(747, 56);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(75, 38);
            this.SaveAsButton.TabIndex = 3;
            this.SaveAsButton.Text = "Save location";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(747, 100);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OpenWavFilesDialog
            // 
            this.OpenWavFilesDialog.Filter = "WAV Files|*.wav|MP3|*.mp3";
            this.OpenWavFilesDialog.Multiselect = true;
            // 
            // SaveMP3FolderBrowserDialog
            // 
            this.SaveMP3FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // BitrateComboBox
            // 
            this.BitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitrateComboBox.FormattingEnabled = true;
            this.BitrateComboBox.Items.AddRange(new object[] {
            "32",
            "40",
            "48",
            "56",
            "64",
            "80",
            "96",
            "112",
            "128",
            "144",
            "160"});
            this.BitrateComboBox.Location = new System.Drawing.Point(168, 102);
            this.BitrateComboBox.Name = "BitrateComboBox";
            this.BitrateComboBox.Size = new System.Drawing.Size(121, 21);
            this.BitrateComboBox.TabIndex = 5;
            // 
            // SamplingrateComboBox
            // 
            this.SamplingrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SamplingrateComboBox.FormattingEnabled = true;
            this.SamplingrateComboBox.Items.AddRange(new object[] {
            "16",
            "22.05",
            "24",
            "32",
            "44.1"});
            this.SamplingrateComboBox.Location = new System.Drawing.Point(480, 102);
            this.SamplingrateComboBox.Name = "SamplingrateComboBox";
            this.SamplingrateComboBox.Size = new System.Drawing.Size(121, 21);
            this.SamplingrateComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bitrate (Kbps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sampling Rate (KHz)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(720, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(720, 187);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(12, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(720, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Download Audio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SamplingrateComboBox);
            this.Controls.Add(this.BitrateComboBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.SaveFilesPath);
            this.Controls.Add(this.TotalFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wav To MP3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalFiles;
        private System.Windows.Forms.TextBox SaveFilesPath;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.OpenFileDialog OpenWavFilesDialog;
        private System.Windows.Forms.FolderBrowserDialog SaveMP3FolderBrowserDialog;
        private System.Windows.Forms.ComboBox BitrateComboBox;
        private System.Windows.Forms.ComboBox SamplingrateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

