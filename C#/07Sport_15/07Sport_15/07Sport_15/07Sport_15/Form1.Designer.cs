namespace _07Sport_15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstVw = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtBxN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBxS = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstVw
            // 
            this.lstVw.Location = new System.Drawing.Point(13, 13);
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(182, 246);
            this.lstVw.TabIndex = 0;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(204, 236);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "Inserisci";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtBxN
            // 
            this.txtBxN.Location = new System.Drawing.Point(204, 26);
            this.txtBxN.Name = "txtBxN";
            this.txtBxN.Size = new System.Drawing.Size(100, 20);
            this.txtBxN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cognome";
            // 
            // txtBxC
            // 
            this.txtBxC.Location = new System.Drawing.Point(204, 70);
            this.txtBxC.Name = "txtBxC";
            this.txtBxC.Size = new System.Drawing.Size(100, 20);
            this.txtBxC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sport";
            // 
            // cmbBxS
            // 
            this.cmbBxS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBxS.Items.AddRange(new object[] {
            "Calcio",
            "Pallavolo",
            "Tennis"});
            this.cmbBxS.Location = new System.Drawing.Point(204, 113);
            this.cmbBxS.Name = "cmbBxS";
            this.cmbBxS.Size = new System.Drawing.Size(100, 21);
            this.cmbBxS.TabIndex = 7;
            this.cmbBxS.Text = "Calcio";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 265);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(291, 150);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 427);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cmbBxS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxN);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtBxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBxS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}

