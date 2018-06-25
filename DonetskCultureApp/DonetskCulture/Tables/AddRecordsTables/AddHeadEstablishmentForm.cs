using DonetskCulture.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonetskCulture.Tables.AddRecordsTables
{
    public partial class AddHeadEstablishmentForm : Form
    {


        Command controlCommand; // = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();


        string[] parametersTableSQL = new string[] { "@id_head", "@fullName", "@adminCorps", "@phone", "@email" };


        public AddHeadEstablishmentForm()
        {
            InitializeComponent();
        }

        public AddHeadEstablishmentForm(Command command) : this()
        {
            controlCommand = command;
        }

        private string[] GetValuesFromForm()
        {
            //Вытаскиваем данные во время ввода
            string idText = IDTextBox.Text;
            string fullName = fullNameTextBox.Text;
            string adminCorps = adminCorpsTextBox.Text;
            string phone = phoneTextBox.Text;
            string mail = mailTextBox.Text; 
           
            //Полученные значения с формы
            return new string[] { idText, fullName, adminCorps, phone, mail };
        }

        private void AddHeadEstablishmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.heads_establishments " +
                                         "VALUES(@id_head, @fullName, @adminCorps, @phone, @email)";
                controlCommand.Insert(parametersTableSQL, GetValuesFromForm(), queryInsert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом AddHeadEstablishmentButton_Click");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            interactingWithForms.ClearForm(textBoxes: new[] { IDTextBox, fullNameTextBox, adminCorpsTextBox, phoneTextBox, mailTextBox });
        }
    }
}
