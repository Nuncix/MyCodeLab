namespace _07Rain_15
{
    partial class InOutCtrl
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
            this.lblOut = new System.Windows.Forms.Label();
            this.txtBxRain = new System.Windows.Forms.TextBox();
            this.lblRain = new System.Windows.Forms.Label();
            this.txtBxLoc = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(4, 91);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(75, 13);
            this.lblOut.TabIndex = 76;
            this.lblOut.Text = "Pioggia in mm:";
            this.lblOut.Visible = false;
            // 
            // txtBxRain
            // 
            this.txtBxRain.Location = new System.Drawing.Point(3, 64);
            this.txtBxRain.Name = "txtBxRain";
            this.txtBxRain.Size = new System.Drawing.Size(100, 20);
            this.txtBxRain.TabIndex = 75;
            // 
            // lblRain
            // 
            this.lblRain.AutoSize = true;
            this.lblRain.Location = new System.Drawing.Point(3, 48);
            this.lblRain.Name = "lblRain";
            this.lblRain.Size = new System.Drawing.Size(91, 13);
            this.lblRain.TabIndex = 74;
            this.lblRain.Text = "Piovosità mensile:";
            // 
            // txtBxLoc
            // 
            this.txtBxLoc.Location = new System.Drawing.Point(3, 25);
            this.txtBxLoc.Name = "txtBxLoc";
            this.txtBxLoc.Size = new System.Drawing.Size(100, 20);
            this.txtBxLoc.TabIndex = 73;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(3, 9);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(78, 13);
            this.lblLoc.TabIndex = 72;
            this.lblLoc.Text = "Nome Località:";
            // 
            // InOutCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtBxRain);
            this.Controls.Add(this.lblRain);
            this.Controls.Add(this.txtBxLoc);
            this.Controls.Add(this.lblLoc);
            this.Name = "InOutCtrl";
            this.Size = new System.Drawing.Size(108, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtBxRain;
        private System.Windows.Forms.Label lblRain;
        private System.Windows.Forms.TextBox txtBxLoc;
        private System.Windows.Forms.Label lblLoc;
    }
}
