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
    public partial class wagecuts : Form
    {
        public wagecuts()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                MySqlCommand command2;
                connection2.Open();
                String insertQuery2 = "update FilmHall.Salary set Pay_Cuts = '" + txtvalue.Text + "',Reason_For_Pay_Cuts = '" + txtreason.Text + "'where NIC = '" + txtnic.Text + "';";
                command2 = new MySqlCommand(insertQuery2, connection2);
                if (command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection2.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtnic.Text = "";
            txtreason.Text = "";
            txtvalue.Text = "";
        }
    }
}
