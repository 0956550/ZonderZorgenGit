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

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void OrgaandonorenView_Load(object sender, EventArgs e)
        {
            chart2.Series["Aantal x 1000"].Points.AddXY("Niet geregistreerd", 10);
            chart2.Series["Aantal x 1000"].Points.AddXY("Toestemming zonder donatiebeperkingen", 10);
            chart2.Series["Aantal x 1000"].Points.AddXY("Niet geregistreerd", 10);
            chart2.Series["Aantal x 1000"].Points.AddXY("Niet geregistreerd", 10);
            chart2.Series["Aantal x 1000"].Points.AddXY("Niet geregistreerd", 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series["Aantal x 1000"].Points.ElementAt(0).SetValueXY("Niet geregistreerd", 102);
            chart2.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
