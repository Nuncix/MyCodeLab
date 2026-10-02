using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07Rain_15
{
    public partial class InOutCtrl : UserControl
    {
        #region Attributi

        bool running = false;
        public static int startWidth = 120;

        #endregion

        #region Costruttori

        public InOutCtrl()
        {
            InitializeComponent();
        }

        #endregion

        #region Get&Set

        public void SetLblLoc(string txt)
        {
            lblLoc.Text = txt;
        }

        public void SetLblOut(string txt)
        {
            lblOut.Text = txt;
        }

        public string GetTxtBxLoc()
        {
            return txtBxLoc.Text;
        }

        public void SetTxtBxLoc(string txt)
        {
            txtBxLoc.Text = txt;
        }

        public void SetTxtBxRain(string txt)
        {
            txtBxRain.Text = txt;
        }
        
        public bool GetLblOutVisible()
        {
            return lblOut.Visible; 
        }

        public string GetTxtBxRain() 
        {
            return txtBxRain.Text;
        }

        public void SetRunning(bool running)
        {
            this.running = running;
        }

        public bool GetRunning()
        {
            return running;
        }

        public void SetTxtBxesReadOnly(bool tOf)
        {
            txtBxLoc.ReadOnly = tOf;
            txtBxRain.ReadOnly = tOf;
        }

        #endregion

        #region Metodi

        public void ChLblOutVisible()
        {
            lblOut.Visible = !lblOut.Visible;
        }

        #endregion
    }
}
