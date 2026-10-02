using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Zoo_15
{
    class Tigre : Animale
    {
        #region costruttori

        public Tigre(int years, string name) : base(years, name) 
        {
            base.animal = "Tigre";
        }

        #endregion

        #region method

        public override string Verso() 
        {
            return "Ruggisce";
        }

        #endregion
    }
}
