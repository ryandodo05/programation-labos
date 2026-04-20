namespace progra_projet_LABEYE
{
    partial class EcranClavierSouris
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
            this.pnlSouris = new System.Windows.Forms.Panel();
            this.tbxPositionY = new System.Windows.Forms.TextBox();
            this.tbxPositionX = new System.Windows.Forms.TextBox();
            this.tbxClicDroit = new System.Windows.Forms.TextBox();
            this.tbxClicGauche = new System.Windows.Forms.TextBox();
            this.butRAZ = new System.Windows.Forms.Button();
            this.lsbClavier = new System.Windows.Forms.ListBox();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.lblClicDroit = new System.Windows.Forms.Label();
            this.lblClicGauche = new System.Windows.Forms.Label();
            this.lblClavier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSouris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSouris
            // 
            this.pnlSouris.Controls.Add(this.label4);
            this.pnlSouris.Controls.Add(this.label3);
            this.pnlSouris.Controls.Add(this.label2);
            this.pnlSouris.Controls.Add(this.label1);
            this.pnlSouris.Location = new System.Drawing.Point(252, 91);
            this.pnlSouris.Name = "pnlSouris";
            this.pnlSouris.Size = new System.Drawing.Size(403, 332);
            this.pnlSouris.TabIndex = 0;
            this.pnlSouris.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSouris_Paint);
            // 
            // tbxPositionY
            // 
            this.tbxPositionY.Location = new System.Drawing.Point(601, 49);
            this.tbxPositionY.Name = "tbxPositionY";
            this.tbxPositionY.Size = new System.Drawing.Size(96, 22);
            this.tbxPositionY.TabIndex = 21;
            this.tbxPositionY.TextChanged += new System.EventHandler(this.tbxPositionY_TextChanged);
            // 
            // tbxPositionX
            // 
            this.tbxPositionX.Location = new System.Drawing.Point(471, 49);
            this.tbxPositionX.Name = "tbxPositionX";
            this.tbxPositionX.Size = new System.Drawing.Size(96, 22);
            this.tbxPositionX.TabIndex = 20;
            this.tbxPositionX.TextChanged += new System.EventHandler(this.tbxPositionX_TextChanged);
            // 
            // tbxClicDroit
            // 
            this.tbxClicDroit.Location = new System.Drawing.Point(338, 49);
            this.tbxClicDroit.Name = "tbxClicDroit";
            this.tbxClicDroit.Size = new System.Drawing.Size(96, 22);
            this.tbxClicDroit.TabIndex = 19;
            this.tbxClicDroit.TextChanged += new System.EventHandler(this.tbxClicDroit_TextChanged);
            // 
            // tbxClicGauche
            // 
            this.tbxClicGauche.Location = new System.Drawing.Point(211, 49);
            this.tbxClicGauche.Name = "tbxClicGauche";
            this.tbxClicGauche.Size = new System.Drawing.Size(96, 22);
            this.tbxClicGauche.TabIndex = 18;
            this.tbxClicGauche.TextChanged += new System.EventHandler(this.tbxClicGauche_TextChanged);
            // 
            // butRAZ
            // 
            this.butRAZ.Location = new System.Drawing.Point(39, 393);
            this.butRAZ.Name = "butRAZ";
            this.butRAZ.Size = new System.Drawing.Size(158, 30);
            this.butRAZ.TabIndex = 17;
            this.butRAZ.Text = "Remise a 0";
            this.butRAZ.UseVisualStyleBackColor = true;
            this.butRAZ.Click += new System.EventHandler(this.butRAZ_Click);
            // 
            // lsbClavier
            // 
            this.lsbClavier.FormattingEnabled = true;
            this.lsbClavier.ItemHeight = 16;
            this.lsbClavier.Location = new System.Drawing.Point(42, 45);
            this.lsbClavier.Name = "lsbClavier";
            this.lsbClavier.Size = new System.Drawing.Size(156, 340);
            this.lsbClavier.TabIndex = 16;
            this.lsbClavier.SelectedIndexChanged += new System.EventHandler(this.lsbClavier_SelectedIndexChanged);
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Location = new System.Drawing.Point(607, 19);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(67, 16);
            this.lblPositionY.TabIndex = 15;
            this.lblPositionY.Text = "Position Y";
            // 
            // lblPositionX
            // 
            this.lblPositionX.AutoSize = true;
            this.lblPositionX.Location = new System.Drawing.Point(468, 19);
            this.lblPositionX.Name = "lblPositionX";
            this.lblPositionX.Size = new System.Drawing.Size(66, 16);
            this.lblPositionX.TabIndex = 14;
            this.lblPositionX.Text = "Position X";
            // 
            // lblClicDroit
            // 
            this.lblClicDroit.AutoSize = true;
            this.lblClicDroit.Location = new System.Drawing.Point(335, 19);
            this.lblClicDroit.Name = "lblClicDroit";
            this.lblClicDroit.Size = new System.Drawing.Size(67, 16);
            this.lblClicDroit.TabIndex = 13;
            this.lblClicDroit.Text = "Click Droit";
            // 
            // lblClicGauche
            // 
            this.lblClicGauche.AutoSize = true;
            this.lblClicGauche.Location = new System.Drawing.Point(208, 19);
            this.lblClicGauche.Name = "lblClicGauche";
            this.lblClicGauche.Size = new System.Drawing.Size(86, 16);
            this.lblClicGauche.TabIndex = 12;
            this.lblClicGauche.Text = "Click Gauche";
            // 
            // lblClavier
            // 
            this.lblClavier.AutoSize = true;
            this.lblClavier.Location = new System.Drawing.Point(39, 19);
            this.lblClavier.Name = "lblClavier";
            this.lblClavier.Size = new System.Drawing.Size(121, 16);
            this.lblClavier.TabIndex = 11;
            this.lblClavier.Text = "Interception Clavier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "____________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "____________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 272);
            this.label3.TabIndex = 24;
            this.label3.Text = "¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 272);
            this.label4.TabIndex = 25;
            this.label4.Text = "¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n¦\r\n\r\n";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPositionY);
            this.Controls.Add(this.tbxPositionX);
            this.Controls.Add(this.tbxClicDroit);
            this.Controls.Add(this.tbxClicGauche);
            this.Controls.Add(this.butRAZ);
            this.Controls.Add(this.lsbClavier);
            this.Controls.Add(this.lblPositionY);
            this.Controls.Add(this.lblPositionX);
            this.Controls.Add(this.lblClicDroit);
            this.Controls.Add(this.lblClicGauche);
            this.Controls.Add(this.lblClavier);
            this.Controls.Add(this.pnlSouris);
            this.Name = "EcranClavierSouris";
            this.Text = "EcranClavierSouris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.pnlSouris.ResumeLayout(false);
            this.pnlSouris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSouris;
        private System.Windows.Forms.TextBox tbxPositionY;
        private System.Windows.Forms.TextBox tbxPositionX;
        private System.Windows.Forms.TextBox tbxClicDroit;
        private System.Windows.Forms.TextBox tbxClicGauche;
        private System.Windows.Forms.Button butRAZ;
        private System.Windows.Forms.ListBox lsbClavier;
        private System.Windows.Forms.Label lblPositionY;
        private System.Windows.Forms.Label lblPositionX;
        private System.Windows.Forms.Label lblClicDroit;
        private System.Windows.Forms.Label lblClicGauche;
        private System.Windows.Forms.Label lblClavier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}