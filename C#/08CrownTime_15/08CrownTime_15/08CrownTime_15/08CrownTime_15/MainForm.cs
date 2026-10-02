using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _08CrownTime_15
{
    public partial class MainForm : Form
    {
        #region Attributi

        bool running = false;

        delegate void MyDelegate(int cOut);
        MyDelegate del;

        Batteri[] test = new Batteri[10];
        Thread[] threads = new Thread[10];
        Thread rT;
        InOutCtrl[] iOCl;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            SetCtrl();
        }

        #region UI

        private void btnStrt_Click(object sender, EventArgs e)
        {
            try
            {
                del = new MyDelegate(ChUse);
                for (int i = 0; i < test.Length; i++)
                {
                    if (!string.IsNullOrEmpty(iOCl[i].GetTxtBxGl()))
                    {
                        test[i] = new Batteri(iOCl[i], Convert.ToDouble(txtBxTR.Text), Convert.ToInt32(txtBxPI.Text), Convert.ToDouble(txtBxGlH.Text));
                        threads[i] = new Thread(test[i].Vivi);
                    }
                    else
                    {
                        i = test.Length;
                        test[test.Length - 1] = null;
                        MessageBox.Show("Errore: Inserire correttamente i dati.");
                    }
                }
                if (test[test.Length - 1] != null)
                {
                    rT = new Thread(Run);
                    rT.Start();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore: " + exc);
            }
        }

        private void btnAut_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < threads.Length; i++)
            {
                iOCl[i].SetTxtBxGl(Convert.ToString(r.Next(10, 50)));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running)
            {
                this.Enabled = false;
                for (int l = 0; l < threads.Length; l++)
                {
                    threads[l].Abort("Closing");
                }
                rT.Abort("Closing");
            }

            while (running)
                Application.DoEvents();
            Application.Exit();
        }

        private void txtBxTR_TextChanged(object sender, EventArgs e)
        {
            ControlTxtBxs();
        }

        private void txtBxPI_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBxGlH_TextChanged(object sender, EventArgs e)
        {
            ControlTxtBxs();
        }

        #endregion

        #region Metodi

        private void Run()
        {
            try
            {
                int cOut = 0;
                double[] iOut = new double[test.Length];
                running = true;
                for (int i = 0; i < test.Length; i++)
                {
                    iOCl[i].SetRunning(true);
                    threads[i].Start();
                }
                this.Invoke(del, cOut);
                for (int i = 0; i < test.Length; i++)
                {
                    threads[i].Join();
                    iOCl[i].SetRunning(false);
                    iOut[i] = test[i].GetRapporto();
                }
                for (int i = 0; i < test.Length - 1; i++)
                {
                    if (iOut.Max() == test[i].GetRapporto())
                        cOut = i;
                }
                running = false;
                this.Invoke(del, cOut);
            }
            catch (ThreadAbortException exAbort)
            {
                if ((string)exAbort.ExceptionState == "Closing")
                    Thread.ResetAbort();
                running = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore: " + exc);
            }
        }

        private void ChUse(int cOut)
        {
            btnAut.Enabled = !btnAut.Enabled;
            btnStrt.Enabled = !btnStrt.Enabled;
            txtBxPI.ReadOnly = !txtBxPI.ReadOnly;
            txtBxTR.ReadOnly = !txtBxTR.ReadOnly;
            txtBxGlH.ReadOnly = !txtBxGlH.ReadOnly;
            for (int i = 0; i < test.Length; i++)
            {
                iOCl[i].SetTxtBxesReadOnly(iOCl[i].GetRunning());
            }
            if (!running)
            {
                lblOut.Visible = true;
                lblOut.Text = "Rapporto migliore test N° " + cOut + ".";
            }
        }

        private void SetCtrl()
        {
            int nL = 10;
            int xPn = 0, yPn = 0;
            int sW = 670 - InOutCtrl.startWidth;
            int w = 35 + nL * InOutCtrl.startWidth;
            if (w < sW)
                this.Width = w;
            else
                this.Width = sW + 50;
            if (this.Width < 300) this.Width = 300;
            iOCl = new InOutCtrl[nL];

            for (int i = 0; i < nL; i++)
            {
                iOCl[i] = new InOutCtrl();
                iOCl[i].SetLblGl("Test N° " + (i + 1));
                iOCl[i].Left += xPn;
                iOCl[i].Top = yPn;
                xPn += InOutCtrl.startWidth;
                if (xPn >= sW)
                {
                    xPn = 0;
                    int dy = (int)1.5 * iOCl[0].Height;
                    yPn += dy;
                    this.Height += dy;
                }
                Controls.Add(iOCl[i]);
            }
            ControlTxtBxs();
        }

        private void ControlTxtBxs() 
        {
            if (!(((string.IsNullOrEmpty(txtBxTR.Text) && string.IsNullOrWhiteSpace(txtBxTR.Text)) || (string.IsNullOrEmpty(txtBxPI.Text) && string.IsNullOrWhiteSpace(txtBxPI.Text))) || (string.IsNullOrEmpty(txtBxGlH.Text) && string.IsNullOrWhiteSpace(txtBxGlH.Text))))
            {
                for (int i = 0; i < test.Length; i++)
                {
                    btnStrt.Enabled = true;
                    btnAut.Enabled = true;
                    iOCl[i].SetTxtBxesReadOnly(false);
                }
            }
            else
            {
                for (int i = 0; i < test.Length; i++)
                {
                    btnStrt.Enabled = false;
                    btnAut.Enabled = false;
                    iOCl[i].SetTxtBxesReadOnly(true);
                }
            }
        }

        #endregion
    }
}
