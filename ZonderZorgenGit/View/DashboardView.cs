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
    public partial class DashboardView : Form
    {
        private DashboardController dashboardController;

        public DashboardView(DashboardController dashboardControllerP)
        {
            InitializeComponent();
            dashboardController = dashboardControllerP;
        }

        private void OrgaandonorenBtn_Click(object sender, EventArgs e)
        {
            OrgaandonorenController orgaandonorenController = new OrgaandonorenController(dashboardController.GetConnection(), this);
        }

        private void WerkgelegenheidBtn_Click(object sender, EventArgs e)
        {
            WerkgelegenheidController werkgelegenheidController = new WerkgelegenheidController(this.dashboardController.GetConnection(), this);
        }

        private void ZorgkostenBtn_Click(object sender, EventArgs e)
        {
            ZorgkostenController zorgkostenController = new ZorgkostenController(this.dashboardController.GetConnection(), this);
        }

        private void OverBtn_Click(object sender, EventArgs e)
        {
            using (Over Over = new Over())
            {
                Over.ShowDialog(this);
            }
        }
    }
}
