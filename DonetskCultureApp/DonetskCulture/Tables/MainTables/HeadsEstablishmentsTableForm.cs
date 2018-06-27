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
        private string otherQuery = " select heads_establishments.id_head AS 'ID керівника', " +
                                    " heads_establishments.fullName AS 'ПІБ керівника', heads_establishments.adminCorps AS 'Адміністративний корпус', " +
                                    " heads_establishments.phone AS 'Телефон', heads_establishments.email AS 'E-mail' " +
                                    " from donetsk_culture.heads_establishments group by fullName; ";

        //часть запроса для поиска с учётом группировки
        string partSelectSearchQuery = " select heads_establishments.id_head AS 'ID керівника', " +
                        " heads_establishments.fullName AS 'ПІБ керівника', heads_establishments.adminCorps AS 'Адміністративний корпус', " +
                        " heads_establishments.phone AS 'Телефон',heads_establishments.email AS 'E-mail' " +
                        " from donetsk_culture.heads_establishments " +
                        " WHERE lower(CONCAT(COALESCE(heads_establishments.id_head,''), ' ',  COALESCE(heads_establishments.fullName,''), ' ', " +
                        " COALESCE(heads_establishments.adminCorps,''), ' ', COALESCE(heads_establishments.phone,''), ' ', COALESCE(heads_establishments.email,''), ' ')) like ";

        string[] parametersTableSQL = new string[] { "@id_head",  "@fullName", "@adminCorps", "@phone", "@email" };

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


        //Отобразить сгруппированные по ФИО руководителей 
        private void HeadsEstablishmentsTableForm_Load(object sender, EventArgs e)
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
                adminCorpsTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                phoneTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                mailTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
            string adminCorps = adminCorpsTextBox.Text;
            string phone = phoneTextBox.Text;
            string mail = mailTextBox.Text;

            //Полученные значения с формы
            return new string[] { idText, fullName, adminCorps, phone, mail };
        }


        #region Работа с записями: Вставка, удаление, изменение

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.heads_establishments " +
                                         " VALUES(@id_head, @fullName, @adminCorps, @phone, @email)";
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
                string queryUpdate = " UPDATE donetsk_culture.heads_establishments SET " +
                    " id_head=@id_head, fullName=@fullName, adminCorps=@adminCorps, phone=@phone, email=@email " +
                    " WHERE id_head=@id_head";
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
                string queryDelete = "DELETE FROM donetsk_culture.heads_establishments WHERE id_head=@id_head";
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
                    string query = "  select heads_establishments.id_head AS 'ID керівника', " +
                                    " heads_establishments.fullName AS 'ПІБ керівника', heads_establishments.adminCorps AS 'Адміністративний корпус', " +
                                    " heads_establishments.phone AS 'Телефон', heads_establishments.email AS 'E-mail' " +
                                    " from donetsk_culture.heads_establishments ";

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
            TextBox[] textBoxes = new TextBox[] { IDTextBox, fullNameTextBox, adminCorpsTextBox, phoneTextBox, mailTextBox };
            interactingWithForms.ClearForm(textBoxes: textBoxes);
        }


    }
}
