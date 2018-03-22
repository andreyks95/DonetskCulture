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

        //Users Generated Methods


        //DataTable table = connection.FillDataGridView(dataGridView1, 20, query: query); //заполняем таблицу данными с запроса и настраиваем
        //managerBase = this.BindingContext[table]; //подключаем таблицу для передвижения по ней


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
