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


        public void FillComboBox(List<string> list, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            object[] arrayObjects = list.Cast<object>().ToArray();
            comboBox.Items.AddRange(arrayObjects);
        }
    }
}
