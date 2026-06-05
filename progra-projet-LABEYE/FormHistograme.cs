using System;
using System.Collections;
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
    public partial class FormHistograme : Form
    {
        // Classe MonPoint
        public class MonPoint // représente un point (X,Y)
        {
            public int X { get; set; }
            public int Y { get; set; }

            public MonPoint(int x, int y) { X = x; Y = y; }// Constructeur

            public override string ToString() { return $"X={X}, Y={Y}"; }// Affichage dans ListBox
        }
        ArrayList alData = new ArrayList();// Stocke les points
        Random rnd = new Random();// Générateur de nombres aléatoires
        public FormHistograme()// Constructeur
        {
            
            InitializeComponent();
        }

        private void bCreer_Click(object sender, EventArgs e)// Créer des points aléatoires
        {
            alData.Clear();// Vider la liste de données
            lbMonPoint.Items.Clear();// Vider la ListBox

            int nb = rnd.Next(5, 15);// Nombre de points entre 5 et 15
            int dernierX = 0;

            for (int i = 0; i < nb; i++)// Générer les points
            {
                dernierX += rnd.Next(1, 20);        // X croissant
                int y = rnd.Next(-100, 101);         // Y entre -100 et 100

                MonPoint mp = new MonPoint(dernierX, y);// Créer un point
                alData.Add(mp);
                lbMonPoint.Items.Add(mp);
            }
        }

        private void lbMonPoint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            pDessin.Invalidate();
        }

        private void pDessin_Paint(object sender, PaintEventArgs e)// Dessiner les points et les lignes
        {
            if (alData.Count == 0) return;// Rien à dessiner

            Graphics g = e.Graphics;// Contexte graphique
            int W = pDessin.Width;// Largeur du panel
            int H = pDessin.Height;// Hauteur du panel

            // Trouver Min/Max
            int minX = ((MonPoint)alData[0]).X;
            int maxX = ((MonPoint)alData[alData.Count - 1]).X;
            int minY = 100, maxY = -100;

            foreach (MonPoint mp in alData)
            {
                if (mp.Y < minY) minY = mp.Y;
                if (mp.Y > maxY) maxY = mp.Y;
            }

            // convertir (px, py) en (ex, ey) pour dessiner
            Point Conv(int px, int py)
            {
                int ex = (px - minX) * (W - 1) / (maxX - minX);// X de 0 à W-1
                int ey = (maxY - py) * (H - 1) / (maxY - minY);// Y de 0 à H-1 (inversé)
                return new Point(ex, ey);
            }

            // Dessiner les lignes
            Pen stylo = new Pen(Color.Blue, 2); 
            for (int i = 0; i < alData.Count - 1; i++)
            {
                MonPoint p1 = (MonPoint)alData[i];
                MonPoint p2 = (MonPoint)alData[i + 1];
                g.DrawLine(stylo, Conv(p1.X, p1.Y), Conv(p2.X, p2.Y));
            }

            // Dessiner les points
            foreach (MonPoint mp in alData)
            {
                Point pt = Conv(mp.X, mp.Y);
                g.FillEllipse(Brushes.Red, pt.X - 4, pt.Y - 4, 8, 8);
            }

            stylo.Dispose();
        }
    
    }
}
