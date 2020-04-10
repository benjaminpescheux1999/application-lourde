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
using System.Security.Cryptography;


namespace BreizhFood
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        string connectionString = "datasource=btsinfo-rousseau53.fr;port=33017;username=2018-breizhinc;password=123456;database=2018-breizhinc_";

        private void button1_Click(object sender, EventArgs e)
        {
            string password = Password.Text;
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();
            Password.Text = encoded;

            // Prepare the connection
            MySqlConnection myConn = new MySqlConnection(connectionString);
            myConn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM auteur Where pseudo_auteur='" + Pseudo.Text + "' and mdp_auteur='" + Password.Text + "'", myConn);
            MySqlDataReader dr;
            dr = sql.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Accueil Ac1 = new Accueil();
                Ac1.ShowDialog();
                Ac1.Activate();
                Dispose();
                // textBox1.Text = dr["pseudo_auteur"].ToString();
                // textBox2.Text = dr["mdp_auteur"].ToString();
            }  else {
                MessageBox.Show("Mauvais identifiant");
            }
        }

        private void Pseudo_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pseudo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
