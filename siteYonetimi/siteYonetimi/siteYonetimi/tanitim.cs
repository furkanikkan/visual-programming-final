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
    public partial class tanitim : Form
    {

        kullaniciArayuzu ka;


        public tanitim(kullaniciArayuzu gelenkullaniciArayuzu)
        {
            InitializeComponent();
            ka = gelenkullaniciArayuzu;
        }

        private void tanitim_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled=false;
            richTextBox1.Text = "                    Genel Özellikler\r\n\r\n          Ankastre Ürünler          Kombi\r\n\r\n          Fitness                        Sauna\r\n\r\n          Oyun Parkı                  Kapalı Otopark\r\n\r\n          Açık Otopark\r\n\r\n ADRES : Odunluk Mahallesi Akpınar Caddesi No:15/A\r\n Efe Tower İş Mrk ABlok K:8 No:29\r\n Nilüfer / BURSA";
        }

        private void tanitim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ka.Show();
            this.Hide();
        }
    }
}
