using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Sport_15
{
    class Intervista
    {
        #region attributi

        private string name;
        private string surname;
        private string sport;

        #endregion

        #region Costruttori

        public Intervista(string name, string surname, string sport) 
        {
            this.name = name;
            this.surname = surname;
            this.sport = sport;
        }

        #endregion

        #region Get&Set

        public void Setname(string name)
        {
            this.name = name;
        }
        public void Setsurname(string surname)
        {
            this.surname = surname;
        }
        public void Setsport(string sport)
        {
            this.sport = sport;
        }
        public string Getname()
        {
            return name;
        }
        public string Getsurname()
        {
            return surname;
        }
        public string Getsport()
        {
            return sport;
        }

        #endregion
    }
}
