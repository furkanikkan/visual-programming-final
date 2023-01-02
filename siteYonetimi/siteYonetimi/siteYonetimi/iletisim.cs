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
    public partial class iletisim : Form
    {
        kullaniciArayuzu kullaniciArayuzu;
        Baglanti baglanti = new Baglanti();
        public iletisim(kullaniciArayuzu gelenKullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenKullaniciArayuzu;
        }

        private void iletisim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }

        private void iletisim_Load(object sender, EventArgs e)
        {
            this.Width = 320;
            cBitelisimNedeni.Items.Add("Öneri");
            cBitelisimNedeni.Items.Add("Şikayet");
            cBitelisimNedeni.Items.Add("Site/Yönetim ile ilgili soru");
            baglanti.BaglantiKontrol();
            MySqlCommand yoneticiler = new MySqlCommand("SELECT * FROM yoneticiler WHERE kullaniciAd='" + kullaniciArayuzu.kullaniciAdi + "' ", baglanti.connection);
            MySqlDataReader oku = yoneticiler.ExecuteReader();
            if (oku.Read())
            {
                baglanti.BaglantiKapat();
                iletisimListele();

                this.Width = 630;
            }
            oku.Close();
            baglanti.BaglantiKapat();



        }

        private void iletisimListele()
        {
            listIletisim.Items.Clear();
            baglanti.BaglantiKontrol();
            MySqlCommand iletisimGetir = new MySqlCommand("SELECT * FROM iletisim WHERE durum IN('0')", baglanti.connection);
            MySqlDataReader iletisimleriOku = iletisimGetir.ExecuteReader();
            while (iletisimleriOku.Read())
            {
                int id = Convert.ToInt32(iletisimleriOku["iletisimID"]);
                string baslik = iletisimleriOku["iletisimNedeni"].ToString();
                string metin = iletisimleriOku["iletisimText"].ToString();
                listIletisim.Items.Add(id + "-" + baslik + "-" + metin);
            }
            iletisimleriOku.Close();
            baglanti.BaglantiKapat();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            string baslik = cBitelisimNedeni.SelectedItem.ToString();
            string metin = rTBiletisimForm.Text;
            baglanti.BaglantiKontrol();
            MySqlCommand iletisimEkle = new MySqlCommand("INSERT INTO iletisim (iletisimNedeni,iletisimText) VALUES('" + baslik + "','" + metin + "')", baglanti.connection);
            iletisimEkle.ExecuteNonQuery();
            iletisimListele();
            MessageBox.Show("İletişim formu gönderildi.");
            baglanti.BaglantiKapat();
        }

        private void listIletisim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] secili = listIletisim.SelectedItem.ToString().ToString().Split('-');
            baglanti.BaglantiKontrol();
            MySqlCommand iletisimPasifEt = new MySqlCommand("UPDATE iletisim SET durum='1' WHERE iletisimID='" + secili[0] +"'",baglanti.connection);
            iletisimPasifEt.ExecuteNonQuery();
            baglanti.BaglantiKapat();
            iletisimListele();
            MessageBox.Show("İletişim formu kapatıldı.");
        }

        private void bottonCevapla_Click(object sender, EventArgs e)
        {

        }
    }

}


