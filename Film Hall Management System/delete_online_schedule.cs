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
    public partial class delete_online_schedule : Form
    {
        public delete_online_schedule()
        {
            InitializeComponent();
        }

        private void schedulesearch_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");
                string sql = @"select * from FilmHall.schedule where schedule_id like'" + txtscheduleid.Text + "%'"; ;
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to Delete " + System.Environment.NewLine + "This Schedule ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "delete from FilmHall.schedule where schedule_id like'" + txtscheduleid.Text + "%'"; ;
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Removed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured Please Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Please try to avoid these Mistakes Again", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
