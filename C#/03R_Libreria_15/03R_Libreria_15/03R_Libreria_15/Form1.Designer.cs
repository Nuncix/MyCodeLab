namespace _03R_Libreria_15
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
            this.btnOrd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxTit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNpg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPrz = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.lstIsbn = new System.Windows.Forms.ListView();
            this.lstNpg = new System.Windows.Forms.ListView();
            this.lstPrz = new System.Windows.Forms.ListView();
            this.lstTit = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrd
            // 
            this.btnOrd.Enabled = false;
            this.btnOrd.Location = new System.Drawing.Point(528, 157);
            this.btnOrd.Name = "btnOrd";
            this.btnOrd.Size = new System.Drawing.Size(156, 40);
            this.btnOrd.TabIndex = 1;
            this.btnOrd.Text = "Ordina per rapporto prezzo/pagine";
            this.btnOrd.UseVisualStyleBackColor = true;
            this.btnOrd.Click += new System.EventHandler(this.btnOrd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titolo";
            // 
            // txtBxTit
            // 
            this.txtBxTit.Location = new System.Drawing.Point(528, 24);
            this.txtBxTit.Name = "txtBxTit";
            this.txtBxTit.Size = new System.Drawing.Size(156, 20);
            this.txtBxTit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "N. Pagine";
            // 
            // txtBxNpg
            // 
            this.txtBxNpg.Location = new System.Drawing.Point(528, 63);
            this.txtBxNpg.Name = "txtBxNpg";
            this.txtBxNpg.Size = new System.Drawing.Size(156, 20);
            this.txtBxNpg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezzo";
            // 
            // txtBxPrz
            // 
            this.txtBxPrz.Location = new System.Drawing.Point(528, 102);
            this.txtBxPrz.Name = "txtBxPrz";
            this.txtBxPrz.Size = new System.Drawing.Size(156, 20);
            this.txtBxPrz.TabIndex = 8;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(528, 128);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "Inserisci";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Enabled = false;
            this.btnCanc.Location = new System.Drawing.Point(609, 128);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 11;
            this.btnCanc.Text = "Elimina";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // lstIsbn
            // 
            this.lstIsbn.Location = new System.Drawing.Point(12, 25);
            this.lstIsbn.Name = "lstIsbn";
            this.lstIsbn.Size = new System.Drawing.Size(121, 172);
            this.lstIsbn.TabIndex = 12;
            this.lstIsbn.UseCompatibleStateImageBehavior = false;
            this.lstIsbn.View = System.Windows.Forms.View.List;
            // 
            // lstNpg
            // 
            this.lstNpg.Location = new System.Drawing.Point(267, 25);
            this.lstNpg.Name = "lstNpg";
            this.lstNpg.Size = new System.Drawing.Size(121, 172);
            this.lstNpg.TabIndex = 13;
            this.lstNpg.UseCompatibleStateImageBehavior = false;
            this.lstNpg.View = System.Windows.Forms.View.List;
            // 
            // lstPrz
            // 
            this.lstPrz.Location = new System.Drawing.Point(394, 25);
            this.lstPrz.Name = "lstPrz";
            this.lstPrz.Size = new System.Drawing.Size(121, 172);
            this.lstPrz.TabIndex = 14;
            this.lstPrz.UseCompatibleStateImageBehavior = false;
            this.lstPrz.View = System.Windows.Forms.View.List;
            // 
            // lstTit
            // 
            this.lstTit.Location = new System.Drawing.Point(140, 25);
            this.lstTit.Name = "lstTit";
            this.lstTit.Size = new System.Drawing.Size(121, 172);
            this.lstTit.TabIndex = 15;
            this.lstTit.UseCompatibleStateImageBehavior = false;
            this.lstTit.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Codice ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Prezzo del libro (€)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numero di pagine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Titolo libro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 209);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstTit);
            this.Controls.Add(this.lstPrz);
            this.Controls.Add(this.lstNpg);
            this.Controls.Add(this.lstIsbn);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxPrz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxNpg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxTit);
            this.Controls.Add(this.btnOrd);
            this.Name = "Form1";
            this.Text = "Libri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxTit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNpg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPrz;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.ListView lstIsbn;
        private System.Windows.Forms.ListView lstNpg;
        private System.Windows.Forms.ListView lstPrz;
        private System.Windows.Forms.ListView lstTit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}

