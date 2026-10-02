using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05RAngle_15
{
    public partial class Form1 : Form
    {
        RAngle angle;
        public Form1()
        {
            InitializeComponent();
            angle = new RAngle();
        }

        private void TxtBx_TextChanged(object sender, EventArgs e)
        {
            FormCode();
        }
        private void FormCode()
        {
            try
            {
                if (rBtnGra.Checked && txtBx.Text != "")
                {
                    angle.ToGrad(Convert.ToDouble(txtBx.Text));
                    angle.ToRad(Convert.ToDouble(txtBx.Text));
                    lblGra.Text = "Gradi: " + Convert.ToString(angle.Getgradi());
                    lblPri.Text = "Primi: " + Convert.ToString(angle.Getprimi());
                    lblSec.Text = "Secondi: " + Convert.ToString(angle.Getsecondi());
                    lblRad.Text = "Radianti: " + Convert.ToString(angle.Getradianti());
                }
                if (rBtnRad.Checked && txtBx.Text != "")
                {
                    angle.Setradianti(Convert.ToDouble(txtBx.Text));
                    angle.ToGrad();
                    lblGra.Text = "Gradi: " + Convert.ToString(angle.Getgradi());
                    lblPri.Text = "Primi: " + Convert.ToString(angle.Getprimi());
                    lblSec.Text = "Secondi: " + Convert.ToString(angle.Getsecondi());
                    lblRad.Text = "Radianti: " + Convert.ToString(angle.Getradianti());
                }
            }
            catch
            {
                MessageBox.Show("Inserisci formato valido.");
            }
        }

        private void RBtnGra_CheckedChanged(object sender, EventArgs e)
        {
            FormCode();
        }

        private void RBtnRad_CheckedChanged(object sender, EventArgs e)
        {
            FormCode();
        }
    }
}
