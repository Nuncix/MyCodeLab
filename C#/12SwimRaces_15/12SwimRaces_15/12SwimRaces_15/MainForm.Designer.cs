namespace _12SwimRaces_15
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
            this.pnSwimmer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSwimmer = new System.Windows.Forms.Button();
            this.dTPBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbSwimmers = new System.Windows.Forms.ComboBox();
            this.cbRaces = new System.Windows.Forms.ComboBox();
            this.dTPCmp = new System.Windows.Forms.DateTimePicker();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCmp = new System.Windows.Forms.Button();
            this.dGVDisplay = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnPlacements = new System.Windows.Forms.Button();
            this.dGVSwimmer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSwimmer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSwimmer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSwimmer
            // 
            this.pnSwimmer.Controls.Add(this.label3);
            this.pnSwimmer.Controls.Add(this.btnSwimmer);
            this.pnSwimmer.Controls.Add(this.dTPBirth);
            this.pnSwimmer.Controls.Add(this.label2);
            this.pnSwimmer.Controls.Add(this.txtFName);
            this.pnSwimmer.Controls.Add(this.label1);
            this.pnSwimmer.Controls.Add(this.txtName);
            this.pnSwimmer.Location = new System.Drawing.Point(12, 154);
            this.pnSwimmer.Name = "pnSwimmer";
            this.pnSwimmer.Size = new System.Drawing.Size(293, 68);
            this.pnSwimmer.TabIndex = 0;
            this.pnSwimmer.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth Date";
            // 
            // btnSwimmer
            // 
            this.btnSwimmer.Location = new System.Drawing.Point(216, 20);
            this.btnSwimmer.Name = "btnSwimmer";
            this.btnSwimmer.Size = new System.Drawing.Size(75, 46);
            this.btnSwimmer.TabIndex = 3;
            this.btnSwimmer.Text = "Set Swimmer";
            this.btnSwimmer.UseVisualStyleBackColor = true;
            this.btnSwimmer.Click += new System.EventHandler(this.btnSwimmer_Click);
            // 
            // dTPBirth
            // 
            this.dTPBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPBirth.Location = new System.Drawing.Point(109, 46);
            this.dTPBirth.Name = "dTPBirth";
            this.dTPBirth.Size = new System.Drawing.Size(100, 20);
            this.dTPBirth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fname";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(109, 20);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // cbSwimmers
            // 
            this.cbSwimmers.FormattingEnabled = true;
            this.cbSwimmers.Items.AddRange(new object[] {
            "+"});
            this.cbSwimmers.Location = new System.Drawing.Point(12, 52);
            this.cbSwimmers.Name = "cbSwimmers";
            this.cbSwimmers.Size = new System.Drawing.Size(293, 21);
            this.cbSwimmers.TabIndex = 1;
            this.cbSwimmers.SelectedIndexChanged += new System.EventHandler(this.cbSwimmers_SelectedIndexChanged);
            // 
            // cbRaces
            // 
            this.cbRaces.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRaces.FormattingEnabled = true;
            this.cbRaces.Location = new System.Drawing.Point(266, 11);
            this.cbRaces.Name = "cbRaces";
            this.cbRaces.Size = new System.Drawing.Size(241, 21);
            this.cbRaces.TabIndex = 2;
            this.cbRaces.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbRaces_DrawItem);
            // 
            // dTPCmp
            // 
            this.dTPCmp.Location = new System.Drawing.Point(12, 12);
            this.dTPCmp.Name = "dTPCmp";
            this.dTPCmp.Size = new System.Drawing.Size(209, 20);
            this.dTPCmp.TabIndex = 3;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(365, 52);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(31, 20);
            this.txtH.TabIndex = 4;
            this.txtH.DoubleClick += new System.EventHandler(this.txtH_DoubleClick);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(476, 53);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(31, 20);
            this.txtC.TabIndex = 5;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(439, 53);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(31, 20);
            this.txtS.TabIndex = 6;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(402, 52);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(31, 20);
            this.txtM.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "hh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "cc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ss";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "mm";
            // 
            // btnCmp
            // 
            this.btnCmp.Location = new System.Drawing.Point(418, 83);
            this.btnCmp.Name = "btnCmp";
            this.btnCmp.Size = new System.Drawing.Size(89, 64);
            this.btnCmp.TabIndex = 7;
            this.btnCmp.Text = "Set Competition";
            this.btnCmp.UseVisualStyleBackColor = true;
            this.btnCmp.Click += new System.EventHandler(this.btnCmp_Click);
            // 
            // dGVDisplay
            // 
            this.dGVDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.FName,
            this.cmpDate,
            this.time});
            this.dGVDisplay.Location = new System.Drawing.Point(12, 154);
            this.dGVDisplay.Name = "dGVDisplay";
            this.dGVDisplay.Size = new System.Drawing.Size(500, 443);
            this.dGVDisplay.TabIndex = 12;
            this.dGVDisplay.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // FName
            // 
            this.FName.HeaderText = "FName";
            this.FName.Name = "FName";
            // 
            // cmpDate
            // 
            this.cmpDate.HeaderText = "CmpDate";
            this.cmpDate.Name = "cmpDate";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(72, 84);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(89, 64);
            this.btnTimes.TabIndex = 13;
            this.btnTimes.Text = "Personal Times";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnPlacements
            // 
            this.btnPlacements.Location = new System.Drawing.Point(167, 84);
            this.btnPlacements.Name = "btnPlacements";
            this.btnPlacements.Size = new System.Drawing.Size(89, 64);
            this.btnPlacements.TabIndex = 14;
            this.btnPlacements.Text = "Race Placements";
            this.btnPlacements.UseVisualStyleBackColor = true;
            this.btnPlacements.Click += new System.EventHandler(this.btnPlacements_Click);
            // 
            // dGVSwimmer
            // 
            this.dGVSwimmer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSwimmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSwimmer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dGVSwimmer.Location = new System.Drawing.Point(12, 154);
            this.dGVSwimmer.Name = "dGVSwimmer";
            this.dGVSwimmer.Size = new System.Drawing.Size(500, 443);
            this.dGVSwimmer.TabIndex = 15;
            this.dGVSwimmer.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Race";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 609);
            this.Controls.Add(this.dGVSwimmer);
            this.Controls.Add(this.btnPlacements);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.dGVDisplay);
            this.Controls.Add(this.btnCmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.dTPCmp);
            this.Controls.Add(this.cbRaces);
            this.Controls.Add(this.cbSwimmers);
            this.Controls.Add(this.pnSwimmer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnSwimmer.ResumeLayout(false);
            this.pnSwimmer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSwimmer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSwimmer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSwimmer;
        private System.Windows.Forms.DateTimePicker dTPBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbSwimmers;
        private System.Windows.Forms.ComboBox cbRaces;
        private System.Windows.Forms.DateTimePicker dTPCmp;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCmp;
        private System.Windows.Forms.DataGridView dGVDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnPlacements;
        private System.Windows.Forms.DataGridView dGVSwimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}

