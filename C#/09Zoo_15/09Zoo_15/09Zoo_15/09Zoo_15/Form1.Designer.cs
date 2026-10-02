namespace _09Zoo_15
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
            this.cmBxAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNm = new System.Windows.Forms.TextBox();
            this.btnAgg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxEt = new System.Windows.Forms.ComboBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBxAn
            // 
            this.cmBxAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxAn.FormattingEnabled = true;
            this.cmBxAn.Items.AddRange(new object[] {
            "Elefante",
            "Tigre",
            "Capra",
            "Lupo",
            "Scimmia"});
            this.cmBxAn.Location = new System.Drawing.Point(379, 29);
            this.cmBxAn.Name = "cmBxAn";
            this.cmBxAn.Size = new System.Drawing.Size(89, 21);
            this.cmBxAn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Animale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtBxNm
            // 
            this.txtBxNm.Location = new System.Drawing.Point(379, 69);
            this.txtBxNm.Name = "txtBxNm";
            this.txtBxNm.Size = new System.Drawing.Size(89, 20);
            this.txtBxNm.TabIndex = 4;
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(382, 318);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(86, 23);
            this.btnAgg.TabIndex = 5;
            this.btnAgg.Text = "Aggiungi";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Età";
            // 
            // cmBxEt
            // 
            this.cmBxEt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxEt.FormattingEnabled = true;
            this.cmBxEt.Location = new System.Drawing.Point(379, 108);
            this.cmBxEt.Name = "cmBxEt";
            this.cmBxEt.Size = new System.Drawing.Size(89, 21);
            this.cmBxEt.TabIndex = 7;
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AllowUserToResizeColumns = false;
            this.dGV.AllowUserToResizeRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.ColumnHeadersVisible = false;
            this.dGV.Location = new System.Drawing.Point(13, 13);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersVisible = false;
            this.dGV.Size = new System.Drawing.Size(360, 334);
            this.dGV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmBxEt);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.txtBxNm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBxAn);
            this.Controls.Add(this.dGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBxAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNm;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBxEt;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label4;
    }
}

