using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class pracownik : osoba
    {
        public enum Stanowisko { zwykły_pracownik = 1, kierownik = 2 };

        private string identyfikator;
        private Stanowisko stanowisko;

        public string Identyfikator { get => identyfikator; set => identyfikator = value; }
        internal Stanowisko Stanowisko1 { get => stanowisko; set => stanowisko = value; }

        #region konstruktory
        public pracownik()
        {
        }

        public pracownik(string identyfikator)
        {
            Identyfikator = identyfikator ?? throw new ArgumentNullException(nameof(identyfikator));
        }

        public pracownik(string identyfikator, Stanowisko stanowisko) : this(identyfikator)
        {
            this.stanowisko = stanowisko;
        }

        public pracownik(string imie, string nazwisko, string pESEL)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
        }
        public pracownik(string imie, string nazwisko, string pESEL, string identyfikator, Stanowisko stanowisko)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
            Identyfikator = identyfikator ?? throw new ArgumentNullException(nameof(identyfikator));
        }
        #endregion

        public override string ToString()
        {
            Console.WriteLine("Zalogowano jako pracownik.\n");

            return "Identyfikator  : " + this.identyfikator +"\nStanowisko: " + stanowisko +  base.ToString();
        }
    }
}
