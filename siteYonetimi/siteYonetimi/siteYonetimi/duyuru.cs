
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
namespace siteYonetimi
{
    public partial class duyuru : Form
    {
        kullaniciArayuzu kullaniciArayuzu;
        public duyuru(kullaniciArayuzu gelenKullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenKullaniciArayuzu;
        }

        Baglanti baglanti = new Baglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.BaglantiKontrol();

            MySqlCommand duyuruEkle = new MySqlCommand("insert into duyurular (duyuruBaslik,duyuruIcerik) values ('" + tBduyuruBaslikEkle.Text + "','" + rTBduyuruİcerikEkle.Text + "')", baglanti.connection);
            duyuruEkle.ExecuteNonQuery();
            veriyiGoster();
            MessageBox.Show("Duyuru eklendi.");
            baglanti.BaglantiKapat();
        }
        private void duyuruYonetici_Load(object sender, EventArgs e)
        {
            gBduyuruBaslik.Visible = false;
            gBDuyuruİcerik.Visible = false;
            buttonDuyuruEkle.Visible = false;
            buttonDuyuruSil.Visible = false;
            this.Width = 305;

            veriyiGoster();

            baglanti.BaglantiKontrol();
            MySqlCommand yoneticiler = new MySqlCommand("SELECT * FROM yoneticiler WHERE kullaniciAd='" + kullaniciArayuzu.kullaniciAdi + "' ", baglanti.connection);
            MySqlDataReader oku = yoneticiler.ExecuteReader();
            if (oku.Read())
            {
                gBduyuruBaslik.Visible = true;
                gBDuyuruİcerik.Visible = true;
                buttonDuyuruEkle.Visible = true;
                buttonDuyuruSil.Visible = true;
                this.Width = 540;
            }
            oku.Close();
            baglanti.BaglantiKapat();
        }

        private void veriyiGoster()
        {
            baglanti.BaglantiKontrol();
            DataSet ds = new DataSet();
            MySqlDataAdapter verileriListele = new MySqlDataAdapter("SELECT duyuruBaslik,duyuruIcerik FROM duyurular ", baglanti.connection);
            verileriListele.Fill(ds, "Duyurular");
            dGWduyurularGoruntule.DataSource = ds.Tables["duyurular"];
            baglanti.BaglantiKapat();
        }

        private void duyuru_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string duyuruSilBaslik = Interaction.InputBox("Başlık adına göre duyuruları silebilirsiniz.", "Duyuru Silme Ekranı", "...", 550, 300);

            baglanti.BaglantiAc();
            MySqlCommand duyuruKontrol = new MySqlCommand("SELECT duyuruBaslik FROM duyurular WHERE duyuruBaslik='" + duyuruSilBaslik + "'", baglanti.connection);
            MySqlDataReader oku = duyuruKontrol.ExecuteReader();

            if (oku.Read())
            {
                baglanti.BaglantiKapat();
                baglanti.BaglantiKontrol();
                MySqlCommand duyuruSilme = new MySqlCommand("DELETE FROM duyurular WHERE duyuruBaslik='" + duyuruSilBaslik + "'", baglanti.connection);
                duyuruSilme.ExecuteNonQuery();
                oku.Close();
                MessageBox.Show("Duyuru silindi.");
                veriyiGoster(); 
                baglanti.BaglantiKapat();
            }
            else
            {
                MessageBox.Show("Böyle bir başlık bulunamadı.");

            }

            baglanti.BaglantiKapat();
        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string baslik = dGWduyurularGoruntule.CurrentRow.Cells[0].Value.ToString();
            string metin = dGWduyurularGoruntule.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show(metin, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
