namespace progra_projet_LABEYE
{
    partial class portscoms
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(74, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(208, 73);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 151);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(364, 176);
            this.txtData.TabIndex = 1;
            // 
            // panelBrowser
            // 
            this.panelBrowser.Location = new System.Drawing.Point(384, 12);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(884, 656);
            this.panelBrowser.TabIndex = 2;
            // 
            // portscoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.panelBrowser);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnConnect);
            this.Name = "portscoms";
            this.Text = "portscoms";
            this.Load += new System.EventHandler(this.portscoms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Panel panelBrowser;
    }
}