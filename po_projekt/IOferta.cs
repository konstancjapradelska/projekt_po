using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    interface IOferta
    {
        void Dodaj(samochody s);
        void Usuń(samochody s);
        void Wyczysc();
        int PodajIlosc();
    }
}
