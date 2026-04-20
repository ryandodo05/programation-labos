namespace progra_projet_LABEYE
{
    partial class EcranEditeur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.fdPolice = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.Editer = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caractèreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soulign2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.pbEnregistrer = new System.Windows.Forms.PictureBox();
            this.pbOuvrir = new System.Windows.Forms.PictureBox();
            this.pbNouveau = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pbQuitter);
            this.pMenu.Controls.Add(this.pbEnregistrer);
            this.pMenu.Controls.Add(this.pbOuvrir);
            this.pMenu.Controls.Add(this.pbNouveau);
            this.pMenu.Location = new System.Drawing.Point(20, 54);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(784, 90);
            this.pMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(726, 283);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // rtbTexte
            // 
            this.rtbTexte.Location = new System.Drawing.Point(19, 150);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(785, 309);
            this.rtbTexte.TabIndex = 2;
            this.rtbTexte.Text = "";
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier,
            this.Editer,
            this.Format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Fichier
            // 
            this.Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.Fichier.Name = "Fichier";
            this.Fichier.Size = new System.Drawing.Size(66, 26);
            this.Fichier.Text = "Fichier";
            this.Fichier.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // Editer
            // 
            this.Editer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.Editer.Name = "Editer";
            this.Editer.Size = new System.Drawing.Size(62, 26);
            this.Editer.Text = "Editer";
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justifierToolStripMenuItem,
            this.policeToolStripMenuItem,
            this.caractèreToolStripMenuItem});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(70, 24);
            this.Format.Text = "Format";
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.copierToolStripMenuItem.Text = "Copier";
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.couperToolStripMenuItem.Text = "Couper";
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.collerToolStripMenuItem.Text = "Coller";
            // 
            // justifierToolStripMenuItem
            // 
            this.justifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaucheToolStripMenuItem,
            this.centreToolStripMenuItem,
            this.droiteToolStripMenuItem});
            this.justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            this.justifierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.justifierToolStripMenuItem.Text = "Justifier";
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.policeToolStripMenuItem.Text = "Police";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // caractèreToolStripMenuItem
            // 
            this.caractèreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grasToolStripMenuItem,
            this.italiqueToolStripMenuItem,
            this.soulign2ToolStripMenuItem,
            this.barréToolStripMenuItem});
            this.caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            this.caractèreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // gaucheToolStripMenuItem
            // 
            this.gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            this.gaucheToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gaucheToolStripMenuItem.Text = "Gauche";
            this.gaucheToolStripMenuItem.Click += new System.EventHandler(this.gaucheToolStripMenuItem_Click);
            // 
            // centreToolStripMenuItem
            // 
            this.centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            this.centreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.centreToolStripMenuItem.Text = "Centre";
            this.centreToolStripMenuItem.Click += new System.EventHandler(this.centreToolStripMenuItem_Click);
            // 
            // droiteToolStripMenuItem
            // 
            this.droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            this.droiteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.droiteToolStripMenuItem.Text = "Droite";
            this.droiteToolStripMenuItem.Click += new System.EventHandler(this.droiteToolStripMenuItem_Click);
            // 
            // grasToolStripMenuItem
            // 
            this.grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            this.grasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grasToolStripMenuItem.Text = "Gras";
            this.grasToolStripMenuItem.Click += new System.EventHandler(this.grasToolStripMenuItem_Click);
            // 
            // italiqueToolStripMenuItem
            // 
            this.italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            this.italiqueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.italiqueToolStripMenuItem.Text = "Italique";
            this.italiqueToolStripMenuItem.Click += new System.EventHandler(this.italiqueToolStripMenuItem_Click);
            // 
            // soulign2ToolStripMenuItem
            // 
            this.soulign2ToolStripMenuItem.Name = "soulign2ToolStripMenuItem";
            this.soulign2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.soulign2ToolStripMenuItem.Text = "Souligné";
            this.soulign2ToolStripMenuItem.Click += new System.EventHandler(this.soulign2ToolStripMenuItem_Click);
            // 
            // barréToolStripMenuItem
            // 
            this.barréToolStripMenuItem.Name = "barréToolStripMenuItem";
            this.barréToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.barréToolStripMenuItem.Text = "Barré";
            this.barréToolStripMenuItem.Click += new System.EventHandler(this.barréToolStripMenuItem_Click);
            // 
            // pbQuitter
            // 
            this.pbQuitter.Image = global::progra_projet_LABEYE.Properties.Resources.leaveicon;
            this.pbQuitter.Location = new System.Drawing.Point(223, 17);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(63, 59);
            this.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuitter.TabIndex = 3;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // pbEnregistrer
            // 
            this.pbEnregistrer.Image = global::progra_projet_LABEYE.Properties.Resources.saveicon;
            this.pbEnregistrer.Location = new System.Drawing.Point(154, 17);
            this.pbEnregistrer.Name = "pbEnregistrer";
            this.pbEnregistrer.Size = new System.Drawing.Size(63, 59);
            this.pbEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnregistrer.TabIndex = 2;
            this.pbEnregistrer.TabStop = false;
            this.pbEnregistrer.Click += new System.EventHandler(this.pbEnregistrer_Click);
            // 
            // pbOuvrir
            // 
            this.pbOuvrir.Image = global::progra_projet_LABEYE.Properties.Resources.openicon;
            this.pbOuvrir.Location = new System.Drawing.Point(85, 17);
            this.pbOuvrir.Name = "pbOuvrir";
            this.pbOuvrir.Size = new System.Drawing.Size(63, 59);
            this.pbOuvrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOuvrir.TabIndex = 1;
            this.pbOuvrir.TabStop = false;
            this.pbOuvrir.Click += new System.EventHandler(this.pbOuvrir_Click);
            // 
            // pbNouveau
            // 
            this.pbNouveau.Image = global::progra_projet_LABEYE.Properties.Resources.newicon;
            this.pbNouveau.Location = new System.Drawing.Point(16, 17);
            this.pbNouveau.Name = "pbNouveau";
            this.pbNouveau.Size = new System.Drawing.Size(63, 59);
            this.pbNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNouveau.TabIndex = 0;
            this.pbNouveau.TabStop = false;
            this.pbNouveau.Click += new System.EventHandler(this.pbNouveau_Click);
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 514);
            this.Controls.Add(this.rtbTexte);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EcranEditeur";
            this.Text = "EcranEditeur";
            this.pMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pbEnregistrer;
        private System.Windows.Forms.PictureBox pbOuvrir;
        private System.Windows.Forms.PictureBox pbNouveau;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.FontDialog fdPolice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Fichier;
        private System.Windows.Forms.ToolStripMenuItem Editer;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caractèreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soulign2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barréToolStripMenuItem;
    }
}