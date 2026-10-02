using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13Pizzeria_15
{
    class Pizza
    {
        #region attributi

        private string name;
        private string[] ingridients;
        private double prize;

        #endregion

        #region costruttore

        public Pizza(string name, double prize, string ingridients)
        {
            string[] sep = { ",", ".", ":", ";" };
            this.ingridients = ingridients.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            this.name = name;
            this.prize = prize;
        }

        #endregion

        #region Get&Set

        public string GetName()
        {
            return name;
        }
        public string[] GetIngridients()
        {
            return ingridients;
        }
        public double GetPrize()
        {
            return prize;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetIngridients(string ingridients)
        {
            string[] sep = { ",", ".", ":", ";" };
            this.ingridients = ingridients.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        }
        public void SetPrize(double prize)
        {
            this.prize = prize;
        }

        #endregion

        #region metodi

        public override string ToString()
        {
            return GetName();
        }

        #endregion
    }
}
