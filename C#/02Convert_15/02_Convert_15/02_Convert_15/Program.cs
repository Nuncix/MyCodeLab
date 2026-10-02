using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _02_Convert_15
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _02_Converti_15.Form1());
        }
    }
}
