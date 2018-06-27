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
    /// <summary>
    /// Класс предназначен для управления командами (обращение) к БД, вывод данных на экран 
    /// </summary>
    public class Command
    {
        //Fields
        private MySqlCommand command;// = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable table = new DataTable();
        private MySqlConnection connection = Connection.GetConnection;
        

        //Properties of this class
        public MySqlCommand SqlCommand
        {
            get { return command; }
            set { command = value; }
        }

        //Methods

        ////для отображения Таблицы
        //public void FillDataGridView(DataGridView dataGridView, string query = "")
        //{
        //    try
        //    {
        //        //Connection.OpenConnection();
        //        command = new MySqlCommand(query, connection); //Создаём запрос для поиска
        //        adapter = new MySqlDataAdapter(command); //Выполняем команду
        //        adapter.SelectCommand = command;
        //        //Для отображения в таблице
        //        table.Clear();
        //        adapter.Fill(table); //Вставляем данные при выполнении команды в таблицу
        //        dataGridView.DataSource = table; //подключаем заполненную таблицу и отображаем

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        //Connection.CloseConnection();
        //    }
        //}

        //для отображения Таблицы
        public DataTable FillDataGridView(DataGridView dataGridView, string query = "")
        {
            try
            {
                Connection.OpenConnection();
                command = new MySqlCommand(query, connection); //Создаём запрос для поиска
                adapter = new MySqlDataAdapter(command); //Выполняем команду
                adapter.SelectCommand = command;
                //Для отображения в таблице
                table.Clear();
                adapter.Fill(table); //Вставляем данные при выполнении команды в таблицу


                dataGridView.DataSource = table; //подключаем заполненную таблицу и отображаем
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
            finally
            {
                Connection.CloseConnection();
            }
        }

        //Добавить пареметры в MySQL (При обновлении, удалении)
        private void AddParametersString(MySqlCommand command, string[] variables, string[] values)
        {
            int i = 0;
            foreach (string val in values)
                command.Parameters.AddWithValue(variables[i++], val);
        }

        private void AddParametersString(string[] variables, string[] values)
        {
            int i = 0;
            command.Parameters.Clear();
            foreach (string val in values)
                command.Parameters.AddWithValue(variables[i++], val);
        }


        private void PrepareQuery(string query)
        {
            Connection.OpenConnection();
            command.Connection = Connection.GetConnection;
            command.CommandText = query;
            command.Prepare();
            Connection.CloseConnection();
        }

        private void ExecuteQuery()
        {
            Connection.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запит успішно виконано!");
                }
                else
                {
                    MessageBox.Show("Помилка запиту");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// + String.Empty + ex.InnerException.ToString());
                //Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Connection.CloseConnection();
            }

        }


        //Взаимодействие с БД

        //Для выполнения вставки данных
        public void Insert(string[] variables, string[] values, string query)
        {
            PrepareQuery(query); //Подготовить запрос
            AddParametersString(variables, values); //Добавить параметры 
            ExecuteQuery(); //Попытка выполнить запрос
        }

        //Для выполнения обновления
        public void Update(string[] variables, string[] values, string query) {
            Insert(variables, values, query);
        }

        public void Delete(string[] variables, string[] values, string query)
        {
            Insert(variables, values, query);
        }

        //Возвращает результат первого столбца первой строки запроса
        public string ExecuteScalar(string query)
        {
            command = new MySqlCommand(query, connection); //Создаём запрос для поиска
            string result = command.ExecuteScalar().ToString();
            return result;
        }

        // Возвращает список состоящий из строк результата
        // Значение каждой строки объединённое из запроса
        public List<string> ExecuteReaderOneGetString(string query)
        {

            command = new MySqlCommand(query, connection);
            Connection.OpenConnection();
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();

            try
            {
                
                List<string> list = new List<string>();
                while (myReader.Read())
                {
                    list.Add(myReader.GetString(0));
                }
                return list;
            }
            catch(MySqlException ex)
            {
                //MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                myReader.Close();
                Connection.CloseConnection();

            }
        }
    }
}
