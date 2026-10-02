namespace _07Rain_15
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStrt = new System.Windows.Forms.Button();
            this.btnAut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrt
            // 
            this.btnStrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStrt.Location = new System.Drawing.Point(165, 70);
            this.btnStrt.Name = "btnStrt";
            this.btnStrt.Size = new System.Drawing.Size(100, 24);
            this.btnStrt.TabIndex = 12;
            this.btnStrt.Text = "Start";
            this.btnStrt.UseVisualStyleBackColor = true;
            this.btnStrt.Click += new System.EventHandler(this.btnStrt_Click);
            // 
            // btnAut
            // 
            this.btnAut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAut.Location = new System.Drawing.Point(59, 70);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(100, 24);
            this.btnAut.TabIndex = 13;
            this.btnAut.Text = "Auto";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Click += new System.EventHandler(this.btnAut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 106);
            this.Controls.Add(this.btnAut);
            this.Controls.Add(this.btnStrt);
            this.Name = "Form1";
            this.Text = "Meteo by Giuliacci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStrt;
        private System.Windows.Forms.Button btnAut;
    }
}

