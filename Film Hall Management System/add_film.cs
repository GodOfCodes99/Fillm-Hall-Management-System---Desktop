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
using MySql.Data.MySqlClient;
using System.IO;

namespace Film_Hall_Management_System
{
    public partial class addfilm : Form
    {

        public addfilm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfilmid.Text != null || txtfilmname.Text != null || txtfilmtime.Text != null || txtfilmstart.Text != null || txtfilmend.Text != null)
                {
                    MySqlConnection connection = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                    MySqlCommand command;

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    String insertQuery = "insert into FilmHall.Films(Film_ID,Film_Name,Filming_Time,Screening_Start_Date,Screening_Ending_Date,Picture)values(@id,@name,@time,@start,@end,@picture)";
                    connection.Open();
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar, 15);
                    command.Parameters.Add("@name", MySqlDbType.VarChar, 100);
                    command.Parameters.Add("@time", MySqlDbType.VarChar, 50);
                    command.Parameters.Add("@start", MySqlDbType.VarChar, 50); 
                    command.Parameters.Add("@end", MySqlDbType.VarChar, 50);
                    command.Parameters.Add("@picture", MySqlDbType.Blob);

                    command.Parameters["@id"].Value = txtfilmid.Text;
                    command.Parameters["@name"].Value = txtfilmname.Text;
                    command.Parameters["@time"].Value = txtfilmtime.Text;
                    command.Parameters["@start"].Value = txtfilmstart.Text;
                    command.Parameters["@end"].Value = txtfilmend.Text;
                    command.Parameters["@picture"].Value = img;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtfilmid_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtfilmid.Text = "";
            txtfilmname.Text = "";
            txtfilmtime.Text = "";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
