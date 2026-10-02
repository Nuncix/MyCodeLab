using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _06FrmRep_15
{
    class Linee
    {

        #region attributi


        private delegate void MyDelegate();
        private MyDelegate del;
        ListView lstVw;

        private ushort nLinea;
        private double prodMax;
        private double prodH=50;
        private uint pezziProd;
        private Random r;

        #endregion

        #region costruttori

        public Linee(ushort nLinea, double prodMax, ListView lstVw)
        {
            this.lstVw = lstVw;
            this.nLinea = nLinea;
            this.prodMax = prodMax;
            prodH = prodMax - ((10 * prodMax) / 100); 
            r = new Random(nLinea);
            del = new MyDelegate(Produci);
        }

        #endregion

        #region metodi

        public uint GetpezziProd()
        {
            return pezziProd;
        }

        public void InvokeMethod()
        {
            lstVw.Invoke(del);
        }

        private void Produci()
        {
            ushort nOrePassate = 0;
            ushort nCambioTurni = 3;
            while (nOrePassate < 9)
            {
                CambioTurno(ref nCambioTurni, nOrePassate);
                pezziProd += (UInt32)prodH;
                lstVw.Items.Add("Linea " + nLinea + " produce " + prodH + " all'ora.");
                RandomEvnt();
                nOrePassate++;
            }
            Thread.Sleep(r.Next(0, 250));
            lstVw.Items.Add("Linea n°" + nLinea + " ha prodotto: " + pezziProd + " pezzi.");
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
            if (((prodH * 100) / prodMax) < 50) prodH = prodH + ((r.Next(0, 20) * prodMax) / 100);
            else prodH = prodH - ((r.Next(0, 20) * prodMax) / 100);
        }

        #endregion
    }
}
