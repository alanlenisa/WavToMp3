using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace WavToMP3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Wav2Mp3 v1.9";
            textBox2.Text = "https://www.youtube.com/watch?v=t-hTrgAJXTs";
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (OpenWavFilesDialog.ShowDialog() == DialogResult.OK)
            {
                TotalFiles.Text = "Total Files = "+OpenWavFilesDialog.FileNames.Length.ToString();
            }
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            if (SaveMP3FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            { 
            SaveFilesPath.Text=SaveMP3FolderBrowserDialog.SelectedPath.ToString();
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (OpenWavFilesDialog.FileNames.Length > 0 && SaveMP3FolderBrowserDialog.SelectedPath != "")
            {
                progressBar1.Visible = true;
                BrowseButton.Enabled = false;
                SaveAsButton.Enabled = false;
                BitrateComboBox.Enabled = false;
                SamplingrateComboBox.Enabled = false;
                ConvertButton.Enabled = false;
                try
                {
                    progressBar1.Maximum = OpenWavFilesDialog.FileNames.Length;
                    textBox1.Text = "-";
                    foreach (string  fn in OpenWavFilesDialog.FileNames)
                    {
                        
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.UseShellExecute = false;
                        psi.CreateNoWindow = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        psi.RedirectStandardError = true;    
                        psi.FileName = Application.StartupPath + @"\lame.exe";
                        psi.Arguments = "-b" + BitrateComboBox.SelectedItem.ToString() + " --resample " + SamplingrateComboBox.SelectedItem.ToString() + " -m j " +
                                       "\"" + fn + "\"" + " " +
                                        "" + "--priority 3" +  " " +
                                        "\"" + SaveFilesPath.Text + "\\" + Path.GetFileNameWithoutExtension(fn)+".mp3" + "\"";
                        Process p = Process.Start(psi);
                        //string stdoutx = p.StandardOutput.ReadToEnd();
                        string stderrx = p.StandardError.ReadToEnd();
                        textBox1.Text = textBox1.Text + "\n\r" + stderrx;
                        p.WaitForExit();
                        p.Close();
                        p.Dispose();
                        progressBar1.Value = progressBar1.Value + 1;
                        Thread.Sleep(1000);
                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                           
                            MessageBox.Show(OpenWavFilesDialog.FileNames.Length + " File(s) Converted Successfully", "Success");
                            progressBar1.Visible = false;
                            progressBar1.Value = 0;
                            TotalFiles.Clear();
                            BrowseButton.Enabled = true;
                            SaveFilesPath.Clear();
                            SaveAsButton.Enabled = true;
                            BitrateComboBox.Enabled = true;
                            SamplingrateComboBox.Enabled = true;
                            ConvertButton.Enabled = true;
                            OpenWavFilesDialog.Reset();
                            SaveMP3FolderBrowserDialog.Reset();
                        }
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            { 
            
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BitrateComboBox.SelectedIndex = 8;
            SamplingrateComboBox.SelectedIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             button1.Enabled = false;
             button2.Enabled = false;

            try
            {
                SaveVideoToDisk(textBox2.Text);
            }
            finally
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

            MessageBox.Show("Operazione completata!");
        }
        String SaveVideoToDisk(string link)
        {
            var youTube = VideoLibrary.YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video
            String videoTmp = @"C:\temp\" + video.FullName;
            File.WriteAllBytes(videoTmp, video.GetBytes());
            //string videoTmp =@"c:\temp\Che cos'è la vera ricchezza_ - YouTube.mp4";
            return videoTmp;
            

        }

        void extractAudio(string file)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardError = true;
            psi.FileName = Application.StartupPath + @"\ffmpeg.exe";
            psi.Arguments = " -i \"" + file +"\" -vn -b:a 128k -c:a libmp3lame " +
                            "\"" + SaveFilesPath.Text + "\\" + Path.GetFileNameWithoutExtension(file) + ".mp3" + "\"";
            Process p = Process.Start(psi);
            //string stdoutx = p.StandardOutput.ReadToEnd();
            string stderrx = p.StandardError.ReadToEnd();
            textBox1.Text = textBox1.Text + "\n\r" + stderrx;
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SaveFilesPath.Text == "")
                MessageBox.Show("Selezionare un percorso di salvataggio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;

                try
                {
                    extractAudio(SaveVideoToDisk(textBox2.Text));
                }
                finally
                {
                  button1.Enabled = true;
                  button2.Enabled = true;

                }
                MessageBox.Show("Operazione completata!");
            }
        }

    //     m_process.ErrorDataReceived += this.ErrorDataHandler;
    //    m_process.OutputDataReceived += this.OutputDataHandler;

    //    m_process.BeginErrorReadLine();
    //    m_process.BeginOutputReadLine();

    //    m_process.Start();

    //    m_processExited.WaitOne();
    //}

    //private void ErrorDataHandler(object sender, DataReceivedEventArgs args)
    //{
    //    string message = args.Data;

    //    if (message.StartsWith("Error"))
    //    {
    //        // The vsinstr.exe process reported an error
    //        m_errorMessages.Add(message);
    //    }
    //}
    }
}