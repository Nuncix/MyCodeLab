using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04R_Dama_15
{
    public partial class Form1 : Form
    {

        #region variabili

        int[,] m = new int[10,10];
        int cb = 0;
        int cw = 0;
        int b = 2;
        int w = 3;

        #endregion

        public Form1()
        {
            InitializeComponent();
            InitializationDgv();
        }
        public void InitializationDgv()
        {
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            for (int i = 0; i < 8; i++)
            {
                dgvDam.Columns.Add(imageCol);
                imageCol = new DataGridViewImageColumn();
            }
            dgvDam.RowCount = 8;
            dgvDam.ColumnCount = 8;
            bool v = false;
            for (int i = 0; i < dgvDam.RowCount; i++)
            {
                v = !v;
                for (int j = 0; j < dgvDam.RowCount; j++)
                {
                    if (v)
                    {
                        dgvDam[j, i].Value = imgD.Images[0];
                        m[i + 1, j + 1] = 0;
                        v = !v;
                    }
                    else
                    {
                        dgvDam[j, i].Value = imgD.Images[1];
                        m[i + 1, j + 1] = 1;
                        v = !v;
                    }
                }
            }
            dgvDam.RowHeadersWidth = dgvDam.Height / dgvDam.RowCount;
            foreach (DataGridViewRow r in dgvDam.Rows) r.Height = dgvDam.RowHeadersWidth;
        }

        public void Ctrl()
        {
            lstV.Items.Clear();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (m[j, i] == b)
                    {
                        if (m[j + 1, i + 1] == w || m[j + 1, i - 1] == w || m[j - 1, i + 1] == w || m[j - 1, i - 1] == w)
                        {
                            PrintV(j, i);
                        }
                    }
                }
            }
        }

        public void PrintV(int x, int y)
        { lstV.Items.Add(x + "; " + y + " ha vicino una o più pedine bianche."); }

        private void DgvDam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (m[e.ColumnIndex + 1, e.RowIndex + 1] != 1)
            {
                if (rBtnB.Checked)
                {
                    if (cb < 12)
                    {
                        cb++;
                        m[e.RowIndex + 1, e.ColumnIndex + 1] = b;
                        dgvDam[e.ColumnIndex, e.RowIndex].Value = imgD.Images[2];
                    }
                    else MessageBox.Show("Max. 12 pedine.");
                }
                if (rBtnW.Checked)
                {
                    if (cw < 12)
                    {
                        cw++;
                        m[e.RowIndex + 1, e.ColumnIndex + 1] = w;
                        dgvDam[e.ColumnIndex, e.RowIndex].Value = imgD.Images[3];
                    }
                    else MessageBox.Show("Max. 12 pedine.");
                }
            }
        }

        private void BtnCerca_Click(object sender, EventArgs e)
        {
            Ctrl();
        }
    }
}
