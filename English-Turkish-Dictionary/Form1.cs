using Microsoft.Data.SqlClient;

namespace ingilizce_turkce_sozluk
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=sozluk;Integrated Security=True;Trust Server Certificate=True");
        public Form1()
        {
            InitializeComponent();
            
        }

        WebBrowser webceviri = new WebBrowser();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webceviri.Navigate("https://www.bing.com/translator/");
                webceviri.ScriptErrorsSuppressed = true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ekle_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into ingturk(ingilizce,turkce) values ('"+(textBox1.Text).TrimStart()+"','"+(textBox2.Text).TrimStart()+"')", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kelime veri tabanina eklendi", "Veri Tabani", MessageBoxButtons.OK, MessageBoxIcon.Information);
                webceviri.Document.GetElementById("tta_input_ta").InnerText = " ";
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Veri Tabaný");
                baglanti.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == false && radioButton2.Checked == false || textBox1.Text == null)
            {
                MessageBox.Show("Hatalý Ýþlem", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {



                if (radioButton2.Checked == true)
                {

                    try
                    {

                        baglanti.Open();
                        //ingilizcesi yazilan sözcüðün türkçe anlamýný güncelleme
                        SqlCommand guncelle = new SqlCommand(@"update ingturk set turkce='"+textBox2.Text+"' where " +
                            "ingilizce='"+textBox1.Text+"'", baglanti);
                        guncelle.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Sözcük veri tabanýnda türkçe anlamý güncellenecek þekilde deðiþtirildi.", "Veri Tabaný Ýþlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                    }

                    catch (Exception aciklama)
                    {
                        MessageBox.Show(aciklama.Message, "Veri Tabaný");
                        baglanti.Close();

                    }
                    radioButton2.Checked = false;
                    textBox2.ReadOnly = true;
                }

                if (radioButton1.Checked == true)
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand guncelle2 = new SqlCommand(@"update ingturk set ingilizce='"+textBox1.Text+"'where " +
                            "turkce='"+textBox2.Text+"'", baglanti);
                        guncelle2.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Sözcük veri tabanýnda ingilizce anlamý güncellenecek þekilde deðiþtirildi.", "Veri Tabaný Ýþlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Veri Tabaný");
                    }
                    radioButton1.Checked = false;
                    textBox2.ReadOnly = true;
                    timer1.Start();
                }
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from ingturk where ingilizce='"+textBox1.Text+"'", baglanti);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sözcük veri tabanýndan silindi.", "Veri Tabaný Ýþlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                webceviri.Document.GetElementById("tta_input_ta").InnerText = " ";
                textBox1.Clear();
                textBox2.Clear();


            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabaný");
                baglanti.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                webceviri.Document.GetElementById("tta_input_ta").InnerText = textBox1.Text;
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Hata");

            }

            timer1.Start();

            try
            {
                kelime_list.Items.Clear();
                baglanti.Open();
                SqlCommand aramakomutu = new SqlCommand(@"select * from ingturk where ingilizce 
                like'" + textBox1.Text + "%'", baglanti);

                SqlDataReader oku = aramakomutu.ExecuteReader();

                while (oku.Read())
                {
                    kelime_list.Items.Add(oku["ingilizce"].ToString() + "=" + oku["turkce"].ToString());

                }
                oku.Close();

                baglanti.Close();

            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabaný");

                baglanti.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.BackColor = rndclr();
        }
        private Color rndclr()
        {
            Random random = new Random();
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            timer1.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox2.ReadOnly = false;
            


        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (sayac == 1000)
                    timer1.Stop();
                textBox2.Text=webceviri.Document.GetElementById("tta_output_ta").InnerText;
                
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webceviri.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webceviri.Document.GetElementById("tta_playicontgt").InvokeMember("click");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
