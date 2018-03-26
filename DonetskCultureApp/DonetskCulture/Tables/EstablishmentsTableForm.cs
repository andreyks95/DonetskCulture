using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonetskCulture.Control;
using MySql.Data.MySqlClient;

namespace DonetskCulture
{
    public partial class EstablishmentsTableForm : Form
    {
        //Fields
        MySqlConnection connection;//= Connection.GetConnection; //Избыточное
        Command controlCommand = new Command();



        //Constructors
        public EstablishmentsTableForm(MySqlConnection connect)
        {
            InitializeComponent();
            connection = connect; //Избыточное
            //TryConnectDB();
        }


        //Methods

        //System Generated Methods 

        private void EstablishmentsTableForm_Load(object sender, EventArgs e)
        {
            //ShowDatabase();
            string query = "SELECT * FROM donetsk_culture_db.establishments";
            controlCommand.FillDataGridView(dataGridView1, query);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            IDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            regionOrCityTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addressTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            formWorkComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }


        //Users Generated Methods

        //Test Methods
        public void ExecuteMyQuery(string query)
        {
            try
            {
                Connection.OpenConnection();
                MySqlCommand command = new MySqlCommand(query, Connection.GetConnection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query executed");
                }
                else
                {
                    MessageBox.Show("Query not executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + String.Empty + ex.InnerException.ToString());
            }
            finally
            {
                Connection.CloseConnection();
            }

        }

        //DataTable table = connection.FillDataGridView(dataGridView1, 20, query: query); //заполняем таблицу данными с запроса и настраиваем
        //managerBase = this.BindingContext[table]; //подключаем таблицу для передвижения по ней


        //public void AddParametersString(MySqlCommand command, string[] variables, MySqlDbType[] mySqlDbTypes, string[] values)
        //{
        //    int i = 0, j = 0;
        //    foreach (string val in values)
        //        command.Parameters.Add(variables[i++], mySqlDbTypes[j++]).Value = val;
        //    //command.Parameters.AddWithValue(variables[i++],val);
        //}

        /*
        void TryConnectDB()
        {
            using (var context = new DesktopDBContext())
            {
                //Console.WriteLine("Create A New Product");

                Establishment establishment = new Establishment();
                //trying to insert data to DB

                establishment.id_establishment = 1;

                establishment.name = "П'єжка";

                establishment.regionOrCity = "П'ятка";

                establishment.address = "Улица Пушкина, дом колотушкина";

                establishment.formWork = "I don't know)))";
                context.Establishments.Add(establishment);
                

                if (context.SaveChanges() > 0)
                {
                    ////Console.WriteLine("New Product Created");
                    //Console.ReadLine();
                    MessageBox.Show("Данные успешно вставлены!");

                }
                else
                {
                    MessageBox.Show("Ошибка!");
                    //Console.WriteLine("Error in Creating Product");
                }
            }
        }*/
    }
}
