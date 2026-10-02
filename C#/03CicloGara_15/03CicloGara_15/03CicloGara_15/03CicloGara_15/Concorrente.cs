using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _03CicloGara_15
{
    class Concorrente
    {
        #region attributi

        private int nConcorrente = 0;
        private int velocita = 0;
        private int tempo = 0;
        private int spazio = 0;
        private int percorso = 0;

        #endregion

        #region costruttori

        public Concorrente()
        {

        }
        public Concorrente(int nConcorrente, int percorso)
        {
            this.nConcorrente = nConcorrente;
            this.percorso = percorso;
        }

        #endregion

        #region Get&Set

        public void Setvelocita(int velocita)
        {
            this.velocita = velocita;
        }
        public void SetnConcorrente(int nConcorrente)
        {
            this.nConcorrente = nConcorrente;
        }
        public void Settempo(int tempo)
        {
            this.tempo = tempo;
        }
        public void Setspazio(int spazio)
        {
            this.spazio = spazio;
        }
        public int Getvelocita()
        {
            return velocita;
        }
        public int Gettempo()
        {
            return tempo;
        }
        public int Getspazio()
        {
            return spazio;
        }
        public int GetnConcorrente()
        {
            return nConcorrente;
        }

        #endregion

        #region metodi

        public void Gareggia()
        {
            Random r = new Random(Convert.ToInt32(GetnConcorrente()));
            r = new Random(Convert.ToInt32(GetnConcorrente() + r.Next(0, 2929)));
            int p;
            while (spazio <= percorso)
            {
                if (velocita < 20)
                {
                    while (Getvelocita() < 50)
                    {
                        p = r.Next(100, 500);
                        Setvelocita(Getvelocita() + 5);
                        Settempo(Gettempo() + (p / 100));
                        Setspazio(Getvelocita() * Gettempo());
                        Thread.Sleep(p);
                    }
                }
                else
                {
                    while (Getvelocita() > 20)
                    {
                        p = r.Next(100, 500);
                        Setvelocita(Getvelocita() - 5);
                        Settempo(Gettempo() + (p / 100));
                        Setspazio(Getvelocita() * Gettempo());
                        Thread.Sleep(p);
                    }
                }
            }
            Console.WriteLine("Concorrente n° " + GetnConcorrente() + " arrivato in " + Gettempo() + " secondi.");
        }

        #endregion
    }
}
