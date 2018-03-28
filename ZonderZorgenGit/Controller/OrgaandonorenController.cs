using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class OrgaandonorenController
    {

        private ConnectionController mainConnection;
        private OrgaandonorenView orgaandonorenView;
        private DashboardView dashboardView;

        public OrgaandonorenController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            mainConnection = connectionControllerP;
            dashboardView = dashboardViewP;
            orgaandonorenView = new OrgaandonorenView(this);
            this.Initialize();
        }

        private void Initialize()
        {
            this.orgaandonorenView.Show();
            this.dashboardView.Close();
        }
    }
}
