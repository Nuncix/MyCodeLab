using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            lbl.Text = Ctrl();
            lbl.Visible = true;
        }

        public string Ctrl()
        {
            string esp = txtBx.Text;
            string[] p = new string[esp.Length];
            CtrlPar(esp, p);
            esp = "";
            for (int i = 0; i <= p.Length - 1; i++)
            {
                esp += p[i];
            }
            if (esp != "") return esp;
            return "Nessun errore";
        }
        public void Push(string x, string[] p) 
        {
            for (int i = p.Length - 1; i > 0; i--)
            {
                if (p[i] == null | p[i]== "")
                {
                    p[i] = x;
                    return;
                }
            }
        }
        public string Pop(string[] p)
        {
            string r = "";
            for (int i = 0; i <= p.Length - 1; i++)
            {
                if (p[i] != null) 
                {
                    r = p[i];
                    p[i] = null;
                    return r;
                }
            }
            return r;
        }
        public string Top(string[] p)
        {
            for (int i = 0; i <= p.Length - 1; i++)
            {
                if (p[i] != null | p[i] != "") return p[i];
            }
            return "";
        }
        public void CtrlPar(string v, string[] p)
        {
            for (int i = 0; i <= v.Length - 1; i++)
            {
                switch (v[i])
                {
                    case '{':
                        Push("{", p);
                        break;

                    case '[':
                        Push("[", p);
                        break;

                    case '(':
                        Push("(", p);
                        break;

                    case '}':
                        Pop(p);
                        break;

                    case ']':
                        Pop(p);
                        break;

                    case ')':
                        Pop(p);
                        break;
                    
                }
            }
        }
    }
}
