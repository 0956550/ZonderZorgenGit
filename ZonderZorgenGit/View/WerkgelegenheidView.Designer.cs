namespace ZonderZorgenGit.View
{
    partial class WerkgelegenheidView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WerkgelegenheidView));
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.DoctorImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImg
            // 
            this.LogoImg.Image = ((System.Drawing.Image)(resources.GetObject("LogoImg.Image")));
            this.LogoImg.Location = new System.Drawing.Point(1052, 12);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(200, 70);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 0;
            this.LogoImg.TabStop = false;
            // 
            // DoctorImg
            // 
            this.DoctorImg.Image = ((System.Drawing.Image)(resources.GetObject("DoctorImg.Image")));
            this.DoctorImg.Location = new System.Drawing.Point(1052, 467);
            this.DoctorImg.Name = "DoctorImg";
            this.DoctorImg.Size = new System.Drawing.Size(200, 250);
            this.DoctorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorImg.TabIndex = 1;
            this.DoctorImg.TabStop = false;
            // 
            // WerkgelegenheidView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.DoctorImg);
            this.Controls.Add(this.LogoImg);
            this.Name = "WerkgelegenheidView";
            this.Text = "ZonderZorgen";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.PictureBox DoctorImg;
    }
}