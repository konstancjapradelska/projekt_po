using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
     /// <summary>
     /// Klasa opisująca klienta.
     /// </summary>
     /// <seealso cref="po_projekt.osoba" />

    public class klient : osoba
    {
        private string numer_klienta;

        /// <summary>
        /// Numer_klienta jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Numer_klienta jest liczbą.
        /// </summary>
        /// <value>
        /// Numer klienta.
        /// </value>

        public string Numer_klienta { get => numer_klienta; set => numer_klienta = value; }
        /// <summary>
        /// Inicjalizuje nową instancję <see cref="klient"/> klasy.
        /// </summary>

        public klient()
        {
        }
        /// <summary>
        /// Inicjalizuje nową instację <see cref="klient"/> klasy.
        /// </summary>
        /// <param name="numer_klienta">Parametr numer_klienta pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <exception cref="ArgumentNullException">Wyrzuca wyjątek numer_klienta.</exception>

        public klient(string numer_klienta)
        {
            numer_klienta = numer_klienta ?? throw new ArgumentNullException(nameof(numer_klienta));
        }
        /// <summary>
        /// Inicjalizuje nową instancję <see cref="klient"/> klasy.
        /// </summary>
        /// <param name="imie">Parametr imie pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="nazwisko">Parametr nazwisko pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="pESEL">Parametr pESEL pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <exception cref="ArgumentNullException"> Wyrzuca wyjątek 
        /// imie
        /// lub
        /// nazwisko
        /// lub
        /// pESEL
        /// </exception>

        public klient(string imie, string nazwisko, string pESEL)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
        }
        /// <summary>
        /// Inicjalizuje nową instancję <see cref="klient"/> klasy.
        /// </summary>
        /// <param name="imie">Parametr imie pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="nazwisko">Parametr nazwisko pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="pESEL">Parametr pESEL pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="identyfikator">Parametr identyfikator pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <exception cref="ArgumentNullException"> Wyrzuca wyjątek
        /// imie
        /// lub
        /// nazwisko
        /// lub
        /// pESEL
        /// lub
        /// Numer_klienta
        /// </exception>

        public klient(string imie, string nazwisko, string pESEL, string identyfikator)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
            Numer_klienta = Numer_klienta ?? throw new ArgumentNullException(nameof(Numer_klienta));
        }
        /// <summary>
        /// Rezerwacje klienta.
        /// </summary>
        /// <param name="s">>Parametr s pozwala na przekazywanie oraz zwracanie danych z metody.
        /// </param>

        public void Rezerwacje_klienta(oferta s)
        {
            Console.WriteLine("Twoja lista zarezerwowanych aut");
            foreach (samochody element in s.Oferta)
            {
                if (element.Rezerwujacy == this.Numer_klienta)
                {
                    Console.WriteLine(element);
                }
                else
                {
                    continue;
                }
            }
        }
        public void Wypożyczone_klienta(oferta s)
        {
            Console.WriteLine("Twoja lista wypożyczonych aut");
            foreach (samochody element in s.Oferta)
            {
                if (element.Wypożyczający == this.Numer_klienta)
                {
                    Console.WriteLine(element);
                }
                else
                {
                    continue;
                }
            }
        }
        public void wypożyczenia(oferta s)
        {
            List<samochody> w = new List<samochody>();
            foreach (samochody element in s.Oferta)
            {
                if (element.Wypożyczający == this.Numer_klienta)
                {
                    w.Add(element);
                }
            }

        }

        /// <summary>
        /// Wypisanie klienta.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> Wypisuje klienta w podanej postaci.
        /// </returns>

        public override string ToString()
        {
            return "numer_klienta  : " + this.Numer_klienta + base.ToString();
        }
    }
}