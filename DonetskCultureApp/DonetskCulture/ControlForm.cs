using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonetskCulture
{
    public partial class ControlForm : Form
    {
        MySqlConnection sqlConnection;
        
        public ControlForm()
        {
            InitializeComponent();
        }

        public ControlForm(MySqlConnection con) : this()
        {
            sqlConnection = con;
        }

        private void EstablishmentsButton_Click(object sender, EventArgs e)
        {
            EstablishmentsTableForm establishmentsTableForm = new EstablishmentsTableForm(sqlConnection);
            establishmentsTableForm.Show();
        }
    }
}
