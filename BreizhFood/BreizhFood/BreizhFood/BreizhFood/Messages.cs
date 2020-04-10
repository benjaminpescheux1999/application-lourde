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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }
        string connectionString = "datasource=btsinfo-rousseau53.fr;port=33017;username=2018-breizhinc;password=123456;database=2018-breizhinc_";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil A1 = new Accueil();
            A1.ShowDialog();
            A1.Activate();
            Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            // Prepare the connection
            MySqlConnection myConn1 = new MySqlConnection(connectionString);
            myConn1.Open();
            MySqlCommand sql1 = new MySqlCommand("SELECT * FROM message Order by DateMess DESC", myConn1);
            MySqlDataReader dr;
            dr = sql1.ExecuteReader();
            if (dr.HasRows)
            {
                listBox1.Items.Clear();
                while (dr.Read())
                {
                    listBox1.Font = new Font("Comic Sans MS", 10);
                    listBox1.Items.Add(dr["NomMess"].ToString()+ " "+ dr["IdMess"].ToString());
                }
            }
            else
            {
                MessageBox.Show("incorrect");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recuperation de la item
            String temp = listBox1.SelectedItem.ToString();

            // recherche de la separation
            int test = temp.IndexOf(" ");
           // MessageBox.Show("recherche du separateur",test.ToString());

            String Nom = temp.ToString().Substring(0, test);
            //MessageBox.Show(Nom.ToString());
            String Id = temp.ToString().Substring(test);

            //MessageBox.Show(Id.ToString());


            // while (listBox1.SelectedItem != null) { MessageBox.Show("ghj"); }

            // Prepare the connection
            MySqlConnection myConn2 = new MySqlConnection(connectionString);
            myConn2.Open();
            MySqlCommand sql2 = new MySqlCommand("SELECT * FROM message where NomMess ='" + Nom + "'and IdMess='"+Id+"'", myConn2);
            MySqlDataReader dr2;
            dr2 = sql2.ExecuteReader();

            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    richTextBox1.Font = new Font("Comic Sans MS", 9);
                    richTextBox1.Text = dr2["NomMess"].ToString()+" - "+dr2["DateMess"].ToString() + " : ";
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox1.AppendText(dr2["MessMess"].ToString());
                }
            }
            else
            {
                MessageBox.Show("incorrect");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
