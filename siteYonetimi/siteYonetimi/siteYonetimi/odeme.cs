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
using Microsoft.VisualBasic;

namespace siteYonetimi
{
    public partial class odeme : Form
    {

        Baglanti baglanti = new Baglanti();
        kullaniciArayuzu kullaniciArayuzu;
        public odeme(kullaniciArayuzu gelenkullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenkullaniciArayuzu;
        }

        int borc;
        private void aidatOdeme_Load(object sender, EventArgs e)
        {
            borclariListele();

        }

        private void borclariListele()
        {
            listOdemeler.Items.Clear();
            baglanti.BaglantiKontrol();
            MySqlCommand ara = new MySqlCommand("SELECT * FROM kullanicilar INNER JOIN daireler ON kullanicilar.daireID=daireler.daireID WHERE aidatBorcu > 0", baglanti.connection);
            MySqlDataReader aramaSonuc = ara.ExecuteReader();
            while (aramaSonuc.Read())
            {
                borc = Convert.ToInt32(aramaSonuc["aidatBorcu"]);
                listOdemeler.Items.Add(aramaSonuc["daireID"] + "-" + aramaSonuc["Ad"] + " " + aramaSonuc["Soyad"] + " " + aramaSonuc["aidatBorcu"] + " TL borcu bulunmakatadır.");
            }
            baglanti.BaglantiKapat();
        }

        private void odeme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listOdemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] secili = listOdemeler.SelectedItem.ToString().Split('-');
            try
            { 
            int odeme = Convert.ToInt32(Interaction.InputBox("Ödenecek Ücreti Giriniz.", "Ödeme Sayfası.", "", 560, 320));
           
            int guncelAidatBorcu = borc - odeme;

            baglanti.BaglantiKontrol();
            MySqlCommand duzenle = new MySqlCommand("UPDATE daireler SET aidatBorcu='" + guncelAidatBorcu + "' WHERE daireID='" + secili[0] + "'", baglanti.connection);
            duzenle.ExecuteNonQuery();
            baglanti.BaglantiKapat();
            borclariListele();
            MessageBox.Show("Aidat borcu güncellendi");
            }
            catch 
            {
                MessageBox.Show("Bir değer giriniz.");
            }
        }
    }
}
