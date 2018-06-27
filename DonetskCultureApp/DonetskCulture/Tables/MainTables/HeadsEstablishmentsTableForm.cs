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

namespace DonetskCulture.Tables.MainTables
{
    public partial class HeadsEstablishmentsTableForm : Form
    {

        #region Поля класса
        //Fields
        //MySqlConnection connection;//= Connection.GetConnection; //Избыточное
        Command controlCommand = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();

        //запрос с группированием
        private string otherQuery = "";

        //часть запроса для поиска с учётом группировки
        string partSelectSearchQuery = "";

        string[] parametersTableSQL = new string[] {  };

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion

        public HeadsEstablishmentsTableForm()
        {
            InitializeComponent();
        }

        public HeadsEstablishmentsTableForm(Command command):this()
        {
            controlCommand = command;
        }

        private void HeadsEstablishmentsTableForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void GroupByNameDGVCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void firstRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void previousRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void nextRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void lastRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }


    }
}
