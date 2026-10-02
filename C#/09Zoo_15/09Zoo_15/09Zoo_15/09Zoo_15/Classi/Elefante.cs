using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Zoo_15
{
    class Elefante : Animale
    {
        #region costruttori

        public Elefante(int years, string name) : base(years, name)
        {
            base.animal = "Elefante";
        }

        #endregion

        #region method

        public override string Verso() 
        {
            return "Barrisce";
        }

        #endregion
    }
}
