using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06Rubrica_15
{
    public partial class Form1 : Form
    {
        Contatto[] contatti = new Contatto[15];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < contatti.Length; i++) contatti[i] = new Contatto();
        }

        #region metodi form

        private void Add(string name, string number)
        {
            for (int i = 0; i <= contatti.Length - 1; i++)
                if (contatti[i].Getname() == null && contatti[i].Getnumber() == null)
                {
                    contatti[i].Setname(name);
                    contatti[i].Setnumber(number);
                    return;
                }
        }

        private void Print() 
        {
            lstVNom.Items.Clear();
            lstVNum.Items.Clear();
            for (int i = 0; i < contatti.Length; i++)
            {
                lstVNom.Items.Add(contatti[i].Getname());
                lstVNum.Items.Add(contatti[i].Getnumber());
            }
        }

        private void Canc(int x) 
        {
            for (int i = 0; i < contatti.Length; i++)
            {
                if (contatti[i].Getname() == null)
                {
                    SwapContatto(ref contatti, x, i - 1);
                    contatti[i - 1] = new Contatto();
                    return;
                }
                if (i == contatti.Length - 1)
                {
                    SwapContatto(ref contatti, x, contatti.Length - 1);
                    contatti[contatti.Length - 1] = new Contatto();
                    return;
                }
            }
        }

        private void SwapContatto(ref Contatto[] v, int x, int y)
        {
            Contatto temp = v[x];
            v[x] = v[y];
            v[y] = temp;
            return;
        }

        #endregion

        #region comandi interfaccia

        private void btnIns_Click(object sender, EventArgs e)
        {
            try
            {
                Add(txtBxNom.Text, txtBxNum.Text);
                Print();
                btnCanc.Enabled = true;
                if (contatti[contatti.Length - 1].Getname() != null)
                {
                    btnIns.Enabled = false;
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
                Canc(lstVNom.FocusedItem.Index);
                Print();
                if (contatti[0].Getname() == null) btnCanc.Enabled = false;
                if (contatti[contatti.Length - 1].Getname() == null) btnIns.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Errore comando elimina. Prova a selezionare il contatto.");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtBxNom.Text = contatti[lstVNom.FocusedItem.Index].Getname();
                txtBxNum.Text = contatti[lstVNom.FocusedItem.Index].Getnumber();
                Canc(lstVNom.FocusedItem.Index);
                Print();
                if (contatti[0].Getname() == null) btnCanc.Enabled = false;
                if (contatti[contatti.Length - 1].Getname() == null) btnIns.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Errore comando Modifica. Prova a selezionare il contatto.");
            }

        }

        #endregion
    }
}
