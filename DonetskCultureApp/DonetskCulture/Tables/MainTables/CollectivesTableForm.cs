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
        string partSelectSearchQueryWithGroup = "";

        //часть запроса для поиска 
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

        //Отобразить сгруппированные по названию колективы 
        private void CollectivesTableForm_Load(object sender, EventArgs e)
        {
            table = controlCommand.FillDataGridView(dataGridView1, otherQuery);
            bindingManagerBase = this.BindingContext[table];
        }

        //ИСПРАВИТЬ ЭТОТ МЕТОД

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

    }
}
