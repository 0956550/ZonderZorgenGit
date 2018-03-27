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

namespace ZonderZorgenGit
{
    public partial class LoginView : Form
    {
        ConnectionController mainConnection = new ConnectionController();

        public LoginView()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            ConnectionStatusLbl.Text = "Status: Connecting";
            mainConnection.Initialize(ServerIpTxtBx.Text, PortTxtBx.Text, DatabaseTxtBx.Text, UserIdTxtBx.Text, PasswordTxtBx.Text);
            if (mainConnection.GetConnectionStatus())
            {
                ConnectionStatusLbl.Text = "Status: Connected";
                //DashboardController dashboardController = new DashboardController(mainConnection.GetConnection(), mainConnection.GetConnectionStatus());
            }
            else
            {
                ConnectionStatusLbl.Text = "Status: Can't connect, please contact admin";
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            mainConnection.CloseConnection();
            if (mainConnection.GetConnectionStatus())
            {
                ConnectionStatusLbl.Text = "Status: Connection closed";
                this.Close();
            }
            else
            {
                ConnectionStatusLbl.Text = "Status: Shit is broken son!";
            }
        }
    }
}
