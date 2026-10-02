using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _01Auto_15
{
    class Auto
    {

        #region attributi

        private bool onOff = false;
        private double vel = 0;

        #endregion

        #region Get&Set

        public void Setvel(double vel)
        {
            this.vel = vel;
        }

        public double Getvel()
        {
            return vel;
        }

        public void SetonOff(bool onOff)
        {
            this.onOff = onOff;
        }

        public bool GetonOff()
        {
            return onOff;
        }

        #endregion

        #region metodi

        public void OnOff()
        {
            onOff = !onOff;
        }

        public void Acceleration(int x)
        {
            while (vel < x && onOff) 
            {
                Setvel(vel + 1);
                Application.DoEvents();
                Thread.Sleep(80);
            }
        }

        public void Brake()
        {
            Setvel(vel - 20);
            if (vel < 0) Setvel(0);
        }

        public void Deceleration()
        {
            Setvel(vel - 5);
            if (vel < 0) Setvel(0);
            Thread.Sleep(100);
        }

        #endregion

        #region costruttori

        public Auto()
        {
 
        }

        #endregion

    }
}
