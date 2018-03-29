namespace ZonderZorgenGit.View
{
    partial class OrgaandonorenView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrgaandonorenView));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SidePnl = new System.Windows.Forms.Panel();
            this.DatasetsBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.OverBtn = new System.Windows.Forms.Button();
            this.MainPnl = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SidePnl.SuspendLayout();
            this.MainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePnl
            // 
            this.SidePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePnl.BackgroundImage")));
            this.SidePnl.Controls.Add(this.DatasetsBtn);
            this.SidePnl.Controls.Add(this.DashboardBtn);
            this.SidePnl.Controls.Add(this.OverBtn);
            this.SidePnl.Location = new System.Drawing.Point(0, -4);
            this.SidePnl.Name = "SidePnl";
            this.SidePnl.Size = new System.Drawing.Size(265, 739);
            this.SidePnl.TabIndex = 0;
            // 
            // DatasetsBtn
            // 
            this.DatasetsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatasetsBtn.BackgroundImage")));
            this.DatasetsBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DatasetsBtn.FlatAppearance.BorderSize = 2;
            this.DatasetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatasetsBtn.Location = new System.Drawing.Point(54, 296);
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
            this.DashboardBtn.Location = new System.Drawing.Point(54, 184);
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
            this.OverBtn.Location = new System.Drawing.Point(54, 240);
            this.OverBtn.Name = "OverBtn";
            this.OverBtn.Size = new System.Drawing.Size(150, 50);
            this.OverBtn.TabIndex = 7;
            this.OverBtn.UseVisualStyleBackColor = true;
            // 
            // MainPnl
            // 
            this.MainPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPnl.BackgroundImage")));
            this.MainPnl.Controls.Add(this.chart2);
            this.MainPnl.Controls.Add(this.chart1);
            this.MainPnl.Controls.Add(this.button2);
            this.MainPnl.Controls.Add(this.button1);
            this.MainPnl.Location = new System.Drawing.Point(271, 12);
            this.MainPnl.MaximumSize = new System.Drawing.Size(980, 705);
            this.MainPnl.MinimumSize = new System.Drawing.Size(980, 705);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(980, 705);
            this.MainPnl.TabIndex = 1;
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(240, 195);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Aantal x 1000";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(649, 300);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(-299, -69);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Antillen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Autochtoon";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrgaandonorenView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.SidePnl);
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "OrgaandonorenView";
            this.Text = "ZonderZorgen";
            this.Load += new System.EventHandler(this.OrgaandonorenView_Load);
            this.SidePnl.ResumeLayout(false);
            this.MainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePnl;
        private System.Windows.Forms.Panel MainPnl;
        private System.Windows.Forms.Button DatasetsBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button OverBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}