namespace ZonderZorgenGit
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.ConnectionStatusLbl = new System.Windows.Forms.Label();
            this.ServerIpLbl = new System.Windows.Forms.Label();
            this.DatabaseLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserIdLbl = new System.Windows.Forms.Label();
            this.PortLbl = new System.Windows.Forms.Label();
            this.ServerIpTxtBx = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImg
            // 
            this.LogoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoImg.Cursor = System.Windows.Forms.Cursors.No;
            this.LogoImg.Image = ((System.Drawing.Image)(resources.GetObject("LogoImg.Image")));
            this.LogoImg.Location = new System.Drawing.Point(295, 15);
            this.LogoImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(333, 123);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 0;
            this.LogoImg.TabStop = false;
            // 
            // ConnectionStatusLbl
            // 
            this.ConnectionStatusLbl.AutoSize = true;
            this.ConnectionStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnectionStatusLbl.Location = new System.Drawing.Point(16, 532);
            this.ConnectionStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnectionStatusLbl.Name = "ConnectionStatusLbl";
            this.ConnectionStatusLbl.Size = new System.Drawing.Size(74, 25);
            this.ConnectionStatusLbl.TabIndex = 1;
            this.ConnectionStatusLbl.Text = "Status:";
            // 
            // ServerIpLbl
            // 
            this.ServerIpLbl.AutoSize = true;
            this.ServerIpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServerIpLbl.Location = new System.Drawing.Point(16, 171);
            this.ServerIpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIpLbl.Name = "ServerIpLbl";
            this.ServerIpLbl.Size = new System.Drawing.Size(99, 25);
            this.ServerIpLbl.TabIndex = 2;
            this.ServerIpLbl.Text = "Server IP:";
            // 
            // DatabaseLbl
            // 
            this.DatabaseLbl.AutoSize = true;
            this.DatabaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatabaseLbl.Location = new System.Drawing.Point(16, 210);
            this.DatabaseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatabaseLbl.Name = "DatabaseLbl";
            this.DatabaseLbl.Size = new System.Drawing.Size(104, 25);
            this.DatabaseLbl.TabIndex = 3;
            this.DatabaseLbl.Text = "DataBase:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordLbl.Location = new System.Drawing.Point(16, 289);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(104, 25);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password:";
            // 
            // UserIdLbl
            // 
            this.UserIdLbl.AutoSize = true;
            this.UserIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserIdLbl.Location = new System.Drawing.Point(16, 250);
            this.UserIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserIdLbl.Name = "UserIdLbl";
            this.UserIdLbl.Size = new System.Drawing.Size(83, 25);
            this.UserIdLbl.TabIndex = 5;
            this.UserIdLbl.Text = "User ID:";
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PortLbl.Location = new System.Drawing.Point(16, 329);
            this.PortLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(53, 25);
            this.PortLbl.TabIndex = 6;
            this.PortLbl.Text = "Port:";
            // 
            // ServerIpTxtBx
            // 
            this.ServerIpTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServerIpTxtBx.Location = new System.Drawing.Point(163, 167);
            this.ServerIpTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerIpTxtBx.Name = "ServerIpTxtBx";
            this.ServerIpTxtBx.Size = new System.Drawing.Size(197, 30);
            this.ServerIpTxtBx.TabIndex = 7;
            this.ServerIpTxtBx.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(163, 207);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "zonder_zorgen";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(163, 246);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 30);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "ZonderZorgen";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox4.Location = new System.Drawing.Point(163, 286);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 30);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.Location = new System.Drawing.Point(163, 325);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 30);
            this.textBox5.TabIndex = 11;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ServerIpTxtBx);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.UserIdLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.DatabaseLbl);
            this.Controls.Add(this.ServerIpLbl);
            this.Controls.Add(this.ConnectionStatusLbl);
            this.Controls.Add(this.LogoImg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginView";
            this.Text = "ZonderZorgen";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.Label ConnectionStatusLbl;
        private System.Windows.Forms.Label ServerIpLbl;
        private System.Windows.Forms.Label DatabaseLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UserIdLbl;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.TextBox ServerIpTxtBx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

