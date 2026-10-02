using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Assenze_15
{
    class Assenze
    {
        #region attributi

        private DateTime day = new DateTime();
        private ushort classe = 1;
        private char sezione = 'A';

        #endregion

        #region costruttori

        public Assenze(DateTime day, ushort classe, char sezione) 
        {
            this.day = day;
            this.classe = classe;
            this.sezione = sezione;
        }

        #endregion

        #region Get&Set

        public char GetSezione()
        {
            return sezione;
        }
        public void SetSezione(char sezione)
        {
            this.sezione = sezione;
        }

        public void SetDay(DateTime day)
        {
            this.day = day;
        }
        public int GetDay()
        {
            return day.Day;
        }

        public void SetClasse(ushort classe)
        {
            this.classe = classe;
        }
        public ushort GetClasse()
        {
            return classe;
        }

        #endregion
    }
}
