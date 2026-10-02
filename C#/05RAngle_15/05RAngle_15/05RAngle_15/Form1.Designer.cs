namespace _05RAngle_15
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            this.txtBx = new System.Windows.Forms.TextBox();
            this.rBtnGra = new System.Windows.Forms.RadioButton();
            this.rBtnRad = new System.Windows.Forms.RadioButton();
            this.lblRad = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblPri = new System.Windows.Forms.Label();
            this.lblGra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(12, 12);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(100, 20);
            this.txtBx.TabIndex = 1;
            this.txtBx.TextChanged += new System.EventHandler(this.TxtBx_TextChanged);
            // 
            // rBtnGra
            // 
            this.rBtnGra.AutoSize = true;
            this.rBtnGra.Checked = true;
            this.rBtnGra.Location = new System.Drawing.Point(13, 39);
            this.rBtnGra.Name = "rBtnGra";
            this.rBtnGra.Size = new System.Drawing.Size(117, 17);
            this.rBtnGra.TabIndex = 2;
            this.rBtnGra.TabStop = true;
            this.rBtnGra.Text = "Gradi Primi Secondi";
            this.rBtnGra.UseVisualStyleBackColor = true;
            this.rBtnGra.CheckedChanged += new System.EventHandler(this.RBtnGra_CheckedChanged);
            // 
            // rBtnRad
            // 
            this.rBtnRad.AutoSize = true;
            this.rBtnRad.Location = new System.Drawing.Point(13, 62);
            this.rBtnRad.Name = "rBtnRad";
            this.rBtnRad.Size = new System.Drawing.Size(64, 17);
            this.rBtnRad.TabIndex = 3;
            this.rBtnRad.Text = "Radianti";
            this.rBtnRad.UseVisualStyleBackColor = true;
            this.rBtnRad.CheckedChanged += new System.EventHandler(this.RBtnRad_CheckedChanged);
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Location = new System.Drawing.Point(141, 12);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(52, 13);
            this.lblRad.TabIndex = 4;
            this.lblRad.Text = "Radianti: ";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(141, 51);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(46, 13);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "Secondi";
            // 
            // lblPri
            // 
            this.lblPri.AutoSize = true;
            this.lblPri.Location = new System.Drawing.Point(141, 38);
            this.lblPri.Name = "lblPri";
            this.lblPri.Size = new System.Drawing.Size(29, 13);
            this.lblPri.TabIndex = 6;
            this.lblPri.Text = "Primi";
            // 
            // lblGra
            // 
            this.lblGra.AutoSize = true;
            this.lblGra.Location = new System.Drawing.Point(141, 25);
            this.lblGra.Name = "lblGra";
            this.lblGra.Size = new System.Drawing.Size(38, 13);
            this.lblGra.TabIndex = 7;
            this.lblGra.Text = "Gradi: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 89);
            this.Controls.Add(this.lblGra);
            this.Controls.Add(this.lblPri);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblRad);
            this.Controls.Add(this.rBtnRad);
            this.Controls.Add(this.rBtnGra);
            this.Controls.Add(this.txtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.RadioButton rBtnGra;
        private System.Windows.Forms.RadioButton rBtnRad;
        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblPri;
        private System.Windows.Forms.Label lblGra;
    }
}

