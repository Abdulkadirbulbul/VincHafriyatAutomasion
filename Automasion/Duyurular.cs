using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automasion
{
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1460T3M\\SQLEXPRESS01;Initial Catalog=oztuncelvinc;Integrated Security=True");
        void DuyurularıListele()
        {

            con.Open();
            SqlDataAdapter da;
            da = new SqlDataAdapter("Select * From DUYURU", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();


        }
        /*
           void TariheDuyurularıListele(string tarih)
          {
              con.Open();
              SqlDataAdapter da;
              da = new SqlDataAdapter("Select * From DUYURU Where DATE='"+tarih.ToString()+"'",con);
              DataTable tabl = new DataTable();
              da.Fill(tabl);
           //   dataGridView2.DataSource = tabl;
              con.Close();
          }
         */
        private void button1_Click(object sender, EventArgs e)
          {
            try
            {
                con.Open();
                string bld = textBox1.Text;
                string date = dateTimePicker1.Text;
                cmd = new SqlCommand("Insert into DUYURU (DATE,BILDIRIM) values(@date,@bld)", con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@bld", bld);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Duyuru Paylaşıldı");
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata" + error);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Duyurular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oztuncelvincDataSet2.DUYURU' table. You can move, or remove it, as needed.
            this.dUYURUTableAdapter.Fill(this.oztuncelvincDataSet2.DUYURU);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             //   TariheDuyurularıListele(dateTimePicker1.Text);
            }
            catch (Exception Error)
            {
                MessageBox.Show("Hata" + Error);
            }
        }
    }
}
