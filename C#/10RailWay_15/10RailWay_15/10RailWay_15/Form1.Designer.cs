namespace _10RailWay_15
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
            this.components = new System.ComponentModel.Container();
            this.btnStr = new System.Windows.Forms.Button();
            this.nUDTr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmC = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nUDTr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStr
            // 
            this.btnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStr.Location = new System.Drawing.Point(211, 51);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(61, 23);
            this.btnStr.TabIndex = 0;
            this.btnStr.Text = "Start";
            this.btnStr.UseVisualStyleBackColor = true;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // nUDTr
            // 
            this.nUDTr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDTr.Location = new System.Drawing.Point(151, 54);
            this.nUDTr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDTr.Name = "nUDTr";
            this.nUDTr.Size = new System.Drawing.Size(54, 20);
            this.nUDTr.TabIndex = 1;
            this.nUDTr.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUDTr.ValueChanged += new System.EventHandler(this.nUDTr_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N Treni";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Treni rimasti: ";
            this.label2.Visible = false;
            // 
            // tmC
            // 
            this.tmC.Tick += new System.EventHandler(this.tmC_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDTr);
            this.Controls.Add(this.btnStr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nUDTr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.NumericUpDown nUDTr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmC;
    }
}

