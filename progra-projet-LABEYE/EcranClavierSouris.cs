using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progra_projet_LABEYE
{
    public partial class EcranClavierSouris : Form
    {
        private int nbGauche = 0;
        private int nbDroit = 0;
        public EcranClavierSouris()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }
        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nbGauche++;

            if (e.Button == MouseButtons.Right)
                nbDroit++;

            AfficherClic();

            // Détection de la case cliquée
            DetecterCaseCliquee(e.X, e.Y);
        }

        private void DetecterCaseCliquee(int x, int y)
        {
            int w = pnlSouris.Width;
            int h = pnlSouris.Height;

            int col = x / (w / 3);
            int lig = y / (h / 3);

            lsbClavier.Items.Add($"Clic dans case : Ligne {lig + 1}, Colonne {col + 1}");
        }



        private void butRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();

            tbxPositionX.Text = "";
            tbxPositionY.Text = "";

            lsbClavier.Items.Clear();
        }

        private void tbxClicGauche_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxClicDroit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPositionX_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPositionY_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsbClavier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlSouris_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Add($"KeyDown : {e.KeyCode}");
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Add($"KeyPress : '{e.KeyChar}'");
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Add($"KeyUp : {e.KeyCode}");
        }
    }
}
