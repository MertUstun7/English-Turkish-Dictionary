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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into ingturk(ingilizce,turkce) values ('" + (textBox1.Text).TrimStart() + "','" + (textBox2.Text).TrimStart() + "')", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kelime veri tabanina eklendi", "Veri Tabani", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Veri Taban�");
                baglanti.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {

                try
                {

                    baglanti.Open();
                    //ingilizcesi yazilan s�zc���n t�rk�e anlam�n� g�ncelleme
                    SqlCommand guncelle = new SqlCommand(@"update ingturk set turkce='" + textBox2.Text + "' where " +
                        "ingilizce='" + textBox1.Text + "'", baglanti);
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("S�zc�k veri taban�nda t�rk�e anlam� g�ncellenecek �ekilde de�i�tirildi.", "Veri Taban� ��lemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                }

                catch (Exception aciklama)
                {
                    MessageBox.Show(aciklama.Message, "Veri Taban�");
                    baglanti.Close();

                }

            }

            if (radioButton1.Checked == true)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand guncelle2 = new SqlCommand(@"update ingturk set ingilizce='" + textBox1.Text + "'where " +
                        "turkce='" + textBox2.Text + "'", baglanti);
                    guncelle2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("S�zc�k veri taban�nda ingilizce anlam� g�ncellenecek �ekilde de�i�tirildi.", "Veri Taban� ��lemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Veri Taban�");
                }
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from ingturk where ingilizce='" + textBox1.Text + "'", baglanti);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("S�zc�k veri taban�ndan silindi.", "Veri Taban� ��lemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();


            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Taban�");
                baglanti.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


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
                MessageBox.Show(aciklama.Message, "Veri Taban�");

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

        }
    }
}
