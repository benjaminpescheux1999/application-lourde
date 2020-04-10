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

namespace BreizhFood
{
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }
        string connectionString = "datasource=btsinfo-rousseau53.fr;port=33017;username=2018-breizhinc;password=123456;database=2018-breizhinc_";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ImportCat_Click(object sender, EventArgs e)
        {

        }

        private void ImportP_Click(object sender, EventArgs e)
        {

        }

        private void ProduitN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }

        private void ModifCat_Click(object sender, EventArgs e)
        {

        }

        private void Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Categories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string item = this.Categories.GetItemText(this.Categories.SelectedItem);

            // Prepare the connection
            MySqlConnection myConn1 = new MySqlConnection(connectionString);
            myConn1.Open();
            MySqlCommand sql1 = new MySqlCommand("SELECT * FROM produit Where id_categorie = (select id_categorie from categorie where lib_categorie='"+ item +"')", myConn1);
            MySqlDataReader dr;
            dr = sql1.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["lib_produit"].ToString());
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
        private void Articles_Load_1(object sender, EventArgs e)
        {
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProduitN.Clear();
            ProduitP.Clear();
            ProduitI.Clear();
            ProduitC.Clear();

            // Prepare the connection
            MySqlConnection myConn = new MySqlConnection(connectionString);
            myConn.Open();
            MySqlCommand sql1 = new MySqlCommand("SELECT * FROM categorie", myConn);
            MySqlDataReader dr1;
            dr1 = sql1.ExecuteReader();
            if (dr1.HasRows)
            {
                Categories.Items.Clear();
                while (dr1.Read())
                {
                    Categories.Items.Add(dr1["lib_categorie"].ToString());
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String temp = listBox1.SelectedItem.ToString();
            // Prepare the connection
            MySqlConnection myConn2 = new MySqlConnection(connectionString);
            myConn2.Open();
            MySqlCommand sql2 = new MySqlCommand("SELECT * FROM produit where lib_produit ='" +temp+"'", myConn2);
            MySqlDataReader dr2;
            dr2 = sql2.ExecuteReader();
            if (dr2.HasRows)
            {
                Categories.Items.Clear();
                while (dr2.Read())
                {
                    ProduitN.Text = dr2["lib_produit"].ToString();
                    ProduitP.Text = dr2["prix_produit"].ToString();
                    ProduitI.Text = dr2["img_produit"].ToString();
                    ProduitC.Text = dr2["id_categorie"].ToString();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ProduitN_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void ModifCat_Click_1(object sender, EventArgs e)
        {
            String temp = listBox1.SelectedItem.ToString();
            // Prepare the connection
            MySqlConnection myConn3 = new MySqlConnection(connectionString);
            myConn3.Open();
            MySqlCommand sql3 = new MySqlCommand("UPDATE produit SET lib_produit='"+ProduitN.Text+"',prix_produit='"+ProduitP.Text+ "',img_produit='" + ProduitI.Text + "',id_categorie='" + ProduitC.Text + "' WHERE lib_produit='" + temp +"'", myConn3);
            MySqlDataReader dr3;
            dr3 = sql3.ExecuteReader();
            ProduitN.Clear();
            ProduitP.Clear();
            ProduitI.Clear();
            ProduitC.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Refresh la page");
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil Ac1 = new Accueil();
            Ac1.ShowDialog();
            Ac1.Activate();
            Dispose();
        }

        private void DelCat_Click(object sender, EventArgs e)
        {
            String temp = listBox1.SelectedItem.ToString();
            // Prepare the connection
            MySqlConnection myConn3 = new MySqlConnection(connectionString);
            myConn3.Open();
            MySqlCommand sql3 = new MySqlCommand("DELETE FROM produit WHERE lib_produit = '" + temp + "'", myConn3);
            MySqlDataReader dr3;
            dr3 = sql3.ExecuteReader();
            ProduitN.Clear();
            ProduitP.Clear();
            ProduitI.Clear();
            ProduitC.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Refresh la page");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void AddCat_Click(object sender, EventArgs e)
        {
            // Prepare the connection
            MySqlConnection myConn4 = new MySqlConnection(connectionString);
            myConn4.Open();
            MySqlCommand sql4 = new MySqlCommand("INSERT INTO produit(lib_produit, img_produit, prix_produit, id_categorie) VALUES('"+ProduitN.Text+"', '"+ProduitI.Text + "', '"+ProduitP.Text+"', '"+ProduitC.Text+"')", myConn4);
            MySqlDataReader dr4;
            dr4 = sql4.ExecuteReader();
            ProduitN.Clear();
            ProduitP.Clear();
            ProduitI.Clear();
            ProduitC.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Refresh la page");
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
