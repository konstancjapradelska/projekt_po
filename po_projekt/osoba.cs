using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    public abstract class osoba
    {
        private string imie;
        private string nazwisko;
        private string PESEL;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => PESEL; set => PESEL = value; }

        public osoba()
        {
        }

        public osoba(string imie, string nazwisko, string pESEL)
        {
            this.imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            PESEL = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
        }

        public override string ToString()
        {
            return "\nImię:   " + this.imie + "\nNazwisko:   " + this.nazwisko + "\nPesel:   " + this.PESEL;
        }
    }
}
