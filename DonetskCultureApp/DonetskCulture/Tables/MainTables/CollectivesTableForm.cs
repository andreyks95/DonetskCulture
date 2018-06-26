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
        string partSelectSearchQueryWithGroup = " SELECT collectives.id_collective AS 'ID колективу', collectives.name AS 'Назва', collectives.form AS 'Форма', " +
                                                " collectives.genre AS 'Жанр', collectives.ageCategory AS 'Вікова категорія', collectives.rank AS 'Звання' " +
                                                " FROM donetsk_culture.collectives " +
                                                " WHERE lower(CONCAT(COALESCE(collectives.id_collective,''), ' ', " +
                                                " COALESCE(collectives.name,''), ' ', COALESCE(collectives.form,''), ' ', " +
                                                " COALESCE(collectives.genre,''), ' ', COALESCE(collectives.ageCategory,''), ' ', " +
                                                " COALESCE(collectives.rank,''), ' ' )) like ";

        //часть запроса для поиска 
        string partSelectSearchQuery = " SELECT collectives.id_collective AS 'ID колективу', collectives.name AS 'Назва', collectives.form AS 'Форма', " +
                                       " collectives.genre AS 'Жанр', collectives.ageCategory AS 'Вікова категорія', collectives.rank AS 'Звання', " +
                                       " managers_collectives.fullName AS 'ПІБ керівника' " +
                                       " FROM(donetsk_culture.collectives LEFT JOIN donetsk_culture.managers_collectives ON collectives.id_manager = managers_collectives.id_manager) " +
                                       " WHERE lower(CONCAT(COALESCE(collectives.id_collective,''), ' ',  " +
                                       " COALESCE(collectives.name,''), ' ', COALESCE(collectives.form,''), ' ', " +
                                       " COALESCE(collectives.genre,''), ' ', COALESCE(collectives.ageCategory,''), ' ', " +
                                       " COALESCE(collectives.rank,''), ' ', COALESCE(managers_collectives.fullName,''), ' ')) like ";


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

        //Получаем данные с DataGridView и заполняем поля
        private void GetDataDataGrid()
        {

            try
            {
                IDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? "";
                nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                formTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                genreTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ageCategoryComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                rankComboBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //managerComboBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                if (!GroupByNameDGVCheckBox.Checked)
                {
                    managerComboBox.Text = dataGridView1.CurrentRow.Cells[6].Value?.ToString() ?? "";
                }
                else
                {
                    managerComboBox.Text = "";
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
            GetDataDataGrid();
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

        //Заполняем ComboBox для отображения руководителей
        private void managerComboBox_Enter(object sender, EventArgs e)
        {
            string query = " SELECT CONCAT(COALESCE(managers_collectives.id_manager, ''), ' ', COALESCE(managers_collectives.fullName, ''), ' ', " +
                            " COALESCE(managers_collectives.rankManager, ''), ' ', COALESCE(managers_collectives.education, ''), ' ', " +
                            " COALESCE(managers_collectives.experience, ''), ' ', COALESCE(managers_collectives.phone, ''), ' ', " +
                            " COALESCE(managers_collectives.email, ''), ' ') AS 'Result' " +
                            " From donetsk_culture.managers_collectives; ";


            List<string> result = controlCommand.ExecuteReaderOneGetString(query);
            interactingWithForms.FillComboBox(result, managerComboBox);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            interactingWithForms.ClearForm(new[] { ageCategoryComboBox, rankComboBox, managerComboBox }, new[] { IDTextBox, nameTextBox, formTextBox, genreTextBox });
        }

        #region Работа с записями: Вставка, удаление, изменение

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.collectives " +
                                         "VALUES(@id_collective, @name, @form, @genre, @ageCategory, @rank, @id_manager)";
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
                string queryUpdate = "UPDATE donetsk_culture.collectives SET " +
                    " id_collective=@id_collective, name=@name, form=@form, genre=@genre, ageCategory=@ageCategory, rank=@rank, id_manager=@id_manager " +
                    "WHERE id_collective=@id_collective";
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
                string queryDelete = "DELETE FROM donetsk_culture.collectives WHERE id_collective=@id_collective";
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


        //Группирирование 
        private void GroupByNameDGVCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!GroupByNameDGVCheckBox.Checked)
                {
                    string query =     " SELECT collectives.id_collective AS 'ID колективу', collectives.name AS 'Назва', collectives.form AS 'Форма', " +
                                       " collectives.genre AS 'Жанр', collectives.ageCategory AS 'Вікова категорія', collectives.rank AS 'Звання', " +
                                       " managers_collectives.fullName AS 'ПІБ керівника' " +
                                       " FROM(donetsk_culture.collectives LEFT JOIN donetsk_culture.managers_collectives ON collectives.id_manager = managers_collectives.id_manager); ";

                    table = controlCommand.FillDataGridView(dataGridView1, query);
                    dataGridView1.Columns[6].Visible = true;
                    bindingManagerBase = this.BindingContext[table];
                }
                else
                {
                    table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
                    dataGridView1.Columns[6].Visible = false;
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
    }
}
