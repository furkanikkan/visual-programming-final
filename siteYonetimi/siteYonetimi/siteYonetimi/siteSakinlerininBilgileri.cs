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
    public partial class siteSakinlerininBilgileri : Form
    {

        Baglanti baglanti = new Baglanti();
        kullaniciArayuzu kullaniciArayuzu;
        public siteSakinlerininBilgileri(kullaniciArayuzu gelenForm)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenForm;
        }

        int ilkId, SonId, gecerliIdDegeri;
        private void siteSakinlerininBilgileri_Load(object sender, EventArgs e)
        {
            if (kullaniciArayuzu.yetki=="Yönetici")
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

            ilkKullaniciyiGetir();

        }

        private void ilkKullaniciyiGetir()
        {
            baglanti.BaglantiKontrol();
            MySqlCommand ara = new MySqlCommand("SELECT * FROM kullanicilar INNER JOIN daireler ON kullanicilar.daireID=daireler.daireID ORDER BY Id ASC", baglanti.connection);
            MySqlDataReader aramaSonuc = ara.ExecuteReader();
            if (aramaSonuc.Read())
            {
                ilkId = Convert.ToInt32(aramaSonuc["Id"]);
                gecerliIdDegeri = Convert.ToInt32(aramaSonuc["Id"]);
                labelAd.Text = aramaSonuc["Ad"].ToString();
                labelSoyad.Text = aramaSonuc["Soyad"].ToString();
                labelKullaniciAdi.Text = aramaSonuc["kullaniciAdi"].ToString();
                labelSifre.Text = aramaSonuc["Sifre"].ToString();
                labelDaire.Text = aramaSonuc["daireNo"].ToString();
                labelAracBilgisi.Text = aramaSonuc["aracPlaka"].ToString();
                labelTelefonNo.Text = aramaSonuc["telefonNo"].ToString();
            }
            baglanti.BaglantiKapat();
        }

        private void sonKullaniciyiGetir()
        {
            baglanti.BaglantiKontrol();
            MySqlCommand ara = new MySqlCommand("SELECT * FROM kullanicilar INNER JOIN daireler ON kullanicilar.daireID=daireler.daireID ORDER BY Id DESC", baglanti.connection);
            MySqlDataReader aramaSonuc = ara.ExecuteReader();
            if (aramaSonuc.Read())
            {
                SonId = Convert.ToInt32(aramaSonuc["Id"]);
                labelAd.Text = aramaSonuc["Ad"].ToString();
                labelSoyad.Text = aramaSonuc["Soyad"].ToString();
                labelKullaniciAdi.Text = aramaSonuc["kullaniciAdi"].ToString();
                labelSifre.Text = aramaSonuc["Sifre"].ToString();
                labelDaire.Text = aramaSonuc["daireNo"].ToString();
                labelAracBilgisi.Text = aramaSonuc["aracPlaka"].ToString();
                labelTelefonNo.Text = aramaSonuc["telefonNo"].ToString();
            }
            baglanti.BaglantiKapat();
        }



        private void btnSonKayit_Click(object sender, EventArgs e)
        {
            sonKullaniciyiGetir();
        }

        private void btnIlkKayit_Click(object sender, EventArgs e)
        {
            ilkKullaniciyiGetir();
        }

        private void siteSakinlerininBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            int yeniId = ilkId + 1; 

            baglanti.BaglantiKontrol();
            MySqlCommand ara = new MySqlCommand("SELECT * FROM kullanicilar INNER JOIN daireler ON kullanicilar.daireID=daireler.daireID WHERE Id='" + yeniId + "' ORDER BY Id DESC", baglanti.connection);
            MySqlDataReader aramaSonuc = ara.ExecuteReader();
            if (aramaSonuc.Read())
            {
                SonId = Convert.ToInt32(aramaSonuc["Id"]);
                labelAd.Text = aramaSonuc["Ad"].ToString();
                labelSoyad.Text = aramaSonuc["Soyad"].ToString();
                labelKullaniciAdi.Text = aramaSonuc["kullaniciAdi"].ToString();
                labelSifre.Text = aramaSonuc["Sifre"].ToString();
                labelDaire.Text = aramaSonuc["daireNo"].ToString();
                labelAracBilgisi.Text = aramaSonuc["aracPlaka"].ToString();
                labelTelefonNo.Text = aramaSonuc["telefonNo"].ToString();
            }
            baglanti.BaglantiKapat();
            ilkId = yeniId;
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        { 
            int yeniId = SonId - 1; 

            if(yeniId<gecerliIdDegeri) yeniId = gecerliIdDegeri;

            SonId = yeniId; 
            baglanti.BaglantiKontrol();
            MySqlCommand ara = new MySqlCommand("SELECT * FROM kullanicilar INNER JOIN daireler ON kullanicilar.daireID=daireler.daireID WHERE Id='" + yeniId + "' ORDER BY Id DESC", baglanti.connection);
            MySqlDataReader aramaSonuc = ara.ExecuteReader();
            if (aramaSonuc.Read())
            {
                SonId = Convert.ToInt32(aramaSonuc["Id"]);
                labelAd.Text = aramaSonuc["Ad"].ToString();
                labelSoyad.Text = aramaSonuc["Soyad"].ToString();
                labelKullaniciAdi.Text = aramaSonuc["kullaniciAdi"].ToString();
                labelSifre.Text = aramaSonuc["Sifre"].ToString();
                labelDaire.Text = aramaSonuc["daireNo"].ToString();
                labelAracBilgisi.Text = aramaSonuc["aracPlaka"].ToString();
                labelTelefonNo.Text = aramaSonuc["telefonNo"].ToString();
            }
            baglanti.BaglantiKapat();

        }
    }
}
