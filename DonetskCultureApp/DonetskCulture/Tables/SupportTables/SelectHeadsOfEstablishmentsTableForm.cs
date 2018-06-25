using DonetskCulture.Control;
using DonetskCulture.Tables.AddRecordsTables;
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
    public partial class SelectHeadsOfEstablishmentsTableForm : Form
    {
        #region Поля класса

        Command controlCommand = new Command();

        string valueSelectedEstablishment = "";

        //Дописать запросы
        string partQueryBeforeWhere = " select heads_establishments.id_head AS 'ID керівника', " +
                                      " heads_establishments.fullName AS 'ПІБ керівника', " +
                                      " heads_establishments.adminCorps AS 'Адміністративний корпус', " +
                                      " heads_establishments.phone AS 'Телефон', " +
                                      " heads_establishments.email AS 'E-mail' " +
                                      " from donetsk_culture.heads_establishments, donetsk_culture.establishments " +
                                      " WHERE heads_establishments.id_head = establishments.id_head AND establishments.name = ";
        string partQueryAfterWhere = "AND CONCAT(" +
            " COALESCE(heads_establishments.id_head ,''), ' ', COALESCE(heads_establishments.fullName,''), ' ', " +
            " COALESCE(heads_establishments.adminCorps,''), ' ', COALESCE(heads_establishments.phone ,''), ' ', " +
            " COALESCE(heads_establishments.email ,''), ' ') " +
            " group by heads_establishments.id_head, heads_establishments.fullName ";

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion

        public SelectHeadsOfEstablishmentsTableForm()
        {
            InitializeComponent();
        }

        public SelectHeadsOfEstablishmentsTableForm(string value) : this()
        {
            valueSelectedEstablishment = value;
        }

        private void SelectHeadsOfEstablishmentsTableForm_Load(object sender, EventArgs e)
        {
            string query = partQueryBeforeWhere + " '" + valueSelectedEstablishment + "' " + partQueryAfterWhere;
            table = controlCommand.FillDataGridView(dataGridView1, query);
            bindingManagerBase = this.BindingContext[table];
        }

        private void AddHeadsOfEstablishmentButton_Click(object sender, EventArgs e)
        {
            AddHeadEstablishmentForm addHeadEstablishment = new AddHeadEstablishmentForm(controlCommand);
            addHeadEstablishment.Show();
        }
    }
}
