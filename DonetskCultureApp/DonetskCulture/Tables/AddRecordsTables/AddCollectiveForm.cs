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

        Command controlCommand = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();

        public AddCollectiveForm()
        {
            InitializeComponent();
        }

        private void managerComboBox_Enter(object sender, EventArgs e)
        {

            //Поменять запрос на отображение руководителей
            string query = " SELECT CONCAT(COALESCE(heads_establishments.id_head, ''), ' ', COALESCE(heads_establishments.fullName, ''), ' ', " +
                            " COALESCE(heads_establishments.adminCorps, ''), ' ', " +
                            " COALESCE(heads_establishments.phone, ''), ' ', COALESCE(heads_establishments.email, ''), ' ') AS 'Result' " +
                              " From donetsk_culture.heads_establishments; ";
            List<string> result = controlCommand.ExecuteReaderOneGetString(query);
            interactingWithForms.FillComboBox(result, managerComboBox);
        }

        //Добавить методы для вставки записи
        //Добавить методы для очистки формы

    }
}
