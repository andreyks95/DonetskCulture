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
    public partial class SelectHeadsOfEstablishmentsTableForm : Form
    {
        #region Поля класса

        Command controlCommand = new Command();

        string valueSelectedEstablishment = "";

        //Дописать запросы
        string partQueryBeforeWhere;
        string partQueryAfterWhere;

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
            //Передать конструктору ссылку на класс Command();
        }
    }
}
