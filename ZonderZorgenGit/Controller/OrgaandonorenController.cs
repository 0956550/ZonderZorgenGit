using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    class OrgaandonorenController
    {

        private ConnectionController mainConnection;
        private OrgaandonorenView orgaandonorenView = new OrgaandonorenView();
        private DashboardView dashboardView;

        public OrgaandonorenController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            mainConnection = connectionControllerP;
            dashboardView = dashboardViewP;
            this.Initialize();
        }

        private void Initialize()
        {
            this.orgaandonorenView.Show();
            this.dashboardView.Close();
        }

    }
}
