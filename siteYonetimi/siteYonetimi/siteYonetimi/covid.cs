using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siteYonetimi
{
    public partial class covid : Form
    {
        Baglanti baglanti = new Baglanti();
        kullaniciArayuzu kullaniciArayuzu;
        public covid(kullaniciArayuzu gelenKullaniciArayuzu)
        {
            InitializeComponent();
            kullaniciArayuzu = gelenKullaniciArayuzu;
        }

        private void ciktiAl_Load(object sender, EventArgs e)
        {

            // read JSON directly from a file
            JObject covidinfo;
            using (StreamReader file = File.OpenText(@"..\..\Resources\json\corona_json.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                covidinfo = (JObject)JToken.ReadFrom(reader);
            }
            foreach (var item in covidinfo)
            {
                var jsonParse = JObject.Parse(item.Value.ToString());
                tarih.ListView.Items.Add(jsonParse["date"].ToString());
                testSayisi.ListView.Items.Add(jsonParse["totalTests"].ToString());
                vaka.ListView.Items.Add(jsonParse["totalPatients"].ToString());
                iyilesen.ListView.Items.Add(jsonParse["totalRecovered"].ToString());
                vefat.ListView.Items.Add(jsonParse["totalDeaths"].ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciArayuzu.Show();
            this.Hide();
        }

        private void ciktiAl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
