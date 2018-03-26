using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DonetskCulture
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Создаём подкючение к БД
            //Connection connection = new Connection();
            Connection.TryConnectMySQL();
            MySqlConnection connection = Connection.GetConnection;

            //Запускаем форму
            Application.Run(new EstablishmentsTableForm(connection));
        }
    }
}
