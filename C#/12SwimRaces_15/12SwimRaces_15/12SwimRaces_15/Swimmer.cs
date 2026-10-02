using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12SwimRaces_15
{
    class Swimmer
    {
        #region Attributi

        private string name;
        private string fName;
        private DateTime bDate;

        #endregion

        #region Costruttore

        public Swimmer(string name, string fName, DateTime bDate)
        {
            this.name = name;
            this.fName = fName;
            this.bDate = bDate;
        }

        #endregion

        #region Get&Set

        public DateTime GetBDate()
        {
            return bDate;
        }
        public string GetFName()
        {
            return fName;
        }
        public string GetName()
        {
            return name;
        }

        #endregion

        #region Metodi

        public override string ToString()
        {
            return name+" "+fName+ " "+bDate.ToString("dd/MM/yyyy");
        }

        #endregion
    }

    static class Race 
    {
        static string[] styles = {"Delfino", "Dorso", "Rana", "Stile Libero", "Misti"};
        static int[] distances = { 50, 100, 200, 400, 800, 1500, 5000, 10000, 25000 };
        static int[,] races = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 0 }, { 1, 1 }, { 1, 2 }, { 2, 0 }, { 2, 1 }, { 2, 2 }, { 3, 0 }, { 3, 1 }, { 3, 2 }, { 3, 3 }, { 3, 4 }, { 3, 5 }, { 3, 6 }, { 3, 7 }, { 3, 8 }, { 4, 1 }, { 4, 2 }, { 4, 3 } };

        static public int GetNRaces()
        {
            return races.GetLength(0);
        }

        static public string GetRace(int rcI)
        {
            string s = styles[races[rcI, 0]];
            int m = distances[races[rcI, 1]];
            return s + ", " + m.ToString() + "m";
        }

        static public long GetTypicTime(int rcI)
        {
            return distances[races[rcI, 1]] * 90;
        }


    }

    class Competition
    {
        Swimmer sw;
        DateTime date;
        int race;
        DateTime time;

        public Competition(Swimmer sw, DateTime date, int race, DateTime time) 
        {
            this.sw = sw;
            this.date = date;
            this.race = race;
            this.time = time;
        }

        public Swimmer GetSwimmer() 
        {
            return sw;
        }

        public DateTime GetDate() 
        {
            return date;
        }

        public int GetRace()
        {
            return race;
        }

        public DateTime GetTime()
        {
            return time;
        }
    }

    class CmpByTime : IComparer<Competition>
    {
        public int Compare(Competition cmp1, Competition cmp2)
        {
            int r = 0;
            if (cmp1.GetTime()>=cmp2.GetTime())
                r = 1;
            else
                r = -1;
            return r;
        }
    }

    class CmpByRace : IComparer<Competition>
    {
        public int Compare(Competition cmp1, Competition cmp2)
        {
            int r = 0;
            if (cmp1.GetRace() > cmp2.GetRace()) 
                r = 1;
            if (cmp1.GetRace() < cmp2.GetRace())
                r = -1;
            else
            {
                r = 0;
                if (cmp1.GetRace() >= cmp2.GetRace())
                    r = 1;
                else
                    r = -1;
            }
            return r;
        }
    }
}
