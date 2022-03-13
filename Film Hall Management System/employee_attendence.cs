using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Hall_Management_System
{
    public partial class employee_attendence : Form
    {
        public employee_attendence()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtnic.Text = "";
            txtworktime.Text = "";
            txtarrival.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "";
                connectionString = @"Data Source = SUPUNPIYUMANTHA\SQLEXPRESS; Initial catalog = FilmHall ; Integrated Security = true";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = @"insert into Attendence(NIC,Date,Arrival_Time,Work_Time)values ('" + txtnic.Text + "','" + txtdate.Text + "','" + txtarrival.Text + "','" + txtworktime.Text + "')"; ;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Marked", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

