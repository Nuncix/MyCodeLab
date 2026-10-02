using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _05Reparti_15
{
    class Linee
    {

        #region attributi

        private ushort nLinea;
        private double prodMax;
        private double prodH;
        private uint pezziProd=0;

        #endregion

        #region costruttori

        public Linee(ushort nLinea, double prodMax) 
        {
            this.nLinea = nLinea;
            this.prodMax = prodMax;
            prodH = prodMax - ((10 * prodMax) / 100);
        }

        #endregion

        #region metodi

        public uint GetpezziProd()
        { 
            return pezziProd;
        }

        public void Produci()
        {
            ushort nOrePassate = 0;
            ushort nCambioTurni = 3;
            while (nOrePassate < 9)
            {
                CambioTurno(ref nCambioTurni, nOrePassate);
                pezziProd += (UInt32)prodH;
                Thread.Sleep(200);
                Console.WriteLine("Linea n° " + nLinea + " ha prodotto: " + prodH + " pezzi nella "+(nOrePassate+1)+"° ora.");
                RandomEvnt();
                nOrePassate++;
            }
            Thread.Sleep(800);
            Console.WriteLine("\n=======================================================\nLinea n° " + nLinea + " ha prodotto: " + pezziProd + " pezzi totali.\n=======================================================\n");
        }

        private void CambioTurno(ref ushort nCambioTurni, ushort nOrePassate) 
        {
            if (nCambioTurni > 0) 
            {
                if ((nOrePassate % 3) == 0)
                {
                    prodH = prodMax - ((30 * prodMax) / 100);
                    nCambioTurni--;
                }
                if (((nOrePassate - 1) % 3) == 0)
                {
                    prodH = prodMax + ((30 * prodMax) / 100);
                }
            }
        }

        private void RandomEvnt() 
        {
            Random r = new Random(nLinea);
            if (((prodH * 100) / prodMax) < 50) prodH = prodH + ((r.Next(0, 20) * prodMax) / 100);
            else prodH = prodH - ((r.Next(0, 20) * prodMax) / 100);
        }

        #endregion
    }
}
