using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreizhFood
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients C1 = new Clients();
            C1.ShowDialog();
            C1.Activate();
            Dispose();
        }

        private void Articles_Click(object sender, EventArgs e)
        {

            this.Hide();
            Articles A1 = new Articles();
            A1.ShowDialog();
            A1.Activate();
            Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Messages M1 = new Messages();

            M1.ShowDialog();
            M1.Activate();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L1 = new Login();
            L1.ShowDialog();
            L1.Activate();
            Dispose();
        }
    }
}
