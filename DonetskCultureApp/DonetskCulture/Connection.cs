using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace DonetskCulture
{
    class Connection
    {
        private readonly MySqlConnection connection;

        public Connection()
        {
            connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=KZ-_-S_D48Line");
            OpenConnection();
            TryConnectMySQL();
        }

        private void TryConnectMySQL()
        {
            bool IsOpen = false;

            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    IsOpen = true;
                    //MessageBox.Show("Open connection!");
                }
                else
                {
                    //MessageBox.Show("Fault connection!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OpenConnection() => connection.Open();
        public void CloseConnection() => connection.Close();


    }
}
