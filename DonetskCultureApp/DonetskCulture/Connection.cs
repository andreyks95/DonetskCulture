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
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Open connection!");
                }
                else
                {
                    MessageBox.Show("Fault connection!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenConnection() => connection.Open();
        private void CloseConnection() => connection.Close();


    }
}
