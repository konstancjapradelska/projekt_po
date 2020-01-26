using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    /// <summary>
    /// Klasa porównująca ceny samochodów.
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IComparer{po_projekt.samochody}" />
    class PriceCOMPARATOR : IComparer<samochody>
    {
        /// <summary>
        /// Porównuje dwa obiekty i zwraca tą wartość która jest większa, równa lub większa od tej drugiej.
        /// </summary>
        /// <param name="x">Pierwszy obiekt do porównania.</param>
        /// <param name="y">Drugi obiekt do porównania.</param>
        /// <returns>
        /// Liczba całkowita wskazująca wartości <paramref name="x" /> i <paramref name="y" />, jak pokazano w tabeli.
        /// Wartość
        /// Znaczenie
        /// Mniejszy niż zero
        /// <paramref name="x" /> jest mniejszy niż <paramref name="y" />.
        /// Zero
        /// <paramref name="x" /> równy <paramref name="y" />.
        /// Większy niż zero
        /// <paramref name="x" /> jest większy niż <paramref name="y" />.
        /// </returns>
        public int Compare(samochody x, samochody y)
        {
            if (x != null && y != null)
            {
                return x.Cena1.CompareTo(y.Cena1);
            }
            else
                return 0;
        }
    }
}
