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
    public partial class OrgaandonorenView : Form
    {
        private OrgaandonorenController orgaandonorenController;

        public OrgaandonorenView(OrgaandonorenController orgaandonorenControllerP)
        {
            this.orgaandonorenController = orgaandonorenControllerP;
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
