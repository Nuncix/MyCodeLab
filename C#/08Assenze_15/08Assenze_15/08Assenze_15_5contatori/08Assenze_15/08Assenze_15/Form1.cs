using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08Assenze_15
{
    public partial class Form1 : Form
    {
        #region attributi

        ushort nClasse;
        char cSezione;
        Assenze[] assenze;

        #endregion

        public Form1()
        {
            InitializeComponent();
            nClasse = 1;
            cSezione = 'A';
            assenze = new Assenze[10000];
        }

        private void btnAsnz_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < assenze.Length; i++)
                {
                    if (assenze[i] == null)
                    {
                        assenze[i] = new Assenze(dtTmPkr.Value, nClasse, cSezione);                          
                        i = assenze.Length;
                    }
                }
                ShowAssenze();
            }
            catch (Exception) 
            {
                MessageBox.Show("Errore.");
            }
        }

        private void ShowAssenze() 
        {
            lstVw.Items.Clear();
            uint t = 0;
            uint tt = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < assenze.Length; i++)
                {
                    if (assenze[i] != null && assenze[i].GetDay() == dtTmPkr.Value.Day && assenze[i].GetClasse() == j + 1)
                    {
                        t++;
                    }
                }
                lstVw.Items.Add("Sono assenti: " + t + " alunni nelle classi " + (j + 1) + ".");
                tt += t;
                t = 0;
            }
            lstVw.Items.Add("Sono assenti: " + tt + " alunni in totale.");
        }
        private void dtTmPkr_ValueChanged(object sender, EventArgs e)
        {
            ShowAssenze();
        }
        
        #region radioButton

        private void rdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
                nClasse = 1;
        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn2.Checked)
                nClasse = 2;
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn3.Checked)
                nClasse = 3;
        }

        private void rdBtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn4.Checked)
                nClasse = 4;
        }

        private void rdBtn5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn5.Checked)
                nClasse = 5;
        }

        private void rdBtnA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnA.Checked)
                cSezione = 'A';
        }

        private void rdBtnB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnB.Checked)
                cSezione = 'B';
        }

        private void rdBtnC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnC.Checked)
                cSezione = 'C';
        }

        private void rdBtnD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnD.Checked)
                cSezione = 'D';
        }

        private void rdBtnE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnE.Checked)
                cSezione = 'E';
        }

        #endregion

    }
}
