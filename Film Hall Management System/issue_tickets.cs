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
    public partial class issue_tickets : Form
    {
        public issue_tickets()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");
                string sql = @"select * from FilmHall.schedule where schedule_id like'" + txtscheduleid.Text + "%'"; ;
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            txtgenerate.Text = "Schedule ID : " + txtscheduleid.Text +" "+ "Ticket Type : " + txtticket.Text;
        }

        private void issue_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtgenerate.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
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
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

    }
}
