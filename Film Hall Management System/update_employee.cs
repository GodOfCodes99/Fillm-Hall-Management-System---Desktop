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
    public partial class updateemployee : Form
    {
        public updateemployee()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to Update " + System.Environment.NewLine + "This Person's Details ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (txtname.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Employee set Name = '" + txtupdate.Text + "'where NIC = '" + txtnic.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }

                    if (txtaddress.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Employee set Address = '" + txtupdate.Text + "'where NIC = '" + txtnic.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }

                    if (txtjobrole.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Employee set Job_Role = '" + txtupdate.Text + "'where NIC = '" + txtnic.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }

                    if (txtbasicsalary.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Salary set Basic_Salary = '" + txtupdate.Text + "'where NIC = '" + txtnic.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }
                    if (txttel.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Employee set Tel = '" + txtupdate.Text + "'where NIC = '" + txtnic.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }

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
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Please Avoid these Mistakes Again", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtupdate.Text = "";
            txtnic.Text = "";
        }
    }
}
