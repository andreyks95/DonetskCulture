using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonetskCulture.Control
{
    class Command
    {
        //Fields
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable table = new DataTable();
        private MySqlConnection connection = Connection.GetConnection;

        //Methods
        public void FillDataGridView(DataGridView dataGridView, string query = "")
        {
            try
            {
                command = new MySqlCommand(query, connection); //Создаём запрос для поиска
                adapter = new MySqlDataAdapter(command); //Выполняем команду
                adapter.SelectCommand = command;
                //Для отображения в таблице
                table.Clear();
                adapter.Fill(table); //Вставляем данные при выполнении команды в таблицу
                dataGridView.DataSource = table; //подключаем заполненную таблицу и отображаем
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
