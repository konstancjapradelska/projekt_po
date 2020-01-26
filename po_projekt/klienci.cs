using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace po_projekt
{
    /// <summary>
    /// Klasa opisująca klientów.
    /// </summary>
    public class klienci
    {
        int liczba_klientów;
        /// <summary>
        /// Lista klientów.
        /// </summary>
        public List<klient> Klienci = new List<klient>();

        /// <summary>
        /// Liczba_klientów jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Liczba_klientów jest liczbą.
        /// </summary>
        /// <value>
        /// Liczba klientów.
        /// </value>
        public int Liczba_klientów { get => liczba_klientów; set => liczba_klientów = value; }

        public object Pobierz(string numer_klienta)
        {
            klient k = new klient();
            foreach(klient element in Klienci)
            {
                if (element.Numer_klienta == numer_klienta)
                    return element;
            }
             return null;
        }
        /// <summary>
        /// Metoda pozwalająca na dodanie klienta.
        /// </summary>
        /// <param name="k">Parametr k pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        public void Dodaj(klient k)
        {
            Klienci.Add(k);
            Liczba_klientów++;
        }
        /// <summary>
        /// Metoda pozwalająca usunąć klienta.
        /// </summary>
        /// <param name="k">Parametr k pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        public void Usuń(klient k)
        {
            Klienci.Remove(k);
            Liczba_klientów--;
        }
        /// <summary>
        /// Sprawdzenie czy występuje podany klient dzięki jego numerowi.
        /// </summary>
        /// <param name="k">Parametr k pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Klient występuje, bądź nie.</returns>

        public bool sprawdzenie(klient k)
        {
            klient wynik = new klient();
            foreach (klient element in Klienci)
            {
                if (element.Numer_klienta == k.Numer_klienta)
                {
                    wynik = element;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Zapis klientów - XML.
        /// </summary>
        /// <param name="nazwa">Parametr nazwa pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="k">Parametr k pozwala na przekazywanie oraz zwracanie danych z metody.</param>

        public void Zapisz_Klientów_XML(string nazwa, klienci k)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(klienci));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, k);
            writer.Close();
        }
        /// <summary>
        /// Odczyt klientów - XML.
        /// </summary>
        /// <param name="nazwa">Parametr nazwa pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Zwraca nasz parametr k.</returns>
        public object Odczytaj_Klientów_XML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(klienci));
            StreamReader reader = new StreamReader(nazwa);
            klienci k = serializer.Deserialize(reader) as klienci;
            reader.Close();
            return k;
        }

        /// <summary>
        /// Wypisanie klientów.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> Wypisuje dodanych klientów w podanej postaci.
        /// </returns>
        public override string ToString()
        {
            int count = 0;
            Console.WriteLine("Liczba klientów: " + liczba_klientów + "\n");
            foreach (klient element in Klienci)
            {
                count++;
                Console.WriteLine($"Klient #{count}: {element}");
            }
            return "";
        }
    }
}