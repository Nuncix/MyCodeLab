namespace _01Auto_15
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
            this.txtBxV = new System.Windows.Forms.TextBox();
            this.lblV = new System.Windows.Forms.Label();
            this.lblNF = new System.Windows.Forms.Label();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.tmR = new System.Windows.Forms.Timer(this.components);
            this.lblVr = new System.Windows.Forms.Label();
            this.txtBxVr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxV
            // 
            this.txtBxV.AcceptsReturn = true;
            this.txtBxV.Location = new System.Drawing.Point(12, 63);
            this.txtBxV.Name = "txtBxV";
            this.txtBxV.ReadOnly = true;
            this.txtBxV.Size = new System.Drawing.Size(100, 20);
            this.txtBxV.TabIndex = 0;
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(12, 47);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(79, 13);
            this.lblV.TabIndex = 2;
            this.lblV.Text = "Velocità (Km/s)";
            // 
            // lblNF
            // 
            this.lblNF.AutoSize = true;
            this.lblNF.ForeColor = System.Drawing.Color.Red;
            this.lblNF.Location = new System.Drawing.Point(32, 86);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(41, 13);
            this.lblNF.TabIndex = 4;
            this.lblNF.Text = "Spenta";
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(125, 65);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOnOff.TabIndex = 5;
            this.btnOnOff.Text = "On/Off";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Location = new System.Drawing.Point(125, 29);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 6;
            this.btnA.Text = "Accellera";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(125, 97);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 7;
            this.btnB.Text = "Frena";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.ForeColor = System.Drawing.Color.Red;
            this.lblR.Location = new System.Drawing.Point(19, 110);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(72, 13);
            this.lblR.TabIndex = 8;
            this.lblR.Text = "RALLENTA!!!";
            this.lblR.Visible = false;
            // 
            // tmR
            // 
            this.tmR.Enabled = true;
            this.tmR.Interval = 50;
            this.tmR.Tick += new System.EventHandler(this.TmR_Tick);
            // 
            // lblVr
            // 
            this.lblVr.AutoSize = true;
            this.lblVr.Location = new System.Drawing.Point(12, 8);
            this.lblVr.Name = "lblVr";
            this.lblVr.Size = new System.Drawing.Size(153, 13);
            this.lblVr.TabIndex = 10;
            this.lblVr.Text = "Velocità da raggiungere (Km/s)";
            // 
            // txtBxVr
            // 
            this.txtBxVr.AcceptsReturn = true;
            this.txtBxVr.Location = new System.Drawing.Point(12, 24);
            this.txtBxVr.Name = "txtBxVr";
            this.txtBxVr.Size = new System.Drawing.Size(100, 20);
            this.txtBxVr.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 132);
            this.Controls.Add(this.lblVr);
            this.Controls.Add(this.txtBxVr);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.lblNF);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.txtBxV);
            this.Name = "Form1";
            this.Text = "Ferrari Enzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxV;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblNF;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Timer tmR;
        private System.Windows.Forms.Label lblVr;
        private System.Windows.Forms.TextBox txtBxVr;
    }
}

