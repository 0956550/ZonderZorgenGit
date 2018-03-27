using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonderZorgenGit.Controller
{
    class ConnectionController
    {
        private MySqlConnection connection;
        private bool connectionStatus = false;

        public ConnectionController()
        {
        }

        public void Initialize(String server, String port, String database, string userId, string password)
        {
            string connectionString;
            connectionString = string.Format("Server=" + server + ";" + "Port=" + port + ";" + "Database=" + database + ";" + "Uid=" + userId + ";" + "Pwd=" + password + ";");
            connection = new MySqlConnection(connectionString);

            if (OpenConnection())
            {
                connectionStatus = true;
            }
            else
            {
                connectionStatus = false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public bool GetConnectionStatus()
        {
            return connectionStatus;
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
