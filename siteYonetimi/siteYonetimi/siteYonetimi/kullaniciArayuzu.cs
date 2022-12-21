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
    public partial class kullaniciArayuzu : Form
    {
        Form1 gelenForm;
        public kullaniciArayuzu(Form1 gelenFrm)
        {
            InitializeComponent();
            gelenForm = gelenFrm;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
        private void kullaniciArayuzu_Load(object sender, EventArgs e)
        {
            label1.Text = gelenForm.adSoyad;
            label3.Text = gelenForm.yetki;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            this.Hide();
            hesap.Show(); 
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            this.Hide();
            hesap.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hesapEkle hesapEkle = new hesapEkle();
            this.Hide();
            hesapEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
