using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _10RailWay_15
{
    public partial class Form1 : Form
    {
        #region attributi

        delegate void MyD(int i);

        bool running = false;
        TrPnl[] pnl;
        Semaphore sm;
        Thread[] tAr;
        Thread t;
        int nTr, cTr, cTm;

        #endregion

        public Form1()
        {
            InitializeComponent();
            SetPnl();
            tAr = new Thread[16];
            nTr = (int)nUDTr.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running)
            {
                this.Enabled = false;
                for (int l = 0; l < tAr.Length; l++)
                {
                    tAr[l].Abort("Closing");
                }
                t.Abort("Closing");
            }

            while (running)
                Application.DoEvents();
            Application.Exit();
        }

        private void btnStr_Click(object sender, EventArgs e)
        {
            nTr = (int)nUDTr.Value;
            cTr = 0;
            cTm = nTr;
            try
            {
                if (nTr > 0)
                {
                    if (sm != null) sm.Dispose();
                    sm = new Semaphore(1, 16);
                    t = new Thread(Run);
                    t.Name = "MainThread";
                    t.Start();
                }
            }
            catch (Exception ex)
            {
                btnStr.Enabled = true;
                MessageBox.Show("Errore: " + ex.ToString());
            }
        }

        private void nUDTr_ValueChanged(object sender, EventArgs e)
        {
            nTr = (int)nUDTr.Value;
        }

        private void tmC_Tick(object sender, EventArgs e)
        {
            label2.Text = "Treni rimasti: " + (cTm - cTr);
        }

        private void Run()
        {
            try
            {
                running = true;
                MyD del = new MyD(ChCtrl);
                this.Invoke(del, 0);
                for (int i = 0; i < tAr.Length; i++)
                {
                    tAr[i] = new Thread(MCode);
                    tAr[i].Name = i.ToString();
                }
                foreach (Thread t in tAr)
                    t.Start();
                foreach (Thread t in tAr)
                    t.Join();
                running = false;
                this.Invoke(del, 0);
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
                int pId = Convert.ToInt16(Thread.CurrentThread.Name);
                Random r = new Random(Thread.CurrentThread.GetHashCode());
                TextBox txmp = pnl[pId].GetTxtBx();
                MyD dell = new MyD(pnl[pId].ChInRun);
                while (nTr > 0)
                {
                    Thread.Sleep(r.Next(250));
                    sm.WaitOne();
                    if (nTr > 0)
                    {
                        cTr++;
                        pnl[pId].SetFree(false);
                        this.BeginInvoke(dell, cTr);
                        nTr--;
                    }
                    sm.Release();
                    Thread.Sleep(r.Next(2000));
                    pnl[pId].SetFree(true);
                    this.BeginInvoke(dell, cTr);
                }
            }
            catch (ThreadAbortException exAbort)
            {
                if ((string)exAbort.ExceptionState == "Closing")
                    Thread.ResetAbort();
                running = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.ToString());
            }
        }

        private void ChCtrl(int i)
        {
            btnStr.Enabled = !running;
            nUDTr.Enabled = !running;
            label2.Visible = true;
            tmC.Enabled = running;
        }

        private void SetPnl()
        {
            int nL = 16;
            int startWidth = 71;
            int xPn = 0, yPn = 0;
            int sW = 400 - startWidth;
            int w = 35 + nL * startWidth;
            if (w < sW)
                this.Width = w;
            else
                this.Width = sW + 50;
            if (this.Width < 300) this.Width = 300;
            pnl = new TrPnl[nL];

            for (int i = 0; i < nL; i++)
            {
                pnl[i] = new TrPnl();
                Label lbl = pnl[i].GetLabel();
                lbl.Text = "Binario " + (i + 1);
                pnl[i].SetLabel(lbl);
                pnl[i].Left += xPn;
                pnl[i].Top = yPn;
                xPn += startWidth;
                if (xPn >= sW)
                {
                    xPn = 0;
                    int dy = (int)1.5 * pnl[0].Height;
                    yPn += dy;
                    this.Height += dy;
                }
                Controls.Add(pnl[i]);
            }

        }
    }
}
