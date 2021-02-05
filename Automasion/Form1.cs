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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

       
        
        
     
        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox2.Text = "1234";


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

              
                    string kadi = textBox1.Text;
                    string pass = textBox2.Text;
               
                con = new SqlConnection("Data Source=DESKTOP-1460T3M\\SQLEXPRESS01;Initial Catalog=oztuncelvinc;Integrated Security=True");
            //    con=new SqlConnection ("Data Source=DESKTOP-1460T3M\\SQLEXPRESS01;Catalog=oztuncelvinc;Integrated Security")
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM LOGINPAGE where USERID='" + kadi + "' AND PASS='" + pass + "'";
                var  dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    // MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    Ekle ekle = new Ekle();
                    ekle.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
                


              con.Close();
              /*

          string user = txtUser.Text;
          string pass = txtPass.Text;
          con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
          cmd = new SqlCommand();
          con.Open();
          cmd.Connection = con;
          cmd.CommandText = "SELECT * FROM tblUser where usr='" + txtUser.Text + "' AND pwd='" + txtPass.Text + "'";
          dr = cmd.ExecuteReader();
          if (dr.Read())
          {
              MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. https://yazilimkodlama.com");
          }
          else
          {
              MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
          }
          con.Close();
               */
            }
            catch (Exception error )
            {
                

                MessageBox.Show("Bağlantı Başarısız."+error.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
 
            con = new SqlConnection("server=.; Initial Catalog=okul;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
 */

/*
     komut = new SqlCommand("Select * FROM LOGINPAGE", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();

            int i = 0;
            while (i < 2)
            {
                if (textBox1.Text == oku["USERID"].ToString() && textBox2.Text == oku["PASS"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı.");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız.");
                }
                i++;
            }
             if (textBox1.Text == k_adi.ToString() && textBox2.Text == pass.ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
*/
/*
     //$"SELECT * FROM LOGINPAGE WHERE USERID={kadi} and PASS={pass}"
                string sorgu = "Insert into Ogrenci (numara,ad,soyad,telefon) values (@no,@ad,@soyad,@tel)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@tel", textBox4.Text);
  */
//$"SELECT * FROM LOGINPAGE WHERE USERID={kadi} and PASS={pass}"

//var komut = new SqlCommand($"SELECT * FROM LOGINPAGE WHERE USERID=@USERID and PASS=@PASS", baglan);


//komut.Parameters.AddWithValue("@USERID", kadi);
//                  komut.Parameters.AddWithValue("@PASS", pass);




//              var dr = komut.ExecuteReader();
//                  if (dr.Read())
//                  {
//                      MessageBox.Show("Tebrikler! Pass ve user dogru ");
//                  }
//                  else
//                  {
//                      MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");


//                  }


//var komut = new SqlCommand($"SELECT * FROM LOGINPAGE WHERE USERID=@USERID and PASS=@PASS", con);


//komut.Parameters.AddWithValue("@USERID", kadi);
//                  komut.Parameters.AddWithValue("@PASS", pass);
                 

               

//               dr = komut.ExecuteReader();
//                  if (dr.Read())
//                  {
//                      MessageBox.Show("Tebrikler! Pass ve user dogru ");
//                  }
//                  else
//                  {
//                      MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");


//                  }



