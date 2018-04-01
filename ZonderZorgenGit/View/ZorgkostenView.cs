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

            ZorggebruikChrt.ChartAreas[0].AxisY.Maximum = 100;
            ZorggebruikChrt.ChartAreas[0].AxisY.Minimum = 0;

            ZorgkostenChrt.ChartAreas[0].AxisY.Minimum = 0;

            ZorggebruikChrt.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            ZorgkostenChrt.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController(this.mainConnection);
            this.Close();
        }

        private void HuisartsBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenChrt.Series["2015"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(1)[0][0]));
            ZorgkostenChrt.Series["2016"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(1)[1][0]));
            ZorgkostenChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();

            ZorggebruikChrt.Series["2015"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(1)[0][1]);
            ZorggebruikChrt.Series["2016"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(1)[0][2]);
            ZorggebruikChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();
        }

        private void TandartsBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenChrt.Series["2015"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(2)[0][0]));
            ZorgkostenChrt.Series["2016"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(2)[1][0]));
            ZorgkostenChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();

            ZorggebruikChrt.Series["2015"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(2)[0][1]);
            ZorggebruikChrt.Series["2016"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(2)[0][2]);
            ZorggebruikChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();
        }

        private void ZiekenhuisBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenChrt.Series["2015"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(3)[0][0]));
            ZorgkostenChrt.Series["2016"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(3)[1][0]));
            ZorgkostenChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();

            ZorggebruikChrt.Series["2015"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(3)[0][1]);
            ZorggebruikChrt.Series["2016"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(3)[0][2]);
            ZorggebruikChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();
        }

        private void OndersteunendeDienstenBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenChrt.Series["2015"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(4)[0][0]));
            ZorgkostenChrt.Series["2016"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(4)[1][0]));
            ZorgkostenChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();

            ZorggebruikChrt.Series["2015"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(4)[0][1]);
            ZorggebruikChrt.Series["2016"].Points.ElementAt(0).SetValueY(zorgkostenController.GetZorggebruikData(4)[0][2]);
            ZorggebruikChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();
        }

        private void TotaalBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenChrt.Series["2015"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(5)[0][0]));
            ZorgkostenChrt.Series["2016"].Points.ElementAt(0).SetValueY(int.Parse(zorgkostenController.GetZorgkostenData(5)[1][0]));
            ZorgkostenChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();

            ZorggebruikChrt.Series["2015"].Points.ElementAt(0).SetValueY(100);
            ZorggebruikChrt.Series["2016"].Points.ElementAt(0).SetValueY(100);
            ZorggebruikChrt.ChartAreas[0].RecalculateAxesScale();
            ZorgkostenChrt.Refresh();
        }
    }
}
