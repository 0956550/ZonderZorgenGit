using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class DashboardController
    {
        private ConnectionController mainConnection;
        private bool connectionStatus;
        private DashboardView dashboardView;

        public DashboardController(ConnectionController connectionControllerP, bool connectionStatusP)
        {
            mainConnection = connectionControllerP;
            connectionStatus = connectionStatusP;
            dashboardView = new DashboardView(this);
            Initialize();
        }
        private void Initialize()
        {
            dashboardView.Show();
        }
        public ConnectionController GetConnection()
        {
            return this.mainConnection;
        }
    }
}
