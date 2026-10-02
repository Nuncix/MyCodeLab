namespace _06Rubrica_15
{
    partial class Form1
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
            this.btnIns = new System.Windows.Forms.Button();
            this.txtBxNom = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.txtBxNum = new System.Windows.Forms.TextBox();
            this.lstVNom = new System.Windows.Forms.ListView();
            this.lstVNum = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(293, 226);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 0;
            this.btnIns.Text = "Inserisci";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txtBxNom
            // 
            this.txtBxNom.Location = new System.Drawing.Point(268, 31);
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBxNom.TabIndex = 2;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(268, 15);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(35, 13);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "Nome";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(268, 54);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(44, 13);
            this.lblM.TabIndex = 5;
            this.lblM.Text = "Numero";
            // 
            // txtBxNum
            // 
            this.txtBxNum.Location = new System.Drawing.Point(268, 70);
            this.txtBxNum.Name = "txtBxNum";
            this.txtBxNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxNum.TabIndex = 4;
            // 
            // lstVNom
            // 
            this.lstVNom.Location = new System.Drawing.Point(14, 25);
            this.lstVNom.Name = "lstVNom";
            this.lstVNom.Size = new System.Drawing.Size(121, 224);
            this.lstVNom.TabIndex = 6;
            this.lstVNom.UseCompatibleStateImageBehavior = false;
            this.lstVNom.View = System.Windows.Forms.View.List;
            // 
            // lstVNum
            // 
            this.lstVNum.Location = new System.Drawing.Point(141, 25);
            this.lstVNum.Name = "lstVNum";
            this.lstVNum.Size = new System.Drawing.Size(121, 224);
            this.lstVNum.TabIndex = 7;
            this.lstVNum.UseCompatibleStateImageBehavior = false;
            this.lstVNum.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero";
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(293, 197);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 10;
            this.btnCanc.Text = "Elimina";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(293, 168);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 11;
            this.btnMod.Text = "Modifica";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVNum);
            this.Controls.Add(this.lstVNom);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.txtBxNum);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtBxNom);
            this.Controls.Add(this.btnIns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.TextBox txtBxNom;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtBxNum;
        private System.Windows.Forms.ListView lstVNom;
        private System.Windows.Forms.ListView lstVNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnMod;
    }
}

