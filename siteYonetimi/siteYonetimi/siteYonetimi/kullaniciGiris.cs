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
using MySql.Data.MySqlClient;

namespace siteYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Baglanti baglanti = new Baglanti();
       
        public string adSoyad;
        public string yetki;
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu kullaniciArayuzu = new kullaniciArayuzu(this);
            baglanti.BaglantiAc();
            MySqlCommand girisSorgusu = new MySqlCommand("SELECT * FROM yoneticiler WHERE yoneticiKullaniciAdi='"+textBox1.Text+ "' AND yoneticiSifre='"+textBox2.Text+"'", baglanti.connection);
            MySqlDataReader veriOku=girisSorgusu.ExecuteReader();
            if (veriOku.Read())
            {
                adSoyad = veriOku["yoneticiAd"].ToString() + " " + veriOku["yoneticiSoyad"].ToString();
                yetki = veriOku["yoneticiYetki"].ToString();
                this.Hide();
                kullaniciArayuzu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }

            baglanti.BaglantiKapat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
