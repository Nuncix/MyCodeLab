using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10RailWay_15
{
    public partial class TrPnl : UserControl
    {
        bool free;

        public TrPnl()
        {
            InitializeComponent();
            free = false;
        }

        #region Get&Set

        public TextBox GetTxtBx()
        {
            return txtTr;
        }

        public void SetTxtBx(TextBox txtTr)
        {
            this.txtTr = txtTr;
        }

        public Label GetLabel()
        {
            return lbl1;
        }

        public void SetLabel(Label lbl1)
        {
            this.lbl1 = lbl1;
        }

        public void SetFree(bool free)
        {
            this.free = free;
        }

        #endregion

        #region methods

        public void ChInRun(int i)
        {
            if (!free)
            {
                lbl1.ForeColor = Color.Red;
                txtTr.Text = "Treno " + i;
            }
            else
            {
                lbl1.ForeColor = Color.LimeGreen;
                txtTr.Text = "Libero";
            }
        }

        #endregion
    }
}
