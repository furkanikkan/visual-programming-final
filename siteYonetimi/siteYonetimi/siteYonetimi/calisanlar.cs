using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class calisanlar : Form
    {
        kullaniciArayuzu kullaniciArayuzu;
        Baglanti baglanti = new Baglanti();
        public calisanlar(kullaniciArayuzu gelenKullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenKullaniciArayuzu;
        }

        private void muhasebe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }

        private void muhasebe_Load(object sender, EventArgs e)
        {
            cBcalisanGorev.Items.Add("Kapıcı");
            cBcalisanGorev.Items.Add("Güvenlik Görevlisi");
            cBcalisanGorev.Items.Add("Temizlik Görevlisi");
            calisanlariListele();

            this.Width = 350;

            baglanti.BaglantiKontrol();
            MySqlCommand yoneticiler = new MySqlCommand("SELECT * FROM yoneticiler WHERE kullaniciAd='" + kullaniciArayuzu.kullaniciAdi + "' ", baglanti.connection);
            MySqlDataReader oku = yoneticiler.ExecuteReader();
            if (oku.Read())
            {
                this.Width = 580;
            }
            oku.Close();
            baglanti.BaglantiKapat();
        }

        private void calisanlariListele()
        {
            lBcalisanlar.Items.Clear();
            baglanti.BaglantiKontrol();

            MySqlCommand verileriListele = new MySqlCommand("SELECT * FROM calisanlar", baglanti.connection);
            MySqlDataReader calisanlar = verileriListele.ExecuteReader();
            while (calisanlar.Read())
            {
                lBcalisanlar.Items.Add(calisanlar["calisanID"] + "-" + calisanlar["calisanAd"] + " " + calisanlar["calisanSoyad"] + "---------->" + calisanlar["calisanGorev"]);
            }
            calisanlar.Close();
            baglanti.BaglantiKapat();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.BaglantiKontrol();
            MySqlCommand ekle = new MySqlCommand("insert into calisanlar (calisanAd, calisanSoyad,calisanGorev) values ('" + tBcalisanAd.Text + "','" + tBcalisanSoyad.Text + "','" + cBcalisanGorev.Text + "')", baglanti.connection);
            ekle.ExecuteNonQuery();
            calisanlariListele();
            MessageBox.Show("Kayıt eklendi.");
            baglanti.BaglantiKapat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] secili = lBcalisanlar.SelectedItem.ToString().ToString().Split('-');
            baglanti.BaglantiKontrol();
            MySqlCommand Sil = new MySqlCommand("DELETE FROM calisanlar WHERE calisanID='" + secili[0] +"'", baglanti.connection);
            Sil.ExecuteNonQuery();
            calisanlariListele();
            MessageBox.Show("Kayıt silindi.");
            baglanti.BaglantiKapat();
        }
    }

}
