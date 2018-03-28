using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    class WerkgelegenheidController
    {

        private ConnectionController mainConnection;
        private WerkgelegenheidView werkgelegenheidView = new WerkgelegenheidView();
        private DashboardView dashboardView;

        public WerkgelegenheidController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            this.mainConnection = connectionControllerP;
            this.dashboardView = dashboardViewP;
            this.Initialize();
        }

        private void Initialize()
        {
            werkgelegenheidView.Show();
            dashboardView.Close();
        }
    }
}
