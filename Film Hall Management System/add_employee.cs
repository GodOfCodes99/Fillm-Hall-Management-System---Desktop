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
    public partial class addemployee : Form
    {
        public addemployee()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnic.Text != null || txtname.Text != null || txtsalary.Text != null || txtjobrole.Text != null || txtaddress.Text != null)
                {
                    MySqlConnection connection = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                    MySqlCommand command;

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    String insertQuery = "insert into FilmHall.Employee(NIC,Name,Address,Tel,Job_Role,Picture)values(@nic,@name,@address,@tel,@job,@picture)";
                    connection.Open();
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.Add("@nic", MySqlDbType.VarChar, 12);
                    command.Parameters.Add("@name", MySqlDbType.VarChar, 100);
                    command.Parameters.Add("@address", MySqlDbType.VarChar, 200);
                    command.Parameters.Add("@tel", MySqlDbType.VarChar, 10);
                    command.Parameters.Add("@job", MySqlDbType.VarChar, 50);
                    command.Parameters.Add("@picture", MySqlDbType.Blob);

                    command.Parameters["@nic"].Value = txtnic.Text;
                    command.Parameters["@name"].Value = txtname.Text;
                    command.Parameters["@address"].Value = txtaddress.Text;
                    command.Parameters["@tel"].Value = txttel.Text;
                    command.Parameters["@job"].Value = txtjobrole.Text;
                    command.Parameters["@picture"].Value = img;
                    command.ExecuteNonQuery();



                    connection.Close();

                    MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                    MySqlCommand command2;
                    connection2.Open();
                    String insertQuery2 = "insert into FilmHall.Salary(NIC,Basic_Salary)values(@nic,@salary)";
                    command2 = new MySqlCommand(insertQuery2, connection2);
                    command2.Parameters.Add("@nic", MySqlDbType.VarChar, 12);
                    command2.Parameters.Add("@salary", MySqlDbType.VarChar, 50);

                    command2.Parameters["@nic"].Value = txtnic.Text;
                    command2.Parameters["@salary"].Value = txtsalary.Text;
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

        private void clear_Click(object sender, EventArgs e)
        {
            txtnic.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txttel.Text = "";
            txtsalary.Text = "";
            txtjobrole.Text = "";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
