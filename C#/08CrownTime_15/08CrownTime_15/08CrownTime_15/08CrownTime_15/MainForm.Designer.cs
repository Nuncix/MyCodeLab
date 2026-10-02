namespace _08CrownTime_15
{
    partial class MainForm
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
            this.btnStrt = new System.Windows.Forms.Button();
            this.txtBxTR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxPI = new System.Windows.Forms.TextBox();
            this.btnAut = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtBxGlH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStrt
            // 
            this.btnStrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStrt.Location = new System.Drawing.Point(505, 73);
            this.btnStrt.Name = "btnStrt";
            this.btnStrt.Size = new System.Drawing.Size(75, 23);
            this.btnStrt.TabIndex = 0;
            this.btnStrt.Text = "Start";
            this.btnStrt.UseVisualStyleBackColor = true;
            this.btnStrt.Click += new System.EventHandler(this.btnStrt_Click);
            // 
            // txtBxTR
            // 
            this.txtBxTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBxTR.Location = new System.Drawing.Point(12, 76);
            this.txtBxTR.Name = "txtBxTR";
            this.txtBxTR.Size = new System.Drawing.Size(130, 20);
            this.txtBxTR.TabIndex = 1;
            this.txtBxTR.TextChanged += new System.EventHandler(this.txtBxTR_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempo di raddoppio(minuti)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Popolazione iniziale";
            // 
            // txtBxPI
            // 
            this.txtBxPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBxPI.Location = new System.Drawing.Point(148, 76);
            this.txtBxPI.Name = "txtBxPI";
            this.txtBxPI.Size = new System.Drawing.Size(130, 20);
            this.txtBxPI.TabIndex = 5;
            this.txtBxPI.TextChanged += new System.EventHandler(this.txtBxPI_TextChanged);
            // 
            // btnAut
            // 
            this.btnAut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAut.Location = new System.Drawing.Point(424, 73);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(75, 23);
            this.btnAut.TabIndex = 6;
            this.btnAut.Text = "Auto";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Click += new System.EventHandler(this.btnAut_Click);
            // 
            // lblOut
            // 
            this.lblOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(424, 60);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(23, 13);
            this.lblOut.TabIndex = 7;
            this.lblOut.Text = "lblo";
            this.lblOut.Visible = false;
            // 
            // txtBxGlH
            // 
            this.txtBxGlH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBxGlH.Location = new System.Drawing.Point(284, 76);
            this.txtBxGlH.Name = "txtBxGlH";
            this.txtBxGlH.Size = new System.Drawing.Size(130, 20);
            this.txtBxGlH.TabIndex = 9;
            this.txtBxGlH.TextChanged += new System.EventHandler(this.txtBxGlH_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "glcH (micro grammi)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 108);
            this.Controls.Add(this.txtBxGlH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnAut);
            this.Controls.Add(this.txtBxPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxTR);
            this.Controls.Add(this.btnStrt);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStrt;
        private System.Windows.Forms.TextBox txtBxTR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxPI;
        private System.Windows.Forms.Button btnAut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtBxGlH;
        private System.Windows.Forms.Label label3;
    }
}

