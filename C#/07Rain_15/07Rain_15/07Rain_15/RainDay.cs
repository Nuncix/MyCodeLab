using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _07Rain_15
{
    class RainDay
    {
        #region Attributi

        delegate void assist(int i, double cOut);
        private assist del;

        private double[] rainInDay = new double[365];
        private int[] maxRain = new int[12];
        private string location;
        private double rainMed;
        private InOutCtrl iOCl;

        #endregion

        #region Costruttori

        public RainDay(InOutCtrl iOCl)
        {
            this.iOCl = iOCl;
            location = iOCl.GetTxtBxLoc();
            rainMed = Convert.ToDouble(iOCl.GetTxtBxRain());
            Random r=new Random(location.Length);

            for (int i = 0; i < maxRain.Length; i++) 
            {
                if(i%6==0)
                    maxRain[i] = r.Next(0, (int)rainMed);
                else
                    maxRain[i] = r.Next(0, (int)rainMed);
            }

            del = new assist(Display);
        }

        #endregion

        #region Get&Set

        public void SetRainMed(double rainMed)
        {
            this.rainMed = rainMed;
        }

        public double GetRainMed()
        {
            return rainMed;
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }

        public string GetLocation() 
        {
            return location;
        }

        #endregion

        #region Metodi

        public void Rain() 
        {
            try
            {
                double cOut = 0;
                Random r = new Random(location.Length + (iOCl.Location.X + iOCl.Location.Y));
                for (int i = 0; i < rainInDay.Length; i++)
                {
                    int j = 0;
                    if ((int)(i / 30) >= 12)
                        j = 11;
                    if (r.Next(0, 100) > 50)
                        rainInDay[i] = r.Next(0, maxRain[j]);
                    cOut += rainInDay[i];
                    iOCl.Invoke(del, i, cOut);
                    Thread.Sleep(50);
                }
            }
            catch (ThreadAbortException exAbort)
            {
                if ((string)exAbort.ExceptionState == "Closing")
                    Thread.ResetAbort();
            }
        }

        private void Display(int i, double cOut)
        {
            if(!iOCl.GetLblOutVisible())
                iOCl.ChLblOutVisible();
            iOCl.SetLblOut("Giorno: " + (i + 1) + "\nPioggia: " + rainInDay[i] + "mm.\nMedia giornaliera:\n " + Math.Round(cOut / 365, 2));
        }

        #endregion
    }
}
