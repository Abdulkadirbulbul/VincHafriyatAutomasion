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

namespace Automasion
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1460T3M\\SQLEXPRESS01;Initial Catalog=oztuncelvinc;Integrated Security=True");
        void KisiListele()
        {
          
            con.Open();
            SqlDataAdapter da;
             da =new SqlDataAdapter("Select * From ANA", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox1.Text);
             cmd = new SqlCommand("Delete From ANA where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                KisiListele();

            }
            catch (Exception er)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
                
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

             
                if (VarMi(textBox1.Text)!=0)
                { MessageBox.Show("Bu Kullanıcı İD kayıtlı "); }
                else
                { 

                    /////////////////////////////
                    int id = Convert.ToInt32(textBox1.Text);
                    string ad = textBox2.Text;
                    string cins;
                    if (radioButton1.Checked == true)
                    {
                        cins = "Erkek";
                    }
                    else { cins = "Kadın"; }
                    string tarih = dateTimePicker1.Text;
                    ////////////////////////////////////////

                    //insert into LOGINPAGE (USERID,PASS) values ('ahmet','3333');
                    string sorgu = "Insert into ANA (ID,AD,CINS,DATE) values (@id,@ad,@cins,@tarih)";
                    con.Open();
                    cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@ad", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cins", cins);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    KisiListele();

                }

            }
            catch (Exception error)
            {
              //  MessageBox.Show("Bu İd a sahip biri var lütfen tekrardan yeni bir id giriniz.");
                MessageBox.Show("Hata"+error);
            }
        }
        public int VarMi(string aranan)
        {
            int sonuc;
            cmd = new SqlCommand("Select COUNT(ID) from ANA WHERE ID='" + aranan + "'", con);
            con.Open();

            sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return sonuc;

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oztuncelvincDataSet1.ANA' table. You can move, or remove it, as needed.
            this.aNATableAdapter1.Fill(this.oztuncelvincDataSet1.ANA);
            // TODO: This line of code loads data into the 'oztuncelvincDataSet.ANA' table. You can move, or remove it, as needed.
            this.aNATableAdapter.Fill(this.oztuncelvincDataSet.ANA);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /////////////////////////////
            int id = Convert.ToInt32(textBox1.Text);
            string ad = textBox2.Text;
            string cins;
            if (radioButton1.Checked == true)
            {
                cins = "Erkek";
            }
            else { cins = "Kadın"; }
            string date = dateTimePicker1.Text;
            ////////////////////////////////////////
            con.Open();
              cmd = new SqlCommand("Update ANA Set AD=@ad,CINS=@cins,DATE=@date Where ID=@id",con);
            
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@cins", cins);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();
            con.Close();
            KisiListele();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            


            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            //radioButton1.Checked = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string cinsiyet = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           cinsiyet = cinsiyet.Trim();
            cinsiyet = cinsiyet.ToLower();
           
            //   radioButton1.Checked = true;
            //  radioButton1.Checked = false;
           //  MessageBox.Show(cins);
           
          if (cinsiyet.Equals("erkek"))
            {
            radioButton1.Checked = true;
            }
           else 
            {
                radioButton2.Checked = true;
            }
        //    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Duyurular duyuru = new Duyurular();
            duyuru.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Source src = new Source();
            this.Hide();
            src.Show();
        }
    }
}
