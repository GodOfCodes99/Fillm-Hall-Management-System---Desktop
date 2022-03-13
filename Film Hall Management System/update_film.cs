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
    public partial class updatefilm : Form
    {
        public updatefilm()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to Update " + System.Environment.NewLine + "This Films's Details ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (txtname.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Films set Film_Name = '" + txtupdate.Text + "'where Film_ID = '" + txtid.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();


                    }

                    if (txttime.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Films set Filming_Time = '" + txtupdate.Text + "'where Film_ID = '" + txtid.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }

                    if (txtstartdate.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Films set Screening_Start_Date = '" + txtupdate.Text + "'where Film_ID = '" + txtid.Text + "';";
                        command2 = new MySqlCommand(insertQuery2, connection2);
                        if (command2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection2.Close();
                    }

                    if (txtenddate.Checked == true)

                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "update FilmHall.Films set Screening_Ending_Date = '" + txtupdate.Text + "'where Film_ID = '" + txtid.Text + "';";
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
                        string sql = @"select * from FilmHall.Films where NIC like'" + txtid.Text + "%'"; ;
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
            txtid.Text = "";
        }
    }
}
