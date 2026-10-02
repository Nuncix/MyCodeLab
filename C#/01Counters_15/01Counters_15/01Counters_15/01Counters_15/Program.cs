using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _01Counters_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1;
            Counter c2;
            bool e = true;
            do
            {
                try
                {
                    Console.Write("Inserire numero prima conta: ");
                    c1 = new Counter(Convert.ToUInt32(Console.ReadLine()), ConsoleColor.Red);
                    Console.Write("Inserire numero seconda conta: ");
                    c2 = new Counter(Convert.ToUInt32(Console.ReadLine()), ConsoleColor.Green);
                    Thread t1 = new Thread(c1.Counting);
                    Thread t2 = new Thread(c2.Counting);
                    t1.Start();
                    t2.Start();
                    e = false;
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Errore.");
                    e = true;
                }
            }
            while (e);
        }
    }
}
