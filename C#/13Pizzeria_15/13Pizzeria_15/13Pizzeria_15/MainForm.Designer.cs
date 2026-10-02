namespace _13Pizzeria_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl = new System.Windows.Forms.Panel();
            this.nUDP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxN = new System.Windows.Forms.TextBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.lsBx = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBAd = new System.Windows.Forms.ToolStripButton();
            this.tSBSa = new System.Windows.Forms.ToolStripButton();
            this.tSBEd = new System.Windows.Forms.ToolStripButton();
            this.tSBDel = new System.Windows.Forms.ToolStripButton();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.Controls.Add(this.nUDP);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.txtBxI);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.txtBxN);
            this.pnl.Controls.Add(this.btnFin);
            this.pnl.Enabled = false;
            this.pnl.Location = new System.Drawing.Point(157, 26);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(154, 330);
            this.pnl.TabIndex = 0;
            // 
            // nUDP
            // 
            this.nUDP.DecimalPlaces = 2;
            this.nUDP.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nUDP.Location = new System.Drawing.Point(3, 56);
            this.nUDP.Name = "nUDP";
            this.nUDP.Size = new System.Drawing.Size(148, 20);
            this.nUDP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezzo €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingredienti";
            // 
            // txtBxI
            // 
            this.txtBxI.Location = new System.Drawing.Point(3, 95);
            this.txtBxI.Multiline = true;
            this.txtBxI.Name = "txtBxI";
            this.txtBxI.Size = new System.Drawing.Size(148, 203);
            this.txtBxI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtBxN
            // 
            this.txtBxN.Location = new System.Drawing.Point(3, 16);
            this.txtBxN.Name = "txtBxN";
            this.txtBxN.Size = new System.Drawing.Size(148, 20);
            this.txtBxN.TabIndex = 0;
            // 
            // btnFin
            // 
            this.btnFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFin.Location = new System.Drawing.Point(76, 304);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 4;
            this.btnFin.Text = "Fine";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // lsBx
            // 
            this.lsBx.FormattingEnabled = true;
            this.lsBx.Location = new System.Drawing.Point(13, 26);
            this.lsBx.Name = "lsBx";
            this.lsBx.Size = new System.Drawing.Size(138, 329);
            this.lsBx.TabIndex = 0;
            this.lsBx.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBAd,
            this.tSBSa,
            this.tSBEd,
            this.tSBDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(317, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBAd
            // 
            this.tSBAd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBAd.Image = ((System.Drawing.Image)(resources.GetObject("tSBAd.Image")));
            this.tSBAd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAd.Name = "tSBAd";
            this.tSBAd.Size = new System.Drawing.Size(60, 22);
            this.tSBAd.Text = "Aggiungi";
            this.tSBAd.Click += new System.EventHandler(this.tSBAd_Click);
            // 
            // tSBSa
            // 
            this.tSBSa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBSa.Image = ((System.Drawing.Image)(resources.GetObject("tSBSa.Image")));
            this.tSBSa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBSa.Name = "tSBSa";
            this.tSBSa.Size = new System.Drawing.Size(65, 22);
            this.tSBSa.Text = "Salva Lista";
            this.tSBSa.Click += new System.EventHandler(this.tSBSa_Click);
            // 
            // tSBEd
            // 
            this.tSBEd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBEd.Enabled = false;
            this.tSBEd.Image = ((System.Drawing.Image)(resources.GetObject("tSBEd.Image")));
            this.tSBEd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEd.Name = "tSBEd";
            this.tSBEd.Size = new System.Drawing.Size(58, 22);
            this.tSBEd.Text = "Modifica";
            this.tSBEd.Click += new System.EventHandler(this.tSBEd_Click);
            // 
            // tSBDel
            // 
            this.tSBDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBDel.Enabled = false;
            this.tSBDel.Image = ((System.Drawing.Image)(resources.GetObject("tSBDel.Image")));
            this.tSBDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDel.Name = "tSBDel";
            this.tSBDel.Size = new System.Drawing.Size(50, 22);
            this.tSBDel.Text = "Elimina";
            this.tSBDel.Click += new System.EventHandler(this.tSBDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lsBx);
            this.Controls.Add(this.pnl);
            this.MinimumSize = new System.Drawing.Size(333, 400);
            this.Name = "MainForm";
            this.Text = "Meniù";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ListBox lsBx;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBAd;
        private System.Windows.Forms.ToolStripButton tSBEd;
        private System.Windows.Forms.ToolStripButton tSBSa;
        private System.Windows.Forms.ToolStripButton tSBDel;
        private System.Windows.Forms.NumericUpDown nUDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxN;
        private System.Windows.Forms.Button btnFin;
    }
}

