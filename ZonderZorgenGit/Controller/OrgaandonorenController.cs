using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.Model;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class OrgaandonorenController
    {

        private ConnectionController mainConnection;
        private OrgaandonorenView orgaandonorenView;
        private DonorregistratiesPersoonskenmerkenModel donorregistratiesPersoonskenmerkenModel;
        
        private DashboardView dashboardView;

        public OrgaandonorenController(ConnectionController connectionControllerP, DashboardView dashboardViewP)
        {
            mainConnection = connectionControllerP;
            dashboardView = dashboardViewP;
            orgaandonorenView = new OrgaandonorenView(this, this.mainConnection);
            this.donorregistratiesPersoonskenmerkenModel = new DonorregistratiesPersoonskenmerkenModel(mainConnection);
            this.Initialize();
        }

        private void Initialize()
        {
            this.orgaandonorenView.Show();
            this.dashboardView.Close();
        }
        public List<string>[] GetData(int switchId)
        {
            switch (switchId)
            {
                case 1:
                    return donorregistratiesPersoonskenmerkenModel.GetAntillen();
                case 2:
                    return donorregistratiesPersoonskenmerkenModel.GetSuriname();
                case 3:
                    return donorregistratiesPersoonskenmerkenModel.GetTurkije();
                case 4:
                    return donorregistratiesPersoonskenmerkenModel.GetMarokko();
            }
            return null;
        }  
    }
}
