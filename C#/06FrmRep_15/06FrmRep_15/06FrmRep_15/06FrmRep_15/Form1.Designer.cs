namespace _06FrmRep_15
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
            this.btnCr = new System.Windows.Forms.Button();
            this.lstVw = new System.Windows.Forms.ListView();
            this.txtBxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStrt = new System.Windows.Forms.Button();
            this.btnVis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCr
            // 
            this.btnCr.Location = new System.Drawing.Point(454, 68);
            this.btnCr.Name = "btnCr";
            this.btnCr.Size = new System.Drawing.Size(100, 38);
            this.btnCr.TabIndex = 0;
            this.btnCr.Text = "Crea linea di produzione";
            this.btnCr.UseVisualStyleBackColor = true;
            this.btnCr.Click += new System.EventHandler(this.btnCr_Click);
            // 
            // lstVw
            // 
            this.lstVw.Location = new System.Drawing.Point(13, 13);
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(435, 468);
            this.lstVw.TabIndex = 1;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.List;
            // 
            // txtBxP
            // 
            this.txtBxP.Location = new System.Drawing.Point(454, 42);
            this.txtBxP.Name = "txtBxP";
            this.txtBxP.Size = new System.Drawing.Size(99, 20);
            this.txtBxP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produzione massima\r\nlinea 1";
            // 
            // btnStrt
            // 
            this.btnStrt.Enabled = false;
            this.btnStrt.Location = new System.Drawing.Point(454, 443);
            this.btnStrt.Name = "btnStrt";
            this.btnStrt.Size = new System.Drawing.Size(100, 38);
            this.btnStrt.TabIndex = 8;
            this.btnStrt.Text = "Start";
            this.btnStrt.UseVisualStyleBackColor = true;
            this.btnStrt.Click += new System.EventHandler(this.btnStrt_Click);
            // 
            // btnVis
            // 
            this.btnVis.Enabled = false;
            this.btnVis.Location = new System.Drawing.Point(454, 112);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(99, 38);
            this.btnVis.TabIndex = 9;
            this.btnVis.Text = "Visualizza totale";
            this.btnVis.UseVisualStyleBackColor = true;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVis);
            this.Controls.Add(this.btnStrt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxP);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.btnCr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCr;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.TextBox txtBxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStrt;
        private System.Windows.Forms.Button btnVis;
        private System.Windows.Forms.Label label2;
    }
}

