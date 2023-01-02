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

namespace siteYonetimi
{
    public partial class hesapYonetici : Form
    {
        kullaniciArayuzu kullaniciArayuzu;
        public hesapYonetici(kullaniciArayuzu gelenKullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenKullaniciArayuzu;
        }

        Baglanti baglanti = new Baglanti();



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

        private void yoneticiGetir()
        {
            baglanti.BaglantiKontrol();
            MySqlCommand yonetici = new MySqlCommand("SELECT * FROM kullanicilar WHERE kullaniciAdi='" + kullaniciArayuzu.kullaniciAdi + "'", baglanti.connection);
            MySqlDataReader yoneticiData = yonetici.ExecuteReader();
            if (yoneticiData.Read())
            {

                labelAdGelen.Text = yoneticiData["Ad"].ToString();
                labelSoyadGelen.Text = yoneticiData["Soyad"].ToString();
                labelSifreGelen.Text = yoneticiData["Sifre"].ToString();
                labelAracPlakaGelen.Text = yoneticiData["aracPlaka"].ToString();
                labelTelefonNoGelen.Text = yoneticiData["telefonNo"].ToString();

                tBadDuzenle.Text = yoneticiData["Ad"].ToString();
                tBsoyadDuzenle.Text = yoneticiData["Soyad"].ToString();
                tBsifreDuzenle.Text = yoneticiData["Sifre"].ToString();
                tBaracPlakaDuzenle.Text = yoneticiData["aracPlaka"].ToString();
                tBtelefonNoDuzenle.Text = yoneticiData["telefonNo"].ToString();

            }
            baglanti.BaglantiKapat();
        }

        private void hesapYonetici_Load(object sender, EventArgs e)
        {
            cByetkiEkle.Items.Add("Yönetici");
            cByetkiEkle.Items.Add("Kullanıcı");

            yoneticiGetir();
            tBkullaniciAdiDuzenle.Text = kullaniciArayuzu.kullaniciAdi;
            labelAdGelen.Text = kullaniciArayuzu.ad;
            labelSoyadGelen.Text = kullaniciArayuzu.soyad;
            labelKullaniciAdiGelen.Text = kullaniciArayuzu.kullaniciAdi;
            labelSifreGelen.Text = kullaniciArayuzu.Sifre;
            labelAracPlakaGelen.Text = kullaniciArayuzu.aracPlaka;
            labelTelefonNoGelen.Text = kullaniciArayuzu.telefonNo;

            baglanti.BaglantiKontrol();
            MySqlCommand daireListele = new MySqlCommand("SELECT * FROM daireler", baglanti.connection);
            MySqlDataReader reader = daireListele.ExecuteReader();
            while (reader.Read())
            {
                cBDaireler.Items.Add(reader["daireID"].ToString() + " - DaireNo: " + reader["daireNo"].ToString());
            }
            reader.Close();
            baglanti.BaglantiKapat();
        }

        private void buttonAnaMenu_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }

        private void hesapYonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
         
            baglanti.BaglantiKontrol();
            MySqlCommand sorgula = new MySqlCommand("SELECT * FROM kullanicilar WHERE kullaniciAdi='" + tBkullaniciAdiEkle.Text + "'", baglanti.connection);
            MySqlDataReader reader = sorgula.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("kullanıcı adı kullanılmış ");
                reader.Close(); 
            }
            else
            {
                baglanti.BaglantiKapat();
                string[] daireler = cBDaireler.SelectedItem.ToString().Split('-');
                if (cByetkiEkle.SelectedItem.ToString() == "Yönetici")
                {
                    
                    baglanti.BaglantiKontrol();
                    MySqlCommand kullaniciEkle =
                    new MySqlCommand("INSERT INTO kullanicilar (daireID, Ad, Soyad, kullaniciAdi, Sifre, aracPlaka, telefonNo) " +
                    "values ('" + daireler[0] +"','" + tBadEkle.Text + "','" + tBsoyadEkle.Text + "','" + tBkullaniciAdiEkle.Text + "','" + tBsifreEkle.Text + "','" + tBaracPlakaEkle.Text + "','" + tBtelefonEkle.Text + "')", baglanti.connection);
                    kullaniciEkle.ExecuteNonQuery();

                    MySqlCommand yoneticiEkle = new MySqlCommand("INSERT INTO yoneticiler (ad, soyad, kullaniciAd, sifre, kullaniciID) VALUES" +
                        " ('" + tBadEkle.Text + "','" + tBsoyadEkle.Text + "','" + tBkullaniciAdiEkle.Text + "','" + tBsifreEkle.Text + "','" + kullaniciEkle.LastInsertedId + "')", baglanti.connection);
                    yoneticiEkle.ExecuteNonQuery();

                    baglanti.BaglantiKapat();
                    MessageBox.Show("Kayıt eklendi");

                }
                else
                {
                    baglanti.BaglantiKontrol();
                    MySqlCommand ekle = new MySqlCommand("insert into kullanicilar (daireID, Ad, Soyad, kullaniciAdi, Sifre, aracPlaka, telefonNo) values ('" + daireler[0] +"','" + tBadEkle.Text + "','" + tBsoyadEkle.Text + "','" + tBkullaniciAdiEkle.Text + "','" + tBsifreEkle.Text + "','" + tBaracPlakaEkle.Text + "','" + tBtelefonEkle.Text + "')", baglanti.connection);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt eklendi");
                    baglanti.BaglantiKapat();
                }
            }

        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.BaglantiKontrol();
            MySqlCommand duzenle = new MySqlCommand("UPDATE kullanicilar SET Ad = '" + tBadDuzenle.Text + "', Soyad = '" + tBsoyadDuzenle.Text + "', aracPlaka = '" + tBaracPlakaDuzenle.Text + "', Sifre = '" + tBsifreDuzenle.Text + "', telefonNo = '" + tBtelefonNoDuzenle.Text + "' WHERE kullaniciAdi = '" + kullaniciArayuzu.kullaniciAdi + "'", baglanti.connection);
            duzenle.ExecuteNonQuery();
            baglanti.BaglantiKapat();
            yoneticiGetir();
            MessageBox.Show("profil güncellendi.");
        }
    }
}
