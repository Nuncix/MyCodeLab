using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _07Sport_15
{
    public partial class Form1 : Form
    {
        #region attributi
        Intervista[] inte=new Intervista[15];
        #endregion

        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("Sports");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(inte[inte.Length - 1] == null))
                    MessageBox.Show("La lista è piena.");
                if (CtrlText())
                {
                    for (int i = 0; i < inte.Length; i++)
                    {
                        if (inte[i] == null)
                        {
                            inte[i] = new Intervista(txtBxN.Text, txtBxC.Text, cmbBxS.Text);
                            i = inte.Length;
                            ShowItem();
                        }
                    }
                }
                SetChart();
            }
            catch (Exception) 
            {
                MessageBox.Show("Errore.");
            }
        }

        private bool CtrlText() 
        {
            string[] items = new string[3];
            items[0] = "Calcio";
            items[1] = "Tennis";
            items[2] = "Pallavolo";
            for (int i = 0; i < items.Length; i++) 
            {
                if (!string.IsNullOrEmpty(txtBxN.Text) && !string.IsNullOrEmpty(txtBxC.Text) && !string.IsNullOrEmpty(cmbBxS.Text) && cmbBxS.Text == items[i]) return true;
            }
            return false;
        }

        private void ShowItem()
        {
            for (int i = inte.Length - 1; i >= 0; i--)
            {
                if (!(inte[i] == null))
                {
                    lstVw.Items.Add(inte[i].Getname() + " " + inte[i].Getsurname() + " --Sport: " + inte[i].Getsport());
                    return;
                }
            }
        }

        private void SetChart() 
        {
            int calcio = 0, pallavolo = 0, tennis = 0, tot = 0;
            string[] items = new string[3];
            items[0] = "Calcio";
            items[1] = "Tennis";
            items[2] = "Pallavolo";
            for (int i = 0; i < inte.Length; i++) 
            {
                if (!(inte[i] == null))
                {
                    switch (inte[i].Getsport())
                    {
                        case "Calcio":
                            calcio++;
                            break;
                        case "Tennis":
                            tennis++;
                            break;
                        case "Pallavolo":
                            pallavolo++;
                            break;
                    }
                    tot++;
                }
            }
            chart1.Series.Clear();
            Series series = chart1.Series.Add("Sports");
            series.ChartType = SeriesChartType.Doughnut;
            if(calcio > 0)
                series.Points.AddXY("Calcio: " + Convert.ToString((calcio * 100) / tot) + "%", calcio);
            if(tennis > 0)
                series.Points.AddXY("Tennis: " + Convert.ToString((tennis * 100) / tot) + "%", tennis);
            if(pallavolo > 0)
				series.Points.AddXY("Pallavolo: " + Convert.ToString((pallavolo * 100) / tot) + "%", pallavolo);
        }
    }
}
