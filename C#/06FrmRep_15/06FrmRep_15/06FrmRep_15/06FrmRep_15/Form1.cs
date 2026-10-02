using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _06FrmRep_15
{
    public partial class Form1 : Form
    {
        #region attributi

        private Thread[] threads;
        private Linee[] linea;

        #endregion

        public Form1()
        {
            InitializeComponent();
            linea = new Linee[50];
            threads = new Thread[50];
        }

        private void btnStrt_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < linea.Length && linea[i] != null; i++)
                {
                    threads[i] = new Thread(linea[i].InvokeMethod);
                }
                for (int i = 0; i < linea.Length && linea[i] != null; i++)
                {
                    threads[i].Start();
                }
                btnVis.Enabled = true;
                btnCr.Enabled = false;
                btnStrt.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore." + ex);
            }
        }

        private void btnCr_Click(object sender, EventArgs e)
        {
            try
            {
                lstVw.Items.Clear();
                label2.Visible = false;
                if (!string.IsNullOrEmpty(txtBxP.Text) && !string.IsNullOrWhiteSpace(txtBxP.Text) && Convert.ToDouble(txtBxP.Text) > 0)
                {
                    for (int i = 0; i < linea.Length; i++)
                    {
                        if (linea[i] != null && i + 1 > 49)
                        {
                            MessageBox.Show("Raggiunto numero massimo di linee.");
                        }
                        if (linea[i] == null)
                        {
                            linea[i] = new Linee(Convert.ToUInt16(i + 1), Convert.ToUInt32(txtBxP.Text), lstVw);
                            lstVw.Items.Add("Linee create: " + (i + 1));
                            label1.Text = "Produzione massima\nlinea " + (i + 2);
                            btnStrt.Enabled = true;
                            i = linea.Length;
                        }
                    }
                }

                else
                    MessageBox.Show("Inserisci il numero correttamente.");

            }
            catch (Exception)
            {
                MessageBox.Show("Inserisci il numero correttamente.");
            }
        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            int t = 0;
            for (int i = 0; i < linea.Length && linea[i] != null; i++)
            {
                t += (int)linea[i].GetpezziProd();
            }
            label2.Text = "Pezzi totali prodotti:\n" + t;
            label2.Visible = true;
            linea = new Linee[50];
            threads = new Thread[50];
            label1.Text = "Produzione massima\nlinea 1";
            btnVis.Enabled = false;
            btnCr.Enabled = true;
        }
    }
}
