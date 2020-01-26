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
    /// Klasa opisująca pracowników.
    /// </summary>
    public class pracownicy
    {
        /// <summary>
        /// Lista pracowników.
        /// </summary>
        public List<pracownik> Pracownicy = new List<pracownik>();
        /// <summary>
        /// Metoda pozwalająca dodać pracownika.
        /// </summary>
        /// <param name="p">Parametr p pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        public void Dodaj(pracownik p)
        {
            Pracownicy.Add(p);
        }
        /// <summary>
        /// Metoda pozwalająca usunąć pracownika.
        /// </summary>
        /// <param name="p">Parametr p pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        public virtual void Usuń(pracownik p)
        {
            Pracownicy.Remove(p);
        }
        /// <summary>
        /// Metoda pozwalająca sprawdzić pracownika (po identyfikatorze).
        /// </summary>
        /// <param name="p">Parametr p pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Klient występuje, bądź nie.</returns>

        public object sprawdzenie(pracownik p)
        {
            pracownik wynik = new pracownik();
            foreach (pracownik element in Pracownicy)
            {
                if (element.Identyfikator == p.Identyfikator)
                {
                    wynik = element;
                }
            }
            return wynik;
        }

        /// <summary>
        /// Wybór pracownika do usunięcia.
        /// </summary>
        /// <returns>Usunięcie pracownika.</returns>
        /// 
        public pracownik wybór_pracownika_do_usunięcia()
        {
            pracownik p = new pracownik();
            string wybór;
            Console.WriteLine("Jeżeli chcesz usunąć danego pracownika wybierz: TAK");
            foreach (pracownik element in Pracownicy)
            {
                Console.WriteLine(element);
                wybór = Console.ReadLine();
                if (wybór == "TAK")
                {
                    p = element;
                    break;
                }
                else continue;
            }

            return p;
        }

        /// <summary>
        /// Zapis Pracowników - XML.
        /// </summary>
        /// <param name="nazwa">Parametr nazwa pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="p">Parametr p pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        public void Zapisz_Pracowników_XML(string nazwa, pracownicy p)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(pracownicy));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, p);
            writer.Close();
        }
        /// <summary>
        /// Odczyt Pracowników - XML.
        /// </summary>
        /// <param name="nazwa">Parametr nazwa pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Zwraca nasz parametr p.</returns>
        public object Odczytaj_Pracowników_XML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(pracownicy));
            StreamReader reader = new StreamReader(nazwa);
            pracownicy p = serializer.Deserialize(reader) as pracownicy;
            reader.Close();
            return p;
        }

        /// <summary>
        /// Wybór pracownika do usunięcia.
        /// </summary>
        /// <returns>Usunięcie pracownika.</returns>
 
        public override string ToString()
        {
            int count = 0;
            foreach (pracownik element in Pracownicy)
            {
                count++;
                Console.WriteLine($"Pracownik #{count}: {element}");
            }
            return "";
        }

    }
}