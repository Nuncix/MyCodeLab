using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Zoo_15
{
    class Scimmia : Animale
    {
        #region costruttori

        public Scimmia(int years, string name) : base(years, name)
        {
            base.animal = "Scimmia";
        }

        #endregion

        #region method

        public override string Verso() 
        {
            return "Urla e farfuglia";
        }

        #endregion
    }
}
