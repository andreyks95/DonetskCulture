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
    static class Connection
    {
        private static MySqlConnection connection; //соединение

        //private static void GetConnection()
        //{
        //    connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=KZ-_-S_D48Line");
        //    OpenConnection();
        //    TryConnectMySQL();
        //}

        //Попытаться подкючиться к БД
        public static void TryConnectMySQL()
        {
            bool IsOpen = false;

            connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=KZ-_-S_D48Line");
            OpenConnection();

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

        /// <summary>
        /// Метод для открытия соединения с БД
        /// </summary>
        public static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        /// <summary>
        /// Метод для закрытия соединения с БД
        /// </summary>
        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        /// <summary>
        /// Получить текущее соединение 
        /// </summary>
        public static MySqlConnection GetConnection => connection;


    }
}
