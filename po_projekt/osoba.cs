using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    /// <summary>
    /// Klasa opisująca osobę.
    /// </summary>
    public abstract class osoba
    {
        private string imie;
        private string nazwisko;
        private string PESEL;
        /// <summary>
        /// Imie jest zadeklarowane jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Imie jest liczbą.
        /// </summary>
        /// <value>
        /// Imię.
        /// </value>
        public string Imie { get => imie; set => imie = value; }
        /// <summary>
        /// Nazwisko jest zadeklarowane jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Nazwisko jest liczbą.
        /// </summary>
        /// <value>
        /// Nazwisko.
        /// </value>
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        /// <summary>
        /// Pesel jest zadeklarowane jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Pesel jest liczbą.
        /// </summary>
        /// <value>
        /// Pesel.
        /// </value>
        public string Pesel { get => PESEL; set => PESEL = value; }
        /// <summary>
        /// Inicjalizuje nową instancję <see cref="osoba"/> klasy.
        /// </summary>
        public osoba()
        {
        }
        /// <summary>
        /// Inicjalizuje nową instancję <see cref="osoba"/> klasy.
        /// </summary>
        /// <param name="imie">Parametr imie pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="nazwisko">Parametr nazwisko pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="pESEL">Parametr pESEL pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <exception cref="ArgumentNullException"> Wyrzucenie wyjątku 
        /// imie
        /// lub
        /// nazwisko
        /// lub
        /// pESEL
        /// </exception>
        public osoba(string imie, string nazwisko, string pESEL)
        {
            this.imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            PESEL = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
        }
        /// <summary>
        /// Wypisanie osób.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> Wypisuje osoby w podanej postaci.
        /// </returns>
        public override string ToString()
        {
            return "\nImię:   " + this.imie + "\nNazwisko:   " + this.nazwisko + "\nPesel:   " + this.PESEL;
        }
    }
}
