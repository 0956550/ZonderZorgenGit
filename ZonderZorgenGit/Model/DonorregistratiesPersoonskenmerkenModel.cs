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
        // Get Antillen row out of the database
        public List<string>[] GetAntillen()
        {
            string query = "SELECT * FROM donorregistraties_persoonskenmerken WHERE persoonskenmerken = 'herkomst:_nederlandse_antillen_of_aruba'";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
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
                    list[0].Add(dataReader["bevolking_12_jaar_of_ouder"] + "");
                    list[1].Add(dataReader["geregistreerd_in_donorregister"] + "");
                    list[2].Add(dataReader["toestemming_zonder_donatiebeperkingen"] + "");
                    list[3].Add(dataReader["toestemming_met_donatiebeperkingen"] + "");
                    list[4].Add(dataReader["geen_toestemming"] + "");
                    list[5].Add(dataReader["nabestaanden_beslissen"] + "");
                    list[6].Add(dataReader["aangewezen_persoon_beslist"] + "");
                    list[7].Add(dataReader["niet_geregistreerd_in_donorregister"] + "");

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
        // Get Suriname row out of the database
        public List<string>[] GetSuriname()
        {
            string query = "SELECT * FROM donorregistraties_persoonskenmerken WHERE persoonskenmerken = 'herkomst:_suriname'";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
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
                    list[0].Add(dataReader["bevolking_12_jaar_of_ouder"] + "");
                    list[1].Add(dataReader["geregistreerd_in_donorregister"] + "");
                    list[2].Add(dataReader["toestemming_zonder_donatiebeperkingen"] + "");
                    list[3].Add(dataReader["toestemming_met_donatiebeperkingen"] + "");
                    list[4].Add(dataReader["geen_toestemming"] + "");
                    list[5].Add(dataReader["nabestaanden_beslissen"] + "");
                    list[6].Add(dataReader["aangewezen_persoon_beslist"] + "");
                    list[7].Add(dataReader["niet_geregistreerd_in_donorregister"] + "");

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
        // Get Marokko row out of the database
        public List<string>[] GetMarokko()
        {
            string query = "SELECT * FROM donorregistraties_persoonskenmerken WHERE persoonskenmerken = 'herkomst:_marokko'";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
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
                    list[0].Add(dataReader["bevolking_12_jaar_of_ouder"] + "");
                    list[1].Add(dataReader["geregistreerd_in_donorregister"] + "");
                    list[2].Add(dataReader["toestemming_zonder_donatiebeperkingen"] + "");
                    list[3].Add(dataReader["toestemming_met_donatiebeperkingen"] + "");
                    list[4].Add(dataReader["geen_toestemming"] + "");
                    list[5].Add(dataReader["nabestaanden_beslissen"] + "");
                    list[6].Add(dataReader["aangewezen_persoon_beslist"] + "");
                    list[7].Add(dataReader["niet_geregistreerd_in_donorregister"] + "");

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
        public List<string>[] GetTurkije()
        {
            string query = "SELECT * FROM donorregistraties_persoonskenmerken WHERE persoonskenmerken = 'herkomst:_turkije'";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
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
                    list[0].Add(dataReader["bevolking_12_jaar_of_ouder"] + "");
                    list[1].Add(dataReader["geregistreerd_in_donorregister"] + "");
                    list[2].Add(dataReader["toestemming_zonder_donatiebeperkingen"] + "");
                    list[3].Add(dataReader["toestemming_met_donatiebeperkingen"] + "");
                    list[4].Add(dataReader["geen_toestemming"] + "");
                    list[5].Add(dataReader["nabestaanden_beslissen"] + "");
                    list[6].Add(dataReader["aangewezen_persoon_beslist"] + "");
                    list[7].Add(dataReader["niet_geregistreerd_in_donorregister"] + "");

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
