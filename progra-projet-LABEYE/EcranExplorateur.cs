using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progra_projet_LABEYE
{
    public partial class EcranExplorateur : Form
    {
        public EcranExplorateur()
        {
            InitializeComponent();
            this.Load += EcranExplorateur_Load; // load car j'ai pas trouvr dans les evenements du designer
        }


        private void EcranExplorateur_Load(object sender, EventArgs e)
        {
            RemplirTreeView(); // remplir le treeview avec les disques

        }
        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear(); // on le vide avant
            LireDisques(); // et on le remplit avec les disques du pc
        }

        private void LireDisques()
        {
            string[] disques = Environment.GetLogicalDrives(); //recup les disques

            foreach (string disque in disques) // pour chacuns
            {
                TreeNode node = new TreeNode(disque); //on ajoute le disque dans le treeview
                node.Tag = disque;

                node.Nodes.Add("..."); // ajout de mon noeud pour le developper plus tard

                tvRepertoire.Nodes.Add(node); // le mettre dans le treeview
            }
        }

        private void LireRepertoires(TreeNode parent)
        {
            try
            {
                string chemin = parent.Tag.ToString(); //recup le chemin du noeud parent
                string[] dossiers = Directory.GetDirectories(chemin);// recup les dossiers du chemin

                foreach (string dossier in dossiers)// pour chacuns
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dossier));// on ajoute le nom du dossier dans le treeview
                    node.Tag = dossier;// on stock le chemin du dossier dans le tag du noeud

                    node.Nodes.Add("...");

                    parent.Nodes.Add(node);
                }
            }
            catch
            {
                // ignore ereur 
            }
        }

        private void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear();// on vide la listview avant de la remplir

            try
            {
                string[] fichiers = Directory.GetFiles(chemin);// recup les fichiers du chemin

                foreach (string fichier in fichiers)// pour chacuns
                {
                    FileInfo info = new FileInfo(fichier);// recup les infos du fichier

                    ListViewItem item = new ListViewItem(NomFichier(info.Name));// on ajoute le nom du fichier dans la listview

                    item.SubItems.Add(info.Length.ToString()); // la taille, la date de creation et la date de modification
                    item.SubItems.Add(info.CreationTime.ToString());
                    item.SubItems.Add(info.LastWriteTime.ToString());

                    lvFichiers.Items.Add(item);
                }
            }
            catch
            {
                // ignore ereur
            }
        }

        private string NomFichier(string nom)
        {
            return Path.GetFileNameWithoutExtension(nom); // on retourne le nom du fichier sans l'extension
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close(); //pour fermer la fenetre
        }

        private void tsddbApparence_Click(object sender, EventArgs e)
        {

        }

        private void tsaPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.SmallIcon; // petites icones
        }

        private void tsaGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.LargeIcon; // grosses icones
        }

        private void tsaListe_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.List; // lsite
        }

        private void tsaDetail_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.Details; // details
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)// si le noeud n'a pas de tag, on    
                return; // ignore

            string chemin = e.Node.Tag.ToString();// recup le chemin du noeud selectionné
            LireFichiers(chemin);// et on affiche les fichiers dans la listview
        }

        private void lvFichiers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsCommandes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ssMessage_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tvRepertoire_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {//test push
            e.Node.Nodes.Clear(); //enlever le ... pour pas avoir de doubles

            LireRepertoires(e.Node); //lire sous dossiers
        }
    }
}
