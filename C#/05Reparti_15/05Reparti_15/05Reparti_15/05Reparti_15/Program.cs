using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _05Reparti_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Numero di linee di produzione: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread[] t = new Thread[n];
            Linee[] l = new Linee[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Produzione massima per la linea " + (i + 1) + ": ");
                m = Convert.ToInt32(Console.ReadLine());
                l[i] = new Linee(Convert.ToUInt16(i + 1), Convert.ToUInt32(m));
            }
            for (int i = 0; i < n; i++)
            {
                t[i] = new Thread(l[i].Produci);
                t[i].Start();
            }
            int p = 0;
            for (int i = 0; i < n; i++) 
            {
                while (t[i].IsAlive) ; 
                p += Convert.ToInt32(l[i].GetpezziProd());
            }
            Console.WriteLine("Pezzi prodotti dal reparto: " + p);
            Console.ReadKey();
        }
    }
}
