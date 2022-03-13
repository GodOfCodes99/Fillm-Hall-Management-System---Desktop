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
using System.Drawing.Printing;

namespace Film_Hall_Management_System
{
    public partial class view_employee_attendence : Form
    {
        public view_employee_attendence()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtnic.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");
                string sql = @"select * from FilmHall.Attendence where NIC like'" + txtnic.Text + "%'"; ;
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                ada.Fill(datatable);
                datatable1.DataSource = datatable;

                string sql2 = @"select * from FilmHall.Name,Job_Role,Tel from where NIC like'" + txtnic.Text + "%'"; ;
                MySqlCommand cmd2 = new MySqlCommand(sql2, cnn);
                MySqlDataAdapter ada2 = new MySqlDataAdapter(cmd2);
                DataTable datatable2 = new DataTable();
                ada.Fill(datatable2);
                datatable22.DataSource = datatable2;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");

            string sql = @"SELECT COUNT(Date)FROM FilmHall.Attendence WHERE NIC like'" + txtnic.Text + "%'"; ;
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            ada.Fill(datatable);
            datatable33.DataSource = datatable;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();

        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(datatable1.Width, datatable1.Height);
            datatable1.DrawToBitmap(bm, new Rectangle(0, 0, datatable1.Width, datatable1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
