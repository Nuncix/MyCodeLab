using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Zoo_15
{
    class Animale
    {
        #region attributi

        protected int years;
        protected string name;
        protected string animal;

        #endregion

        #region costruttore

        public Animale(int years, string name)
        {
            this.years = years;
            this.name = name;
        }

        #endregion

        #region Get&Set

        public void SetYears(int years)
        {
            this.years = years;
        }
        public int GetYears()
        {
            return years;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAnimal(string animal)
        {
            this.animal = animal;
        }
        public string GetAnimal()
        {
            return animal;
        }

        #endregion

        #region method

        public virtual string Verso()
        {
            return "'Verso animalesco.'";
        }

        #endregion
    }
}
