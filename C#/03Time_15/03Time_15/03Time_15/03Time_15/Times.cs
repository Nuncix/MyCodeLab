using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Time_15
{
    class Times
    {
        #region Attributi

        private int[] time = new int[4];

        #endregion

        #region Costruttori

        public Times()
        {
            time[0] = 0;
            time[1] = 0;
            time[2] = 0;
            time[3] = 0;
        }
        public Times(int s)
        {
            time[0] = s;
            time[1] = 0;
            time[2] = 0;
            time[3] = 0;
        }

        public Times(int s, int m)
        {
            time[0] = s;
            time[1] = m;
            time[2] = 0;
            time[3] = 0;
        }

        public Times(int s, int m, int h)
        {
            time[0] = s;
            time[1] = m;
            time[2] = h;
            time[3] = 0;
        }

        public Times(int s, int m, int h, int d)
        {
            time[0] = s;
            time[1] = m;
            time[2] = h;
            time[3] = d;
        }
        public Times(string p)
        {
            int c = CtrlString(p);
            string[] t = p.Split('/');
            for (int i = 0; i <= c; i++)
            {
                time[i] = Convert.ToInt32(t[i]);
            }
        }

        #endregion

        #region Get&Set

        public void Settime(int time, int index)
        {
            this.time[index] = time;
        }
        public void Settime(int[] time)
        {
            this.time = time;
        }
        public int Gettime(int i)
        {
            return time[i];
        }
        public int[] GettimeV()
        {
            return time;
        }

        #endregion

        #region MetodiConversioneTempo
        private void ToSec()
        {
            time[0] += (time[1] * 60) + (time[2] * 3600) + (time[3] * 86400);
            time[1] = 0;
            time[2] = 0;
            time[3] = 0;
        }
        private void SecToMinSec()
        {
            time[3] = 0;
            time[2] = 0;
            time[1] = time[0] / 60;
            time[0] %= 60;
        }
        private void SecToHourMinSec()
        {
            time[3] = 0;
            time[2] = time[0] / 3600;
            time[1] = (time[0] % 3600) / 60;
            time[0] = (time[0] % 3600) % 60;
        }
        private void SecToDayHourMinSec()
        {
            time[3] = time[0] / 86400;
            time[2] = (time[0] % 86400) / 3600;
            time[1] = ((time[0] - (time[0] % 60)) / 60) % 60;
            time[0] %= 60;
        }
        public string ChangeFormat(int type)
        {
            ToSec();
            switch (type)
            {
                case 1:
                    SecToMinSec();
                    return Convert.ToString(time[0]) + '/' + Convert.ToString(time[1]);
                case 2:
                    SecToHourMinSec();
                    return Convert.ToString(time[0]) + '/' + Convert.ToString(time[1]) + '/' + Convert.ToString(time[2]);
                case 3:
                    SecToDayHourMinSec();
                    return Convert.ToString(time[0]) + '/' + Convert.ToString(time[1]) + '/' + Convert.ToString(time[2]) + '/' + Convert.ToString(time[3]); ;
            }
            return Convert.ToString(time[0]);
        }
        private int CtrlString(string x)
        {
            int j = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '/') j++;
            }
            if (j<4 && j>=0) return j;
            return j = 4;
        }
        #endregion
    }
}
