using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    // <summary>
    /// Klasa opisująca samochody.
    /// </summary>
    /// <seealso cref="System.IComparable" />
    [Serializable]
    public class samochody : IComparable
    {
        public enum marka { Alfa_Romeo, Audi, BMW, Chevrolet, Chrysler, Citroen, Fiat, Ford, Honda, Hyundai, Kia, Porshe, Renault, Skoda, Opel }
        public enum klasa { A = 1, B = 2, C = 3, D = 4, E = 5, F, G, H, I, K }
        // klasy: A = mini, B = małe, C = kompaktowe, D = rodzinne, E = klasa wyższa-średnia, F = limuzyny, G = sportowe, H = kabriolety, I = terenowe, K = vany;
        public enum podział_cenowy { tani = 1, popularny = 2, luksusowy = 3, superluksusowy = 4, sportowy = 5, supersportowy = 6 }
        public enum silnik { benzynowy = 1, diesel = 2, elektryczny, hybrydowy };
        public enum skrzynia_biegów { automatyczna = 1, manualna = 2 }
        public enum rodzaj_nadwozia { combi = 1, hatchback = 2, sedan = 3, fastback = 4, coupe, kabriolet, liftback, pickup }
        public enum rezerw { Zarezerwowany = 1, Niezarezerwowany = 0 };

        private marka Marka;
        private int Cena = 10000;
        public double mnożnik = 1;
        private podział_cenowy Podział_cenowy;
        private int Rok_produkcji;

        private klasa Klasa;
        private string Model;
        private silnik Silnik;
        private skrzynia_biegów Skrzynia_Biegów;
        private rodzaj_nadwozia Rodzaj_Nadwozia;
        private rezerw rezerwacja;
        private string rezerwujacy;

        public int Cena1 { get => Cena; set => Cena = value; }
        public int Rok_produkcji1 { get => Rok_produkcji; set => Rok_produkcji = value; }
        /// <summary>
        /// klasa1 jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość klasa1 jest liczbą.
        /// </summary>
        /// <value>
        /// Klasa.
        /// </value>
        public klasa Klasa1 { get => Klasa; set => Klasa = value; }
        /// <summary>
        /// marka1 jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość marka1 jest liczbą.
        /// </summary>
        /// <value>
        /// Marka.
        /// </value>
        public podział_cenowy Podział_cenowy1 { get => Podział_cenowy; set => Podział_cenowy = value; }
        public marka Marka1 { get => Marka; set => Marka = value; }
        /// <summary>
        /// silniki jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość silniki jest liczbą.
        /// </summary>
        /// <value>
        /// Silniki.
        /// </value>
        public silnik Silnik1 { get => Silnik; set => Silnik = value; }
        /// <summary>
        /// skrzynia_biegów jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość skrzynia_biegów jest liczbą.
        /// </summary>
        /// <value>
        /// Skrzynia biegów.
        /// </value>
        public skrzynia_biegów Skrzynia_Biegów1 { get => Skrzynia_Biegów; set => Skrzynia_Biegów = value; }
        /// <summary>
        /// rodzaj_nadwozia jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość rodzaj_nadwozia jest liczbą.
        /// </summary>
        /// <value>
        /// Rodzaj nadwozia.
        /// </value>
        public rodzaj_nadwozia Rodzaj_Nadwozia1 { get => Rodzaj_Nadwozia; set => Rodzaj_Nadwozia = value; }
        /// <summary>
        /// Model1 jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Model1 jest liczbą.
        /// </summary>
        /// <value>
        /// Model.
        /// </value>
        public string Model1 { get => Model; set => Model = value; }
        /// <summary>
        /// Rezerwacja jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Rezerwacja jest liczbą.
        /// </summary>
        /// <value>
        /// Rezerwacja.
        /// </value>
        public rezerw Rezerwacja { get => rezerwacja; set => rezerwacja = value; }
        /// <summary>
        /// Rezerwujacy jest zadeklarowana jako właściwość, aby metoda dostępu set mogła upewnić się, że wartość Rezerwujacy jest liczbą.
        /// </summary>
        /// <value>
        /// Rezerwujący.
        /// </value>
        public string Rezerwujacy { get => rezerwujacy; set => rezerwujacy = value; }


        /// <summary>
        /// Inicjalizuje nową instancję <see cref="samochody"/> klasy.
        /// </summary>
        public samochody()
        {
        }

        /// <summary>
        /// Inicjalizuje nową instancję <see cref="samochody"/> klasy.
        /// </summary>
        /// <param name="klasa">Parametr klasa pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="podział_cenowy">Parametr podział_cenowy pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="marka">Parametr marka pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="silnik">Parametr silnik pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="skrzynia_Biegów">Parametr skrzynia_Biegów pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <param name="rodzaj_Nadwozia">Parametr rodzaj_Nadwozia pozwala na przekazywanie oraz zwracanie danych z metody..</param>
        /// <param name="rok_produkcji">Parametr rok_produkcji pozwala na przekazywanie oraz zwracanie danych z metody..</param>
        public samochody(klasa klasa, string marka, silnik silnik, skrzynia_biegów skrzynia_Biegów, rodzaj_nadwozia rodzaj_Nadwozia)
        {
            Klasa = klasa;
            Marka1 = Marka;
            Silnik = silnik;
            Skrzynia_Biegów = skrzynia_Biegów;
            Rodzaj_Nadwozia = rodzaj_Nadwozia;
            Rezerwacja = rezerw.Niezarezerwowany;
            Rezerwujacy = null;
        }
        /// <summary>
        /// Oszacowanie ceny samochodu ze względu na uwzględnione parametry (marka, klasa, podział_cenowy)
        /// </summary>
        public void Wycena()
        {
            #region podstawowe_ceny
            if (Marka == marka.Fiat)
                Cena = 20000;
            else if (Marka == marka.Alfa_Romeo)
                Cena = 40000;
            else if (Marka == marka.Audi)
                Cena = 55000;
            else if (Marka == marka.BMW)
                Cena = 70000;
            else if (Marka == marka.Chevrolet)
                Cena = 20000;
            else if (Marka == marka.Chrysler)
                Cena = 10000;
            else if (Marka == marka.Citroen)
                Cena = 23000;
            else if (Marka == marka.Ford)
                Cena = 30000;
            else if (Marka == marka.Honda)
                Cena = 27000;
            else if (Marka == marka.Hyundai)
                Cena = 19000;
            else if (Marka == marka.Kia)
                Cena = 25000;
            else if (Marka == marka.Opel)
                Cena = 34000;
            else if (Marka == marka.Porshe)
                Cena = 90000;
            else if (Marka == marka.Renault)
                Cena = 20000;
            else if (Marka == marka.Skoda)
                Cena = 20000;
            #endregion

            #region podział_cenowy
            if (Podział_cenowy == podział_cenowy.tani)
                mnożnik = 0.6;
            else if (Podział_cenowy == podział_cenowy.popularny)
                mnożnik = 1;
            else if (Podział_cenowy == podział_cenowy.luksusowy)
                mnożnik = 1.5;
            else if (Podział_cenowy == podział_cenowy.superluksusowy)
                mnożnik = 3;
            else if (Podział_cenowy == podział_cenowy.sportowy)
                mnożnik = 2;
            else if (Podział_cenowy == podział_cenowy.supersportowy)
                mnożnik = 4;
            #endregion

            #region klasy
            if (Klasa == klasa.B)
                mnożnik = mnożnik * 0.6;
            else if (Klasa == klasa.C)
                mnożnik = mnożnik * 0.8;
            else if (Klasa == klasa.D)
                mnożnik = mnożnik * 1.1;
            else if (Klasa == klasa.E)
                mnożnik = mnożnik * 1.2;
            else if (Klasa == klasa.F)
                mnożnik = mnożnik * 1.4;
            else if (Klasa == klasa.G)
                mnożnik = mnożnik * 1.6;
            else if (Klasa == klasa.H)
                mnożnik = mnożnik * 1.8;
            else if (Klasa == klasa.I)
                mnożnik = mnożnik * 2.0;
            else if (Klasa == klasa.K)
                mnożnik = mnożnik * 1;
            #endregion

            if (Rok_produkcji >= 1980 && Rok_produkcji < 1990)
                mnożnik *= 0.6;
            else if (Rok_produkcji >= 2000 && Rok_produkcji < 2010)
                mnożnik *= 1;
            else if (Rok_produkcji >= 2010 && Rok_produkcji < 2015)
                mnożnik *= 1.5;
            else if (Rok_produkcji >= 2015 && Rok_produkcji < 2020)
                mnożnik *= 2;

            double cenka = Cena * mnożnik;
            Cena = (int)cenka;
        }

        /// <summary>
        /// Porównanie.
        /// </summary>
        /// <param name="other">Parametr other pozwala na przekazywanie oraz zwracanie danych z metody.</param>
        /// <returns>Zwraca prawdę, bądź fałsz.</returns>
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
        public int ComparePrice(object other)
        {
            samochody k = (samochody)other;
            int cmp = Cena.CompareTo(k.Cena);
            if (cmp < k.Cena)
                return cmp;
            else return 0;
        }
        /// <summary>
        /// Wypisanie samochodów.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> Wypisuje samochody w podanej postaci.
        /// </returns>
        public override string ToString()
        {
            return "\n" + "             Klasa: " + Klasa + "\n" + "             Marka: " + Marka + "\n" + "             Model: " + Model + "\n" + "             Silnik: " + Silnik + "\n" + "             Skrzynia biegów: " + Skrzynia_Biegów + "\n" + "             Rodzaj nadwozia: " + Rodzaj_Nadwozia + "\n" + "             Rok produkcji: " + Rok_produkcji + "\n" + "             Cena: " + Cena;
        }

    }
}
