using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    class ZorgkostenController
    {
        private ConnectionController mainConnection;
        private ZorgkostenView zorgkostenView = new ZorgkostenView();
        private DashboardView dashboardView;

        public ZorgkostenController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            this.mainConnection = connectionControllerP;
            this.dashboardView = dashboardViewP;
            Initialize();
        }

        private void Initialize()
        {
            this.zorgkostenView.Show();
            this.dashboardView.Close();
        }
    }
}
