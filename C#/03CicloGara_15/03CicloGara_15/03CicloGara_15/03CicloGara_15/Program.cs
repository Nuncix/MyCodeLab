using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _03CicloGara_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inserisci numero gareggianti: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Concorrente[] c = new Concorrente[n];
            Thread[] t = new Thread[n];
            Console.Write("Inserisci lunghezza percorso: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                c[i] = new Concorrente(i + 1, x);
                t[i] = new Thread(c[i].Gareggia);
                t[i].Start();
            }
            StampaClassifica(ref c);

            Console.ReadKey();
        }
        private static void StampaClassifica(ref Concorrente[] c)
        {
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            for (int j = 0; j < c.Length; j++)
            {
                for (int i = 0; i < c.Length - 1; i++)
                {
                    if (c[i].Gettempo() > c[i + 1].Gettempo()) Swap(ref c, i, i + 1);
                }
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Al " + (i + 1) + "° posto il concorrente n°" + c[i].GetnConcorrente() + ". Tempo(Secondi): " + c[i].Gettempo());
            }
        }
        private static void Swap(ref Concorrente[] v, int x, int y)
        {
            Concorrente temp = v[x];
            v[x] = v[y];
            v[y] = temp;
            return;
        }
    }
}
