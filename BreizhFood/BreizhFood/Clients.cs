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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void vilbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil A1 = new Accueil();
            A1.ShowDialog();
            A1.Activate();
            Dispose();
        }

        private void actubut_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;username=root;password=;database=2018-breizhinc_";

            // Prepare the connection
            MySqlConnection myConn1 = new MySqlConnection(connectionString);
            myConn1.Open();
            MySqlCommand sql1 = new MySqlCommand("SELECT * FROM auteur", myConn1);
            MySqlDataReader dr;
            dr = sql1.ExecuteReader();
            if (dr.HasRows)
            {
                listBoxclient.Items.Clear();
                while (dr.Read())
                {
                    listBoxclient.Items.Add(dr["pseudo_auteur"].ToString());
                    // MessageBox.Show(dr["lib_produit"].ToString(), dr["id_categorie"].ToString());
                    // MessageBox.Show(dr["id_categorie"].ToString());
                    // Produits.Items.Add(dr["lib_produit"].ToString());
                    //MessageBox.Show(dr["lib_produit"].ToString());
                    // richTextBox1.Text = dr["lib_produit"].ToString();
                    // textBox2.Text = dr["mdp_auteur"].ToString();
                }
            }
            else
            {
                MessageBox.Show("incorrect");
            }
        }

        private void listBoxclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = listBoxclient.SelectedItem.ToString();
            string connectionString = "datasource=127.0.0.1;username=root;password=;database=2018-breizhinc_";

            // Prepare the connection
            MySqlConnection myConn2 = new MySqlConnection(connectionString);
            myConn2.Open();
            MySqlCommand sql2 = new MySqlCommand("SELECT * FROM auteur where pseudo_auteur ='" + temp + "'", myConn2);
            MySqlDataReader dr2;
            dr2 = sql2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    PseudoAuteur.Text = dr2["pseudo_auteur"].ToString();
                    imgAuteur.Text = dr2["img_auteur"].ToString();
                    NomAuteur.Text = dr2["nom_auteur"].ToString();
                    PrenomAuteur.Text = dr2["pre_auteur"].ToString();
                    RueAuteur.Text = dr2["rue_auteur"].ToString();
                    CPAuteur.Text = dr2["cp_auteur"].ToString();
                    VilleAuteur.Text = dr2["ville_auteur"].ToString();
                    TelAuteur.Text = dr2["tel_auteur"].ToString();
                    MailAuteur.Text = dr2["email_auteur"].ToString();



                    // Categories.Items.Add(dr1["lib_categorie"].ToString());
                    // MessageBox.Show(dr1["lib_categorie"].ToString());
                    // textBox1.Text = dr["pseudo_auteur"].ToString();
                    // textBox2.Text = dr["mdp_auteur"].ToString();
                }
            }
            else
            {
                MessageBox.Show("incorrect");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil Ac1 = new Accueil();
            Ac1.ShowDialog();
            Ac1.Activate();
            Dispose();
        }

        private void nombox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdpAuteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgAuteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomAuteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelCat_Click(object sender, EventArgs e)
        {
            String temp = listBoxclient.SelectedItem.ToString();
            string connectionString = "datasource=127.0.0.1;username=root;password=;database=2018-breizhinc_";

            // Prepare the connection
            MySqlConnection myConn3 = new MySqlConnection(connectionString);
            myConn3.Open();
            MySqlCommand sql3 = new MySqlCommand("DELETE FROM auteur WHERE pseudo_Auteur = '" + temp + "'", myConn3);
            MySqlDataReader dr3;
            dr3 = sql3.ExecuteReader();
            PseudoAuteur.Clear();
            mdpAuteur.Clear();
            imgAuteur.Clear();
            NomAuteur.Clear();
            PrenomAuteur.Clear();
            RueAuteur.Clear();
            CPAuteur.Clear();
            VilleAuteur.Clear();
            TelAuteur.Clear();
            MailAuteur.Clear();
            listBoxclient.Items.Clear();
            MessageBox.Show("Refresh la page");
        }

        private void AddCat_Click(object sender, EventArgs e)
        {
            string password = mdpAuteur.Text;

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
            mdpAuteur.Text = encoded;
            string connectionString = "datasource=127.0.0.1;username=root;password=;database=2018-breizhinc_";

            // Prepare the connection
            MySqlConnection myConn4 = new MySqlConnection(connectionString);
            myConn4.Open();
            MySqlCommand sql4 = new MySqlCommand("INSERT INTO auteur(pseudo_auteur, mdp_auteur, img_auteur, nom_auteur, pre_auteur, rue_auteur, cp_auteur, ville_auteur, tel_auteur, email_auteur) VALUES('" + PseudoAuteur.Text + "', '" + mdpAuteur.Text + "', '" + imgAuteur.Text + "', '" + NomAuteur.Text + "', '" + PrenomAuteur.Text + "', '" + RueAuteur.Text + "', '" + CPAuteur.Text + "', '" + VilleAuteur.Text + "', '" + TelAuteur.Text + "', '" + MailAuteur.Text + "')", myConn4);
            MySqlDataReader dr4;
            dr4 = sql4.ExecuteReader();
            PseudoAuteur.Clear();
            mdpAuteur.Clear();
            imgAuteur.Clear();
            NomAuteur.Clear();
            PrenomAuteur.Clear();
            RueAuteur.Clear();
            CPAuteur.Clear();
            VilleAuteur.Clear();
            TelAuteur.Clear();
            MailAuteur.Clear();
            listBoxclient.Items.Clear();
            MessageBox.Show("Refresh la page");
        }

        private void ModifCat_Click(object sender, EventArgs e)
        {
            string password = mdpAuteur.Text;

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
            mdpAuteur.Text = encoded;
            String temp = listBoxclient.SelectedItem.ToString();
            string connectionString = "datasource=127.0.0.1;username=root;password=;database=2018-breizhinc_";

            // Prepare the connection
            MySqlConnection myConn3 = new MySqlConnection(connectionString);
            myConn3.Open();
            MySqlCommand sql3 = new MySqlCommand("UPDATE auteur SET pseudo_auteur='" + PseudoAuteur.Text + "',mdp_auteur='" + mdpAuteur.Text + "',img_auteur='" + imgAuteur.Text + "',nom_auteur='" + NomAuteur.Text + "',pre_auteur='" + PrenomAuteur.Text + "',rue_auteur='" + RueAuteur.Text + "',cp_auteur='" + CPAuteur.Text + "',ville_auteur='" + VilleAuteur.Text + "',tel_auteur='" + TelAuteur.Text + "',email_auteur='" + MailAuteur.Text + "' WHERE pseudo_auteur='" + temp + "'", myConn3);
            MySqlDataReader dr3;
            dr3 = sql3.ExecuteReader();
            PseudoAuteur.Clear();
            mdpAuteur.Clear();
            imgAuteur.Clear();
            NomAuteur.Clear();
            PrenomAuteur.Clear();
            RueAuteur.Clear();
            CPAuteur.Clear();
            VilleAuteur.Clear();
            TelAuteur.Clear();
            MailAuteur.Clear();
            listBoxclient.Items.Clear();
            MessageBox.Show("Refresh la page");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login L1 = new Login();
            L1.ShowDialog();
            L1.Activate();
            Dispose();
        }
    }
}
