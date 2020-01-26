using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    /// <summary>
    /// Interfejs Oferty.
    /// </summary>
    interface IOferta
    {
        /// <summary>
        /// Metoda pozwalająca dodać samochód.
        /// </summary>
        /// <param name="s">Parametr s pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        void Dodaj(samochody s);
        /// <summary>
        /// Metoda pozwalająca usunąć samochód.
        /// </summary>
        /// <param name="s">Parametr s pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        void Usuń(samochody s);
        /// <summary>
        /// Wyczyszczenie - ustawienie ilości samochodów do wypożyczenia na 0.
        /// </summary>
        void Wyczysc();
        /// <summary>
        /// Ilość samochodów do wypożyczenia.
        /// </summary>
        /// <returns>Ilość samochodów do wypożyczenia.</returns>
        int PodajIlosc();
    }
}
