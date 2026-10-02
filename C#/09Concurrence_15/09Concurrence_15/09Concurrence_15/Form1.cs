using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _09Concurrence_15
{
    public partial class MainForm : Form
    {
        #region Attributi

        int vOut= 0;
        int cmV = 1;
        Thread sTh;
        Thread[] tAr = new Thread[100];
        bool running = false;

        delegate void MyDelegate();
        MyDelegate del;

        #endregion

        #region UI

        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i <= 10; i++)
                cmBxS.Items.Add((int)Math.Pow(2, i));
            cmBxS.Text = "1";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            try
            {
                del = new MyDelegate(ChBtn);
                vOut= 0;
                pBC.Value = 0;
                for (int i = 0; i < tAr.Length; i++)
                {
                    tAr[i] = new Thread(MCode);
                }
                sTh = new Thread(Buff);
                sTh.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore: " + exc);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running)
            {
                this.Enabled = false;
                foreach (Thread th in tAr)
                    th.Abort("Closing");
                sTh.Abort("Closing");
            }

            while (running)
                Application.DoEvents();
            Application.Exit();
        }

        private void tmDisplei_Tick(object sender, EventArgs e)
        {
            pBC.Value = vOut;
            lblV.Text = vOut.ToString();
            Application.DoEvents();
        }

        private void cmBxS_TextChanged(object sender, EventArgs e)
        {
            cmV = Convert.ToInt32(cmBxS.Text);
        }
        
        #endregion

        #region Metodi

        private void Buff()
        {
            try
            {
                running = true;
                this.Invoke(del);
                foreach (Thread th in tAr)
                {
                    th.Start();
                }
                foreach (Thread th in tAr)
                    th.Join();
                running = false;
                this.Invoke(del);
            }
            catch (ThreadAbortException exAbort)
            {
                if ((string)exAbort.ExceptionState == "Closing")
                    Thread.ResetAbort();
                running = false;
            }
        }

        private void MCode()
        {
            try
            {
                int t = vOut;
                Thread.Sleep(cmV);
                t++;
                vOut = t;
            }
            catch (ThreadAbortException exAbort)
            {
                if ((string)exAbort.ExceptionState == "Closing")
                    Thread.ResetAbort();
                running = false;
            }
        }

        private void ChBtn()
        {
            btnR.Enabled = !running;
            tmDisplei.Enabled = running;
            cmBxS.Enabled = !running;
        }

        #endregion
    }
}
