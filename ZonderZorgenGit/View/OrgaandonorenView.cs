﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZonderZorgenGit.Controller;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace ZonderZorgenGit.View
{
    public partial class OrgaandonorenView : Form
    {
        private OrgaandonorenController orgaandonorenController;
        private ConnectionController mainConnection;

        public OrgaandonorenView(OrgaandonorenController orgaandonorenControllerP, ConnectionController connectionControllerP)
        {
            this.orgaandonorenController = orgaandonorenControllerP;
            this.mainConnection = connectionControllerP;
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController(this.mainConnection);
            this.Close();
        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void OrgaandonorenView_Load(object sender, EventArgs e)
        {
            geregistreerd.Series["Geregistreerd"].Points.AddXY("Wel geregistreerd", 50);
            geregistreerd.Series["Geregistreerd"].Points.AddXY("Niet geregistreerd", 50);
            Hoe.Series["hoe"].Points.AddXY("Toestemming zonder berperkingen", 5);
            Hoe.Series["hoe"].Points.AddXY("Toestemming met beperkingen", 5);
            Hoe.Series["hoe"].Points.AddXY("Geen toestemming", 5);
            Hoe.Series["hoe"].Points.AddXY("Nabestaande Beslissen", 5);
            Hoe.Series["hoe"].Points.AddXY("Aangeweze persoon beslist", 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Antillen";
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(1)[1][0]));
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(1)[7][0]));
            Hoe.Series["hoe"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(1)[2][0]));
            Hoe.Series["hoe"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(1)[3][0]));
            Hoe.Series["hoe"].Points.ElementAt(2).SetValueY(int.Parse(orgaandonorenController.GetData(1)[4][0]));
            Hoe.Series["hoe"].Points.ElementAt(3).SetValueY(int.Parse(orgaandonorenController.GetData(1)[5][0]));
            Hoe.Series["hoe"].Points.ElementAt(4).SetValueY(int.Parse(orgaandonorenController.GetData(1)[6][0]));
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(0).Color = Color.Lime;
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(1).Color = Color.Red;

            geregistreerd.ChartAreas[0].RecalculateAxesScale();
            Hoe.ChartAreas[0].RecalculateAxesScale();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Turkije";

        }

        private void button3_Click(object sender, EventArgs e)
        {   
            label3.Text = "Suriname";
            //chart2.Series["Aantal x 1000"].Points.ElementAt(0).SetValueXY("Geregistreerd in donnorregister", int.Parse(orgaandonorenController.GetData(2)[0][0]));
            //chart2.Series["Aantal x 1000"].Points.ElementAt(1).SetValueXY("Niet geregistreerd in donnorregister", int.Parse(orgaandonorenController.GetData(2)[1][0]));
            //chart2.ChartAreas[0].RecalculateAxesScale();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Marokko";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
