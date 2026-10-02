namespace _08CrownTime_15
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
            this.txtBxGl = new System.Windows.Forms.TextBox();
            this.lblGl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(4, 65);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(17, 13);
            this.lblOut.TabIndex = 81;
            this.lblOut.Text = "lbl";
            this.lblOut.Visible = false;
            // 
            // txtBxGl
            // 
            this.txtBxGl.Location = new System.Drawing.Point(6, 38);
            this.txtBxGl.Name = "txtBxGl";
            this.txtBxGl.Size = new System.Drawing.Size(91, 20);
            this.txtBxGl.TabIndex = 80;
            // 
            // lblGl
            // 
            this.lblGl.AutoSize = true;
            this.lblGl.Location = new System.Drawing.Point(3, 9);
            this.lblGl.Name = "lblGl";
            this.lblGl.Size = new System.Drawing.Size(28, 13);
            this.lblGl.TabIndex = 79;
            this.lblGl.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Glucosio (g):";
            // 
            // InOutCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtBxGl);
            this.Controls.Add(this.lblGl);
            this.Name = "InOutCtrl";
            this.Size = new System.Drawing.Size(100, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtBxGl;
        private System.Windows.Forms.Label lblGl;
        private System.Windows.Forms.Label label1;
    }
}
