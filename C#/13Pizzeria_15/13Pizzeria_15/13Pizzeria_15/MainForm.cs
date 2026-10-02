using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _13Pizzeria_15
{
    public partial class MainForm : Form
    {
        #region attributi

        List<Pizza> pizzas;
        bool editing;
        uint indexEd;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region UI

        private void MainForm_Load(object sender, EventArgs e)
        {
            pizzas = new List<Pizza>();
            editing = false;
            try
            {
                StreamReader sr = new StreamReader("pizzalist.txt");
                string[] pt = new string[3];
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    if (s == "#")
                    {
                        pnl.Enabled = true;
                        ReadonlyCt(true);
                        pt[0] = sr.ReadLine();
                        pt[1] = sr.ReadLine();
                        pt[2] = sr.ReadLine();
                        pizzas.Add(new Pizza(pt[0], Convert.ToDouble(pt[1]), pt[2]));
                    }
                }
                sr.Close();
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            lsBx.Height = this.Height - 70;
            lsBx.Width = this.Width - 195;
            pnl.Width = this.Width - 195;
            pnl.Height = this.Height - 70;
            txtBxI.Height = this.Height - 197;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((lsBx.SelectedIndex <= pizzas.ToArray().Length && lsBx.SelectedIndex >= 0)&&!editing)
                {
                    Pizza p = pizzas.ToArray()[lsBx.SelectedIndex];
                    txtBxN.Text = p.GetName();
                    txtBxI.Text = string.Join(", ", p.GetIngridients());
                    nUDP.Value = Convert.ToDecimal(p.GetPrize());
                    tSBDel.Enabled = true;
                    tSBEd.Enabled = true;
                }
                else 
                {
                    tSBDel.Enabled = false;
                    tSBEd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex);
            }
        }

        private void tSBAd_Click(object sender, EventArgs e)
        {
            pnl.Enabled = true;
            ReadonlyCt(false);
            txtBxN.Focus();
            txtBxN.Clear();
            txtBxI.Clear();
            nUDP.Value = 0;
        }

        private void tSBSa_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("pizzalist.txt", false);
                foreach (Pizza p in pizzas)
                {
                    sw.WriteLine("#\n" + p.GetName() + "\n" + p.GetPrize().ToString() + "\n" + string.Join(",", p.GetIngridients()));
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex);
            }
        }

        private void tSBEd_Click(object sender, EventArgs e)
        {
            if (lsBx.SelectedIndex <= pizzas.ToArray().Length && lsBx.SelectedIndex >= 0)
            {
                pnl.Enabled = true;
                ReadonlyCt(false);
                editing = true;
                indexEd = (uint)lsBx.SelectedIndex;
            }
        }

        private void tSBDel_Click(object sender, EventArgs e)
        {
            try
            {
                pizzas.RemoveAt(lsBx.SelectedIndex);
                Display();
                txtBxN.Clear();
                txtBxI.Clear();
                nUDP.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex);
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza(txtBxN.Text, (double)nUDP.Value, txtBxI.Text);
            if (editing)
            {
                Pizza[] pAr = pizzas.ToArray();
                pAr[indexEd] = p;
                pizzas = pAr.ToList<Pizza>();
                editing = false;
            }
            else 
            {
                pizzas.Add(p);
            }
            txtBxN.Clear();
            txtBxI.Clear();
            nUDP.Value = 0;
            ReadonlyCt(true);
            Display();
        }

        #endregion

        #region metodi

        private void Display() 
        {
            lsBx.Items.Clear();
            foreach (Pizza p in pizzas) 
            {
                lsBx.Items.Add(p);
            }
        }

        private void ReadonlyCt(bool on) 
        {
            txtBxN.ReadOnly = on;
            txtBxI.ReadOnly = on;
            nUDP.ReadOnly = on;
            nUDP.InterceptArrowKeys = !on;
            btnFin.Enabled = !on;
        }

        #endregion
    }
}
