using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    /// <summary>
    /// Klasa opsująca wypożyczenia.
    /// </summary>
    /// <seealso cref="po_projekt.oferta" />
    class wypożyczanie : oferta
    {
        /// <summary>
        /// Wypożyczanie samochodu z oferty.
        /// </summary>
        /// <param name="s">Parametr s pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="o">Parametr o pozwala na przekazywanie oraz zwracanie danych z metody.</param>

        public virtual void wypożycz(samochody s, oferta o)
        {
            Console.WriteLine("Wypożyczono samochód:");
            Console.WriteLine(s);
            o.Usuń(s);
        }
        /// <summary>
        /// Wybór samochodu do wypożyczenia.
        /// </summary>
        /// <param name="s">Parametr s pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="K">Parametr K pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Zwraca parametr k.</returns>

        public samochody wybór_samochodu_do_wypożyczenia(oferta s, klient K)
        {
            samochody k = new samochody();
            string wybór;
            foreach (samochody element in s.Oferta)
            {
                if (element.Rezerwacja == rezerw.Zarezerwowany)
                {
                    if (element.Rezerwujacy == K.Numer_klienta)
                    {
                        Console.WriteLine("Jeżeli chcesz wypożyczyć to auto wybierz: TAK");
                        Console.WriteLine(element);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Jeżeli chcesz wypożyczyć to auto wybierz: TAK");
                    Console.WriteLine(element);
                }
                wybór = Console.ReadLine();
                if (wybór == "TAK")
                {
                    k = element;
                    break;
                }
                else
                    continue;
            }
            return k;
        }
    }
}