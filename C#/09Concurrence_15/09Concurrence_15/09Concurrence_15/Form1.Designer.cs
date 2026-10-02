namespace _09Concurrence_15
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
            this.components = new System.ComponentModel.Container();
            this.btnR = new System.Windows.Forms.Button();
            this.pBC = new System.Windows.Forms.ProgressBar();
            this.tmDisplei = new System.Windows.Forms.Timer(this.components);
            this.lblV = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.cmBxS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnR
            // 
            this.btnR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnR.Location = new System.Drawing.Point(197, 95);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 0;
            this.btnR.Text = "Esegui";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // pBC
            // 
            this.pBC.Location = new System.Drawing.Point(12, 12);
            this.pBC.Name = "pBC";
            this.pBC.Size = new System.Drawing.Size(260, 23);
            this.pBC.TabIndex = 1;
            // 
            // tmDisplei
            // 
            this.tmDisplei.Tick += new System.EventHandler(this.tmDisplei_Tick);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(13, 42);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(13, 13);
            this.lblV.TabIndex = 2;
            this.lblV.Text = "0";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(13, 79);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(103, 13);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "Ritardo (millisecondi)";
            // 
            // cmBxS
            // 
            this.cmBxS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxS.FormattingEnabled = true;
            this.cmBxS.Location = new System.Drawing.Point(12, 95);
            this.cmBxS.Name = "cmBxS";
            this.cmBxS.Size = new System.Drawing.Size(121, 21);
            this.cmBxS.TabIndex = 5;
            this.cmBxS.TextChanged += new System.EventHandler(this.cmBxS_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.cmBxS);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.pBC);
            this.Controls.Add(this.btnR);
            this.Name = "MainForm";
            this.Text = "Concurrence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.ProgressBar pBC;
        private System.Windows.Forms.Timer tmDisplei;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.ComboBox cmBxS;
    }
}

