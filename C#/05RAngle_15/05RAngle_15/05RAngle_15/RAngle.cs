using System;
using System.Collections.Generic;
using System.Text;

namespace _05RAngle_15
{
    class RAngle
    {

        #region attributi

        private int gradi;
        private int secondi;
        private int primi;
        private double radianti;

        #endregion

        #region costruttore

        public RAngle(string grad)
        {

        }
        public RAngle(int gradi, int primi, int secondi)
        {
            this.gradi = gradi;
            this.primi = primi;
            this.secondi = secondi;
            ToRad();
        }
        public RAngle(int gradi, int primi)
        {
            this.gradi = gradi;
            this.primi = primi;
            secondi = 0;
            ToRad();
        }

        public RAngle(int gradi)
        {
            this.gradi = gradi;
            primi = 0;
            secondi = 0;
            ToRad();
        }
        public RAngle(double radianti)
        {
            this.radianti = radianti;
            ToGrad();
        }

        public RAngle()
        {
            gradi = 0;
            primi = 0;
            secondi = 0;
            radianti = 0;
        }

        #endregion

        #region Set&Get

        public void Setgradi(int gradi)
        {
            this.gradi = gradi;
        }
        public int Getgradi()
        {
            return gradi;
        }
        public void Setprimi(int primi)
        {
            this.primi = primi;
        }
        public int Getprimi()
        {
            return primi;
        }
        public void Setsecondi(int secondi)
        {
            this.secondi = secondi;
        }
        public int Getsecondi()
        {
            return secondi;
        }
        public void Setradianti(double radianti)
        {
            this.radianti = radianti;
        }
        public double Getradianti()
        {
            return radianti;
        }

        #endregion

        #region metodi
        public void ToGrad()
        {
            gradi = Convert.ToInt32(Math.Truncate(radianti * 180 / Math.PI));
            primi = Convert.ToInt32(Math.Truncate((radianti * (60 * 180) / Math.PI)));
            secondi = Convert.ToInt32((radianti * (3600 * 180) / Math.PI));
        }
        public void ToGrad(double gradi)
        {
            this.gradi = Convert.ToInt32(Math.Truncate(gradi));
            primi = Convert.ToInt32(Math.Truncate((gradi - this.gradi) * 60));
            secondi = Convert.ToInt32((((gradi - this.gradi) * 60) - primi) * 60);
        }
        public void ToRad(double gradi)
        {
            radianti = ((primi / 60) + (secondi / 3600) + gradi) * (Math.PI / 180);
        }
        public void ToRad()
        {
            radianti = ((primi / 60) + (secondi / 3600) + gradi) * (Math.PI / 180);
        }

        #endregion
    }
}
