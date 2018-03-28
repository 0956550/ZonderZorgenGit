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
    public partial class WerkgelegenheidView : Form
    {
        private WerkgelegenheidController werkgelegenheidController;

        public WerkgelegenheidView(WerkgelegenheidController werkgelegenheidControllerP)
        {
            this.werkgelegenheidController = werkgelegenheidControllerP;
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
