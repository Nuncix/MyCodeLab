using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _01Counters_15
{
    class Counter
    {
        #region attributi

        private uint count = 0;
        private uint counted = 20;
        private ConsoleColor consoleColor=ConsoleColor.Green;

        #endregion

        #region costruttore

        public Counter(uint count,ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
            this.count = count;
            counted = 1;
        }
        public Counter(uint count)
        {
            consoleColor = ConsoleColor.Green;
            this.count = count;
            counted = 1;
        }
        public Counter()
        {
            consoleColor = ConsoleColor.Green;
            count = 20;
            counted = 1;
        }

        #endregion

        #region Get&Set

        public void Setcounted(uint counted)
        {
            this.counted = counted;
        }
        public uint Getcounted()
        {
            return counted;
        }
        public void Setcount(uint count)
        {
            this.count = count;
        }
        public ConsoleColor GetconsoleColor()
        {
            return consoleColor;
        }
        public void SetconsoleColor(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }
        public uint Getcount()
        {
            return count;
        }

        #endregion

        #region metodi

        public void Counting()
        {
            Random r = new Random(Convert.ToInt32(count));
            while (counted <= count)
            {
                Thread.Sleep(r.Next(0, 200));
                Console.ForegroundColor = consoleColor;
                Console.WriteLine("Numero: " + counted);
                counted++;
            }
            Console.WriteLine("Finito.");
        }

        #endregion
    }
}
