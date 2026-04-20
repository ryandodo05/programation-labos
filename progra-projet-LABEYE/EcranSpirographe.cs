using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progra_projet_LABEYE
{
    public partial class EcranSpirographe : Form
    {
        private Color cFond;
        private Color cTrait;
        private GraphicsPath gpSauvegarde;
        public EcranSpirographe()
        {
            InitializeComponent();
            cFond = Color.White; // Couleur de fond par défaut
            cTrait = Color.Black; // Couleur de trait par défaut
            gpSauvegarde = null;

            DoubleBuffered = true; // Activer le double buffering pour éviter les scintillements
        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (gpSauvegarde != null)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(cFond),
                    new Rectangle(new Point(248, 0), ClientSize));

                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int iSommets = tbSommets.Value; // recupere les infos des trackar
            int iDensite = tbDensite.Value;
            int iProfondeur = tbProfondeur.Value;

            int x0 = 248; // Marge gauche pour le menu
            int largeur = ClientSize.Width - x0; // Largeur disponible pour le dessin
            int hauteur = ClientSize.Height; // Hauteur disponible pour le dessin

            int xc = x0 + largeur / 2; // Centre du dessin
            int yc = hauteur / 2; // Centre du dessin
            int rayon = Math.Min(largeur, hauteur) / 2 - 10; // Rayon du cercle initial, avec une marge de 10 pixels

            double[] sx = new double[iSommets + 1];// Tableau pour les coordonnées x des sommets du polygone
            double[] sy = new double[iSommets + 1];
            for (int i = 0; i <= iSommets; i++)// Initialisation des coordonnées des sommets du polygone
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets); // Calcul de la coordonnée x du sommet i
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets); // Calcul de la coordonnée y du sommet i
            }

            gpSauvegarde = new GraphicsPath();

            // profondeur en pourcentage du rayon initial
            while (Distance(sx[0], sy[0], xc, yc) > rayon * iProfondeur / 100.0)
            {
                // Tracer
                for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine(
                        (float)sx[i], (float)sy[i],
                        (float)sx[i + 1], (float)sy[i + 1]);
                }

                // Calcul du suivant
                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }

                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];
            }

            Invalidate();
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK) // slection couleur trait
            {
                cTrait = cdCouleur.Color;
                Invalidate();
            }
        }

        private void bFond_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK) //slection couleur
            {
                cFond = cdCouleur.Color;
                Invalidate();
            }
        }

        private double Distance(double x1, double y1, double x2, double y2) // Calcul de la distance entre deux points (x1, y1) et (x2, y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        private void tbProfondeur_Scroll(object sender, EventArgs e)
        {

        }

        private void tbDensite_Scroll(object sender, EventArgs e)
        {

        }

        private void tbSommets_Scroll(object sender, EventArgs e)
        {

        }

        private void EcranSpirographe_Paint_1(object sender, PaintEventArgs e)
        {
            if (gpSauvegarde != null)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(cFond),
                    new Rectangle(new Point(248, 0), ClientSize));

                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }
        }
    }
}
