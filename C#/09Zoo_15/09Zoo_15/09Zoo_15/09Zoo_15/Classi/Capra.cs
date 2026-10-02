using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Zoo_15
{
    class Capra : Animale
    {
        #region costruttori

        public Capra(int years, string name) : base(years, name)
        {
            base.animal = "Capra";
        }

        #endregion

        #region method

        public override string Verso()
        {
            return "Bela";
        }

        #endregion
    }
}
