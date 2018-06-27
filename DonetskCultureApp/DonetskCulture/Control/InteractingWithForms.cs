using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonetskCulture.Control
{
    class InteractingWithForms
    {

        //Заполняем комбобоксы
        public void FillComboBox(List<string> list, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            object[] arrayObjects = list.Cast<object>().ToArray();
            comboBox.Items.AddRange(arrayObjects);
        }

        //Парсим строку для получения ид
        public string ParseForGetID(string rawString)
        {
            string result = null;
            foreach (char symbol in rawString)
            {
                if (char.IsDigit(symbol))
                    result += symbol;
                else break;
            }
            return result;
        }

        //Очистка формы от записей
        public void ClearForm(ComboBox[] comboBoxes = null, TextBox[] textBoxes = null)
        {
            if (comboBoxes != null)
            {
                foreach (var item in comboBoxes)
                    item.Text = "";
            }
            if (textBoxes != null)
            {
                foreach (var item in textBoxes)
                    item.Text = "";
            }
        }
    }
}
