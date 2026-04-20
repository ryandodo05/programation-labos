namespace progra_projet_LABEYE
{
    partial class EcranSpirographe
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
            this.gbParametrage = new System.Windows.Forms.GroupBox();
            this.lSommets = new System.Windows.Forms.Label();
            this.lDensite = new System.Windows.Forms.Label();
            this.lProfondeur = new System.Windows.Forms.Label();
            this.tbSommets = new System.Windows.Forms.TrackBar();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.bGo = new System.Windows.Forms.Button();
            this.bTrait = new System.Windows.Forms.Button();
            this.bFond = new System.Windows.Forms.Button();
            this.cdCouleur = new System.Windows.Forms.ColorDialog();
            this.gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametrage
            // 
            this.gbParametrage.Controls.Add(this.bFond);
            this.gbParametrage.Controls.Add(this.bTrait);
            this.gbParametrage.Controls.Add(this.bGo);
            this.gbParametrage.Controls.Add(this.tbProfondeur);
            this.gbParametrage.Controls.Add(this.tbDensite);
            this.gbParametrage.Controls.Add(this.tbSommets);
            this.gbParametrage.Controls.Add(this.lProfondeur);
            this.gbParametrage.Controls.Add(this.lDensite);
            this.gbParametrage.Controls.Add(this.lSommets);
            this.gbParametrage.Location = new System.Drawing.Point(42, 49);
            this.gbParametrage.Name = "gbParametrage";
            this.gbParametrage.Size = new System.Drawing.Size(239, 280);
            this.gbParametrage.TabIndex = 0;
            this.gbParametrage.TabStop = false;
            this.gbParametrage.Text = "gbParametrage";
            // 
            // lSommets
            // 
            this.lSommets.AutoSize = true;
            this.lSommets.Location = new System.Drawing.Point(17, 30);
            this.lSommets.Name = "lSommets";
            this.lSommets.Size = new System.Drawing.Size(67, 16);
            this.lSommets.TabIndex = 0;
            this.lSommets.Text = "lSommets";
            // 
            // lDensite
            // 
            this.lDensite.AutoSize = true;
            this.lDensite.Location = new System.Drawing.Point(17, 97);
            this.lDensite.Name = "lDensite";
            this.lDensite.Size = new System.Drawing.Size(56, 16);
            this.lDensite.TabIndex = 1;
            this.lDensite.Text = "lDensite";
            // 
            // lProfondeur
            // 
            this.lProfondeur.AutoSize = true;
            this.lProfondeur.Location = new System.Drawing.Point(17, 161);
            this.lProfondeur.Name = "lProfondeur";
            this.lProfondeur.Size = new System.Drawing.Size(76, 16);
            this.lProfondeur.TabIndex = 2;
            this.lProfondeur.Text = "lProfondeur";
            // 
            // tbSommets
            // 
            this.tbSommets.Location = new System.Drawing.Point(103, 21);
            this.tbSommets.Maximum = 8;
            this.tbSommets.Minimum = 3;
            this.tbSommets.Name = "tbSommets";
            this.tbSommets.Size = new System.Drawing.Size(125, 56);
            this.tbSommets.TabIndex = 3;
            this.tbSommets.Value = 3;
            this.tbSommets.Scroll += new System.EventHandler(this.tbSommets_Scroll);
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(101, 88);
            this.tbDensite.Maximum = 50;
            this.tbDensite.Minimum = 2;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(127, 56);
            this.tbDensite.TabIndex = 4;
            this.tbDensite.Value = 2;
            this.tbDensite.Scroll += new System.EventHandler(this.tbDensite_Scroll);
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(99, 152);
            this.tbProfondeur.Maximum = 100;
            this.tbProfondeur.Minimum = 1;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(129, 56);
            this.tbProfondeur.TabIndex = 5;
            this.tbProfondeur.Value = 1;
            this.tbProfondeur.Scroll += new System.EventHandler(this.tbProfondeur_Scroll);
            // 
            // bGo
            // 
            this.bGo.Location = new System.Drawing.Point(79, 227);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(72, 25);
            this.bGo.TabIndex = 6;
            this.bGo.Text = "Go";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // bTrait
            // 
            this.bTrait.Location = new System.Drawing.Point(142, 198);
            this.bTrait.Name = "bTrait";
            this.bTrait.Size = new System.Drawing.Size(72, 23);
            this.bTrait.TabIndex = 7;
            this.bTrait.Text = "Trait";
            this.bTrait.UseVisualStyleBackColor = true;
            this.bTrait.Click += new System.EventHandler(this.bTrait_Click);
            // 
            // bFond
            // 
            this.bFond.Location = new System.Drawing.Point(20, 198);
            this.bFond.Name = "bFond";
            this.bFond.Size = new System.Drawing.Size(72, 23);
            this.bFond.TabIndex = 8;
            this.bFond.Text = "Fond";
            this.bFond.UseVisualStyleBackColor = true;
            this.bFond.Click += new System.EventHandler(this.bFond_Click);
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.gbParametrage);
            this.Name = "EcranSpirographe";
            this.Text = "EcranSpirographe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranSpirographe_Paint_1);
            this.gbParametrage.ResumeLayout(false);
            this.gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametrage;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.TrackBar tbSommets;
        private System.Windows.Forms.Label lProfondeur;
        private System.Windows.Forms.Label lDensite;
        private System.Windows.Forms.Label lSommets;
        private System.Windows.Forms.Button bFond;
        private System.Windows.Forms.Button bTrait;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.ColorDialog cdCouleur;
    }
}