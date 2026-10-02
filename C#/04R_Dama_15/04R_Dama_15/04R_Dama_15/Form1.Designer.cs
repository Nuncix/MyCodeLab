namespace _04R_Dama_15
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvDam = new System.Windows.Forms.DataGridView();
            this.imgD = new System.Windows.Forms.ImageList(this.components);
            this.btnCerca = new System.Windows.Forms.Button();
            this.rBtnW = new System.Windows.Forms.RadioButton();
            this.rBtnB = new System.Windows.Forms.RadioButton();
            this.lblIn = new System.Windows.Forms.Label();
            this.lstV = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDam
            // 
            this.dgvDam.AllowUserToResizeColumns = false;
            this.dgvDam.AllowUserToResizeRows = false;
            this.dgvDam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDam.ColumnHeadersVisible = false;
            this.dgvDam.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvDam.Location = new System.Drawing.Point(12, 12);
            this.dgvDam.Name = "dgvDam";
            this.dgvDam.RowHeadersVisible = false;
            this.dgvDam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDam.Size = new System.Drawing.Size(350, 348);
            this.dgvDam.TabIndex = 0;
            this.dgvDam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDam_CellDoubleClick);
            // 
            // imgD
            // 
            this.imgD.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgD.ImageStream")));
            this.imgD.TransparentColor = System.Drawing.Color.Transparent;
            this.imgD.Images.SetKeyName(0, "blackS.png");
            this.imgD.Images.SetKeyName(1, "whiteS.png");
            this.imgD.Images.SetKeyName(2, "blackP.jpg");
            this.imgD.Images.SetKeyName(3, "whiteP.jpg");
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(475, 16);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(119, 47);
            this.btnCerca.TabIndex = 1;
            this.btnCerca.Text = "Cerca pedine nere accanto a bianche";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.BtnCerca_Click);
            // 
            // rBtnW
            // 
            this.rBtnW.AutoSize = true;
            this.rBtnW.Location = new System.Drawing.Point(367, 31);
            this.rBtnW.Name = "rBtnW";
            this.rBtnW.Size = new System.Drawing.Size(100, 17);
            this.rBtnW.TabIndex = 5;
            this.rBtnW.TabStop = true;
            this.rBtnW.Text = "Pedine Bianche";
            this.rBtnW.UseVisualStyleBackColor = true;
            // 
            // rBtnB
            // 
            this.rBtnB.AutoSize = true;
            this.rBtnB.Location = new System.Drawing.Point(367, 54);
            this.rBtnB.Name = "rBtnB";
            this.rBtnB.Size = new System.Drawing.Size(84, 17);
            this.rBtnB.TabIndex = 6;
            this.rBtnB.TabStop = true;
            this.rBtnB.Text = "Pedine Nere";
            this.rBtnB.UseVisualStyleBackColor = true;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(368, 12);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(61, 13);
            this.lblIn.TabIndex = 7;
            this.lblIn.Text = "Inserimento";
            // 
            // lstV
            // 
            this.lstV.BackColor = System.Drawing.SystemColors.Window;
            this.lstV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstV.HideSelection = false;
            this.lstV.Location = new System.Drawing.Point(369, 78);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(225, 282);
            this.lstV.TabIndex = 8;
            this.lstV.UseCompatibleStateImageBehavior = false;
            this.lstV.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.lstV);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.rBtnB);
            this.Controls.Add(this.rBtnW);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.dgvDam);
            this.Name = "Form1";
            this.Text = "Dama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDam;
        private System.Windows.Forms.ImageList imgD;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.RadioButton rBtnW;
        private System.Windows.Forms.RadioButton rBtnB;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.ListView lstV;
    }
}

