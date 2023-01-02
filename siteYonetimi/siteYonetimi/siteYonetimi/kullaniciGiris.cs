using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public int Id;
        public string ad;
        public string soyad;
        public string aracPlaka;
        public string telefonNo;
        public string kullaniciAdi;
        public string Sifre;

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu kullaniciArayuzu = new kullaniciArayuzu(this);
            if (baglanti.connection.State == ConnectionState.Closed)
            { 
                baglanti.BaglantiAc();
            }
            MySqlCommand girisSorgusu = new MySqlCommand("SELECT * FROM kullanicilar WHERE kullaniciAdi='"+tBkullaniciAdıGiris.Text+ "' AND Sifre='"+tBsifreGiris.Text+"'", baglanti.connection);
            MySqlDataReader veriOku=girisSorgusu.ExecuteReader();
            if (veriOku.Read())
            {
                Id = Convert.ToInt32(veriOku["Id"]);
                ad = veriOku["Ad"].ToString();
                soyad = veriOku["Soyad"].ToString();
                aracPlaka = veriOku["aracPlaka"].ToString();
                telefonNo = veriOku["telefonNo"].ToString();
                kullaniciAdi = veriOku["kullaniciAdi"].ToString();
                Sifre = veriOku["Sifre"].ToString();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tBkullaniciAdıGiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
