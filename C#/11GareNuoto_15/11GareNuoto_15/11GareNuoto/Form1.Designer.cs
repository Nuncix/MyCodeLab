namespace _11GareNuoto
{
    partial class FormGare
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
            this.lstV = new System.Windows.Forms.ListView();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBxSpec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmBxVis = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lstV
            // 
            this.lstV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstV.Location = new System.Drawing.Point(0, 0);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(321, 482);
            this.lstV.TabIndex = 0;
            this.lstV.UseCompatibleStateImageBehavior = false;
            this.lstV.View = System.Windows.Forms.View.List;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Location = new System.Drawing.Point(327, 447);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(61, 23);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "Inserisci";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtBoxN
            // 
            this.txtBoxN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxN.Location = new System.Drawing.Point(327, 25);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(123, 20);
            this.txtBoxN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // nUDM
            // 
            this.nUDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDM.Location = new System.Drawing.Point(327, 64);
            this.nUDM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nUDM.Name = "nUDM";
            this.nUDM.Size = new System.Drawing.Size(123, 20);
            this.nUDM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minuti";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Secondi";
            // 
            // nUDS
            // 
            this.nUDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDS.Location = new System.Drawing.Point(327, 103);
            this.nUDS.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nUDS.Name = "nUDS";
            this.nUDS.Size = new System.Drawing.Size(123, 20);
            this.nUDS.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Specialità";
            // 
            // cmBxSpec
            // 
            this.cmBxSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBxSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxSpec.FormattingEnabled = true;
            this.cmBxSpec.Location = new System.Drawing.Point(327, 142);
            this.cmBxSpec.Name = "cmBxSpec";
            this.cmBxSpec.Size = new System.Drawing.Size(123, 21);
            this.cmBxSpec.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vista";
            // 
            // cmBxVis
            // 
            this.cmBxVis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBxVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxVis.Items.AddRange(new object[] {
            "Tutti"});
            this.cmBxVis.Location = new System.Drawing.Point(327, 420);
            this.cmBxVis.Name = "cmBxVis";
            this.cmBxVis.Size = new System.Drawing.Size(123, 21);
            this.cmBxVis.TabIndex = 13;
            this.cmBxVis.SelectedIndexChanged += new System.EventHandler(this.cmBxVis_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(389, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Random5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmBxVis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmBxSpec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lstV);
            this.MinimumSize = new System.Drawing.Size(475, 521);
            this.Name = "FormGare";
            this.Text = " Gareee";
            this.Resize += new System.EventHandler(this.FormGare_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nUDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstV;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBxSpec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmBxVis;
        private System.Windows.Forms.Button button1;
    }
}

