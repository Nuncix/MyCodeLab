namespace _08Assenze_15
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
            this.dtTmPkr = new System.Windows.Forms.DateTimePicker();
            this.lstVw = new System.Windows.Forms.ListView();
            this.btnAsnz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtn5 = new System.Windows.Forms.RadioButton();
            this.rdBtn4 = new System.Windows.Forms.RadioButton();
            this.rdBtn3 = new System.Windows.Forms.RadioButton();
            this.rdBtn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn1 = new System.Windows.Forms.RadioButton();
            this.rdBtnA = new System.Windows.Forms.RadioButton();
            this.rdBtnB = new System.Windows.Forms.RadioButton();
            this.rdBtnC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnE = new System.Windows.Forms.RadioButton();
            this.rdBtnD = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtTmPkr
            // 
            this.dtTmPkr.Location = new System.Drawing.Point(12, 3);
            this.dtTmPkr.Name = "dtTmPkr";
            this.dtTmPkr.Size = new System.Drawing.Size(212, 20);
            this.dtTmPkr.TabIndex = 0;
            this.dtTmPkr.ValueChanged += new System.EventHandler(this.dtTmPkr_ValueChanged);
            // 
            // lstVw
            // 
            this.lstVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstVw.Location = new System.Drawing.Point(12, 29);
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(212, 188);
            this.lstVw.TabIndex = 3;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.List;
            // 
            // btnAsnz
            // 
            this.btnAsnz.Location = new System.Drawing.Point(230, 183);
            this.btnAsnz.Name = "btnAsnz";
            this.btnAsnz.Size = new System.Drawing.Size(89, 34);
            this.btnAsnz.TabIndex = 4;
            this.btnAsnz.Text = "Aggiungi assente";
            this.btnAsnz.UseVisualStyleBackColor = true;
            this.btnAsnz.Click += new System.EventHandler(this.btnAsnz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtn5);
            this.panel1.Controls.Add(this.rdBtn4);
            this.panel1.Controls.Add(this.rdBtn3);
            this.panel1.Controls.Add(this.rdBtn2);
            this.panel1.Controls.Add(this.rdBtn1);
            this.panel1.Location = new System.Drawing.Point(230, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 123);
            this.panel1.TabIndex = 5;
            // 
            // rdBtn5
            // 
            this.rdBtn5.AutoSize = true;
            this.rdBtn5.Location = new System.Drawing.Point(4, 100);
            this.rdBtn5.Name = "rdBtn5";
            this.rdBtn5.Size = new System.Drawing.Size(31, 17);
            this.rdBtn5.TabIndex = 4;
            this.rdBtn5.Text = "5";
            this.rdBtn5.UseVisualStyleBackColor = true;
            this.rdBtn5.CheckedChanged += new System.EventHandler(this.rdBtn5_CheckedChanged);
            // 
            // rdBtn4
            // 
            this.rdBtn4.AutoSize = true;
            this.rdBtn4.Location = new System.Drawing.Point(4, 76);
            this.rdBtn4.Name = "rdBtn4";
            this.rdBtn4.Size = new System.Drawing.Size(31, 17);
            this.rdBtn4.TabIndex = 3;
            this.rdBtn4.Text = "4";
            this.rdBtn4.UseVisualStyleBackColor = true;
            this.rdBtn4.CheckedChanged += new System.EventHandler(this.rdBtn4_CheckedChanged);
            // 
            // rdBtn3
            // 
            this.rdBtn3.AutoSize = true;
            this.rdBtn3.Location = new System.Drawing.Point(4, 52);
            this.rdBtn3.Name = "rdBtn3";
            this.rdBtn3.Size = new System.Drawing.Size(31, 17);
            this.rdBtn3.TabIndex = 2;
            this.rdBtn3.Text = "3";
            this.rdBtn3.UseVisualStyleBackColor = true;
            this.rdBtn3.CheckedChanged += new System.EventHandler(this.rdBtn3_CheckedChanged);
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.Location = new System.Drawing.Point(4, 28);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(31, 17);
            this.rdBtn2.TabIndex = 1;
            this.rdBtn2.Text = "2";
            this.rdBtn2.UseVisualStyleBackColor = true;
            this.rdBtn2.CheckedChanged += new System.EventHandler(this.rdBtn2_CheckedChanged);
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.Checked = true;
            this.rdBtn1.Location = new System.Drawing.Point(4, 4);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(31, 17);
            this.rdBtn1.TabIndex = 0;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "1";
            this.rdBtn1.UseVisualStyleBackColor = true;
            this.rdBtn1.CheckedChanged += new System.EventHandler(this.rdBtn1_CheckedChanged);
            // 
            // rdBtnA
            // 
            this.rdBtnA.AutoSize = true;
            this.rdBtnA.Checked = true;
            this.rdBtnA.Location = new System.Drawing.Point(281, 33);
            this.rdBtnA.Name = "rdBtnA";
            this.rdBtnA.Size = new System.Drawing.Size(32, 17);
            this.rdBtnA.TabIndex = 6;
            this.rdBtnA.TabStop = true;
            this.rdBtnA.Text = "A";
            this.rdBtnA.UseVisualStyleBackColor = true;
            this.rdBtnA.CheckedChanged += new System.EventHandler(this.rdBtnA_CheckedChanged);
            // 
            // rdBtnB
            // 
            this.rdBtnB.AutoSize = true;
            this.rdBtnB.Location = new System.Drawing.Point(281, 57);
            this.rdBtnB.Name = "rdBtnB";
            this.rdBtnB.Size = new System.Drawing.Size(32, 17);
            this.rdBtnB.TabIndex = 7;
            this.rdBtnB.Text = "B";
            this.rdBtnB.UseVisualStyleBackColor = true;
            this.rdBtnB.CheckedChanged += new System.EventHandler(this.rdBtnB_CheckedChanged);
            // 
            // rdBtnC
            // 
            this.rdBtnC.AutoSize = true;
            this.rdBtnC.Location = new System.Drawing.Point(281, 81);
            this.rdBtnC.Name = "rdBtnC";
            this.rdBtnC.Size = new System.Drawing.Size(32, 17);
            this.rdBtnC.TabIndex = 8;
            this.rdBtnC.Text = "C";
            this.rdBtnC.UseVisualStyleBackColor = true;
            this.rdBtnC.CheckedChanged += new System.EventHandler(this.rdBtnC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Classi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sezioni";
            // 
            // rdBtnE
            // 
            this.rdBtnE.AutoSize = true;
            this.rdBtnE.Location = new System.Drawing.Point(281, 128);
            this.rdBtnE.Name = "rdBtnE";
            this.rdBtnE.Size = new System.Drawing.Size(32, 17);
            this.rdBtnE.TabIndex = 12;
            this.rdBtnE.Text = "E";
            this.rdBtnE.UseVisualStyleBackColor = true;
            this.rdBtnE.CheckedChanged += new System.EventHandler(this.rdBtnE_CheckedChanged);
            // 
            // rdBtnD
            // 
            this.rdBtnD.AutoSize = true;
            this.rdBtnD.Location = new System.Drawing.Point(281, 104);
            this.rdBtnD.Name = "rdBtnD";
            this.rdBtnD.Size = new System.Drawing.Size(33, 17);
            this.rdBtnD.TabIndex = 11;
            this.rdBtnD.Text = "D";
            this.rdBtnD.UseVisualStyleBackColor = true;
            this.rdBtnD.CheckedChanged += new System.EventHandler(this.rdBtnD_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 221);
            this.Controls.Add(this.rdBtnE);
            this.Controls.Add(this.rdBtnD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBtnC);
            this.Controls.Add(this.rdBtnB);
            this.Controls.Add(this.rdBtnA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAsnz);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.dtTmPkr);
            this.Name = "Form1";
            this.Text = "Argo SkuolaNecst";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTmPkr;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.Button btnAsnz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtn5;
        private System.Windows.Forms.RadioButton rdBtn4;
        private System.Windows.Forms.RadioButton rdBtn3;
        private System.Windows.Forms.RadioButton rdBtn2;
        private System.Windows.Forms.RadioButton rdBtn1;
        private System.Windows.Forms.RadioButton rdBtnA;
        private System.Windows.Forms.RadioButton rdBtnB;
        private System.Windows.Forms.RadioButton rdBtnC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBtnE;
        private System.Windows.Forms.RadioButton rdBtnD;
    }
}

