using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _02Poly_15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                try
                {
                    Console.Write("Inserisci quantità monomi: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Monomio[] p = new Monomio[n + 1];
                    Thread[] t = new Thread[n + 1];
                    Console.Write("Inserisci valore dell'incognita: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Inserisci valore di a con x^" + i + ": ");
                        p[i] = new Monomio(Convert.ToInt32(Console.ReadLine()), i, x);
                    }
                    for (int i = 0; i < n; i++)
                    {
                        t[i] = new Thread(p[i].Ris);
                        t[i].Start();
                    }
                    Thread.Sleep(500);
                    Console.WriteLine("Risultato finale: ");
                    Console.WriteLine(p[0].Getr());
                    b = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Inserire valore in forma corretta.");
                }

                Console.ReadKey();
            }
        }
    }
}
