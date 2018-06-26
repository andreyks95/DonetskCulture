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

        string otherQuery = " select collectives.id_collective AS 'ID колективу', collectives.name AS 'Назва', collectives.form AS 'Форма', " +
                            " collectives.genre AS 'Жанр', collectives.ageCategory AS 'Вікова категорія', collectives.rank AS 'Звання' " +
                            " from donetsk_culture.collectives GROUP BY(name); ";

        string partSelectSearchQueryWithGroup = "";


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



        private void ClearButton_Click(object sender, EventArgs e)
        {
            interactingWithForms.ClearForm(new[] { ageCategoryComboBox, rankComboBox, managerComboBox }, new[] { IDTextBox, nameTextBox, formTextBox, genreTextBox });
        }
    }
}
