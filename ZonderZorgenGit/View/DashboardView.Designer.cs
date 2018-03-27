namespace ZonderZorgenGit.View
{
    partial class DashboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            this.LogoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImg
            // 
            this.LogoImg.BackColor = System.Drawing.Color.Transparent;
            this.LogoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoImg.Image = ((System.Drawing.Image)(resources.GetObject("LogoImg.Image")));
            this.LogoImg.Location = new System.Drawing.Point(1002, 12);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(250, 100);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 0;
            this.LogoImg.TabStop = false;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.LogoImg);
            this.Name = "DashboardView";
            this.Text = "ZonderZorgen";
            this.Load += new System.EventHandler(this.DashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImg;
    }
}