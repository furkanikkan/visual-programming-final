using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace siteYonetimi
{
    public class Baglanti
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Baglanti()
        {
            server = "localhost";
            database = "siteyonetimi";
            uid = "root";
            password = "12345678";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
             
        }
        public bool BaglantiAc()
        {
            connection.Open();
          return true;
        }
        public bool BaglantiKapat()
        {
            connection.Close();
           return true;
        }
    }
}
