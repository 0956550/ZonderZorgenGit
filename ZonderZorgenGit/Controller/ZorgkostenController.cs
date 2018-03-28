using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class ZorgkostenController
    {
        private ConnectionController mainConnection;
        private ZorgkostenView zorgkostenView;
        private DashboardView dashboardView;

        public ZorgkostenController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            this.mainConnection = connectionControllerP;
            this.dashboardView = dashboardViewP;
            this.zorgkostenView = new ZorgkostenView(this);
            Initialize();
        }

        private void Initialize()
        {
            this.zorgkostenView.Show();
            this.dashboardView.Close();
        }
        public DashboardView GetDashboardView()
        {
            return this.dashboardView;
        }
    }
}
