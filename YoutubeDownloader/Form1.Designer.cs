
namespace YoutubeDownloader
{
    partial class Homepage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.txtBox_Link = new System.Windows.Forms.TextBox();
            this.lbl_Format = new System.Windows.Forms.Label();
            this.radBtn_Audio = new System.Windows.Forms.RadioButton();
            this.radBtn_Video = new System.Windows.Forms.RadioButton();
            this.lbl_SelectedLink = new System.Windows.Forms.Label();
            this.lbl_SelectedFormat = new System.Windows.Forms.Label();
            this.lbl_SelectedQuality = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Downloader";
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Link.Location = new System.Drawing.Point(65, 74);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(47, 23);
            this.lbl_Link.TabIndex = 2;
            this.lbl_Link.Text = "Link:";
            // 
            // txtBox_Link
            // 
            this.txtBox_Link.Location = new System.Drawing.Point(69, 117);
            this.txtBox_Link.Name = "txtBox_Link";
            this.txtBox_Link.Size = new System.Drawing.Size(409, 20);
            this.txtBox_Link.TabIndex = 4;
            this.txtBox_Link.TextChanged += new System.EventHandler(this.txtBox_Link_TextChanged);
            // 
            // lbl_Format
            // 
            this.lbl_Format.AutoSize = true;
            this.lbl_Format.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Format.Location = new System.Drawing.Point(65, 160);
            this.lbl_Format.Name = "lbl_Format";
            this.lbl_Format.Size = new System.Drawing.Size(120, 23);
            this.lbl_Format.TabIndex = 6;
            this.lbl_Format.Text = "Choose Format:";
            // 
            // radBtn_Audio
            // 
            this.radBtn_Audio.AutoSize = true;
            this.radBtn_Audio.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radBtn_Audio.Location = new System.Drawing.Point(149, 201);
            this.radBtn_Audio.Name = "radBtn_Audio";
            this.radBtn_Audio.Size = new System.Drawing.Size(66, 27);
            this.radBtn_Audio.TabIndex = 7;
            this.radBtn_Audio.TabStop = true;
            this.radBtn_Audio.Text = "Audio";
            this.radBtn_Audio.UseVisualStyleBackColor = true;
            this.radBtn_Audio.CheckedChanged += new System.EventHandler(this.radBtn_Audio_CheckedChanged);
            // 
            // radBtn_Video
            // 
            this.radBtn_Video.AutoSize = true;
            this.radBtn_Video.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radBtn_Video.Location = new System.Drawing.Point(71, 201);
            this.radBtn_Video.Name = "radBtn_Video";
            this.radBtn_Video.Size = new System.Drawing.Size(64, 27);
            this.radBtn_Video.TabIndex = 8;
            this.radBtn_Video.TabStop = true;
            this.radBtn_Video.Text = "Video";
            this.radBtn_Video.UseVisualStyleBackColor = true;
            this.radBtn_Video.CheckedChanged += new System.EventHandler(this.radBtn_Video_CheckedChanged);
            // 
            // lbl_SelectedLink
            // 
            this.lbl_SelectedLink.AutoSize = true;
            this.lbl_SelectedLink.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SelectedLink.ForeColor = System.Drawing.Color.Red;
            this.lbl_SelectedLink.Location = new System.Drawing.Point(115, 74);
            this.lbl_SelectedLink.Name = "lbl_SelectedLink";
            this.lbl_SelectedLink.Size = new System.Drawing.Size(0, 23);
            this.lbl_SelectedLink.TabIndex = 9;
            // 
            // lbl_SelectedFormat
            // 
            this.lbl_SelectedFormat.AutoSize = true;
            this.lbl_SelectedFormat.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SelectedFormat.ForeColor = System.Drawing.Color.Red;
            this.lbl_SelectedFormat.Location = new System.Drawing.Point(191, 160);
            this.lbl_SelectedFormat.Name = "lbl_SelectedFormat";
            this.lbl_SelectedFormat.Size = new System.Drawing.Size(0, 23);
            this.lbl_SelectedFormat.TabIndex = 10;
            this.lbl_SelectedFormat.Click += new System.EventHandler(this.lbl_SelectedFormat_Click);
            // 
            // lbl_SelectedQuality
            // 
            this.lbl_SelectedQuality.AutoSize = true;
            this.lbl_SelectedQuality.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SelectedQuality.ForeColor = System.Drawing.Color.Red;
            this.lbl_SelectedQuality.Location = new System.Drawing.Point(191, 247);
            this.lbl_SelectedQuality.Name = "lbl_SelectedQuality";
            this.lbl_SelectedQuality.Size = new System.Drawing.Size(0, 23);
            this.lbl_SelectedQuality.TabIndex = 11;
            this.lbl_SelectedQuality.Click += new System.EventHandler(this.lbl_SelectedQuality_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.BackColor = System.Drawing.Color.Black;
            this.btn_Download.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Download.ForeColor = System.Drawing.Color.Red;
            this.btn_Download.Location = new System.Drawing.Point(69, 273);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(413, 62);
            this.btn_Download.TabIndex = 12;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = false;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Progress.Location = new System.Drawing.Point(208, 397);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(185, 23);
            this.lbl_Progress.TabIndex = 13;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Title.Location = new System.Drawing.Point(69, 51);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(480, 23);
            this.lbl_Title.TabIndex = 14;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 383);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.lbl_SelectedQuality);
            this.Controls.Add(this.lbl_SelectedFormat);
            this.Controls.Add(this.lbl_SelectedLink);
            this.Controls.Add(this.radBtn_Video);
            this.Controls.Add(this.radBtn_Audio);
            this.Controls.Add(this.lbl_Format);
            this.Controls.Add(this.txtBox_Link);
            this.Controls.Add(this.lbl_Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Homepage";
            this.Text = "Youtube Video/Audio Downloader";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.TextBox txtBox_Link;
        private System.Windows.Forms.Label lbl_Format;
        private System.Windows.Forms.RadioButton radBtn_Audio;
        private System.Windows.Forms.RadioButton radBtn_Video;
        private System.Windows.Forms.Label lbl_SelectedLink;
        private System.Windows.Forms.Label lbl_SelectedFormat;
        private System.Windows.Forms.Label lbl_SelectedQuality;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Label lbl_Title;
    }
}

