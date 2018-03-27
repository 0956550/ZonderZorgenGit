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
            this.DatabaseTxtBx = new System.Windows.Forms.TextBox();
            this.UserIdTxtBx = new System.Windows.Forms.TextBox();
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.PortTxtBx = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImg
            // 
            this.LogoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoImg.Cursor = System.Windows.Forms.Cursors.No;
            this.LogoImg.Image = ((System.Drawing.Image)(resources.GetObject("LogoImg.Image")));
            this.LogoImg.Location = new System.Drawing.Point(221, 12);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(250, 100);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 0;
            this.LogoImg.TabStop = false;
            // 
            // ConnectionStatusLbl
            // 
            this.ConnectionStatusLbl.AutoSize = true;
            this.ConnectionStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnectionStatusLbl.Location = new System.Drawing.Point(12, 432);
            this.ConnectionStatusLbl.Name = "ConnectionStatusLbl";
            this.ConnectionStatusLbl.Size = new System.Drawing.Size(60, 20);
            this.ConnectionStatusLbl.TabIndex = 1;
            this.ConnectionStatusLbl.Text = "Status:";
            // 
            // ServerIpLbl
            // 
            this.ServerIpLbl.AutoSize = true;
            this.ServerIpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServerIpLbl.Location = new System.Drawing.Point(12, 135);
            this.ServerIpLbl.Name = "ServerIpLbl";
            this.ServerIpLbl.Size = new System.Drawing.Size(78, 20);
            this.ServerIpLbl.TabIndex = 2;
            this.ServerIpLbl.Text = "Server IP:";
            // 
            // DatabaseLbl
            // 
            this.DatabaseLbl.AutoSize = true;
            this.DatabaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatabaseLbl.Location = new System.Drawing.Point(12, 167);
            this.DatabaseLbl.Name = "DatabaseLbl";
            this.DatabaseLbl.Size = new System.Drawing.Size(83, 20);
            this.DatabaseLbl.TabIndex = 3;
            this.DatabaseLbl.Text = "Database:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordLbl.Location = new System.Drawing.Point(12, 231);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(82, 20);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password:";
            // 
            // UserIdLbl
            // 
            this.UserIdLbl.AutoSize = true;
            this.UserIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserIdLbl.Location = new System.Drawing.Point(12, 199);
            this.UserIdLbl.Name = "UserIdLbl";
            this.UserIdLbl.Size = new System.Drawing.Size(68, 20);
            this.UserIdLbl.TabIndex = 5;
            this.UserIdLbl.Text = "User ID:";
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PortLbl.Location = new System.Drawing.Point(12, 263);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(42, 20);
            this.PortLbl.TabIndex = 6;
            this.PortLbl.Text = "Port:";
            // 
            // ServerIpTxtBx
            // 
            this.ServerIpTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServerIpTxtBx.Location = new System.Drawing.Point(122, 132);
            this.ServerIpTxtBx.Name = "ServerIpTxtBx";
            this.ServerIpTxtBx.Size = new System.Drawing.Size(149, 26);
            this.ServerIpTxtBx.TabIndex = 7;
            this.ServerIpTxtBx.Text = "127.0.0.1";
            // 
            // DatabaseTxtBx
            // 
            this.DatabaseTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatabaseTxtBx.Location = new System.Drawing.Point(122, 164);
            this.DatabaseTxtBx.Name = "DatabaseTxtBx";
            this.DatabaseTxtBx.Size = new System.Drawing.Size(149, 26);
            this.DatabaseTxtBx.TabIndex = 8;
            this.DatabaseTxtBx.Text = "zonder_zorgen";
            // 
            // UserIdTxtBx
            // 
            this.UserIdTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserIdTxtBx.Location = new System.Drawing.Point(122, 196);
            this.UserIdTxtBx.Name = "UserIdTxtBx";
            this.UserIdTxtBx.Size = new System.Drawing.Size(149, 26);
            this.UserIdTxtBx.TabIndex = 9;
            this.UserIdTxtBx.Text = "ZonderZorgen";
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTxtBx.Location = new System.Drawing.Point(122, 228);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.PasswordChar = '*';
            this.PasswordTxtBx.Size = new System.Drawing.Size(149, 26);
            this.PasswordTxtBx.TabIndex = 10;
            // 
            // PortTxtBx
            // 
            this.PortTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PortTxtBx.Location = new System.Drawing.Point(122, 260);
            this.PortTxtBx.Name = "PortTxtBx";
            this.PortTxtBx.Size = new System.Drawing.Size(149, 26);
            this.PortTxtBx.TabIndex = 11;
            this.PortTxtBx.Text = "3306";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnectBtn.Location = new System.Drawing.Point(16, 343);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(111, 34);
            this.ConnectBtn.TabIndex = 12;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DisconnectBtn.Location = new System.Drawing.Point(133, 343);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(111, 34);
            this.DisconnectBtn.TabIndex = 13;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.PortTxtBx);
            this.Controls.Add(this.PasswordTxtBx);
            this.Controls.Add(this.UserIdTxtBx);
            this.Controls.Add(this.DatabaseTxtBx);
            this.Controls.Add(this.ServerIpTxtBx);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.UserIdLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.DatabaseLbl);
            this.Controls.Add(this.ServerIpLbl);
            this.Controls.Add(this.ConnectionStatusLbl);
            this.Controls.Add(this.LogoImg);
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
        private System.Windows.Forms.TextBox DatabaseTxtBx;
        private System.Windows.Forms.TextBox UserIdTxtBx;
        private System.Windows.Forms.TextBox PasswordTxtBx;
        private System.Windows.Forms.TextBox PortTxtBx;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisconnectBtn;
    }
}

