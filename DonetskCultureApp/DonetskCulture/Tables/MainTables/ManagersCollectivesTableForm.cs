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
    public partial class ManagersCollectivesTableForm : Form
    {

        #region Поля класса
        //Fields
        //MySqlConnection connection;//= Connection.GetConnection; //Избыточное
        Command controlCommand = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();

        //запрос с группированием
        private string otherQuery = " SELECT managers_collectives.id_manager AS 'ID керівника', managers_collectives.fullName AS 'ПІБ керівника', " +
                            " managers_collectives.rankManager AS 'Звання', managers_collectives.education AS 'Освіта', " +
                            " managers_collectives.experience AS 'Стаж роботи', managers_collectives.phone AS 'Телефон', " +
                            " managers_collectives.email AS 'E-mail' " +
                            " FROM donetsk_culture.managers_collectives GROUP BY(fullName); ";

        //часть запроса для поиска с учётом группировки
        string partSelectSearchQuery = " SELECT managers_collectives.id_manager AS 'ID керівника', managers_collectives.fullName AS 'ПІБ керівника', " +
                                                " managers_collectives.rankManager AS 'Звання', managers_collectives.education AS 'Освіта', " +
                                                " managers_collectives.experience AS 'Стаж роботи', managers_collectives.phone AS 'Телефон', " +
                                                " managers_collectives.email AS 'E-mail' " +
                                                " FROM donetsk_culture.managers_collectives " +
                                                " WHERE lower(CONCAT(COALESCE(managers_collectives.id_manager,''), ' ',  COALESCE(managers_collectives.fullName,''), ' ', " +
                                                " COALESCE(managers_collectives.rankManager,''), ' ', COALESCE(managers_collectives.education,''), ' ', COALESCE(managers_collectives.experience,''), ' ', " +
                                                " COALESCE(managers_collectives.phone,''), ' ', COALESCE(managers_collectives.email,''), ' ' )) like ";

        string[] parametersTableSQL = new string[] { "@id_manager", "@fullName", "@rankManager", "@education", "@experience", "@phone", "@email" };

        BindingManagerBase bindingManagerBase;
        DataTable table;

        #endregion

        public ManagersCollectivesTableForm()
        {
            InitializeComponent();
        }

        public ManagersCollectivesTableForm(Command command): this()
        {
            controlCommand = command;
        }

        //Отобразить сгруппированные по ФИО руководителей 
        private void ManagersCollectivesTableForm_Load(object sender, EventArgs e)
        {
            table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
            bindingManagerBase = this.BindingContext[table];
        }

        //Получаем данные с DataGridView и заполняем поля
        private void GetDataDataGrid()
        {
            try
            {
                IDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? "";
                fullNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                rankManagerTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                educationTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                experienceTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                phoneTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                mailTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
            GetDataDataGrid();
        }

        private string[] GetValuesFromForm()
        {
            //Вытаскиваем данные во время ввода
            string idText = IDTextBox.Text;
            string fullName = fullNameTextBox.Text;
            string rank = rankManagerTextBox.Text;
            string education = educationTextBox.Text;
            string experience = experienceTextBox.Text?.ToString();
            if (String.IsNullOrEmpty(experience) && String.IsNullOrWhiteSpace(experience))
            {
                experience = "0";
            }
            string phone = phoneTextBox.Text;
            string email = mailTextBox.Text;

            //Полученные значения с формы
            return new string[] { idText, fullName, rank, education, experience, phone, email };
        }
        #region Работа с записями: Вставка, удаление, изменение

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.managers_collectives " +
                                         "VALUES( @id_manager, @fullName, @rankManager, @education, @experience, @phone, @email);";
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
                //Old query
                string queryUpdate = "UPDATE donetsk_culture.managers_collectives SET " +
                    " id_manager=@id_manager, fullName=@fullName, rankManager=@rankManager, education=@education, experience=@experience, phone=@phone, email=@email " +
                    "WHERE id_manager=@id_manager";
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
                string queryDelete = "DELETE FROM donetsk_culture.managers_collectives WHERE id_manager=@id_manager";
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

        //Для управления группировкой
        private void GroupByNameDGVCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!GroupByNameDGVCheckBox.Checked)
                {
                    string query = " SELECT managers_collectives.id_manager AS 'ID керівника', managers_collectives.fullName AS 'ПІБ керівника', " +
                            " managers_collectives.rankManager AS 'Звання', managers_collectives.education AS 'Освіта', " +
                            " managers_collectives.experience AS 'Стаж роботи', managers_collectives.phone AS 'Телефон', " +
                            " managers_collectives.email AS 'E-mail' " +
                            " FROM donetsk_culture.managers_collectives; ";

                    table = controlCommand.FillDataGridView(dataGridView1, query);
                    bindingManagerBase = this.BindingContext[table];
                }
                else
                {
                    table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
                    bindingManagerBase = this.BindingContext[table];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом GroupByNameDGVCheckBox_CheckedChanged");
            }
        }

        #region Реализация поиска в таблице

        //Для поиска с группировкой
        private void DoSearchWithGroup()
        {

            string query = partSelectSearchQuery + " lower('%" + SearchTextBox.Text.ToString() + "%') group by fullName;";
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
            }
            else
            {
                DoSearch();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (GroupByNameDGVCheckBox.Checked)
            {
                DoSearchWithGroup();
            }
            else
            {
                DoSearch();
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { IDTextBox, fullNameTextBox, rankManagerTextBox, educationTextBox, experienceTextBox, phoneTextBox, mailTextBox };
            interactingWithForms.ClearForm(textBoxes: textBoxes);
        }
    }
}
