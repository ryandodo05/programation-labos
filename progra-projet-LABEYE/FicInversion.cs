using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progra_projet_LABEYE
{
    public partial class FicInversion : Form
    {
        public FicInversion()
        {
            InitializeComponent();

            img1.Left = (this.ClientSize.Width - img1.Width) / 2 - img1.Width / 2; // Centrer les deux images
            img1.Top = (this.ClientSize.Height - img1.Height) / 2;
            img2.Left = img1.Right + 10;
            img2.Top = img1.Top;

            img1.Image = Image.FromFile("1.jpg");
            img2.Image = Image.FromFile("2.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (img1.Image != null && img2.Image != null)
            {
                Image temp = img1.Image;
                img1.Image = img2.Image;
                img2.Image = temp;
            }
            else
            {
                MessageBox.Show("Les images ne sont pas chargées !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Ouvrir form 2
            f2.Show();
            this.Hide();
        }
    }
}
