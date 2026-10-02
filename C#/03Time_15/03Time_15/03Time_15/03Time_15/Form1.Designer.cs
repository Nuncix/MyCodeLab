namespace _03Time_15
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
            this.txtBxPr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSe = new System.Windows.Forms.TextBox();
            this.txtBxPrF = new System.Windows.Forms.TextBox();
            this.txtBxSeF = new System.Windows.Forms.TextBox();
            this.rBtSecP = new System.Windows.Forms.RadioButton();
            this.rBtDayP = new System.Windows.Forms.RadioButton();
            this.rBtHourP = new System.Windows.Forms.RadioButton();
            this.rBtMinP = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtMinS = new System.Windows.Forms.RadioButton();
            this.rBtHourS = new System.Windows.Forms.RadioButton();
            this.rBtSecS = new System.Windows.Forms.RadioButton();
            this.rBtDayS = new System.Windows.Forms.RadioButton();
            this.btnVis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxPr
            // 
            this.txtBxPr.Location = new System.Drawing.Point(12, 29);
            this.txtBxPr.Name = "txtBxPr";
            this.txtBxPr.Size = new System.Drawing.Size(121, 20);
            this.txtBxPr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primo tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secondo tempo";
            // 
            // txtBxSe
            // 
            this.txtBxSe.Location = new System.Drawing.Point(151, 29);
            this.txtBxSe.Name = "txtBxSe";
            this.txtBxSe.Size = new System.Drawing.Size(121, 20);
            this.txtBxSe.TabIndex = 2;
            // 
            // txtBxPrF
            // 
            this.txtBxPrF.Location = new System.Drawing.Point(12, 164);
            this.txtBxPrF.Name = "txtBxPrF";
            this.txtBxPrF.ReadOnly = true;
            this.txtBxPrF.Size = new System.Drawing.Size(121, 20);
            this.txtBxPrF.TabIndex = 9;
            // 
            // txtBxSeF
            // 
            this.txtBxSeF.Location = new System.Drawing.Point(151, 164);
            this.txtBxSeF.Name = "txtBxSeF";
            this.txtBxSeF.ReadOnly = true;
            this.txtBxSeF.Size = new System.Drawing.Size(121, 20);
            this.txtBxSeF.TabIndex = 10;
            // 
            // rBtSecP
            // 
            this.rBtSecP.AutoSize = true;
            this.rBtSecP.Checked = true;
            this.rBtSecP.Location = new System.Drawing.Point(12, 58);
            this.rBtSecP.Name = "rBtSecP";
            this.rBtSecP.Size = new System.Drawing.Size(44, 17);
            this.rBtSecP.TabIndex = 11;
            this.rBtSecP.TabStop = true;
            this.rBtSecP.Text = "Sec";
            this.rBtSecP.UseVisualStyleBackColor = true;
            this.rBtSecP.CheckedChanged += new System.EventHandler(this.RBtSecP_CheckedChanged);
            // 
            // rBtDayP
            // 
            this.rBtDayP.AutoSize = true;
            this.rBtDayP.Location = new System.Drawing.Point(12, 127);
            this.rBtDayP.Name = "rBtDayP";
            this.rBtDayP.Size = new System.Drawing.Size(118, 17);
            this.rBtDayP.TabIndex = 16;
            this.rBtDayP.Text = "Sec/Min/Hour/Day";
            this.rBtDayP.UseVisualStyleBackColor = true;
            this.rBtDayP.CheckedChanged += new System.EventHandler(this.RBtDayP_CheckedChanged);
            // 
            // rBtHourP
            // 
            this.rBtHourP.AutoSize = true;
            this.rBtHourP.Location = new System.Drawing.Point(12, 104);
            this.rBtHourP.Name = "rBtHourP";
            this.rBtHourP.Size = new System.Drawing.Size(94, 17);
            this.rBtHourP.TabIndex = 17;
            this.rBtHourP.Text = "Sec/Min/Hour";
            this.rBtHourP.UseVisualStyleBackColor = true;
            this.rBtHourP.CheckedChanged += new System.EventHandler(this.RBtHourP_CheckedChanged);
            // 
            // rBtMinP
            // 
            this.rBtMinP.AutoSize = true;
            this.rBtMinP.Location = new System.Drawing.Point(12, 81);
            this.rBtMinP.Name = "rBtMinP";
            this.rBtMinP.Size = new System.Drawing.Size(66, 17);
            this.rBtMinP.TabIndex = 18;
            this.rBtMinP.Text = "Sec/Min";
            this.rBtMinP.UseVisualStyleBackColor = true;
            this.rBtMinP.CheckedChanged += new System.EventHandler(this.RBtMinP_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtMinS);
            this.panel1.Controls.Add(this.rBtHourS);
            this.panel1.Controls.Add(this.rBtSecS);
            this.panel1.Controls.Add(this.rBtDayS);
            this.panel1.Location = new System.Drawing.Point(151, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 100);
            this.panel1.TabIndex = 19;
            // 
            // rBtMinS
            // 
            this.rBtMinS.AutoSize = true;
            this.rBtMinS.Location = new System.Drawing.Point(3, 26);
            this.rBtMinS.Name = "rBtMinS";
            this.rBtMinS.Size = new System.Drawing.Size(66, 17);
            this.rBtMinS.TabIndex = 23;
            this.rBtMinS.Text = "Sec/Min";
            this.rBtMinS.UseVisualStyleBackColor = true;
            this.rBtMinS.CheckedChanged += new System.EventHandler(this.RBtMinS_CheckedChanged);
            // 
            // rBtHourS
            // 
            this.rBtHourS.AutoSize = true;
            this.rBtHourS.Location = new System.Drawing.Point(3, 49);
            this.rBtHourS.Name = "rBtHourS";
            this.rBtHourS.Size = new System.Drawing.Size(94, 17);
            this.rBtHourS.TabIndex = 22;
            this.rBtHourS.Text = "Sec/Min/Hour";
            this.rBtHourS.UseVisualStyleBackColor = true;
            this.rBtHourS.CheckedChanged += new System.EventHandler(this.RBtHourS_CheckedChanged);
            // 
            // rBtSecS
            // 
            this.rBtSecS.AutoSize = true;
            this.rBtSecS.Checked = true;
            this.rBtSecS.Location = new System.Drawing.Point(3, 3);
            this.rBtSecS.Name = "rBtSecS";
            this.rBtSecS.Size = new System.Drawing.Size(44, 17);
            this.rBtSecS.TabIndex = 20;
            this.rBtSecS.TabStop = true;
            this.rBtSecS.Text = "Sec";
            this.rBtSecS.UseVisualStyleBackColor = true;
            this.rBtSecS.CheckedChanged += new System.EventHandler(this.RBtSecS_CheckedChanged);
            // 
            // rBtDayS
            // 
            this.rBtDayS.AutoSize = true;
            this.rBtDayS.Location = new System.Drawing.Point(3, 72);
            this.rBtDayS.Name = "rBtDayS";
            this.rBtDayS.Size = new System.Drawing.Size(118, 17);
            this.rBtDayS.TabIndex = 21;
            this.rBtDayS.Text = "Sec/Min/Hour/Day";
            this.rBtDayS.UseVisualStyleBackColor = true;
            this.rBtDayS.CheckedChanged += new System.EventHandler(this.RBtDayS_CheckedChanged);
            // 
            // btnVis
            // 
            this.btnVis.Location = new System.Drawing.Point(12, 190);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(75, 23);
            this.btnVis.TabIndex = 20;
            this.btnVis.Text = "Visualizza";
            this.btnVis.UseVisualStyleBackColor = true;
            this.btnVis.Click += new System.EventHandler(this.BtnVis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.btnVis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rBtMinP);
            this.Controls.Add(this.rBtHourP);
            this.Controls.Add(this.rBtDayP);
            this.Controls.Add(this.rBtSecP);
            this.Controls.Add(this.txtBxSeF);
            this.Controls.Add(this.txtBxPrF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxSe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPr);
            this.Name = "Form1";
            this.Text = "Tempo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSe;
        private System.Windows.Forms.TextBox txtBxPrF;
        private System.Windows.Forms.TextBox txtBxSeF;
        private System.Windows.Forms.RadioButton rBtSecP;
        private System.Windows.Forms.RadioButton rBtDayP;
        private System.Windows.Forms.RadioButton rBtHourP;
        private System.Windows.Forms.RadioButton rBtMinP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtMinS;
        private System.Windows.Forms.RadioButton rBtHourS;
        private System.Windows.Forms.RadioButton rBtSecS;
        private System.Windows.Forms.RadioButton rBtDayS;
        private System.Windows.Forms.Button btnVis;
    }
}

