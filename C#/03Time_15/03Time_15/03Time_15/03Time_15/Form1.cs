using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03Time_15
{
    public partial class Form1 : Form
    {
        #region attributiForm

        ushort typeP = 0;
        ushort typeS = 0;
        Times time1;
        Times time2;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVis_Click(object sender, EventArgs e)
        {
            try
            {
                time1 = new Times(txtBxPr.Text);
                time2 = new Times(txtBxSe.Text);
                txtBxPrF.Text = time1.ChangeFormat(typeP);
                txtBxSeF.Text = time2.ChangeFormat(typeS);
            }
            catch (Exception)
            {
                MessageBox.Show("Inserisci formato corretto s/m/h/d");
            }
        }

        #region radioButtonPrimo

        private void RBtSecP_CheckedChanged(object sender, EventArgs e)
        {
            typeP = 0;
        }

        private void RBtMinP_CheckedChanged(object sender, EventArgs e)
        {
            typeP = 1;
        }

        private void RBtHourP_CheckedChanged(object sender, EventArgs e)
        {
            typeP = 2;
        }

        private void RBtDayP_CheckedChanged(object sender, EventArgs e)
        {
            typeP = 3;
        }

        #endregion

        #region radioButtonSecondo

        private void RBtSecS_CheckedChanged(object sender, EventArgs e)
        {
            typeS = 0;
        }

        private void RBtMinS_CheckedChanged(object sender, EventArgs e)
        {
            typeS = 1;
        }

        private void RBtHourS_CheckedChanged(object sender, EventArgs e)
        {
            typeS = 2;
        }

        private void RBtDayS_CheckedChanged(object sender, EventArgs e)
        {
            typeS = 3;
        }

        #endregion

    }
}
