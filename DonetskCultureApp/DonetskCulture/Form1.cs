using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DonetskCulture
{
    public partial class Form1 : Form
    {
        //Fields
        MySqlConnection connection;

        //Constructors
        public Form1()
        {
            InitializeComponent();
            //ConnectToMySQLDatabase();
            //MessageBox.Show("");
            //TryConnectDB();
        }


        //Methods

        //System Generated Methods 

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        //Users Generated Methods

        private void ConnectToMySQLDatabase() {
            try
            {
                connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=KZ-_-S_D48Line");
                //connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Open connection!");
                }
                else
                {
                    MessageBox.Show("Closed connection!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void ShowDatabase()
        {
            try
            {
                MySqlConnection connection =  new MySqlConnection("datasource=localhost; port=3306; username=root; password=KZ-_-S_D48Line");

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM donetsk_culture_db.establishments", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "establishments");
                dataGridView1.DataSource = ds.Tables["establishments"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


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
