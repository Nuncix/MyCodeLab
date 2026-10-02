using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _08CrownTime_15
{
    class Batteri
    {
        #region Attributi

        delegate void assist(double i);
        private assist del;

        private double doublingTime;
        private double qGl;
        private double qGlH;
        private int pI;
        private InOutCtrl iOCl;

        #endregion

        #region Costruttori

        public Batteri(InOutCtrl iOCl, double doublingTime, int pI, double qGlH)
        {
            this.iOCl = iOCl;
            this.doublingTime = doublingTime;
            this.qGlH = qGlH * Math.Pow(10, -6);
            qGl = Convert.ToDouble(iOCl.GetTxtBxGl());
            this.pI = pI;
            del = new assist(Display);
        }

        #endregion

        #region Get&Set


        #endregion

        #region Metodi

        public void Vivi() 
        {
            try
            {
                double i = 0;
                while (qGl > 0)
                {
                    i += 1.5;
                    if (i % doublingTime == 0)
                        pI *= 2;
                    if ((qGl - (pI * (qGlH * 60)) >= 0))
                    {
                        qGl -= (pI * (qGlH * 60));
                    }
                    else
                    {
                        qGl = 0;
                    }
                    iOCl.Invoke(del, i);
                    Thread.Sleep(25);
                }
                qGl = 0;
                iOCl.Invoke(del, i);
            }
            catch (ThreadAbortException exAbort)
            {
                if ((string)exAbort.ExceptionState == "Closing")
                    Thread.ResetAbort();
            }
        }

        public double GetRapporto() 
        {
            return pI / Convert.ToDouble(iOCl.GetTxtBxGl());
        }

        private void Display(double i)
        {
            if(!iOCl.GetLblOutVisible())
                iOCl.ChLblOutVisible();
            iOCl.SetLblOut("Tempo trascorso:\n" + i + " minuti.\nqGl(g) rimasto:\n" + qGl + "\nBatteri:\n" + pI);
        }

        #endregion
    }
}
