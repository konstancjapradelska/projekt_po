using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    /// <summary>
    /// Klasa opisująca rezerwacje.
    /// </summary>
    /// <seealso cref="po_projekt.oferta" />
    /// <seealso cref="po_projekt.IOferta" />
    public class rezerwacja : oferta, IOferta
    {
        int Ilość_samochodów_zarezerwowanych;
        /// <summary>
        ///  Rezerwacja1 jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Rezerwacja1 jest liczbą.
        /// </summary>
        /// <value>
        /// Rezerwacja.
        /// </value>
        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        /// <summary>
        /// Ilość_samochodów_zarezerwowanych1 jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Ilość_samochodów_zarezerwowanych1 jest liczbą.
        /// </summary>
        /// <value>
        /// Ilość samochodów zarezerwowanych.
        /// </value>
        public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }
        /// <summary>
        /// Rezerwacja samochodu przez klienta.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="K">The k.</param>
        public virtual void rezerwuj(samochody s, klient K)
        {
            s.Rezerwacja = rezerw.Zarezerwowany;
            s.Rezerwujacy = K.Numer_klienta;
            Ilość_samochodów_do_wypożyczenia--;
            Ilość_samochodów_zarezerwowanych++;
        }
        /// <summary>
        /// Wybórs the samochodu do rezerwacji.
        /// </summary>
        /// <param name="s">>Parametr s pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="K">>Parametr K pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Wybrany samochód.</returns>
        
        public samochody wybór_samochodu_do_rezerwacji(oferta s, klient K)
        {
            samochody k = new samochody();
            string wybór;
            foreach (samochody element in s.Oferta)
            {
                Console.WriteLine("Jeżeli chcesz zarezerwować to auto wybierz: TAK");
                if (element.Rezerwacja == 0)
                {
                    Console.WriteLine(element);
                    wybór = Console.ReadLine();
                    if (wybór == "TAK")
                    {
                        k = element;
                        rezerwuj(k, K);
                        break;
                    }
                    else
                        continue;
                }
            }
            return k;
        }
        /// <summary>
        /// Wypisanie rezerwacji.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> Wypisuje rezerwacje w podanej postaci.
        /// </returns>
        public override string ToString()
        {
            Console.WriteLine("\nIlość zarezerwowanych samochdów: " + Ilość_samochodów_zarezerwowanych);
            return base.ToString();
        }
    }
}