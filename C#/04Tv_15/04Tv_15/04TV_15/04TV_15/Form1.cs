using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04TV_15
{
    public partial class Form1 : Form
    {
        Tv tv = new Tv();

        public Form1()
        {
            InitializeComponent();
            label2.Text = label2.Text + Convert.ToString(tv.Getchannel());
            label3.Text = label3.Text + Convert.ToString(tv.Getvolume());

        }

        private void BtnOnOff_Click(object sender, EventArgs e)
        {
            if (tv.OnOffTv())
            {
                label1.Text = "Acceso";
                label1.ForeColor = System.Drawing.Color.Green;
                label2.Visible = true;
                label3.Visible = true;
                btnChnL.Enabled = true;
                btnChnP.Enabled = true;
                btnVolL.Enabled = true;
                btnVolP.Enabled = true;
            }
            else
            {
                label1.Text = "Spento";
                label1.ForeColor = System.Drawing.Color.Red;
                label2.Visible = false;
                label3.Visible = false;
                btnChnL.Enabled = false;
                btnChnP.Enabled = false;
                btnVolL.Enabled = false;
                btnVolP.Enabled = false;
            }
        }

        private void BtnChnP_Click(object sender, EventArgs e)
        {
            tv.NextChannel();
            label2.Text = tv.Getchannel("Canale: ");
        }

        private void BtnVolP_Click(object sender, EventArgs e)
        {
            tv.MoreVolume();
            label3.Text = tv.Getvolume("Volume: ");
        }

        private void BtnVolL_Click(object sender, EventArgs e)
        {
            tv.LessVolume();
            label3.Text = tv.Getvolume("Volume: ");
        }

        private void BtnChnL_Click(object sender, EventArgs e)
        {
            tv.PreviousChannel();
            label2.Text = tv.Getchannel("Canale: ");
        }
    }
}
