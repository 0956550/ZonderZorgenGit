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

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController(this.mainConnection);
            this.Close();
        }
    }
}
