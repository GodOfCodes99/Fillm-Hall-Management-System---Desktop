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
    public partial class online_ticket : Form
    {
        public online_ticket()
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
                String insertQuery2 = "insert into FilmHall.schedule(schedule_id,film_name,film_id,normal_tickets,box_tickets,date,time)values(@scheduleid,@fname,@fid,@normal,@box,@dat,@tim)";
                command2 = new MySqlCommand(insertQuery2, connection2);
                command2.Parameters.Add("@scheduleid", MySqlDbType.Int32);
                command2.Parameters.Add("@fname", MySqlDbType.VarChar, 500);
                command2.Parameters.Add("@fid", MySqlDbType.Int32);
                command2.Parameters.Add("@normal", MySqlDbType.Int32);
                command2.Parameters.Add("@box", MySqlDbType.Int32);
                command2.Parameters.Add("@dat", MySqlDbType.VarChar,100);
                command2.Parameters.Add("@tim", MySqlDbType.VarChar,10);


                command2.Parameters["@scheduleid"].Value = txtscheduleid.Text;
                command2.Parameters["@fname"].Value = txtfilmname.Text;
                command2.Parameters["@fid"].Value = txtid.Text;
                command2.Parameters["@normal"].Value = txtnormal.Text;
                command2.Parameters["@box"].Value = txtbox.Text;
                command2.Parameters["@dat"].Value = txtdate.Text;
                command2.Parameters["@tim"].Value = txttime.Text;
                if (command2.ExecuteNonQuery() == 1)
                {
                   MessageBox.Show("Successfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 connection2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
