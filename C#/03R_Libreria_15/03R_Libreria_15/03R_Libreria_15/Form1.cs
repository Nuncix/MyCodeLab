using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _03R_Libreria_15
{
    public partial class Form1 : Form
    {
        #region Variabili

        string[] isbn = new string[10];
        string[] tit = new string[10];
        int[] npg = new int[10];
        double[] prz = new double[10];

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Logic

        public void Ins(string x, string y, int a, double b)
        {
            for (int i = 0; i <= isbn.Length - 1; i++)
            {
                if (isbn[i] == null)
                {
                    isbn[i] = x;
                    tit[i] = y;
                    npg[i] = a;
                    prz[i] = b;
                    return;
                }
            }
        }

        public void Canc(int x)
        {
            for (int i = 0; i < isbn.Length; i++)
            {
                if (isbn[i] == null)
                {
                    swapString(ref isbn, x, i - 1);
                    swapString(ref tit, x, i - 1);
                    swapInt(ref npg, x, i - 1);
                    swapDouble(ref prz, x, i - 1);
                    isbn[i - 1] = null;
                    tit[i - 1] = null;
                    npg[i - 1] = 0;
                    prz[i - 1] = 0;
                    return;
                }
                if (i == isbn.Length - 1)
                {
                    swapString(ref isbn, x, isbn.Length - 1);
                    swapString(ref tit, x, isbn.Length - 1);
                    swapInt(ref npg, x, isbn.Length - 1);
                    swapDouble(ref prz, x, isbn.Length - 1);
                    isbn[isbn.Length - 1] = null;
                    tit[isbn.Length - 1] = null;
                    npg[isbn.Length - 1] = 0;
                    prz[isbn.Length - 1] = 0;
                    return;
                }
            }
            return;
        }

        public void print()
        {
            lstIsbn.Items.Clear();
            lstTit.Items.Clear();
            lstNpg.Items.Clear();
            lstPrz.Items.Clear();
            for (int i = 0; i < isbn.Length; i++)
            {
                if (npg[i] != 0 && prz[i] != 0)
                {
                    lstIsbn.Items.Add(isbn[i]);
                    lstTit.Items.Add(tit[i]);
                    lstNpg.Items.Add(Convert.ToString(npg[i]));
                    lstPrz.Items.Add(Convert.ToString(prz[i], System.Globalization.CultureInfo.CurrentCulture.NumberFormat) + " €");
                }
            }
            return;
        }

        public double[] rapPrz()
        {
            double[] p = new double[prz.Length];
            for (int i = 0; i < p.Length - 1; i++)
            {
                p[i] = prz[i] / npg[i];
            }
            return p;
        }

        public void bookSort(double[] x)
        {
            for (int j = 0; j <= x.Length - 2; j++)
            {
                for (int i = 0; i <= isbn.Length - 2; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        swapDouble(ref x, i, i + 1);
                        swapString(ref isbn, i, i + 1);
                        swapString(ref tit, i, i + 1);
                        swapInt(ref npg, i, i + 1);
                        swapDouble(ref prz, i, i + 1);
                    }
                }
            }
        }

        public string genIsbn()
        {
            Random r = new Random();
            return Convert.ToString(97912) + Convert.ToString(r.Next(10000000, 90000000));
        }

        public void swapDouble(ref double[] v, int x, int y)
        {
            double temp = v[x];
            v[x] = v[y];
            v[y] = temp;
            return;
        }

        public void swapString(ref string[] v, int x, int y)
        {
            string temp = v[x];
            v[x] = v[y];
            v[y] = temp;
            return;
        }

        public void swapInt(ref int[] v, int x, int y)
        {
            int temp = v[x];
            v[x] = v[y];
            v[y] = temp;
            return;
        }

        #endregion

        #region Graphic Commands

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                Ins(genIsbn(), txtBxTit.Text, Convert.ToInt32(txtBxNpg.Text), Convert.ToDouble(txtBxPrz.Text));
                print();
                btnCanc.Enabled = true;
                btnOrd.Enabled = true;
                if (isbn[isbn.Length - 1] != null)
                {
                    btnIn.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Errore comando inserisci.");
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            try 
            {
                Canc(lstTit.FocusedItem.Index);
                print();
                if (isbn[0] == null)
                {
                    btnCanc.Enabled = false;
                    btnOrd.Enabled = false;
                }
                if (isbn[isbn.Length - 1] == null)
                {
                    btnIn.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Errore comando elimina. Prova a selezionare il titolo del libro.");
            }
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            try
            {
                bookSort(rapPrz());
                print();
            }
            catch
            {
                MessageBox.Show("Errore comando ordina.");
            }
        }

        #endregion

    }
}
