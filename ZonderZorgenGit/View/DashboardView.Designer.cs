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
            this.SidePnl = new System.Windows.Forms.Panel();
            this.MainPnl = new System.Windows.Forms.Panel();
            this.OrgaandonorenBtn = new System.Windows.Forms.Button();
            this.WerkgelegenheidBtn = new System.Windows.Forms.Button();
            this.ZorgkostenBtn = new System.Windows.Forms.Button();
            this.OrgaandonorenLbl = new System.Windows.Forms.Label();
            this.WerkgelegenheidLbl = new System.Windows.Forms.Label();
            this.ZorgkostenLbl = new System.Windows.Forms.Label();
            this.MainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePnl
            // 
            this.SidePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePnl.BackgroundImage")));
            this.SidePnl.Location = new System.Drawing.Point(0, -2);
            this.SidePnl.Name = "SidePnl";
            this.SidePnl.Size = new System.Drawing.Size(265, 735);
            this.SidePnl.TabIndex = 0;
            // 
            // MainPnl
            // 
            this.MainPnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPnl.BackgroundImage")));
            this.MainPnl.Controls.Add(this.ZorgkostenLbl);
            this.MainPnl.Controls.Add(this.WerkgelegenheidLbl);
            this.MainPnl.Controls.Add(this.OrgaandonorenLbl);
            this.MainPnl.Controls.Add(this.ZorgkostenBtn);
            this.MainPnl.Controls.Add(this.WerkgelegenheidBtn);
            this.MainPnl.Controls.Add(this.OrgaandonorenBtn);
            this.MainPnl.Location = new System.Drawing.Point(271, 12);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(980, 705);
            this.MainPnl.TabIndex = 1;
            // 
            // OrgaandonorenBtn
            // 
            this.OrgaandonorenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrgaandonorenBtn.BackgroundImage")));
            this.OrgaandonorenBtn.Location = new System.Drawing.Point(181, 248);
            this.OrgaandonorenBtn.Name = "OrgaandonorenBtn";
            this.OrgaandonorenBtn.Size = new System.Drawing.Size(200, 200);
            this.OrgaandonorenBtn.TabIndex = 0;
            this.OrgaandonorenBtn.UseVisualStyleBackColor = true;
            // 
            // WerkgelegenheidBtn
            // 
            this.WerkgelegenheidBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WerkgelegenheidBtn.BackgroundImage")));
            this.WerkgelegenheidBtn.Location = new System.Drawing.Point(387, 248);
            this.WerkgelegenheidBtn.Name = "WerkgelegenheidBtn";
            this.WerkgelegenheidBtn.Size = new System.Drawing.Size(200, 200);
            this.WerkgelegenheidBtn.TabIndex = 1;
            this.WerkgelegenheidBtn.UseVisualStyleBackColor = true;
            // 
            // ZorgkostenBtn
            // 
            this.ZorgkostenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZorgkostenBtn.BackgroundImage")));
            this.ZorgkostenBtn.Location = new System.Drawing.Point(593, 248);
            this.ZorgkostenBtn.Name = "ZorgkostenBtn";
            this.ZorgkostenBtn.Size = new System.Drawing.Size(200, 200);
            this.ZorgkostenBtn.TabIndex = 2;
            this.ZorgkostenBtn.UseVisualStyleBackColor = true;
            // 
            // OrgaandonorenLbl
            // 
            this.OrgaandonorenLbl.AutoSize = true;
            this.OrgaandonorenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrgaandonorenLbl.Location = new System.Drawing.Point(224, 451);
            this.OrgaandonorenLbl.Name = "OrgaandonorenLbl";
            this.OrgaandonorenLbl.Size = new System.Drawing.Size(121, 20);
            this.OrgaandonorenLbl.TabIndex = 3;
            this.OrgaandonorenLbl.Text = "Orgaandonoren";
            // 
            // WerkgelegenheidLbl
            // 
            this.WerkgelegenheidLbl.AutoSize = true;
            this.WerkgelegenheidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WerkgelegenheidLbl.Location = new System.Drawing.Point(427, 451);
            this.WerkgelegenheidLbl.Name = "WerkgelegenheidLbl";
            this.WerkgelegenheidLbl.Size = new System.Drawing.Size(125, 20);
            this.WerkgelegenheidLbl.TabIndex = 4;
            this.WerkgelegenheidLbl.Text = "Wergelegenheid";
            // 
            // ZorgkostenLbl
            // 
            this.ZorgkostenLbl.AutoSize = true;
            this.ZorgkostenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ZorgkostenLbl.Location = new System.Drawing.Point(648, 451);
            this.ZorgkostenLbl.Name = "ZorgkostenLbl";
            this.ZorgkostenLbl.Size = new System.Drawing.Size(90, 20);
            this.ZorgkostenLbl.TabIndex = 5;
            this.ZorgkostenLbl.Text = "Zorgkosten";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.SidePnl);
            this.Name = "DashboardView";
            this.Text = "ZonderZorgen";
            this.MainPnl.ResumeLayout(false);
            this.MainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePnl;
        private System.Windows.Forms.Panel MainPnl;
        private System.Windows.Forms.Label ZorgkostenLbl;
        private System.Windows.Forms.Label WerkgelegenheidLbl;
        private System.Windows.Forms.Label OrgaandonorenLbl;
        private System.Windows.Forms.Button ZorgkostenBtn;
        private System.Windows.Forms.Button WerkgelegenheidBtn;
        private System.Windows.Forms.Button OrgaandonorenBtn;
    }
}