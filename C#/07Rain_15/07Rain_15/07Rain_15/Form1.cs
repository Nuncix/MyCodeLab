using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _07Rain_15
{
    public partial class Form1 : Form
    {
        #region Attributi

        bool running = false;

        delegate void MyDelegate();
        MyDelegate del;

        RainDay[] rain = new RainDay[10];
        Thread[] threads = new Thread[10];
        Thread rT;
        InOutCtrl[] iOCl;

        #endregion

        #region UI

        public Form1()
        { 
            InitializeComponent();
            SetLines();
            del = new MyDelegate(ChIOCltxtBxesRdOnly);
        }

        private void btnStrt_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < rain.Length; i++)
                {
                    if (!string.IsNullOrEmpty(iOCl[i].GetTxtBxLoc()) && !string.IsNullOrEmpty(iOCl[i].GetTxtBxRain()))
                    {
                        rain[i] = new RainDay(iOCl[i]);
                        threads[i] = new Thread(rain[i].Rain);
                    }
                    else
                    {
                        i = rain.Length;
                        MessageBox.Show("Errore: Inserire correttamente i dati.");
                    }
                }
                if (rain[rain.Length - 1] != null)
                {
                    btnStrt.Enabled = false;
                    btnAut.Enabled = false;
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
            string[] vS = new string[10] { "Pechino", "Roma", "Londra", "Burundi", "Iraq", "Los Angeles", "Parigi", "Caltanissetta", "Berlino", "Canicattini Bagni" };
            Random r;
            for (int i = 0; i < threads.Length; i++)
            {
                r = new Random();
                iOCl[i].SetTxtBxLoc(vS[i]);
                iOCl[i].SetTxtBxRain(Convert.ToString(r.Next(150, 600)));
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

#endregion

        #region Metodi

        private void Run()
        {
            try
            {
                running = true;
                for (int i = 0; i < rain.Length; i++)
                {
                    iOCl[i].SetRunning(true);
                    threads[i].Start();
                }
                this.Invoke(del);
                for (int i = 0; i < rain.Length; i++)
                {
                    threads[i].Join();
                    iOCl[i].SetRunning(false);
                }
                del += ChBtn;
                running = false;
                this.Invoke(del);
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

        private void ChIOCltxtBxesRdOnly()
        {
            for (int i = 0; i < rain.Length; i++)
            {
                iOCl[i].SetTxtBxesReadOnly(iOCl[i].GetRunning());
            }
        }

        private void ChBtn() 
        {
            btnStrt.Enabled = !btnStrt.Enabled;
            btnAut.Enabled = !btnAut.Enabled;
        }

        private void SetLines()
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
                iOCl[i].SetLblLoc("Nome " + (i + 1) + "° località:");
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

        }

        #endregion
    }
}
