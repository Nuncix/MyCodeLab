using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12SwimRaces_15
{
    public partial class MainForm : Form
    {
        List<Competition> competitions = new List<Competition>();
        Random r = new Random();
        bool[] selRaces;

        public MainForm()
        {
            InitializeComponent();
            pnSwimmer.Top = 80;
        }

        private void btnSwimmer_Click(object sender, EventArgs e)
        {
            DateTime bDate = dTPBirth.Value;
            Swimmer sW = new Swimmer(txtName.Text, txtFName.Text, bDate);
            cbSwimmers.Items.Add(sW);
            pnSwimmer.Visible = false;
        }

        private void cbSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnSwimmer.Visible = false;
            if (cbSwimmers.SelectedIndex == 0) 
            {
                pnSwimmer.BringToFront();
                pnSwimmer.Visible = true;
                txtName.Focus();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            txtFName.SelectAll();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int nRaces = Race.GetNRaces();
            selRaces = new bool[nRaces];
            for (int i = 0; i < nRaces; i++)
            {
                cbRaces.Items.Add(Race.GetRace(i));
                selRaces[i] = false;
            }
        }

        private void btnCmp_Click(object sender, EventArgs e)
        {
            int hh = GetTm(txtH);
            int mm = GetTm(txtM);
            int ss = GetTm(txtS);
            int ms = GetTm(txtC)*10;
            DateTime time = new DateTime(1, 1, 1, hh, mm, ss, ms);
            Swimmer sw = (Swimmer)cbSwimmers.SelectedItem;
            Competition cmp = new Competition(sw, dTPCmp.Value, cbRaces.SelectedIndex, time);
            selRaces[cbRaces.SelectedIndex] = true;
            competitions.Add(cmp);
            DispTime(time);
        }

        private void txtH_DoubleClick(object sender, EventArgs e)
        {
            int t = (int)Race.GetTypicTime(cbRaces.SelectedIndex);
            int dT = (int)t / 4;
            t = r.Next(t - dT, t + dT);
            long lt = (long)t * 100000;
            DateTime time = new DateTime(lt);
            DispTime(time);

            DateTime now = DateTime.Now;
            t = r.Next(6200, (int)(now.Ticks/100000000000000));
            DateTime cD = new DateTime((long)t * 100000000000000);
            dTPCmp.Value = cD;
        }

        private void btnPlacements_Click(object sender, EventArgs e)
        {
            dGVDisplay.Visible = true;
            dGVSwimmer.Visible = false;
            List<Competition> plList = FindAllSelRace(competitions);
            CmpByTime criterion = new CmpByTime();
            plList.Sort(criterion);
            CmpDisplay(plList);
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            dGVDisplay.Visible = false;
            dGVSwimmer.Visible = true;
            List<Competition> swimmerList = FindAllSwCmp(competitions);
            CmpByRace criterion = new CmpByRace();
            swimmerList.Sort(criterion);
            SwDisplay(swimmerList);
        }

        private void cbRaces_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font itF = cbRaces.Font;
            if (selRaces[e.Index])
                itF = new Font(itF, FontStyle.Bold);
            else
                itF = new Font(itF, FontStyle.Regular);
            Brush backgroundColor = SystemBrushes.Window;
            Brush textColor = SystemBrushes.WindowText;
            e.Graphics.FillRectangle(backgroundColor, e.Bounds);
            e.Graphics.DrawString(cbRaces.Items[e.Index].ToString(), itF, textColor, e.Bounds);
        }

        private bool FindCmp(Competition cmp)
        {
            return cmp.GetRace() == cbRaces.SelectedIndex;
        }

        private bool FindSwimmer(Competition cmp)
        {
            return cmp.GetSwimmer() == cbSwimmers.SelectedItem;
        }

        private List<Competition> FindAllSelRace(List<Competition> cmpList)
        {
            Predicate<Competition> criterion = FindCmp;
            List<Competition> results = cmpList.FindAll(criterion);
            return results;
        }

        private List<Competition> FindAllSwCmp(List<Competition> cmpList)
        {
            Predicate<Competition> criterion = FindSwimmer;
            List<Competition> results = cmpList.FindAll(criterion);
            return results;
        }

        private int GetTm(TextBox txtT) 
        {
            int t = 0;
            try
            {
                t = Convert.ToInt16(txtT.Text);
            }
            catch
            {
                txtT.Text = "00";
            }
            return t;
        }

        private void DispTime(DateTime t)
        {
            txtH.Text = t.Hour.ToString("D2");
            txtM.Text = t.Minute.ToString("D2");
            txtS.Text = t.Second.ToString("D2");
            txtC.Text = (t.Millisecond / 10).ToString("D2");
        }

        private void CmpDisplay(List<Competition> cmpList) 
        {
            dGVDisplay.Rows.Clear();
            foreach (Competition cmp in cmpList)
            {
                int r = dGVDisplay.RowCount-1;
                dGVDisplay.Rows.Add();
                dGVDisplay.Rows[r].HeaderCell.Value = r.ToString();
                Swimmer sw = cmp.GetSwimmer();
                dGVDisplay[0, r].Value = sw.GetName();
                dGVDisplay[1, r].Value = sw.GetFName();
                DateTime cDay = cmp.GetDate();
                DateTime cTm = cmp.GetTime();

                dGVDisplay[2, r].Value = cDay.ToString("dd/MM/yyyy");
                dGVDisplay[3, r].Value = cTm.ToString("HH:mm:ss") + ", " + (cTm.Millisecond / 10).ToString("D2");
            }
        }

        private void SwDisplay(List<Competition> cmpList) 
        {
            dGVSwimmer.Rows.Clear();
            foreach (Competition cmp in cmpList)
            {
                int r = dGVSwimmer.RowCount - 1;
                dGVSwimmer.Rows.Add();
                dGVSwimmer.Rows[r].HeaderCell.Value = r.ToString();
                dGVSwimmer[0, r].Value = Race.GetRace(cmp.GetRace());
                dGVSwimmer[1, r].Value = cmp.GetDate().ToString("dd/MM/yyyy");
                dGVSwimmer[2, r].Value = cmp.GetTime().ToString("HH:mm:ss") + ", " + (cmp.GetTime().Millisecond * 10).ToString("D2");
            }
        }
    }
}
