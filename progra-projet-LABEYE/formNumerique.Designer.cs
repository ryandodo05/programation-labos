namespace progra_projet_LABEYE
{
    partial class formNumerique
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.tbNbInt = new System.Windows.Forms.TextBox();
            this.lbResultats = new System.Windows.Forms.ListBox();
            this.bPolynome = new System.Windows.Forms.Button();
            this.bPointeurPolynome = new System.Windows.Forms.Button();
            this.bPointeurTrigonometrique = new System.Windows.Forms.Button();
            this.bTrigonometrique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gauche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Droite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NB intervals";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(66, 71);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(64, 22);
            this.tbGauche.TabIndex = 3;
            this.tbGauche.Text = "0";
            this.tbGauche.TextChanged += new System.EventHandler(this.tbGauche_TextChanged);
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(184, 71);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(64, 22);
            this.tbDroite.TabIndex = 4;
            this.tbDroite.Text = "2";
            this.tbDroite.TextChanged += new System.EventHandler(this.tbDroite_TextChanged);
            // 
            // tbNbInt
            // 
            this.tbNbInt.Location = new System.Drawing.Point(326, 71);
            this.tbNbInt.Name = "tbNbInt";
            this.tbNbInt.Size = new System.Drawing.Size(76, 22);
            this.tbNbInt.TabIndex = 5;
            this.tbNbInt.Text = "2";
            this.tbNbInt.TextChanged += new System.EventHandler(this.tbNbInt_TextChanged);
            // 
            // lbResultats
            // 
            this.lbResultats.FormattingEnabled = true;
            this.lbResultats.ItemHeight = 16;
            this.lbResultats.Location = new System.Drawing.Point(66, 134);
            this.lbResultats.Name = "lbResultats";
            this.lbResultats.Size = new System.Drawing.Size(335, 212);
            this.lbResultats.TabIndex = 6;
            this.lbResultats.SelectedIndexChanged += new System.EventHandler(this.lbResultats_SelectedIndexChanged);
            // 
            // bPolynome
            // 
            this.bPolynome.Location = new System.Drawing.Point(69, 374);
            this.bPolynome.Name = "bPolynome";
            this.bPolynome.Size = new System.Drawing.Size(214, 40);
            this.bPolynome.TabIndex = 7;
            this.bPolynome.Text = "Polynome";
            this.bPolynome.UseVisualStyleBackColor = true;
            this.bPolynome.Click += new System.EventHandler(this.bPolynome_Click);
            // 
            // bPointeurPolynome
            // 
            this.bPointeurPolynome.Location = new System.Drawing.Point(289, 374);
            this.bPointeurPolynome.Name = "bPointeurPolynome";
            this.bPointeurPolynome.Size = new System.Drawing.Size(113, 40);
            this.bPointeurPolynome.TabIndex = 8;
            this.bPointeurPolynome.Text = "Pointeur";
            this.bPointeurPolynome.UseVisualStyleBackColor = true;
            this.bPointeurPolynome.Click += new System.EventHandler(this.bPointeurPolynome_Click);
            // 
            // bPointeurTrigonometrique
            // 
            this.bPointeurTrigonometrique.Location = new System.Drawing.Point(289, 432);
            this.bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            this.bPointeurTrigonometrique.Size = new System.Drawing.Size(113, 40);
            this.bPointeurTrigonometrique.TabIndex = 10;
            this.bPointeurTrigonometrique.Text = "Pointeur";
            this.bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            this.bPointeurTrigonometrique.Click += new System.EventHandler(this.bPointeurTrigonometrique_Click);
            // 
            // bTrigonometrique
            // 
            this.bTrigonometrique.Location = new System.Drawing.Point(69, 432);
            this.bTrigonometrique.Name = "bTrigonometrique";
            this.bTrigonometrique.Size = new System.Drawing.Size(214, 40);
            this.bTrigonometrique.TabIndex = 9;
            this.bTrigonometrique.Text = "Trigonometrique";
            this.bTrigonometrique.UseVisualStyleBackColor = true;
            this.bTrigonometrique.Click += new System.EventHandler(this.bTrigonometrique_Click);
            // 
            // formNumerique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 517);
            this.Controls.Add(this.bPointeurTrigonometrique);
            this.Controls.Add(this.bTrigonometrique);
            this.Controls.Add(this.bPointeurPolynome);
            this.Controls.Add(this.bPolynome);
            this.Controls.Add(this.lbResultats);
            this.Controls.Add(this.tbNbInt);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNumerique";
            this.Text = "formNumerique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.TextBox tbNbInt;
        private System.Windows.Forms.ListBox lbResultats;
        private System.Windows.Forms.Button bPolynome;
        private System.Windows.Forms.Button bPointeurPolynome;
        private System.Windows.Forms.Button bPointeurTrigonometrique;
        private System.Windows.Forms.Button bTrigonometrique;
    }
}