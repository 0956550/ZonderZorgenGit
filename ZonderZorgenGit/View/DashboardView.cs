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
    public partial class DashboardView : Form
    {
        DashboardController dashboardController;

        public DashboardView(DashboardController dashboardControllerP)
        {
            InitializeComponent();
            dashboardController = dashboardControllerP;
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }
    }
}
