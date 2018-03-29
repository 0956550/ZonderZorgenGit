using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class WerkgelegenheidController
    {

        private ConnectionController mainConnection;
        private WerkgelegenheidView werkgelegenheidView;
        private DashboardView dashboardView;

        public WerkgelegenheidController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            this.mainConnection = connectionControllerP;
            this.dashboardView = dashboardViewP;
            werkgelegenheidView = new WerkgelegenheidView(this, this.mainConnection);
            this.Initialize();
        }

        private void Initialize()
        {
            werkgelegenheidView.Show();
            dashboardView.Close();
        }
    }
}
