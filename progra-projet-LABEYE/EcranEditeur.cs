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
    public partial class EcranEditeur : Form
    {
        private string sFichier = "";
        private bool bModifier = false;
        public EcranEditeur()
        {
            InitializeComponent();
            sFichier = "";
            bModifier = false;
        }
        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private bool VerifierSauver()
        {
            if (!bModifier) return true;

            DialogResult rep = MessageBox.Show(
                "Le texte a été modifié, enregistrer ?",
                "Attention",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (rep == DialogResult.Yes)
            {
                FichierEnregistrer();
                return true;
            }
            else if (rep == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                    sFichier = sfdEnregistrer.FileName;
                else
                    return;
            }

            rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
            bModifier = false;
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver()) return;

            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;
        }


        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver()) return;

            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver()) return;

            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofdOuvrir.FileName;
                rtbTexte.LoadFile(sFichier, RichTextBoxStreamType.RichText);
                bModifier = false;
            }
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
                this.Close();
        }

        // pour copier coller et couper
        private void Copier_Click(object sender, EventArgs e) => rtbTexte.Copy();
        private void Couper_Click(object sender, EventArgs e) => rtbTexte.Cut();
        private void Coller_Click(object sender, EventArgs e) => rtbTexte.Paste();

        private void Format_Click(object sender, EventArgs e)
        {

        }

        private void gaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left; // JUSTIFIER A GAUCHE
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center; // JUSTIFIER AU CENTRE
        }

        private void droiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right; // JUSTIFIER A DROITE
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdPolice.Font = rtbTexte.SelectionFont;

            if (fdPolice.ShowDialog() == DialogResult.OK)
                rtbTexte.SelectionFont = fdPolice.Font;
        }

        private void ToggleStyle(FontStyle style)
        {
            if (rtbTexte.SelectionFont == null) return;

            FontStyle newStyle;

            if (rtbTexte.SelectionFont.Style.HasFlag(style))
                newStyle = rtbTexte.SelectionFont.Style & ~style;
            else
                newStyle = rtbTexte.SelectionFont.Style | style;

            rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, newStyle);
        }

        private void grasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void italiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void soulign2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void barréToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Strikeout);
        }
    }
}
