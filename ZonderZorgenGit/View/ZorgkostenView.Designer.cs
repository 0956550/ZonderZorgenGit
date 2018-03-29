namespace ZonderZorgenGit.View
{
    partial class ZorgkostenView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZorgkostenView));
            this.SidePnl = new System.Windows.Forms.Panel();
            this.DatasetsBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.OverBtn = new System.Windows.Forms.Button();
            this.MainPnl = new System.Windows.Forms.Panel();
            this.SidePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePnl
            // 
            this.SidePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePnl.BackgroundImage")));
            this.SidePnl.Controls.Add(this.DatasetsBtn);
            this.SidePnl.Controls.Add(this.DashboardBtn);
            this.SidePnl.Controls.Add(this.OverBtn);
            this.SidePnl.Location = new System.Drawing.Point(0, 0);
            this.SidePnl.Name = "SidePnl";
            this.SidePnl.Size = new System.Drawing.Size(265, 735);
            this.SidePnl.TabIndex = 0;
            // 
            // DatasetsBtn
            // 
            this.DatasetsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatasetsBtn.BackgroundImage")));
            this.DatasetsBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DatasetsBtn.FlatAppearance.BorderSize = 2;
            this.DatasetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatasetsBtn.Location = new System.Drawing.Point(56, 300);
            this.DatasetsBtn.Name = "DatasetsBtn";
            this.DatasetsBtn.Size = new System.Drawing.Size(150, 50);
            this.DatasetsBtn.TabIndex = 8;
            this.DatasetsBtn.UseVisualStyleBackColor = true;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.BackgroundImage")));
            this.DashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DashboardBtn.FlatAppearance.BorderSize = 2;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Location = new System.Drawing.Point(56, 188);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(150, 50);
            this.DashboardBtn.TabIndex = 9;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // OverBtn
            // 
            this.OverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OverBtn.BackgroundImage")));
            this.OverBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.OverBtn.FlatAppearance.BorderSize = 2;
            this.OverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverBtn.Location = new System.Drawing.Point(56, 244);
            this.OverBtn.Name = "OverBtn";
            this.OverBtn.Size = new System.Drawing.Size(150, 50);
            this.OverBtn.TabIndex = 7;
            this.OverBtn.UseVisualStyleBackColor = true;
            // 
            // MainPnl
            // 
            this.MainPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPnl.BackgroundImage")));
            this.MainPnl.Location = new System.Drawing.Point(272, 12);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(980, 705);
            this.MainPnl.TabIndex = 1;
            // 
            // ZorgkostenView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.SidePnl);
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "ZorgkostenView";
            this.Text = "ZonderZorgen";
            this.SidePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePnl;
        private System.Windows.Forms.Panel MainPnl;
        private System.Windows.Forms.Button DatasetsBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button OverBtn;
    }
}