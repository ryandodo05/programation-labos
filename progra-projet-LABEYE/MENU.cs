using Manipulation_liste;
using Progress_bar_KRAUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace progra_projet_LABEYE
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {FicInversion f1 = new FicInversion(); f1.Show();
        }

        private void bLab2_Click(object sender, EventArgs e)
        {
            progressBAR f2 = new progressBAR(); f2.Show();
        }

        private void bLab3_Click(object sender, EventArgs e)
        {
            Listes f3 = new Listes(); f3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btlab4_Click(object sender, EventArgs e)
        {
            Listes f3 = new Listes(); f3.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EcranEditeur f3 = new EcranEditeur(); f3.Show();
        }

        private void labo6_Click(object sender, EventArgs e)
        {
            EcranSpirographe f3 = new EcranSpirographe(); f3.Show();
        }

        private void LABO7_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f3 = new EcranClavierSouris(); f3.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EcranExplorateur f3 = new EcranExplorateur(); f3.Show();
        }
    }
}
