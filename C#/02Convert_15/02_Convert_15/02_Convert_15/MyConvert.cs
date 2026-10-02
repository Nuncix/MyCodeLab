using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Converti_15
{
    class MyConvert
    {
        #region attributi

        private int bI;
        private int bF;

        #endregion

        #region costruttori

        public MyConvert()
        {
            bI = 0;
            bF = 0;
        }
        public MyConvert(int bI, int bF)
        {
            this.bI = bI;
            this.bF = bF;
        }

        #endregion

        #region Get&Set

        public void SetbI(int bI)
        { this.bI = bI; }

        public void SetbF(int bF)
        { this.bF = bF; }

        public int GetbI()
        { return bI; }

        public int GetbF()
        { return bF; }

        #endregion

        #region metodo Convert

        public string ConvertR(int x)
        {
            try
            {
                string d = "0123456789ABCDEF";
                string r = "";
                while (x > 0)
                {
                    r = d[x % bF] + r;
                    x /= bF;
                }
                return r;
            }
            catch (OverflowException)
            {
                return "Numero troppo grande.";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string ConvertR(string x)
        {
            try
            {
                int c = 0;
                string d = "0123456789ABCDEF";
                int r = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = 0; j < bI; j++)
                    {
                        if (x[i] == d[j])
                        {
                            r += j * Convert.ToInt32(Math.Pow(Convert.ToDouble(bI), Convert.ToDouble(x.Length - 1 - i)));
                            c++;
                        }
                    }
                }
                if (c == x.Length) return ConvertR(r);
                else return "Numero non valido.";
            }
            catch (OverflowException)
            {
                return "Numero troppo grande.";
            }
            catch (Exception)
            {
                return "";
            }
        }

        #endregion
    }
}
