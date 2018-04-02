using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.Controller;

namespace ZonderZorgenGit.Model
{
    class ZorgWerkgelegenheidModel
    {

        private ConnectionController mainConnection;

        public ZorgWerkgelegenheidModel(ConnectionController connectionControllerP)
        {
            this.mainConnection = connectionControllerP;
        }
    }
}
