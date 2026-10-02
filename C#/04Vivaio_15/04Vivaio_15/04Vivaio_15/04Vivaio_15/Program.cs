using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _04Vivaio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inserisci numero Fiori nel vivaio: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Fiore[] c = new Fiore[n];
            Thread[] t = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = new Fiore();
                t[i] = new Thread(c[i].Vivi);
                t[i].Start();
            }

            Console.ReadKey();
            Console.Write("\nCrescita media: " + med(ref c));
            Console.ReadKey();

        }
        static double med(ref Fiore[] n) 
        {
            double m = 0;
            for (int i = 0; i < n.Length; i++)
            {
                m = m + n[i].Getcrescita();
            }
            return m / n.Length;
        }
    }
}
