using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _04Vivaio_15
{
    class Fiore
    {
        #region attributi

        private ushort giorni = 0;      //numero giorni vissuti dal fiore
        private ushort vivo = 0;        //<3 -> vivo / >3 -> mortissimo
        private double crescita = 0;    //cm
        private double acqua = 0;       //ml
        private double concime = 0;     //mg

        #endregion

        #region costruttori

        public Fiore() 
        {

        }

        #endregion

        #region Get&Set

        public double Getcrescita()
        { 
            return crescita;
        }
        public double Getconcime()
        { 
            return concime;
        }
        public double Getacqua()
        { 
            return acqua;
        }
        public void Setcrescita(double crescita)
        { 
            this.crescita = crescita;
        }
        public void Setconcime(double concime)
        { 
            this.concime = concime;
        }
        public void Setacqua(double acqua)
        { 
            this.acqua = acqua;
        }
        public ushort Getvivo()
        {
            return vivo;
        }

        #endregion

        #region metodi

        public void Vivi() 
        {
            while (vivo < 3)
            {
                giorni++;
                if (giorni < 30)
                {
                    AcquaConcime();
                    Cresci();
                    Thread.Sleep(300);
                }
                else 
                {
                    Console.WriteLine("Fiore sopravvissuto per 30 giorni.");
                    return;
                }
            }
            Console.WriteLine("Fiore morto. Lunghezza raggiunta: " + crescita + "\nGiorni vissuti: " + giorni);
            return;            
        }
        private void Cresci()
        {
            double quanto = 0;
            if (Getacqua() >= 50 && Getacqua() <= 200) quanto += 0.1;
            else
            {
                vivo++;
            }
            if (Getconcime() > 0 && Getconcime() <= 15) quanto += 0.2;
            else
            {
                if (Getconcime() > 15)
                {
                    vivo++;
                }
            }
            Setcrescita(Getcrescita() + quanto);
        }
        private void AcquaConcime()
        {
            Random r = new Random();
            r = new Random(Convert.ToInt32(r.NextDouble() * 10));
            Setacqua(r.Next(20, 225));
            Setconcime(r.Next(0, 20));
        }

        #endregion
    }
}
