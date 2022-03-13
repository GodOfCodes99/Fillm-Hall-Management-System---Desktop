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

    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == "Admin" || txtpassword.Text == "password1")
                {
                    this.Hide(); 
                    mainform for1 = new mainform();
                    for1.Show();
                }
                else if (txtusername.Text =="Counter" || txtpassword.Text=="password2" )
                {
                    this.Hide(); 
                    main_menu_counter for2 = new main_menu_counter();
                    for2.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotpassword_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
    }
}
