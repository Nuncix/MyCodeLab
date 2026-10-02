using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Zoo_15
{
    class Lupo : Animale
    {
        #region costruttori

        public Lupo(int years, string name) : base(years, name) 
        {
            base.animal = "Lupo";
        }

        #endregion

        #region method

        public override string Verso() 
        {
            return "Ulula";
        }

        #endregion
    }
}
