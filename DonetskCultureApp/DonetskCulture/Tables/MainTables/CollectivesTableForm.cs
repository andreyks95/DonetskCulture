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

namespace DonetskCulture.Tables
{
    public partial class CollectivesTableForm : Form
    {

        #region Поля класса
        //Fields
        //MySqlConnection connection;//= Connection.GetConnection; //Избыточное
        Command controlCommand = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();


        //запрос с группированием
        string otherQuery = " select collectives.id_collective AS 'ID колективу', collectives.name AS 'Назва', collectives.form AS 'Форма', " +
                            " collectives.genre AS 'Жанр', collectives.ageCategory AS 'Вікова категорія', collectives.rank AS 'Звання' " +
                            " from donetsk_culture.collectives GROUP BY(name); ";

        //часть запроса для поиска с учётом группировки
        string partSelectSearchQueryWithGroup = "";

        //часть запроса для поиска 
        string partSelectSearchQuery = "";


        string[] parametersTableSQL = new string[] { "@id_collective", "@name", "@form", "@genre", "@ageCategory", "@rank", "@id_manager" };

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion


        public CollectivesTableForm()
        {
            InitializeComponent();
        }

        public CollectivesTableForm(Command command) : this()
        {
            controlCommand = command;
        }

        //Отобразить сгруппированные по названию колективы 
        private void CollectivesTableForm_Load(object sender, EventArgs e)
        {
            table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
            bindingManagerBase = this.BindingContext[table];
        }


        private string[] GetValuesFromForm()
        {
            //Вытаскиваем данные во время ввода
            string idText = IDTextBox.Text;
            string name = nameTextBox.Text;
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



        private void ClearButton_Click(object sender, EventArgs e)
        {
            interactingWithForms.ClearForm(new[] { ageCategoryComboBox, rankComboBox, managerComboBox }, new[] { IDTextBox, nameTextBox, formTextBox, genreTextBox });
        }


    }
}
