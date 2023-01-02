using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace siteYonetimi
{
    public partial class kullaniciArayuzu : Form
    {
        Form1 gelenForm;

        public kullaniciArayuzu(Form1 gelenFrm)
        {
            InitializeComponent();
            gelenForm = gelenFrm;
        }
        Baglanti baglanti = new Baglanti();

        public string ad;
        public string soyad;
        public string aracPlaka;
        public string telefonNo;
        public string kullaniciAdi;
        public string yetki;
        public string Sifre;

        private void kullaniciArayuzu_Load(object sender, EventArgs e)
        {
            labelAd.Text = gelenForm.ad;
            labelSoyad.Text = gelenForm.soyad;
            kullaniciAdi = gelenForm.kullaniciAdi;

            baglanti.BaglantiKontrol();

            MySqlCommand yoneticDogrulamaSorgusu = new MySqlCommand("SELECT * FROM yoneticiler WHERE kullaniciAd=@kullaniciAdi", baglanti.connection);
            yoneticDogrulamaSorgusu.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            MySqlDataReader veriOku = yoneticDogrulamaSorgusu.ExecuteReader();
            if (veriOku.Read())
            {
                labelYetki.Text = "Yönetici";
                yetki = "Yönetici";
               
            }
            else
            {
                labelYetki.Text = "Kullanıcı";
            }
            baglanti.BaglantiKapat();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kullaniciArayuzu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void buttonResimler_Click(object sender, EventArgs e)
        {
            resimler resimler = new resimler(this);
            resimler.Show();
            this.Hide();
        }

        private void buttonCovidTablosu_Click(object sender, EventArgs e)
        {
            covid covid = new covid(this);
            covid.Show();
            this.Hide();
        }

        private void buttonSiteTanitimi_Click(object sender, EventArgs e)
        {
            tanitim tanitim= new tanitim(this);
            tanitim.Show();
            this.Hide();
        }

        private void buttonIletisim_Click(object sender, EventArgs e)
        {
            iletisim iletisim = new iletisim(this);
            iletisim.Show();
            this.Hide();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            duyuru duyuru = new duyuru(this);
            duyuru.Show();
            this.Hide();
        }

        private void buttonHesapCıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void buttonAidatOdeme_Click(object sender, EventArgs e)
        {
            odeme odeme = new odeme(this);
            odeme.Show();
            this.Hide();
        }

        private void buttonCalisanlar_Click(object sender, EventArgs e)
        {
            calisanlar muhasebe = new calisanlar(this);
            muhasebe.Show();
            this.Hide();
        }

        private void ButtonSiteSakinleriBilgi_Click(object sender, EventArgs e)
        {
            siteSakinlerininBilgileri siteSakinlerininBilgileri = new siteSakinlerininBilgileri(this);
            siteSakinlerininBilgileri.Show();
            this.Hide();
        }

        private void buttonUyeİslemleri_Click(object sender, EventArgs e)
        {
            if (labelYetki.Text == "Yönetici")
            {
                ad = gelenForm.ad;
                soyad = gelenForm.soyad;
                aracPlaka = gelenForm.aracPlaka;
                telefonNo = gelenForm.telefonNo;
                kullaniciAdi = gelenForm.kullaniciAdi;
                Sifre = gelenForm.Sifre;

                hesapYonetici hesapYonetici = new hesapYonetici(this);
                this.Hide();
                hesapYonetici.Show();
            }
            else
            {
                hesap hesap = new hesap(this);
                this.Hide();
                hesap.Show();
            }
        }
    }
}
