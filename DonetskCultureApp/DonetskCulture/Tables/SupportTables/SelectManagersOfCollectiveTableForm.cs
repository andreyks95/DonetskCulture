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
using DonetskCulture.Tables.AddRecordsTables;

namespace DonetskCulture.Tables
{
    public partial class SelectManagersOfCollectiveTableForm : Form
    {

        #region Поля класса

        Command controlCommand = new Command();

        string valueSelectedCollective = "";

        string partQuery = " SELECT " +
                            " managers_collectives.id_manager AS 'ID керівника', " +
                            " managers_collectives.fullName AS 'ПІБ керівника', " +
                            " managers_collectives.rankManager AS 'Звання', " +
                            " managers_collectives.education AS 'Освіта', " +
                            " managers_collectives.experience AS 'Стаж роботи', " +
                            " managers_collectives.phone AS 'Телефон', " +
                            " managers_collectives.email AS 'E-mail' " +
                            " FROM donetsk_culture.collectives, donetsk_culture.managers_collectives " +
                            " Where collectives.id_manager = managers_collectives.id_manager " +
                            " AND collectives.name = ";

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion


        public SelectManagersOfCollectiveTableForm(string valueForSearch)
        {
            InitializeComponent();
            valueSelectedCollective = valueForSearch;
        }

        private void SelectManagersOfCollectiveTableForm_Load(object sender, EventArgs e)
        {
            string query = partQuery + " '" + valueSelectedCollective + "' ";
            table = controlCommand.FillDataGridView(dataGridView1, query);
            bindingManagerBase = this.BindingContext[table];
        }

        private void AddManagerOfCollectiveButton_Click(object sender, EventArgs e)
        {
            AddManagerCollectiveForm addManagerCollective = new AddManagerCollectiveForm(controlCommand);
            addManagerCollective.Show();
        }
    }
}
