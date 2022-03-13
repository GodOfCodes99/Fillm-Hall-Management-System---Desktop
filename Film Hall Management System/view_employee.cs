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
    public partial class viewemployee : Form
    {
        public viewemployee()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");
                string sql = @"select * from FilmHall.Employee where NIC like'" + txtnic.Text + "%'"; ;
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                ada.Fill(datatable);
                datatable1.DataSource = datatable;

            }

            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtnic.Text = "";

        }
    }
}
