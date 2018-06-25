using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonetskCulture.Control;
using MySql.Data.MySqlClient;
using DonetskCulture.Tables;

namespace DonetskCulture
{
    public partial class EstablishmentsTableForm : Form
    {
        #region Поля класса
        //Fields
        //MySqlConnection connection;//= Connection.GetConnection; //Избыточное
        Command controlCommand = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();

        string otherQuery = " SELECT  id_establishment AS 'ID', " +
            " name         AS 'Назва закладу',     " +
            " regionOrCity AS 'Район/Місто',       " +
            " address      AS 'Адреса',            " +
            " formWork AS 'Форма роботи',          " +
            " state        AS 'Стан'               " +
            " FROM donetsk_culture.establishments  " +
            " GROUP BY(name)                       ";

        string partSelectSearchQueryWithGroup = " SELECT id_establishment AS 'ID', " +
                " name  AS 'Назва закладу', " +
                " regionOrCity AS 'Район/Місто', " +
                " address      AS 'Адреса', " +
                " formWork AS 'Форма роботи', " +
                " state        AS 'Стан' " +
                " FROM donetsk_culture.establishments " +
                " WHERE lower(CONCAT(COALESCE(establishments.id_establishment,''), ' ',  " +
                " COALESCE(establishments.name,''), ' ', COALESCE(establishments.regionOrCity,''), ' ', " +
                " COALESCE(establishments.address,''), ' ', COALESCE(establishments.formWork,''), ' ', " +
                " COALESCE(establishments.state,''), ' ' )) like ";


        string partSelectSearchQuery = " SELECT   establishments.id_establishment AS 'ID', " +
                " establishments.name AS 'Назва закладу', " +
                " establishments.regionOrCity AS 'Район/Місто', " +
                " establishments.address AS 'Адреса', " +
                " establishments.formWork AS 'Форма роботи', " +
                " establishments.state AS 'Стан', " +
                " collectives.name AS 'Назва колективу', " +
                " heads_establishments.fullName AS 'Керівник закладу' " +
                " FROM((donetsk_culture.establishments " +
                " LEFT JOIN donetsk_culture.collectives ON establishments.id_collective = collectives.id_collective) " +
                " LEFT JOIN donetsk_culture.heads_establishments ON establishments.id_head = heads_establishments.id_head) " +
                " WHERE lower(CONCAT(COALESCE(establishments.id_establishment,''), ' ', COALESCE(establishments.name,''), ' ', COALESCE(establishments.regionOrCity,''), ' ', " +
                " COALESCE(establishments.address,''), ' ', COALESCE(establishments.formWork,''), ' ', COALESCE(establishments.state,''), ' ', " +
                " COALESCE(collectives.name, ''), ' ', COALESCE(heads_establishments.fullName, ''), ' ' )) like ";


        string[] parametersTableSQL = new string[] { "@id_establishment", "@name", "@regionOrCity", "@address", "@formWork", "@state", "@id_collective", "@id_head" };

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion

        //Constructors
        public EstablishmentsTableForm(MySqlConnection connect)
        {
            InitializeComponent();
            //connection = connect; //Избыточное
            //TryConnectDB();
        }


        //Отображаем БД на экран
        private void EstablishmentsTableForm_Load(object sender, EventArgs e)
        {
            //ShowDatabase();
            //string query = partSelectSearchQuery + " '%" + "" + "%'";
            table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
            bindingManagerBase = this.BindingContext[table];
        }

        //Получаем данные с DataGridView и заполняем поля
        private void GetDataDataGrid()
        {
            //string zahlushka = "";
            try
            {
                //zahlushka = dataGridView1.CurrentRow.Cells?.ToString() ?? "";

                IDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? "";

                //zahlushka = dataGridView1.CurrentRow.Cells?.ToString() ?? "";

                nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                regionOrCityTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                addressTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                formWorkComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string valueForRadioButton = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if (valueForRadioButton == "Функціонує")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                if (!GroupByNameDGVCheckBox.Checked)
                {
                    collectiveOfEstablishmentComboBox.Text = dataGridView1.CurrentRow.Cells[6].Value?.ToString() ?? "";
                    managerOfEstablishmentComboBox.Text = dataGridView1.CurrentRow.Cells[7].Value?.ToString() ?? "";
                }
                else
                {
                    collectiveOfEstablishmentComboBox.Text = "";
                    managerOfEstablishmentComboBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message + "\n вызван методом GetDataDataGrid");
                // Console.WriteLine(ex.Message + "\n вызван методом GetDataDataGrid");

                //MessageBox.Show(ex.Source + "\n\n" + ex.StackTrace + "\n\n" + ex.TargetSite);
            }
        }

        //Заполняем поля формы когда щёлкаем на DataGrid
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            GetDataDataGrid();
        }

        //Заполняем поля формы когда изменяется выбор строки в DataGrid
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //controlCommand.FillDataGridView(dataGridView1, otherQuery);
            GetDataDataGrid();
        }


        //Users Generated Methods


        private string[] GetValuesFromForm()
        {
            //Вытаскиваем данные во время ввода
            string idText = IDTextBox.Text;
            string name = nameTextBox.Text;
            string region = regionOrCityTextBox.Text;
            string address = addressTextBox.Text;
            string formWork = formWorkComboBox.SelectedItem?.ToString(); //Если что-то есть в выбранном пункте, то конвертируем
            string function = "";
            if (radioButton1.Checked)
                function = "Функціонує";
            else if (radioButton2.Checked)
                function = "Не функціонує";
            string collective = collectiveOfEstablishmentComboBox.SelectedItem?.ToString();
            string heads = managerOfEstablishmentComboBox.SelectedItem?.ToString();
            if (!String.IsNullOrEmpty(collective) && !String.IsNullOrWhiteSpace(collective))
                collective = interactingWithForms.ParseForGetID(collective);
            if (!String.IsNullOrEmpty(heads) && !String.IsNullOrWhiteSpace(heads))
                heads = interactingWithForms.ParseForGetID(heads);

            //Полученные значения с формы
            return new string[] { idText, name, region, address, formWork, function, collective, heads };
        }

        #region Работа с записями: Вставка, удаление, изменение

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.establishments " +
                                         "VALUES(@id_establishment, @name, @regionOrCity, @address, @formWork, @state, @id_collective, @id_head )";
                controlCommand.Insert(parametersTableSQL, GetValuesFromForm(), queryInsert);
                table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
                bindingManagerBase = this.BindingContext[table];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом InsertButton_Click");
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryUpdate = "UPDATE donetsk_culture.establishments SET " +
                    "name=@name, regionOrCity=@regionOrCity, address=@address, formWork=@formWork,  state=@state, id_collective=@id_collective, id_head=@id_head  " +
                    "WHERE id_establishment=@id_establishment";
                controlCommand.Update(parametersTableSQL, GetValuesFromForm(), queryUpdate);
                table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
                bindingManagerBase = this.BindingContext[table];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом UpdateButton_Click");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryDelete = "DELETE FROM donetsk_culture.establishments WHERE id_establishment=@id_establishment";
                controlCommand.Delete(parametersTableSQL, GetValuesFromForm(), queryDelete);
                table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
                bindingManagerBase = this.BindingContext[table];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом DeleteButton_Click");
            }
        }

        #endregion

        #region Реализация поиска в таблице

        //Для поиска с группировкой
        private void DoSearchWithGroup()
        {

            string query = partSelectSearchQueryWithGroup + " lower('%" + SearchTextBox.Text.ToString() + "%') group by name;";
            table = controlCommand.FillDataGridView(dataGridView1, query);
            bindingManagerBase = this.BindingContext[table];
        }

        private void DoSearch()
        {
            string query = partSelectSearchQuery + " lower('%" + SearchTextBox.Text.ToString() + "%');";
            table = controlCommand.FillDataGridView(dataGridView1, query);
            bindingManagerBase = this.BindingContext[table];
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (GroupByNameDGVCheckBox.Checked)
            {
                DoSearchWithGroup();
                //dataGridView1.Columns[6].Visible = false;
                //dataGridView1.Columns[7].Visible = false;
            }
            else
            {
                DoSearch();
                //dataGridView1.Columns[6].Visible = true;
                //dataGridView1.Columns[7].Visible = true;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (GroupByNameDGVCheckBox.Checked)
            {
                DoSearchWithGroup();
                //dataGridView1.Columns[6].Visible = false;
                //dataGridView1.Columns[7].Visible = false;
            }
            else
            {
                DoSearch();
                //dataGridView1.Columns[6].Visible = true;
                //dataGridView1.Columns[7].Visible = true;
            }
        }

        #endregion

        #region Перемещение по таблице
        private void firstRecordButton_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position = 0;
        }

        private void previousRecordButton_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position -= 1;
        }

        private void nextRecordButton_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position += 1;
        }

        private void lastRecordButton_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position = bindingManagerBase.Count;
        }

        #endregion





        //Заполняем существующий комбобокс колективами
        private void collectiveOfEstablishmentComboBox_Enter(object sender, EventArgs e)
        {
            string query = " SELECT CONCAT(COALESCE(collectives.id_collective,''), ' ', COALESCE(collectives.name,''), ' ', COALESCE(collectives.form,''), ' ', " +
                 " COALESCE(collectives.genre, ''), ' ', COALESCE(collectives.ageCategory, ''), ' ', COALESCE(collectives.rank, ''), ' ' ) AS 'Result' " +
                 " From donetsk_culture.collectives; ";

            List<string> result = controlCommand.ExecuteReaderOneGetString(query);
            interactingWithForms.FillComboBox(result, collectiveOfEstablishmentComboBox);
        }

        //Заполняем Комбобокс существующими руководителями учреждения 
        private void managerOfEstablishmentComboBox_Enter(object sender, EventArgs e)
        {
            string query = " SELECT CONCAT(COALESCE(heads_establishments.id_head, ''), ' ', COALESCE(heads_establishments.fullName, ''), ' ', " +
                " COALESCE(heads_establishments.adminCorps, ''), ' ', " +
                " COALESCE(heads_establishments.phone, ''), ' ', COALESCE(heads_establishments.email, ''), ' ') AS 'Result' " +
                " From donetsk_culture.heads_establishments; ";
            List<string> result = controlCommand.ExecuteReaderOneGetString(query);
            interactingWithForms.FillComboBox(result, managerOfEstablishmentComboBox);
        }


        //Чек-бокс для группировки по коллективу
        private void GroupByNameDGVCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!GroupByNameDGVCheckBox.Checked)
                {
                    string query = " SELECT   establishments.id_establishment AS 'ID',     " +
                                    " establishments.name AS 'Назва закладу',               " +
                                    " establishments.regionOrCity AS 'Район/Місто',         " +
                                    " establishments.address AS 'Адреса',                   " +
                                    " establishments.formWork AS 'Форма роботи',            " +
                                    " establishments.state AS 'Стан',                       " +
                                    " collectives.name AS 'Назва колективу',                " +
                                    " heads_establishments.fullName AS 'Керівник закладу'   " +
                                    " FROM((donetsk_culture.establishments                  " +
                                    " LEFT JOIN donetsk_culture.collectives ON establishments.id_collective = collectives.id_collective) " +
                                    " LEFT JOIN donetsk_culture.heads_establishments ON establishments.id_head = heads_establishments.id_head);";
                    table = controlCommand.FillDataGridView(dataGridView1, query);
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
                    bindingManagerBase = this.BindingContext[table];
                }
                else
                {

                    //dataGridView1.Update();
                    //dataGridView1.Refresh();
                    table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    bindingManagerBase = this.BindingContext[table];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом GroupByNameDGVCheckBox_CheckedChanged");
            }
        }

        #region Отображение колективов и руководителей которые относятся к выбранному заведению 

        private void ShowCollectives_Button_Click(object sender, EventArgs e)
        {
            //string nameEstablishment = nameTextBox.Text?.ToString() ?? "";
            string valueNameEstablishmentColumn = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
            //if (String.Compare(nameEstablishment, valueNameEstablishmentColumn, true) == 0)
            if(!String.IsNullOrEmpty(valueNameEstablishmentColumn) && !String.IsNullOrWhiteSpace(valueNameEstablishmentColumn))
            {
                SelectCollectivesOfEstablishmentsTableForm selectedCollectives = new SelectCollectivesOfEstablishmentsTableForm(valueNameEstablishmentColumn);
                selectedCollectives.Show();
            }
            else
            {
                MessageBox.Show("Увага!!! \n Виберіть заклад культури в таблиці! ");
            }
        }

        private void ShowHeads_Button_Click(object sender, EventArgs e)
        {
            string valueNameEstablishmentColumn = dataGridView1.CurrentRow.Cells[1].Value?.ToString();

            if (!String.IsNullOrEmpty(valueNameEstablishmentColumn) && !String.IsNullOrWhiteSpace(valueNameEstablishmentColumn))
            {
                SelectHeadsOfEstablishmentsTableForm selectedHeads = new SelectHeadsOfEstablishmentsTableForm(valueNameEstablishmentColumn);
                selectedHeads.Show();
            }
            else
            {
                MessageBox.Show("Увага!!! \n Виберіть заклад культури в таблиці! ");
            }
        }

        #endregion

        private void ClearButton_Click(object sender, EventArgs e)
        {
            interactingWithForms.ClearForm(new[] {formWorkComboBox, collectiveOfEstablishmentComboBox, managerOfEstablishmentComboBox }, 
                new[] { IDTextBox, nameTextBox, regionOrCityTextBox, addressTextBox, });
        }
    }
}
