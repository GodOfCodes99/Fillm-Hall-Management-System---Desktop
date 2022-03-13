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
    public partial class main_menu_counter : Form
    {
        public main_menu_counter()
        {
            InitializeComponent();
        }

        private void issueTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                issueticket myForm = new issueticket();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                Panel1.Controls.Add(myForm);
                myForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "";
                connectionString = @"Data Source = SUPUNPIYUMANTHA\SQLEXPRESS; Initial catalog = FilmHall ; Integrated Security = true";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = @"UPDATE normal_ticket SET Status = Null"; ;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                cnn.Open();
                string sql2 = @"UPDATE balcony_ticket SET Status = Null"; ;
                SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                cmd2.ExecuteNonQuery();
                cnn.Close();
                string sql3 = @"UPDATE box_ticket SET Status = Null"; ;
                SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Successfull Reset", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Successfull Reset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void contactUsRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anotherLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login for1 = new login();
            for1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
        }
    }
}
