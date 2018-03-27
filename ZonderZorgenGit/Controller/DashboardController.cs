﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.View;

namespace ZonderZorgenGit.Controller
{
    public class DashboardController
    {
        ConnectionController mainConnection;
        bool connectionStatus;
        DashboardView dashboardView;

        public DashboardController(ConnectionController connectionControllerP, bool connectionStatusP)
        {
            mainConnection = connectionControllerP;
            connectionStatus = connectionStatusP;
            dashboardView = new DashboardView(this);
            Initialize();
        }
        private void Initialize()
        {
            dashboardView.Show();
        }
    }
}
