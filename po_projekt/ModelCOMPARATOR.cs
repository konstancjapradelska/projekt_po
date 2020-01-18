using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class ModelCOMPARATOR : IComparer<samochody>
    {
        public int Compare(samochody x, samochody y)
        {            
            if (x != null && y != null)
            {
                 return x.Model1.CompareTo(y.Model1);
            }
            else
                return 0;
        }
    }
}
