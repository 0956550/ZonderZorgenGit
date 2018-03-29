using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.Controller;

namespace ZonderZorgenGit.Model
{
    class DonorregistratiesPersoonskenmerkenModel
    {
        private bool connectionStatus;
        private ConnectionController mainConnection;

        public DonorregistratiesPersoonskenmerkenModel(ConnectionController connectionControllerP)
        {
            this.mainConnection = connectionControllerP;
            this.connectionStatus = mainConnection.GetConnectionStatus();
        }
        public List<string>[] Select()
        {
            string query = "SELECT * FROM donorregistraties_persoonskenmerken";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (connectionStatus)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, this.mainConnection.GetConnection());
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Persoonskenmerken"] + "");
                    list[1].Add(dataReader["bevolking_12_jaar_of_ouder"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
