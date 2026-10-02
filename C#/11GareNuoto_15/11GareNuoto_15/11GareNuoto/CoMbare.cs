using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11GareNuoto
{
    class CoMbare : IComparer<Atleta>
    {
        public int Compare(Atleta at1, Atleta at2) 
        {
            int r = 0;
            if ((at1.GetMin() * 60 + at1.GetSec()) >= (at2.GetMin() * 60 + at2.GetSec())) r = 1;
            else
                if ((at1.GetMin() * 60 + at1.GetSec()) < (at2.GetMin() * 60 + at2.GetSec())) r = -1;
            return r;
        }
    }
}
