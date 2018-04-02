using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZonderZorgenGit.Controller;

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

        private void OrgaandonorenView_Load(object sender, EventArgs e)
        {
            geregistreerd.Series["Geregistreerd"].Points.AddXY("Wel geregistreerd", 50);
            geregistreerd.Series["Geregistreerd"].Points.AddXY("Niet geregistreerd", 50);
            Hoe.Series["Verdeling geregistreerde"].Points.AddXY("Toestemming zonder berperkingen", 5);
            Hoe.Series["Verdeling geregistreerde"].Points.AddXY("Toestemming met beperkingen", 5);
            Hoe.Series["Verdeling geregistreerde"].Points.AddXY("Geen toestemming", 5);
            Hoe.Series["Verdeling geregistreerde"].Points.AddXY("Nabestaande Beslissen", 5);
            Hoe.Series["Verdeling geregistreerde"].Points.AddXY("Aangeweze persoon beslist", 5);
            //Hoe.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -90;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Antillen";
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(1)[1][0]));
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(1)[7][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(1)[2][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(1)[3][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(2).SetValueY(int.Parse(orgaandonorenController.GetData(1)[4][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(3).SetValueY(int.Parse(orgaandonorenController.GetData(1)[5][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(4).SetValueY(int.Parse(orgaandonorenController.GetData(1)[6][0]));

            geregistreerd.ChartAreas[0].RecalculateAxesScale();
            Hoe.ChartAreas[0].RecalculateAxesScale();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Turkije";
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(3)[1][0]));
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(3)[7][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(3)[2][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(3)[3][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(2).SetValueY(int.Parse(orgaandonorenController.GetData(3)[4][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(3).SetValueY(int.Parse(orgaandonorenController.GetData(3)[5][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(4).SetValueY(int.Parse(orgaandonorenController.GetData(3)[6][0]));
            geregistreerd.ChartAreas[0].RecalculateAxesScale();
            Hoe.ChartAreas[0].RecalculateAxesScale();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            label3.Text = "Suriname";
            geregistreerd.ChartAreas[0].RecalculateAxesScale();
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(2)[1][0]));
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(2)[7][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(2)[2][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(2)[3][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(2).SetValueY(int.Parse(orgaandonorenController.GetData(2)[4][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(3).SetValueY(int.Parse(orgaandonorenController.GetData(2)[5][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(4).SetValueY(int.Parse(orgaandonorenController.GetData(2)[6][0]));
            Hoe.ChartAreas[0].RecalculateAxesScale();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Marokko";
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(4)[1][0]));
            geregistreerd.Series["Geregistreerd"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(4)[7][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(0).SetValueY(int.Parse(orgaandonorenController.GetData(4)[2][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(1).SetValueY(int.Parse(orgaandonorenController.GetData(4)[3][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(2).SetValueY(int.Parse(orgaandonorenController.GetData(4)[4][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(3).SetValueY(int.Parse(orgaandonorenController.GetData(4)[5][0]));
            Hoe.Series["Verdeling geregistreerde"].Points.ElementAt(4).SetValueY(int.Parse(orgaandonorenController.GetData(4)[6][0]));
            geregistreerd.ChartAreas[0].RecalculateAxesScale();
            Hoe.ChartAreas[0].RecalculateAxesScale();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
