namespace _02_Converti_15
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
            this.txtBxI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnBinI = new System.Windows.Forms.RadioButton();
            this.rBtnEsaI = new System.Windows.Forms.RadioButton();
            this.rBtnDecI = new System.Windows.Forms.RadioButton();
            this.rBtnOttI = new System.Windows.Forms.RadioButton();
            this.rBtnOttF = new System.Windows.Forms.RadioButton();
            this.rBtnDecF = new System.Windows.Forms.RadioButton();
            this.rBtnEsaF = new System.Windows.Forms.RadioButton();
            this.rBtnBinF = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxI
            // 
            this.txtBxI.Location = new System.Drawing.Point(16, 29);
            this.txtBxI.Name = "txtBxI";
            this.txtBxI.Size = new System.Drawing.Size(100, 20);
            this.txtBxI.TabIndex = 1;
            this.txtBxI.TextChanged += new System.EventHandler(this.TxtBxI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero da convertire";
            // 
            // txtBxF
            // 
            this.txtBxF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBxF.Location = new System.Drawing.Point(147, 29);
            this.txtBxF.Name = "txtBxF";
            this.txtBxF.ReadOnly = true;
            this.txtBxF.Size = new System.Drawing.Size(100, 20);
            this.txtBxF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero convertito";
            // 
            // rBtnBinI
            // 
            this.rBtnBinI.AutoSize = true;
            this.rBtnBinI.Location = new System.Drawing.Point(16, 68);
            this.rBtnBinI.Name = "rBtnBinI";
            this.rBtnBinI.Size = new System.Drawing.Size(57, 17);
            this.rBtnBinI.TabIndex = 4;
            this.rBtnBinI.TabStop = true;
            this.rBtnBinI.Text = "Binaria";
            this.rBtnBinI.UseVisualStyleBackColor = true;
            this.rBtnBinI.CheckedChanged += new System.EventHandler(this.RBtnBinI_CheckedChanged);
            // 
            // rBtnEsaI
            // 
            this.rBtnEsaI.AutoSize = true;
            this.rBtnEsaI.Location = new System.Drawing.Point(16, 137);
            this.rBtnEsaI.Name = "rBtnEsaI";
            this.rBtnEsaI.Size = new System.Drawing.Size(85, 17);
            this.rBtnEsaI.TabIndex = 5;
            this.rBtnEsaI.TabStop = true;
            this.rBtnEsaI.Text = "Esadecimale";
            this.rBtnEsaI.UseVisualStyleBackColor = true;
            this.rBtnEsaI.CheckedChanged += new System.EventHandler(this.RBtnEsaI_CheckedChanged);
            // 
            // rBtnDecI
            // 
            this.rBtnDecI.AutoSize = true;
            this.rBtnDecI.Location = new System.Drawing.Point(16, 114);
            this.rBtnDecI.Name = "rBtnDecI";
            this.rBtnDecI.Size = new System.Drawing.Size(69, 17);
            this.rBtnDecI.TabIndex = 9;
            this.rBtnDecI.TabStop = true;
            this.rBtnDecI.Text = "Decimale";
            this.rBtnDecI.UseVisualStyleBackColor = true;
            this.rBtnDecI.CheckedChanged += new System.EventHandler(this.RBtnDecI_CheckedChanged);
            // 
            // rBtnOttI
            // 
            this.rBtnOttI.AutoSize = true;
            this.rBtnOttI.Location = new System.Drawing.Point(16, 91);
            this.rBtnOttI.Name = "rBtnOttI";
            this.rBtnOttI.Size = new System.Drawing.Size(53, 17);
            this.rBtnOttI.TabIndex = 10;
            this.rBtnOttI.TabStop = true;
            this.rBtnOttI.Text = "Ottale";
            this.rBtnOttI.UseVisualStyleBackColor = true;
            this.rBtnOttI.CheckedChanged += new System.EventHandler(this.RBtnOttI_CheckedChanged);
            // 
            // rBtnOttF
            // 
            this.rBtnOttF.AutoSize = true;
            this.rBtnOttF.Location = new System.Drawing.Point(3, 26);
            this.rBtnOttF.Name = "rBtnOttF";
            this.rBtnOttF.Size = new System.Drawing.Size(53, 17);
            this.rBtnOttF.TabIndex = 7;
            this.rBtnOttF.TabStop = true;
            this.rBtnOttF.Text = "Ottale";
            this.rBtnOttF.UseVisualStyleBackColor = true;
            this.rBtnOttF.CheckedChanged += new System.EventHandler(this.RBtnOttF_CheckedChanged);
            // 
            // rBtnDecF
            // 
            this.rBtnDecF.AutoSize = true;
            this.rBtnDecF.Location = new System.Drawing.Point(3, 49);
            this.rBtnDecF.Name = "rBtnDecF";
            this.rBtnDecF.Size = new System.Drawing.Size(69, 17);
            this.rBtnDecF.TabIndex = 6;
            this.rBtnDecF.TabStop = true;
            this.rBtnDecF.Text = "Decimale";
            this.rBtnDecF.UseVisualStyleBackColor = true;
            this.rBtnDecF.CheckedChanged += new System.EventHandler(this.RBtnDecF_CheckedChanged);
            // 
            // rBtnEsaF
            // 
            this.rBtnEsaF.AutoSize = true;
            this.rBtnEsaF.Location = new System.Drawing.Point(3, 72);
            this.rBtnEsaF.Name = "rBtnEsaF";
            this.rBtnEsaF.Size = new System.Drawing.Size(85, 17);
            this.rBtnEsaF.TabIndex = 11;
            this.rBtnEsaF.TabStop = true;
            this.rBtnEsaF.Text = "Esadecimale";
            this.rBtnEsaF.UseVisualStyleBackColor = true;
            this.rBtnEsaF.CheckedChanged += new System.EventHandler(this.RBtnEsaF_CheckedChanged);
            // 
            // rBtnBinF
            // 
            this.rBtnBinF.AutoSize = true;
            this.rBtnBinF.Location = new System.Drawing.Point(3, 3);
            this.rBtnBinF.Name = "rBtnBinF";
            this.rBtnBinF.Size = new System.Drawing.Size(57, 17);
            this.rBtnBinF.TabIndex = 8;
            this.rBtnBinF.TabStop = true;
            this.rBtnBinF.Text = "Binaria";
            this.rBtnBinF.UseVisualStyleBackColor = true;
            this.rBtnBinF.CheckedChanged += new System.EventHandler(this.RBtnBinF_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnBinF);
            this.panel1.Controls.Add(this.rBtnEsaF);
            this.panel1.Controls.Add(this.rBtnDecF);
            this.panel1.Controls.Add(this.rBtnOttF);
            this.panel1.Location = new System.Drawing.Point(147, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 98);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Base:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rBtnOttI);
            this.Controls.Add(this.rBtnDecI);
            this.Controls.Add(this.rBtnEsaI);
            this.Controls.Add(this.rBtnBinI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxF);
            this.Controls.Add(this.txtBxI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Converti base";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnBinI;
        private System.Windows.Forms.RadioButton rBtnEsaI;
        private System.Windows.Forms.RadioButton rBtnDecI;
        private System.Windows.Forms.RadioButton rBtnOttI;
        private System.Windows.Forms.RadioButton rBtnOttF;
        private System.Windows.Forms.RadioButton rBtnDecF;
        private System.Windows.Forms.RadioButton rBtnEsaF;
        private System.Windows.Forms.RadioButton rBtnBinF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxI;
    }
}

