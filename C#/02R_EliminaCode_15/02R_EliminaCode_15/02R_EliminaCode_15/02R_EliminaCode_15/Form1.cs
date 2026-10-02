using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02R_EliminaCode_15
{
    public partial class Form1 : Form
    {
        #region Variabili

        int h = 0;
        int t = -1;
        int c = 0;
        string[] coda = new string[10];

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtBxN.Text))
            {
                lbl.Text = "Inserire Nome.";
                lbl.Visible = true;
            }
            else
            {
                if (Enqueue(txtBxN.Text))
                {
                    lbl.Visible = false;
                    PrintQueue();
                    txtBxN.Text = null;
                }
                else
                {
                    lbl.Text = "Coda piena.";
                    lbl.Visible = true;
                    txtBxN.Text = null;
                }
            }
            Timer.Enabled = true;
        }

        public bool Enqueue(string x)
        {
            if (c == coda.Length)
            {
                return false;
            }
            else
            {
                t = (t + 1) % coda.Length;
                coda[t] = x;

                c++;
            }
            return true;
        }

        public bool Dequeue()
        {
            if (c == 0)
            {
                return false;
            }
            else
            {

                h = (h + 1) % coda.Length;

                c--;
            }
            return true;
        }

        public void PrintQueue()
        {
            int i = h;
            lstVw.Items.Clear();
            if (c == 0)
            {
                return;
            }
            else
            {
                for (int j = 0; j < c; j++)
                {
                    lstVw.Items.Add(coda[i]);

                    i = (i + 1) % coda.Length;
                }
            }
            return;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int RandomNumber = r.Next(5000, 15000);
            if (Dequeue())
            {
                PrintQueue();
            }
            else
            {
                lbl.Text = "Coda vuota.";
                lbl.Visible = true;
                Timer.Enabled = false;
            }
            Timer.Interval = RandomNumber;
        }
    }
}
