namespace progra_projet_LABEYE
{
    partial class EcranExplorateur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            this.tsCommandes = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbApparence = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsaPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.scSeparateur = new System.Windows.Forms.SplitContainer();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.lvFichiers = new System.Windows.Forms.ListView();
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CREA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MODI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilTreeView = new System.Windows.Forms.ImageList(this.components);
            this.ilGrand = new System.Windows.Forms.ImageList(this.components);
            this.ilPetit = new System.Windows.Forms.ImageList(this.components);
            this.tsCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).BeginInit();
            this.scSeparateur.Panel1.SuspendLayout();
            this.scSeparateur.Panel2.SuspendLayout();
            this.scSeparateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommandes
            // 
            this.tsCommandes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsddbApparence});
            this.tsCommandes.Location = new System.Drawing.Point(0, 0);
            this.tsCommandes.Name = "tsCommandes";
            this.tsCommandes.Size = new System.Drawing.Size(1372, 27);
            this.tsCommandes.TabIndex = 0;
            this.tsCommandes.Text = "toolStrip1";
            this.tsCommandes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsCommandes_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "tsbQuitter";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsddbApparence
            // 
            this.tsddbApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsaPetitesIcones,
            this.tsaGrandesIcones,
            this.tsaListe,
            this.tsaDetail});
            this.tsddbApparence.Image = ((System.Drawing.Image)(resources.GetObject("tsddbApparence.Image")));
            this.tsddbApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbApparence.Name = "tsddbApparence";
            this.tsddbApparence.Size = new System.Drawing.Size(34, 24);
            this.tsddbApparence.Text = "toolStripDropDownButton1";
            this.tsddbApparence.Click += new System.EventHandler(this.tsddbApparence_Click);
            // 
            // tsaPetitesIcones
            // 
            this.tsaPetitesIcones.Name = "tsaPetitesIcones";
            this.tsaPetitesIcones.Size = new System.Drawing.Size(224, 26);
            this.tsaPetitesIcones.Text = "petits icones";
            this.tsaPetitesIcones.Click += new System.EventHandler(this.tsaPetitesIcones_Click);
            // 
            // tsaGrandesIcones
            // 
            this.tsaGrandesIcones.Name = "tsaGrandesIcones";
            this.tsaGrandesIcones.Size = new System.Drawing.Size(224, 26);
            this.tsaGrandesIcones.Text = "grandes icones";
            this.tsaGrandesIcones.Click += new System.EventHandler(this.tsaGrandesIcones_Click);
            // 
            // tsaListe
            // 
            this.tsaListe.Name = "tsaListe";
            this.tsaListe.Size = new System.Drawing.Size(224, 26);
            this.tsaListe.Text = "liste";
            this.tsaListe.Click += new System.EventHandler(this.tsaListe_Click);
            // 
            // tsaDetail
            // 
            this.tsaDetail.Name = "tsaDetail";
            this.tsaDetail.Size = new System.Drawing.Size(224, 26);
            this.tsaDetail.Text = "detail";
            this.tsaDetail.Click += new System.EventHandler(this.tsaDetail_Click);
            // 
            // ssMessage
            // 
            this.ssMessage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMessage.Location = new System.Drawing.Point(0, 482);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(1372, 22);
            this.ssMessage.TabIndex = 1;
            this.ssMessage.Text = "statusStrip1";
            this.ssMessage.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssMessage_ItemClicked);
            // 
            // scSeparateur
            // 
            this.scSeparateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSeparateur.Location = new System.Drawing.Point(0, 27);
            this.scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            this.scSeparateur.Panel1.Controls.Add(this.tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            this.scSeparateur.Panel2.Controls.Add(this.lvFichiers);
            this.scSeparateur.Size = new System.Drawing.Size(1372, 455);
            this.scSeparateur.SplitterDistance = 457;
            this.scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Location = new System.Drawing.Point(6, 8);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.Size = new System.Drawing.Size(316, 434);
            this.tvRepertoire.TabIndex = 0;
            this.tvRepertoire.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvRepertoire_BeforeExpand);
            this.tvRepertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRepertoire_AfterSelect);
            // 
            // lvFichiers
            // 
            this.lvFichiers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.TAIL,
            this.CREA,
            this.MODI});
            this.lvFichiers.HideSelection = false;
            this.lvFichiers.Location = new System.Drawing.Point(3, 8);
            this.lvFichiers.Name = "lvFichiers";
            this.lvFichiers.Size = new System.Drawing.Size(896, 434);
            this.lvFichiers.TabIndex = 0;
            this.lvFichiers.UseCompatibleStateImageBehavior = false;
            this.lvFichiers.View = System.Windows.Forms.View.Details;
            this.lvFichiers.SelectedIndexChanged += new System.EventHandler(this.lvFichiers_SelectedIndexChanged);
            // 
            // NOM
            // 
            this.NOM.Text = "Nom";
            this.NOM.Width = 321;
            // 
            // TAIL
            // 
            this.TAIL.Text = "taille";
            this.TAIL.Width = 93;
            // 
            // CREA
            // 
            this.CREA.Text = "création";
            this.CREA.Width = 98;
            // 
            // MODI
            // 
            this.MODI.Text = "Modification";
            this.MODI.Width = 105;
            // 
            // ilTreeView
            // 
            this.ilTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGrand
            // 
            this.ilGrand.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilGrand.ImageSize = new System.Drawing.Size(16, 16);
            this.ilGrand.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilPetit
            // 
            this.ilPetit.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilPetit.ImageSize = new System.Drawing.Size(16, 16);
            this.ilPetit.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EcranExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 504);
            this.Controls.Add(this.scSeparateur);
            this.Controls.Add(this.ssMessage);
            this.Controls.Add(this.tsCommandes);
            this.Name = "EcranExplorateur";
            this.Text = "EcranExplorateur";
            this.tsCommandes.ResumeLayout(false);
            this.tsCommandes.PerformLayout();
            this.scSeparateur.Panel1.ResumeLayout(false);
            this.scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).EndInit();
            this.scSeparateur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommandes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbApparence;
        private System.Windows.Forms.ToolStripMenuItem tsaPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaListe;
        private System.Windows.Forms.ToolStripMenuItem tsaDetail;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.SplitContainer scSeparateur;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.ListView lvFichiers;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAIL;
        private System.Windows.Forms.ColumnHeader CREA;
        private System.Windows.Forms.ColumnHeader MODI;
        private System.Windows.Forms.ImageList ilTreeView;
        private System.Windows.Forms.ImageList ilGrand;
        private System.Windows.Forms.ImageList ilPetit;
    }
}