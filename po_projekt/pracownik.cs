using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    /// <summary>
    /// Klasa opisująca pracownika.
    /// </summary>
    /// <seealso cref="po_projekt.osoba" />
    public class pracownik : osoba
    {
        public enum Stanowisko { zwykły_pracownik = 1, kierownik = 2 }
        private string identyfikator;
        private Stanowisko stanowisko;
        /// <summary>
        /// Identyfikator jest zadeklarowany jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Identyfikatora jest liczbą.
        /// </summary>
        /// <value>
        /// Identyfikator.
        /// </value>
        public string Identyfikator { get => identyfikator; set => identyfikator = value; }
        /// <summary>
        /// Stanowisko jest zadeklarowane jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Stanowiska jest liczbą.
        /// </summary>
        /// <value>
        /// Stanowisko.
        /// </value>
        internal Stanowisko Stanowisko1 { get => stanowisko; set => stanowisko = value; }

        #region konstruktory
        /// <summary>
        /// Inicjalizuje nową instancje <see cref="pracownik"/> klasy.
        /// </summary>
        public pracownik()
        {
        }
        /// <summary>
        /// Inicjalizuje nową instancje <see cref="pracownik"/> klasy.
        /// </summary>
        /// <param name="identyfikator">Parametr identyfikator pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <exception cref="ArgumentNullException">Wyrzucenie wyjątku identyfikator.</exception>
        public pracownik(string identyfikator)
        {
            Identyfikator = identyfikator ?? throw new ArgumentNullException(nameof(identyfikator));
        }
        /// <summary>
        /// Inicjalizuje nową instancje <see cref="pracownik"/> klasy.
        /// </summary>
        /// <param name="identyfikator">Parametr identyfikator pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="stanowisko">Parametr stanowisko pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        public pracownik(string identyfikator, Stanowisko stanowisko) : this(identyfikator)
        {
            this.stanowisko = stanowisko;
        }
        /// <summary>
        /// Inicjalizuje nową instacje <see cref="pracownik"/> klasy.
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
        public pracownik(string imie, string nazwisko, string pESEL)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
        }
        /// <summary>
        /// Inicjalizuje nową instacje <see cref="pracownik"/> klasy.
        /// </summary>
        /// <param name="imie">Parametr imie pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="nazwisko">Parametr nazwisko pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="pESEL">Parametr pESEL pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="identyfikator">Parametr identyfikator pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="stanowisko">Parametr parametr pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <exception cref="ArgumentNullException"> Wyrzucenie wyjątku
        /// imie
        /// lub
        /// nazwisko
        /// lub
        /// pESEL
        /// lub
        /// identyfikator
        /// </exception>
        public pracownik(string imie, string nazwisko, string pESEL, string identyfikator, Stanowisko stanowisko)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
            Identyfikator = identyfikator ?? throw new ArgumentNullException(nameof(identyfikator));
        }
        #endregion
        /// <summary>
        /// Wypisanie Pracowników.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> Wypisuje pracowników w podanej postaci.
        /// </returns>
        public override string ToString()
        {
            Console.WriteLine("Zalogowano jako pracownik.\n");

            return "Identyfikator  : " + this.identyfikator + "\nStanowisko: " + stanowisko + base.ToString();
        }
    }
}