using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZonderZorgenGit.Controller;

namespace ZonderZorgenGit.Model
{
    class ZorggebruikModel
    {

        private ConnectionController mainConnection;
        private bool connectionStatus;

        public ZorggebruikModel(ConnectionController connectionControllerP)
        {
            this.mainConnection = connectionControllerP;
            this.connectionStatus = mainConnection.GetConnectionStatus();
        }

        public List<string>[] GetHuisartsGebruik()
        {
            string query = "SELECT percentage_contact_huisarts FROM zorggebruik where marges = 'waarde' and persoonskenmerken = 'totaal:_personen'";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();

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
                    list[0].Add(dataReader["percentage_contact_huisarts"] + "");
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
        public List<string>[] GetTandartsGebruik()
        {
            string query = "SELECT percentage_contact_tandarts FROM zorggebruik where marges = 'waarde' and persoonskenmerken = 'totaal:_personen'";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();

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
                    list[0].Add(dataReader["percentage_contact_tandarts"] + "");
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
        public List<string>[] GetZiekenhuisGebruik()
        {
            string query = "SELECT percentage_contact_medisch_specialist FROM zorggebruik where marges = 'waarde' and persoonskenmerken = 'totaal:_personen'";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();

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
                    list[0].Add(dataReader["percentage_contact_medisch_specialist"] + "");
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
        public List<string>[] GetOndersteunendGebruik()
        {
            string query = "SELECT contact_met_fysio_en_oefen_therapeut FROM zorggebruik where marges = 'waarde' and persoonskenmerken = 'totaal:_personen'";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();

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
                    list[0].Add(dataReader["contact_met_fysio_en_oefen_therapeut"] + "");
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
