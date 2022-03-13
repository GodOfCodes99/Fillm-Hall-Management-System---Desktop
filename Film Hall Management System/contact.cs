using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Film_Hall_Management_System
{
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");
            string sql = @"select * from FilmHall.Contactus"; ;
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            ada.Fill(datatable);
            datatable1.DataSource = datatable;
        }

        private void datatable1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contact_Load(object sender, EventArgs e)
        {

        }
    }
}
