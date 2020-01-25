using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class rezerwacja : oferta, IOferta
    {
        int Ilość_samochodów_zarezerwowanych;


        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }

        public virtual void rezerwuj(samochody s, klient K)
        {
            s.Rezerwacja = rezerw.Zarezerwowany;
            s.Rezerwujacy = K.Numer_klienta;
            Ilość_samochodów_do_wypożyczenia--;
            Ilość_samochodów_zarezerwowanych++;
        }
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
        public override string ToString()
        {
            Console.WriteLine("\nIlość zarezerwowanych samochdów: " + Ilość_samochodów_zarezerwowanych);
            return base.ToString();
        }
    }
}