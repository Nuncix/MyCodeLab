using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _02_Converti_15
{
    public partial class Form1 : Form
    {
        MyConvert convert = new MyConvert();

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBxI_TextChanged(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            try
            {
                if (convert.GetbI() == 2) txtBxF.Text = convert.ConvertR(txtBxI.Text);
                if (convert.GetbI() == 8) txtBxF.Text = convert.ConvertR(txtBxI.Text);
                if (convert.GetbI() == 10) txtBxF.Text = convert.ConvertR(Convert.ToInt32(txtBxI.Text));
                if (convert.GetbI() == 16) txtBxF.Text = convert.ConvertR(txtBxI.Text);
            }
            catch (Exception)
            {
                if (txtBxI.Text != "") txtBxF.Text = "Formato non valido.";
            }
        }

        #region RadioButtonCheckedI

        private void RBtnBinI_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBinI.Checked) convert.SetbI(2);
            Converter();
        }

        private void RBtnOttI_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtnOttI.Checked) convert.SetbI(8);
            Converter();
        }

        private void RBtnDecI_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtnDecI.Checked) convert.SetbI(10);
            Converter();
        }

        private void RBtnEsaI_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtnEsaI.Checked) convert.SetbI(16);
            Converter();
        }

        #endregion

        #region RadioButtonCheckedF

        private void RBtnBinF_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBinF.Checked) convert.SetbF(2);
            Converter();
        }

        private void RBtnOttF_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtnOttF.Checked) convert.SetbF(8);
            Converter();
        }

        private void RBtnDecF_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtnDecF.Checked) convert.SetbF(10);
            Converter();
        }

        private void RBtnEsaF_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtnEsaF.Checked) convert.SetbF(16);
            Converter();
        }

        #endregion
    }
}
