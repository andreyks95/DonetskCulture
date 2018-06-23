using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCEntity
{
    public partial class Form1 : Form
    {
        ContextData db;
        public Form1()
        {
            InitializeComponent();
            db = new ContextData();
            foreach (Establishment est in db.Establishments)
            {
                MessageBox.Show(est.Id_establishment.ToString());


            }

        }


    }
}
