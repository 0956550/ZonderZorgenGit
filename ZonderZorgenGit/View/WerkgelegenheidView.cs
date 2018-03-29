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
    public partial class WerkgelegenheidView : Form
    {
        private WerkgelegenheidController werkgelegenheidController;
        private ConnectionController mainConnection;

        public WerkgelegenheidView(WerkgelegenheidController werkgelegenheidControllerP, ConnectionController connectionControllerP)
        {
            this.werkgelegenheidController = werkgelegenheidControllerP;
            this.mainConnection = connectionControllerP;
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController(this.mainConnection);
            this.Close();
        }
    }
}
