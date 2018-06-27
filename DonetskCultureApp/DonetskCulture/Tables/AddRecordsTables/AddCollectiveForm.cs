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
    public partial class AddCollectiveForm : Form
    {

        Command controlCommand; // = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();


        string[] parametersTableSQL = new string[] { "@id_collective", "@name", "@form", "@genre", "@ageCategory", "@rank", "@id_manager" };

        public AddCollectiveForm()
        {
            InitializeComponent();
        }

        public AddCollectiveForm(Command command):this()
        {
            controlCommand = command;
        }

        private void managerComboBox_Enter(object sender, EventArgs e)
        {
            string query = " SELECT CONCAT(COALESCE(managers_collectives.id_manager, ''), ' ', COALESCE(managers_collectives.fullName, ''), ' ', " +
                            " COALESCE(managers_collectives.rankManager, ''), ' ', COALESCE(managers_collectives.education, ''), ' ', " +
                            " COALESCE(managers_collectives.experience, ''), ' ', COALESCE(managers_collectives.phone, ''), ' ', " +
                            " COALESCE(managers_collectives.email, ''), ' ') AS 'Result' " +
                            " From donetsk_culture.managers_collectives; ";

            List<string> result = controlCommand.ExecuteReaderOneGetString(query);
            interactingWithForms.FillComboBox(result, managerComboBox);
        }

        private string[] GetValuesFromForm()
        {
            //Вытаскиваем данные во время ввода
            string idText = IDTextBox.Text;
            string name =   nameTextBox.Text;
            string form = formTextBox.Text;
            string genre = genreTextBox.Text;
            string ageCategory = ageCategoryComboBox.SelectedItem?.ToString(); //Если что-то есть в выбранном пункте, то конвертируем
            string rank = rankComboBox.SelectedItem?.ToString();
            string manager = managerComboBox.SelectedItem?.ToString();
            if (!String.IsNullOrEmpty(manager) && !String.IsNullOrWhiteSpace(manager))
                manager = interactingWithForms.ParseForGetID(manager);

            //Полученные значения с формы
            return new string[] { idText, name, form, genre, ageCategory, rank, manager };
        }



        //Вставка записи
        private void AddCollectiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.collectives " +
                                         "VALUES(@id_collective, @name, @form, @genre, @ageCategory, @rank, @id_manager)";
                controlCommand.Insert(parametersTableSQL, GetValuesFromForm(), queryInsert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом AddCollectiveButton_Click");
            }
        }

        //Очистка формы
        private void ClearButton_Click(object sender, EventArgs e)
        {
            interactingWithForms.ClearForm(new [] { ageCategoryComboBox, rankComboBox, managerComboBox }, new [] { IDTextBox, nameTextBox, formTextBox, genreTextBox });
        }

    }
}
