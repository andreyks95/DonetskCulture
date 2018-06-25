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
using DonetskCulture.Tables;
using DonetskCulture.Tables.AddRecordsTables;

namespace DonetskCulture
{
    public partial class SelectCollectivesOfEstablishmentsTableForm : Form
    {

        #region Поля класса

        Command controlCommand = new Command(); // Или передавать по ссылке

        string valueSelectedEstablishment = "";

        string partQueryBeforeWhere = " select collectives.id_collective AS 'ID колективу', collectives.name AS 'Назва', collectives.form AS 'Форма', collectives.genre AS 'Жанр', " +
                           " collectives.ageCategory AS 'Вікова категорія', collectives.rank AS 'Звання' " +
                           " from donetsk_culture.collectives, donetsk_culture.establishments " +
                           " WHERE collectives.id_collective = establishments.id_collective AND establishments.name = ";
        //Выбираем по выбранному закладу культури " 'One' "
        string partQueryAfterWhere = 
                           " AND CONCAT(      COALESCE(collectives.id_collective,''), ' ', COALESCE(collectives.name,''), ' ', COALESCE(collectives.form,''), ' ', " +
                           " COALESCE(collectives.genre,''), ' ', COALESCE(collectives.ageCategory,''), ' ', COALESCE(collectives.rank,''), ' ', " +
                           " COALESCE(collectives.id_manager, ''), ' ' ) " +
                           " group by collectives.id_collective, collectives.name ";

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion

        public SelectCollectivesOfEstablishmentsTableForm(string valueForSearch)
        {
            InitializeComponent();
            valueSelectedEstablishment = valueForSearch;
        }

        private void SelectCollectivesOfEstablishmentsTableForm_Load(object sender, EventArgs e)
        {
           string query = partQueryBeforeWhere + " '" + valueSelectedEstablishment + "' " + partQueryAfterWhere;
            table = controlCommand.FillDataGridView(dataGridView1, query);
            bindingManagerBase = this.BindingContext[table];
        }

        private void ShowManagersOfCollectiveButton_Click(object sender, EventArgs e)
        {
            string valueNameCollectiveColumn = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
            if (!String.IsNullOrEmpty(valueNameCollectiveColumn) && !String.IsNullOrWhiteSpace(valueNameCollectiveColumn))
            {
                SelectManagersOfCollectiveTableForm selectedManagers = new SelectManagersOfCollectiveTableForm(valueNameCollectiveColumn);
                selectedManagers.Show();
            }
            else
            {
                MessageBox.Show("Увага!!! \n Виберіть колектив в таблиці! ");
            }
        }

        private void AddCollectiveButton_Click(object sender, EventArgs e)
        {
            AddCollectiveForm addCollective = new AddCollectiveForm(controlCommand);
            addCollective.Show();
        }
    }
}
