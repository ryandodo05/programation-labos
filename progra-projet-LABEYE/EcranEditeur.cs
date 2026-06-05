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

            // Vérification que les composants existent (pour éviter les erreurs)
            if (rtbTexte == null)
                throw new Exception("Le RichTextBox 'rtbTexte' n'est pas défini dans le designer.");
            if (sfdEnregistrer == null)
                throw new Exception("Le dialogue 'sfdEnregistrer' n'est pas défini dans le designer.");
            if (ofdOuvrir == null)
                throw new Exception("Le dialogue 'ofdOuvrir' n'est pas défini dans le designer.");
        }
        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private bool VerifierSauver()
        {
            if (!bModifier) return true;

            DialogResult rep = MessageBox.Show(
                "Le texte a été modifié. Voulez-vous enregistrer les modifications ?",
                "Attention",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            switch (rep)
            {
                case DialogResult.Yes:
                    FichierEnregistrer();
                    return true;
                case DialogResult.No:
                    return true;
                default: // DialogResult.Cancel
                    return false;
            }
        }

        private void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                // Si aucun fichier n'est ouvert, on demande un nouveau nom
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    sFichier = sfdEnregistrer.FileName;
                }
                else
                {
                    return; // Annulé par l'utilisateur
                }
            }

            try
            {
                rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
                bModifier = false;
                MessageBox.Show("Fichier enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
