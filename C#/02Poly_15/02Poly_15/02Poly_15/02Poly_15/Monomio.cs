using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Poly_15
{
    class Monomio
    {
        #region attributi

        private int a;
        private int x;
        private int potenza;
        private static int r = 0;

        #endregion

        #region costruttore
        
        public Monomio()
        {

        }
        public Monomio(int a, int potenza, int x)
        {
            this.x = x;
            this.a = a;
            this.potenza = potenza;
        }

        #endregion

        #region Get&Set
        
        public void Seta(int a)
        {
            this.a = a;
        }
        public int Geta()
        {
            return a;
        }
        public void Setx(int x)
        {
            this.x = x;
        }
        public int Getx()
        {
            return x;
        }
        public int Getr() 
        {
            return r;
        }

        #endregion

        #region metodi

        public void Ris() 
        {            
            Console.WriteLine("Risultato monomio " + a + "x^" + potenza + ": ");
            switch (potenza) 
            {
                case 0:
                    Console.WriteLine(a);
                    r += a;
                    return;
                case 1:
                    Console.WriteLine(a * x);
                    r += a * x;
                    return;
            }
            if (potenza >= 2)
            {
                Console.WriteLine(a * Pow(x, potenza));
                r += a * Pow(x, potenza);
            }
        }
        private int Pow(int a, int b)
        {
            int c = a;
            for (int i = 0; i < b - 1; i++)
            {
                c = c * a;
            }
            return c;
        }

        #endregion
    }
}
