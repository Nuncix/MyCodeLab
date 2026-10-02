using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace _01Auto_15
{
    public partial class Form1 : Form
    {

        #region variabili

        Auto suzuki;

        #endregion

        public Form1()
        {
            InitializeComponent();
            suzuki = new Auto();
        }

        #region eventi

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            suzuki.OnOff();

            if (suzuki.GetonOff())
            {
                lblNF.Text = "Accesa";
                lblNF.ForeColor = Color.Green;
                btnA.Enabled = true;
            }
            else
            {
                lblNF.Text = "Spenta";
                lblNF.ForeColor = Color.Red;
                btnA.Enabled = false;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            if (suzuki.Getvel() > 0)
            {
                suzuki.Brake();
                if (suzuki.Getvel() < 90) lblR.Visible = false;
                else lblR.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            try
            {
                suzuki.Acceleration(Convert.ToInt32(txtBxVr.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserisci velocità");
            }

        }

        #endregion

        private void TmR_Tick(object sender, EventArgs e)
        {
            if (!suzuki.GetonOff()) suzuki.Deceleration();
            txtBxV.Text = Convert.ToString(suzuki.Getvel());
            if (suzuki.Getvel() < 90) lblR.Visible = false;
            else lblR.Visible = true;
        }
    }
}
