using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06Rubrica_15
{
    class Contatto
    {

        #region attributi

        private string name;
        private string number;

        #endregion

        #region costruttori

        public Contatto()
        {

        }
        public Contatto(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        #endregion

        #region Get&Set

        public void Setname(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return name;
        }
        public void Setnumber(string number)
        {
            this.number = number;
        }
        public string Getnumber()
        {
            return number;
        }

        #endregion

        #region metodi


        #endregion
    }
}
