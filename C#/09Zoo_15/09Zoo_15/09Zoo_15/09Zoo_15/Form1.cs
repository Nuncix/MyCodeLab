using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09Zoo_15
{
    public partial class Form1 : Form
    {
        #region attributi 

        Animale[] animals = new Animale[100];

        #endregion 

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 50; i++)
                cmBxEt.Items.Add(i + 1);

            dGV.ColumnCount = 4;
            dGV.Rows.Add();
            dGV[0, 0].Value = "Animale";
            dGV[1, 0].Value = "Nome";
            dGV[2, 0].Value = "Età";
            dGV[3, 0].Value = "Verso";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CtrlStrng())
                {
                    for (int i = 0; i < animals.Length; i++)
                        if (animals[i] == null)
                        {
                            switch (cmBxAn.Text)
                            {
                                case "Elefante":
                                    animals[i] = new Elefante(Convert.ToInt32(cmBxEt.Text), txtBxNm.Text);
                                    break;

                                case "Lupo":
                                    animals[i] = new Lupo(Convert.ToInt32(cmBxEt.Text), txtBxNm.Text);
                                    break;

                                case "Capra":
                                    animals[i] = new Capra(Convert.ToInt32(cmBxEt.Text), txtBxNm.Text);
                                    break;

                                case "Tigre":
                                    animals[i] = new Tigre(Convert.ToInt32(cmBxEt.Text), txtBxNm.Text);
                                    break;

                                case "Scimmia":
                                    animals[i] = new Scimmia(Convert.ToInt32(cmBxEt.Text), txtBxNm.Text);
                                    break;
                            }
                            dGV.Rows.Add();
                            i = animals.Length;
                        }
                    Display();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore: " + exc);
            }
        }

        private void Display()
        {
            for (int i = 0; i < animals.Length; i++) 
            {
                if (animals[i] != null)
                {
                    dGV[0, i + 1].Value = animals[i].GetAnimal();
                    dGV[1, i + 1].Value = animals[i].GetName();
                    dGV[2, i + 1].Value = animals[i].GetYears();
                    dGV[3, i + 1].Value = animals[i].Verso();
                }
            }
            Conta();
        }

        private void Conta() 
        {
            int[] nAnimals = new int[6];    // indice: 0=Elefante, 1=Lupo, 2=Capra, 3=Tigre, 4=Scimmia.
            string[] animalType = new string[] { "Elefante", "Lupo", "Capra", "Tigre", "Scimmia" };

            for(int j = 0; j <5; j++)
                for (int i = 0; i < animals.Length; i++)
                    if (animals[i] != null && animals[i].GetAnimal() == animalType[j])
                    {
                        nAnimals[j]++;
                        nAnimals[5]++;
                    }
            label4.Text = "Animali totali: " + nAnimals[5] + "\nElefanti: " + nAnimals[0] + "\nLupi: " + nAnimals[1] + "\nCapre: " + nAnimals[2] + "\nTigri: " + nAnimals[3] + "\nScimmie: " + nAnimals[4];
            label4.Visible = true;
        }

        private bool CtrlStrng()
        {
            if (string.IsNullOrEmpty(cmBxAn.Text) || string.IsNullOrEmpty(cmBxEt.Text) || string.IsNullOrWhiteSpace(txtBxNm.Text) || string.IsNullOrEmpty(txtBxNm.Text))
            {
                MessageBox.Show("Inserire attributi animale nelle caselle prima di aggiungere.");
                return false;
            }
            return true;
        }
    }
}
