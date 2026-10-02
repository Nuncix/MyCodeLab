namespace _04TV_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChnL = new System.Windows.Forms.Button();
            this.btnChnP = new System.Windows.Forms.Button();
            this.btnVolP = new System.Windows.Forms.Button();
            this.btnVolL = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChnL
            // 
            this.btnChnL.Enabled = false;
            this.btnChnL.Location = new System.Drawing.Point(12, 68);
            this.btnChnL.Name = "btnChnL";
            this.btnChnL.Size = new System.Drawing.Size(75, 37);
            this.btnChnL.TabIndex = 0;
            this.btnChnL.Text = "Channel-";
            this.btnChnL.UseVisualStyleBackColor = true;
            this.btnChnL.Click += new System.EventHandler(this.BtnChnL_Click);
            // 
            // btnChnP
            // 
            this.btnChnP.Enabled = false;
            this.btnChnP.Location = new System.Drawing.Point(93, 68);
            this.btnChnP.Name = "btnChnP";
            this.btnChnP.Size = new System.Drawing.Size(75, 37);
            this.btnChnP.TabIndex = 1;
            this.btnChnP.Text = "Channel+";
            this.btnChnP.UseVisualStyleBackColor = true;
            this.btnChnP.Click += new System.EventHandler(this.BtnChnP_Click);
            // 
            // btnVolP
            // 
            this.btnVolP.Enabled = false;
            this.btnVolP.Location = new System.Drawing.Point(93, 111);
            this.btnVolP.Name = "btnVolP";
            this.btnVolP.Size = new System.Drawing.Size(75, 37);
            this.btnVolP.TabIndex = 3;
            this.btnVolP.Text = "Volume+";
            this.btnVolP.UseVisualStyleBackColor = true;
            this.btnVolP.Click += new System.EventHandler(this.BtnVolP_Click);
            // 
            // btnVolL
            // 
            this.btnVolL.Enabled = false;
            this.btnVolL.Location = new System.Drawing.Point(12, 111);
            this.btnVolL.Name = "btnVolL";
            this.btnVolL.Size = new System.Drawing.Size(75, 37);
            this.btnVolL.TabIndex = 4;
            this.btnVolL.Text = "Volume-";
            this.btnVolL.UseVisualStyleBackColor = true;
            this.btnVolL.Click += new System.EventHandler(this.BtnVolL_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOnOff.Image")));
            this.btnOnOff.Location = new System.Drawing.Point(123, 12);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(45, 50);
            this.btnOnOff.TabIndex = 2;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.BtnOnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Spento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Canale: ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volume: ";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 155);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolL);
            this.Controls.Add(this.btnVolP);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnChnP);
            this.Controls.Add(this.btnChnL);
            this.Name = "Form1";
            this.Text = ":)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChnL;
        private System.Windows.Forms.Button btnChnP;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btnVolP;
        private System.Windows.Forms.Button btnVolL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

