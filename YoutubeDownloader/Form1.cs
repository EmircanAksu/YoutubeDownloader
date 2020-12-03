using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using VideoLibrary;
using VideoLibrary.Exceptions;
using MediaToolkit;
using MediaToolkit.Model;


namespace YoutubeDownloader
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        public void txtBox_Link_TextChanged(object sender, EventArgs e)
        {
            lbl_SelectedLink.Text = txtBox_Link.Text;
        }

        private void lbl_SelectedFormat_Click(object sender, EventArgs e)
        {
            
        }

        private void radBtn_Video_CheckedChanged(object sender, EventArgs e)
        {
            lbl_SelectedFormat.Text = radBtn_Video.Text;
            
        }

        private void lbl_SelectedQuality_Click(object sender, EventArgs e)
        {
            
        }


        private void radBtn_Audio_CheckedChanged(object sender, EventArgs e)
        {
            lbl_SelectedFormat.Text = radBtn_Audio.Text;
        }

        public async void btn_Download_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog())
            {
                if(fdb.ShowDialog() == DialogResult.OK)
                {
                    if (radBtn_Video.Checked == true)
                    {
                        lbl_Progress.Text = "Downloading...";
                        lbl_Progress.ForeColor = Color.Red;
                        var youtube = YouTube.Default;
                        var video = await youtube.GetVideoAsync(txtBox_Link.Text);
                        lbl_Title.Text = video.Title;
                        File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());
                        lbl_Progress.Text = "Download Successful.";
                        lbl_Progress.ForeColor = Color.Green;
                    }
                    else if (radBtn_Audio.Checked == true)
                    {
                        lbl_Progress.Text = "Downloading...";
                        lbl_Progress.ForeColor = Color.Red;
                        var youtube = YouTube.Default;
                        var video = await youtube.GetVideoAsync(txtBox_Link.Text);
                        lbl_Title.Text = video.Title;
                        File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());
                        var inputFile = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" +  video.FullName };
                        var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3" };

                        using (var engine = new Engine())
                        {
                            engine.GetMetadata(inputFile);
                            engine.Convert(inputFile, outputFile);
                            File.Delete(inputFile.Filename);

                        }
                        lbl_Progress.Text = "Download Successful.";
                        lbl_Progress.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose Format! Video or Audio");
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose File Path!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_Progress_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
