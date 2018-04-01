using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.Model;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class ZorgkostenController
    {
        private ConnectionController mainConnection;
        private ZorgkostenView zorgkostenView;
        private DashboardView dashboardView;
        private ZorguitgavenModel zorguitgavenModel;
        private ZorggebruikModel zorggebruikModel;

        public ZorgkostenController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            this.mainConnection = connectionControllerP;
            this.dashboardView = dashboardViewP;
            this.zorgkostenView = new ZorgkostenView(this, mainConnection);
            this.zorguitgavenModel = new ZorguitgavenModel(mainConnection);
            this.zorggebruikModel = new ZorggebruikModel(mainConnection);
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

        public List<string>[] GetZorgkostenData(int switchId)
        {
            switch(switchId)
            {
                case 1:
                    return zorguitgavenModel.GetHuisartsKosten();
                case 2:
                    return zorguitgavenModel.GetTandartsKosten();
            }
            return null;
        }

        public List<string>[] GetZorggebruikData(int switchId)
        {
            switch(switchId)
            {
                case 1:
                    return zorggebruikModel.GetHuisartsGebruik();
                case 2:
                    return zorggebruikModel.GetTandartsGebruik();
            }
            return null;
        }
    }
}
