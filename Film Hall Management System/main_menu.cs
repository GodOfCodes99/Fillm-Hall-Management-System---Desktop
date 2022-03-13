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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();

        }

        private void filmOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Panel1.Controls.Clear();
                addremoveexpences myForm = new addremoveexpences();
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

        private void addFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                addfilm myForm = new addfilm();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                Panel1.Controls.Add(myForm);
                myForm.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showFilmDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            try
            {
                Panel1.Controls.Clear();
                showfilm myForm = new showfilm();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                Panel1.Controls.Add(myForm);
                myForm.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                deletefilm myForm = new deletefilm();
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

        private void updateFilmDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                updatefilm myForm = new updatefilm();
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

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                addemployee myForm = new addemployee();
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

        private void viewEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                viewemployee myForm = new viewemployee();
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

        private void deleteEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                deleteemployee myForm = new deleteemployee();
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

        private void updateEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                updateemployee myForm = new updateemployee();
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

        private void oTManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                otmanagement myForm = new otmanagement();
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

        private void viewHRMExpencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Panel1.Controls.Clear();
                viewexpences myForm = new viewexpences();
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

        private void totalRevenueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void issueTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                issue_tickets myForm = new issue_tickets();
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

        private void ticketRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editTicketPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wageCutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                wagecuts myForm = new wagecuts();
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

        private void salarySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                view_salary myForm = new view_salary();
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

        private void ticketOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "";
                connectionString = @"Data Source = SUPUNPIYUMANTHA\SQLEXPRESS; Initial catalog = filmhall ; Integrated Security = true";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = @"Delete from normal_ticket"; ;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                cnn.Open();
                string sql2 = @"Delete from balcony_ticket"; ;
                SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                cmd2.ExecuteNonQuery();
                cnn.Close();
                string sql3 = @"Delete from box_ticket"; ;
                SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Successfull Reset", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
            }
            catch(Exception)
            {
                MessageBox.Show("Unsuccessfull Reset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void markAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                employee_attendence myForm = new employee_attendence();
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

        private void showAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                view_employee_attendence myForm = new view_employee_attendence();
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

        private void anotherLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login for1 = new login();
            for1.Show();
        }

        private void addRemoveEpencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                addremoveexpences myForm = new addremoveexpences();
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

        private void viewExpencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                viewexpences myForm = new viewexpences();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cONTACTtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                contact myForm = new contact();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
        }

        private void onlineTicketIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                online_ticket myForm = new online_ticket();
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

        private void onlineTicketCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                online_tickets_check myForm = new online_tickets_check();
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

        private void onlineSheduleDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Controls.Clear();
                delete_online_schedule myForm = new delete_online_schedule();
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
    }
}
