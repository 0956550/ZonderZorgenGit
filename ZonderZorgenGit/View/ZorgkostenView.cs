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
    public partial class ZorgkostenView : Form
    {
        private ZorgkostenController zorgkostenController;
        private ConnectionController mainConnection;

        public ZorgkostenView(ZorgkostenController zorgkostenControllerP, ConnectionController connectionControllerP)
        {
            this.mainConnection = connectionControllerP;
            this.zorgkostenController = zorgkostenControllerP;
            InitializeComponent();
        }

        private void ZorgkostenView_Load(object sender, EventArgs e)
        {
            ZorggebruikChrt.Series["2015"].Points.AddY(1);
            ZorggebruikChrt.Series["2016"].Points.AddY(1);
            ZorgkostenChrt.Series["2015"].Points.AddY(1);
            ZorgkostenChrt.Series["2016"].Points.AddY(1);
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController(this.mainConnection);
            this.Close();
        }

        private void HuisartsBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenChrt.Series["2015"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData()[0][0]));
            ZorgkostenChrt.Series["2016"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData()[1][0]));
            ZorgkostenChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();

            ZorggebruikChrt.Series["2015"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData()[0][1]);
            ZorggebruikChrt.Series["2016"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData()[0][2]);
            ZorggebruikChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();
        }
    }
}
