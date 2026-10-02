namespace _10RailWay_15
{
    partial class TrPnl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Binario 1";
            // 
            // txtTr
            // 
            this.txtTr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTr.Location = new System.Drawing.Point(2, 16);
            this.txtTr.Name = "txtTr";
            this.txtTr.ReadOnly = true;
            this.txtTr.Size = new System.Drawing.Size(66, 20);
            this.txtTr.TabIndex = 4;
            this.txtTr.Text = "Libero";
            // 
            // TrPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTr);
            this.Name = "TrPnl";
            this.Size = new System.Drawing.Size(71, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtTr;
    }
}
