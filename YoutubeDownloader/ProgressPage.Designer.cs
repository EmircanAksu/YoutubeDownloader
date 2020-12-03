
namespace YoutubeDownloader
{
    partial class ProgressPage
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
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Progress.Location = new System.Drawing.Point(185, 71);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(70, 21);
            this.lbl_Progress.TabIndex = 14;
            this.lbl_Progress.Text = "Progress";
            this.lbl_Progress.Click += new System.EventHandler(this.lbl_Progress_Click);
            // 
            // ProgressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 184);
            this.Controls.Add(this.lbl_Progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressPage";
            this.Text = "ProgressPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Progress;
    }
}