namespace _02R_EliminaCode_15
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
            this.components = new System.ComponentModel.Container();
            this.txtBxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lstVw = new System.Windows.Forms.ListView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtBxN
            // 
            this.txtBxN.Location = new System.Drawing.Point(192, 28);
            this.txtBxN.Name = "txtBxN";
            this.txtBxN.Size = new System.Drawing.Size(176, 20);
            this.txtBxN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(293, 162);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Registra";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(210, 87);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(17, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "lbl";
            this.lbl.Visible = false;
            // 
            // lstVw
            // 
            this.lstVw.Location = new System.Drawing.Point(12, 12);
            this.lstVw.MultiSelect = false;
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(174, 173);
            this.lstVw.TabIndex = 8;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.List;
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 197);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxN);
            this.Name = "Form1";
            this.Text = "Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.Timer Timer;
    }
}

