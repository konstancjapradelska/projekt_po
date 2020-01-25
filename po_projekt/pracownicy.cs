using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class pracownicy
    {
        public List<pracownik> Pracownicy = new List<pracownik>();
        public void Dodaj(pracownik p)
        {
            Pracownicy.Add(p);
        }
        public virtual void Usuń(pracownik p)
        {
            Pracownicy.Remove(p);
        }

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