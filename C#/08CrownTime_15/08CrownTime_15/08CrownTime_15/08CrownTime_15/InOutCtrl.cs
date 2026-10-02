using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08CrownTime_15
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


        public void SetLblOut(string txt)
        {
            lblOut.Text = txt;
        }
        
        public void SetLblGl(string txt)
        {
            lblGl.Text = txt;
        }

        public string GetTxtBxGl()
        {
            return txtBxGl.Text;
        }

        public void SetTxtBxGl(string txt)
        {
            txtBxGl.Text = txt;
        }

        public bool GetLblOutVisible()
        {
            return lblOut.Visible;
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
            txtBxGl.ReadOnly = tOf;
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
