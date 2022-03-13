using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Film_Hall_Management_System
{
    public partial class issueticket : Form
    {
        public issueticket()
        {
            InitializeComponent();
        }

        private void issue_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtgenerate.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
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
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void issueticket_Load(object sender, EventArgs e)
        {

        }

        private void ticketgenerate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtnormal.Checked == true)

                {
                    try
                    {
                        MySqlConnection cnn = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =; Allow User Variables = True; ");
                        string sql = @"select * from FilmHall.normal_ticket"; ;
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

              

                if (txtbox.Checked == true)

                {
                    try
                    {
                        string connectionString = "";
                        connectionString = @"Data Source = SUPUNPIYUMANTHA\SQLEXPRESS; Initial catalog = FilmHall; Integrated Security = true";
                        SqlConnection cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        string sql = @"select * from box_ticket"; ;
                        SqlCommand cmd = new SqlCommand(sql, cnn);

                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        DataTable datatable = new DataTable();
                        ada.Fill(datatable);
                        datatable1.DataSource = datatable;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured Please Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void datatable1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datatable1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetDataObject(datatable1.CurrentCell.Value.ToString());
            txtticketnum.Text = Clipboard.GetText();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtnormal.Checked == true)
                {
                    MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                    MySqlCommand command2;
                    connection2.Open();
                    String insertQuery2 = "insert into FilmHall.normal_ticket(Status)values(@status)";
                    command2 = new MySqlCommand(insertQuery2, connection2);
                    command2.Parameters.Add("@status", MySqlDbType.VarChar, 10);

                    command2.Parameters["@status"].Value = "Booked";
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection2.Close();

                    txtgenerate.Text = "Ticket No : " + txtticketnum.Text + "  " + "Normal ticket   " + txtdate.Text;
                }
               
                if (txtbox.Checked == true)
                {
                    MySqlConnection connection2 = new MySqlConnection("datasource =localhost; port = 3306; username = root; password =;Allow User Variables = True; ");
                    MySqlCommand command2;
                    connection2.Open();
                    String insertQuery2 = "insert into FilmHall.box_ticket(Status)values(@status)";
                    command2 = new MySqlCommand(insertQuery2, connection2);
                    command2.Parameters.Add("@status", MySqlDbType.VarChar, 10);

                    command2.Parameters["@status"].Value = "Booked";
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection2.Close();
                    connection2.Close();

                    txtgenerate.Text = "Ticket No : " + txtticketnum.Text + "  " + "Box ticket   "+ txtdate.Text;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void datatable1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 
