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
using System.IO;

namespace Film_Hall_Management_System
{
    public partial class addremoveexpences : Form
    {
        public addremoveexpences()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtinvoiceno.Text != null || txtdetails.Text != null || txtrs.Text != null)
                {
                    MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                    MySqlCommand command2;
                    connection2.Open();
                    String insertQuery2 = "insert into FilmHall.Expences(Invoice_No,Details,Value)values(@invoice,@details,@value)";
                    command2 = new MySqlCommand(insertQuery2, connection2);
                    command2.Parameters.Add("@invoice", MySqlDbType.VarChar, 20);
                    command2.Parameters.Add("@details", MySqlDbType.VarChar, 500);
                    command2.Parameters.Add("@value", MySqlDbType.VarChar, 50);

                    command2.Parameters["@invoice"].Value = txtinvoiceno.Text;
                    command2.Parameters["@details"].Value = txtdetails.Text;
                    command2.Parameters["@value"].Value = txtrs.Text;
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection2.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to Remove " + System.Environment.NewLine + "This Record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                        MySqlCommand command2;
                        connection2.Open();
                        String insertQuery2 = "delete from FilmHall.Expences where Invoice_No like'" + txtinvoiceremove.Text + "%'"; ;
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
                    MessageBox.Show("Please Avoid these Mistakes Again", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtdetails.Text = "";
            txtinvoiceno.Text = "";
            txtrs.Text = "";
        }

        private void clearremove_Click(object sender, EventArgs e)
        {
            txtinvoiceremove.Text = "";
        }
    }
}
