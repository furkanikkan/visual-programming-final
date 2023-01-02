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
using MySql.Data;
using Org.BouncyCastle.Utilities.Collections;
using System.Drawing.Text;

namespace siteYonetimi
{
    public partial class hesap : Form
    {
        kullaniciArayuzu kullaniciArayuzu;
        public hesap(kullaniciArayuzu gelenKullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenKullaniciArayuzu;
        }

        Baglanti baglanti = new Baglanti();

        private void button3_Click(object sender, EventArgs e)
        {
          

        }
         
        private void hesap_Load(object sender, EventArgs e)
        {
           

            yoneticiGetir();

            tBkullaniciAdiDuzenle.Enabled = false;
            tBkullaniciAdiDuzenle.Text = kullaniciArayuzu.kullaniciAdi;
            labelAdGelen.Text = kullaniciArayuzu.ad;
            labelSoyadGelen.Text = kullaniciArayuzu.soyad;
            labelKullaniciAdiGelen.Text = kullaniciArayuzu.kullaniciAdi;
            labelSifreGelen.Text = kullaniciArayuzu.Sifre;
            labelAracPlakaGelen.Text = kullaniciArayuzu.aracPlaka;
            labelTelefonNoGelen.Text = kullaniciArayuzu.telefonNo;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void hesap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            baglanti.BaglantiKontrol();

            MySqlCommand duzenle = new MySqlCommand("UPDATE kullanicilar SET Ad = '" + tBadDuzenle.Text + "', Soyad = '" + tBsoyadDuzenle.Text + "', aracPlaka = '" + tBaracPlakaDuzenle.Text + "', Sifre = '" + tBsifreDuzenle.Text + "', telefonNo = '" + tBtelefonNoDuzenle.Text + "' WHERE kullaniciAdi = '" + kullaniciArayuzu.kullaniciAdi + "'", baglanti.connection);
            duzenle.ExecuteNonQuery();
            baglanti.BaglantiKapat();
            yoneticiGetir();
            MessageBox.Show("profil güncellendi.");
        }

        private void yoneticiGetir()
        {
            baglanti.BaglantiKontrol();
            MySqlCommand kullanici = new MySqlCommand("SELECT * FROM kullanicilar WHERE kullaniciAdi='" + kullaniciArayuzu.kullaniciAdi + "'", baglanti.connection);
            MySqlDataReader kullaniciData = kullanici.ExecuteReader();
            if (kullaniciData.Read())
            {

                labelAdGelen.Text = kullaniciData["Ad"].ToString();
                labelSoyadGelen.Text = kullaniciData["Soyad"].ToString();
                labelSifreGelen.Text = kullaniciData["Sifre"].ToString();
                labelAracPlakaGelen.Text = kullaniciData["aracPlaka"].ToString();
                labelTelefonNoGelen.Text = kullaniciData["telefonNo"].ToString();

                tBadDuzenle.Text = kullaniciData["Ad"].ToString();
                tBsoyadDuzenle.Text = kullaniciData["Soyad"].ToString();
                tBsifreDuzenle.Text = kullaniciData["Sifre"].ToString();
                tBaracPlakaDuzenle.Text = kullaniciData["aracPlaka"].ToString();
                tBtelefonNoDuzenle.Text = kullaniciData["telefonNo"].ToString();

            }
            baglanti.BaglantiKapat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }
    }
}
