using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11GareNuoto
{
    public partial class FormGare : Form
    {
        #region Attributi

        string[] type = { "100m Stile Libero", "200m Stile Libero", "400m Stile Libero", "100m Dorso", "200m Dorso", "100m Rana", "200m Rana", "100m Farfalla", "200m Farfalla", "200m Misti", "400m Misti" };
        List<Atleta> atList = new List<Atleta>();
        CoMbare mbare = new CoMbare();
        string findStr;
        uint id = 1;

        #endregion

        #region GUI

        public FormGare()
        {
            InitializeComponent();
            for (int i = 0; i < type.Length; i++)
            {
                cmBxSpec.Items.Add(type[i]);
                cmBxVis.Items.Add(type[i]);
            }
            cmBxVis.Text = "Tutti";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtBoxN.Text) && !string.IsNullOrWhiteSpace(txtBoxN.Text)) && (!string.IsNullOrEmpty(cmBxSpec.Text) && !string.IsNullOrWhiteSpace(cmBxSpec.Text)))
            {
                Atleta at = new Atleta(id, txtBoxN.Text, Convert.ToDouble(nUDS.Value), Convert.ToInt32(nUDM.Value), cmBxSpec.Text);
                atList.Add(at);
                id++;
                MCode();
            }
            else
                MessageBox.Show("Errore.\nInserisci correttamente le informazioni.");
        }

        private void cmBxVis_SelectedIndexChanged(object sender, EventArgs e)
        {
            MCode();
        }

        private void FormGare_Resize(object sender, EventArgs e)
        {
            lstV.Width = ActiveForm.Size.Width - 154;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atleta at;
            Random r = new Random((int)id);
            for (int i = 0; i < 5; i++)
            {
                at = new Atleta(id, "Saro Falsaperla", Convert.ToDouble(r.Next(60)), Convert.ToInt32(r.Next(4)), type[r.Next(10)]);
                atList.Add(at);
                id++;
            }
            MCode();
        }

        #endregion

        #region Logic

        private void MCode() 
        {
            findStr = cmBxVis.Text;
            if (findStr == "Tutti")
                Display(atList);
            else
            {
                Display(Find(atList));
            }
        }

        private void Display(List<Atleta> atL)
        {
            lstV.Items.Clear();
            //lstV.Items.Add
            foreach (Atleta P in atL)
            {
                lstV.Items.Add(P.GetID() + " " + P.GetName() + " " + P.GetMin() + " " + P.GetSec() + " " + P.GetSpec());
            }
        }

        private bool FindAt(Atleta pk)
        { 
            return pk.GetSpec() == findStr;
        }

        private List<Atleta> Find(List<Atleta> at)
        {
            Predicate<Atleta> criterion = FindAt;
            List<Atleta> results = atList.FindAll(criterion);
            results.Sort(mbare);
            return results;
        }

        #endregion
    }
}
