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
    public partial class ZorgkostenView : Form
    {
        private ZorgkostenController zorgkostenController;

        public ZorgkostenView(ZorgkostenController zorgkostenControllerP)
        {
            this.zorgkostenController = zorgkostenControllerP;
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
