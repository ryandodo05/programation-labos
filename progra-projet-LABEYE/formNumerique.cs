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
    public partial class formNumerique : Form
    {
        public formNumerique()
        {
            InitializeComponent();
        }
        double Polynome(double x) { return x * x + 2; } // fonction polynomiale
        double Trigonometrique(double x) { return Math.Sin(x); }// fonction trigonométrique

        void Calculer(Func<double, double> f, string nomFonction)//calcul intégrale par la méthode des trapèzes
        {
            double a = double.Parse(tbGauche.Text);// borne gauche
            double b = double.Parse(tbDroite.Text);// borne droite
            int n = int.Parse(tbNbInt.Text);// nombre d'intervalles
            if (n < 1) n = 1;// on

            lbResultats.Items.Add($"Méthode des trapèzes");
            lbResultats.Items.Add($"  Fonction : {nomFonction}");

            // On calcule pour n, 2n, 4n, 8n, 16n
            int[] multiples = { 1, 2, 4, 8, 16 };

            foreach (int m in multiples)// on multiplie le nombre d'intervalles par m
            {
                int nbInt = n * m;// nombre d'intervalles
                double h = (b - a) / nbInt;// largeur de chaque intervalle
                double somme = (f(a) + f(b)) / 2.0;// contribution des extrémités

                for (int i = 1; i < nbInt; i++)// contribution des points intermédiaires
                {
                    somme += f(a + i * h);// on évalue la fonction aux points intermédiaires et on les ajoute à la somme
                }

                double resultat = somme * h;// résultat de l'intégrale approchée
                lbResultats.Items.Add($"  Nb Int : {nbInt} => {resultat}");
            }
        }


        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)// calcul intégrale de sin(x) en utilisant un pointeur de fonction
        {
            Func<double, double> fp = x => Math.Sin(x);// on crée un pointeur de fonction pour sin(x)
            Calculer(fp, "sin(x) (pointeur)");
        }

        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            Calculer(Trigonometrique, "sin(x)");// calcul intégrale de sin(x) en utilisant la fonction Trigonometrique
        }

        private void bPolynome_Click(object sender, EventArgs e)
        {
            Calculer(Polynome, "x*x + 2");//    calcul intégrale de x^2 + 2 en utilisant la fonction Polynome
        }

        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            Func<double, double> fp = x => x * x + 2;// on crée un pointeur de fonction pour x^2 + 2
            Calculer(fp, "x*x + 2 (pointeur)");
        }

        private void lbResultats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNbInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDroite_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGauche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
