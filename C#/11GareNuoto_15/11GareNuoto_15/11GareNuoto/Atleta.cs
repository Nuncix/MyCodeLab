using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11GareNuoto
{
    class Atleta
    {
        #region Attributi

        private uint id;
        private string name;
        private double sec;
        private int min;
        private string spec;

        #endregion

        #region Costruttore

        public Atleta(uint id, string name, double sec, int min, string spec)
        {
            this.id = id;
            this.name = name;
            this.sec = sec;
            this.min = min;
            this.spec = spec;
        }

        #endregion

        #region Get&Set

        public double GetSec()
        {
            return sec;
        }
        public uint GetID()
        {
            return id;
        }
        public int GetMin()
        {
            return min;
        }
        public string GetSpec()
        {
            return spec;
        }
        public string GetName()
        {
            return name;
        }

        #endregion

        #region Metodi



        #endregion
    }
}
