using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    [Serializable]
    public class samochody : IComparable
    {
        public enum klasa { klasa_A = 1, klasa_B = 2, klasa_C = 3, klasa_D = 4, klasa_E = 5 }
        public enum silnik { benzynowy = 1, diesel = 2 };
        public enum skrzynia_biegów { automatyczna = 1, manualna = 2 }
        public enum rodzaj_nadwozia { combi = 1, hatchback = 2, sedan = 3 }
        public enum rezerw { Zarezerwowany = 1, Niezarezerwowany = 0 };

        private klasa Klasa;
        private string Marka;
        private string Model;
        private silnik Silnik;
        private skrzynia_biegów Skrzynia_Biegów;
        private rodzaj_nadwozia Rodzaj_Nadwozia;
        private rezerw rezerwacja;

        public klasa Klasa1 { get => Klasa; set => Klasa = value; }
        public string Marka1 { get => Marka; set => Marka = value; }
        public silnik Silnik1 { get => Silnik; set => Silnik = value; }
        public skrzynia_biegów Skrzynia_Biegów1 { get => Skrzynia_Biegów; set => Skrzynia_Biegów = value; }
        public rodzaj_nadwozia Rodzaj_Nadwozia1 { get => Rodzaj_Nadwozia; set => Rodzaj_Nadwozia = value; }
        public string Model1 { get => Model; set => Model = value; }
        public rezerw Rezerwacja { get => rezerwacja; set => rezerwacja = value; }

        public samochody()
        {
        }

        public samochody(klasa klasa, string marka, silnik silnik, skrzynia_biegów skrzynia_Biegów, rodzaj_nadwozia rodzaj_Nadwozia)
        {
            Klasa = klasa;
            Marka = marka ?? throw new ArgumentNullException(nameof(marka));
            Silnik = silnik;
            Skrzynia_Biegów = skrzynia_Biegów;
            Rodzaj_Nadwozia = rodzaj_Nadwozia;
            Rezerwacja = rezerw.Niezarezerwowany;
        }

        public int CompareTo(object other)
        {
         
             if (other != null)
             {
                  samochody k = (samochody)other;
                  int cmp = Klasa.CompareTo(k.Klasa);
                  if (cmp != 0)
                      return cmp;
                  else
                      return 0;
             }
             else
                  return 1;
        }

        public override string ToString()
        {
            return "\n" + "             Klasa: " + Klasa + "\n" + "             Marka: " + Marka + "\n" + "             Model: " + Model + "\n" + "             Silnik: " + Silnik + "\n" + "             Skrzynia biegów: " + Skrzynia_Biegów + "\n" + "             Rodzaj nadwozia: " + Rodzaj_Nadwozia;
        }

    }
}


//baza
//dlugosc wypozyczenia
//mozliwosc kupna po terminie wypozyczenia
//rodzaj oferty bez udziału wlasnego w szkodzie