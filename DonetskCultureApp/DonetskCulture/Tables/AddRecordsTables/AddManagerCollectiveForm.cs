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
    public partial class AddManagerCollectiveForm : Form
    {

       Command controlCommand;// = new Command();

        //Класс для взаимодействия с классами
        InteractingWithForms interactingWithForms = new InteractingWithForms();

        string[] parametersTableSQL = new string[] { "@id_manager", "@fullName", "@rankManager", "@education", "@experience", "@phone", "@email" };

        public AddManagerCollectiveForm()
        {
            InitializeComponent();
        }

        public AddManagerCollectiveForm(Command command): this()
        {
            controlCommand = command;
        }

        private string[] GetValuesFromForm()
        {
            //Вытаскиваем данные во время ввода
            string idText =          IDTextBox.Text;
            string fullName =        fullNameTextBox.Text;
            string rank =            rankManagerTextBox.Text;
            string education =       educationTextBox.Text;
            string experience = experienceTextBox.Text?.ToString();
            if(String.IsNullOrEmpty(experience) && String.IsNullOrWhiteSpace(experience))
            {
                experience = "0";
            }
            string phone =           phoneTextBox.Text;
            string email =           mailTextBox.Text;
           
            //Полученные значения с формы
            return new string[] { idText, fullName, rank, education, experience, phone, email };
        }

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            //Исправить
            try
            {
                string queryInsert = "INSERT INTO donetsk_culture.managers_collectives " +
                                         "VALUES( @id_manager, @fullName, @rankManager, @education, @experience, @phone, @email);";
                controlCommand.Insert(parametersTableSQL, GetValuesFromForm(), queryInsert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n викликаний методом AddManagerButton_Click" + "\n" + ex.StackTrace);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { IDTextBox, fullNameTextBox, rankManagerTextBox, educationTextBox, experienceTextBox, phoneTextBox, mailTextBox };
            interactingWithForms.ClearForm(textBoxes: textBoxes );
        }                                            
    }                                                
}                                                    
                                                     
                                                     
                                                     