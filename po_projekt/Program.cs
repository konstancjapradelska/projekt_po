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
    /// Klasa opisująca program.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            #region baza samochodow
            oferta Oferta = new oferta();
            samochody s1 = new samochody { Klasa1 = samochody.klasa.A, Podział_cenowy1 = samochody.podział_cenowy.tani, Marka1 = samochody.marka.Fiat, Model1 = "Panda", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback, Rok_produkcji1 = 1999 };
            samochody s2 = new samochody { Klasa1 = samochody.klasa.B, Podział_cenowy1 = samochody.podział_cenowy.popularny, Marka1 = samochody.marka.Opel, Model1 = "Corsa", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback, Rok_produkcji1 = 2000 };
            samochody s3 = new samochody { Klasa1 = samochody.klasa.C, Podział_cenowy1 = samochody.podział_cenowy.popularny, Marka1 = samochody.marka.Kia, Model1 = "Ceed", Silnik1 = samochody.silnik.diesel, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi, Rok_produkcji1 = 2006 };
            samochody s4 = new samochody { Klasa1 = samochody.klasa.C, Podział_cenowy1 = samochody.podział_cenowy.popularny, Marka1 = samochody.marka.Kia, Model1 = "Ceed", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback, Rok_produkcji1 = 2010 };
            samochody s5 = new samochody { Klasa1 = samochody.klasa.D, Podział_cenowy1 = samochody.podział_cenowy.popularny, Marka1 = samochody.marka.Kia, Model1 = "Optima", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi, Rok_produkcji1 = 2002 };
            samochody s6 = new samochody { Klasa1 = samochody.klasa.D, Podział_cenowy1 = samochody.podział_cenowy.popularny, Marka1 = samochody.marka.Kia, Model1 = "Optima", Silnik1 = samochody.silnik.diesel, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan, Rok_produkcji1 = 1995 };
            samochody s7 = new samochody { Klasa1 = samochody.klasa.E, Podział_cenowy1 = samochody.podział_cenowy.sportowy, Marka1 = samochody.marka.BMW, Model1 = "525", Silnik1 = samochody.silnik.diesel, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan, Rok_produkcji1 = 2007 };
            samochody s8 = new samochody { Klasa1 = samochody.klasa.E, Podział_cenowy1 = samochody.podział_cenowy.luksusowy, Marka1 = samochody.marka.BMW, Model1 = "550", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi, Rok_produkcji1 = 2008 };
            samochody s9 = new samochody { Klasa1 = samochody.klasa.E, Podział_cenowy1 = samochody.podział_cenowy.tani, Marka1 = samochody.marka.Citroen, Model1 = "C6", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.fastback, Rok_produkcji1 = 2011 };
            samochody s10 = new samochody { Klasa1 = samochody.klasa.E, Podział_cenowy1 = samochody.podział_cenowy.sportowy, Marka1 = samochody.marka.Porshe, Model1 = "Panamera", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan, Rok_produkcji1 = 2011 };
            samochody s11 = new samochody { Klasa1 = samochody.klasa.G, Podział_cenowy1 = samochody.podział_cenowy.sportowy, Marka1 = samochody.marka.Porshe, Model1 = "Panamera Turbo", Silnik1 = samochody.silnik.hybrydowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan, Rok_produkcji1 = 2019 };

            s1.Wycena();
            s2.Wycena();
            s3.Wycena();
            s4.Wycena();
            s5.Wycena();
            s6.Wycena();
            s7.Wycena();
            s8.Wycena();
            s9.Wycena();
            s10.Wycena();
            s11.Wycena();

            Oferta.Dodaj(s1);
            Oferta.Dodaj(s2);
            Oferta.Dodaj(s3);
            Oferta.Dodaj(s4);
            Oferta.Dodaj(s5);
            Oferta.Dodaj(s6);
            Oferta.Dodaj(s7);
            Oferta.Dodaj(s8);
            Oferta.Dodaj(s9);
            Oferta.Dodaj(s10);
            Oferta.Dodaj(s11);
            oferta.ZapiszXML("zapis.xml", Oferta);
            #endregion
            #region baza pracowników
            pracownik p1 = new pracownik { Imie = "Jan", Nazwisko = "Janowski", Pesel = "82080328496", Identyfikator = "100", Stanowisko1 = pracownik.Stanowisko.kierownik };
            pracownik p2 = new pracownik { Imie = "Beata", Nazwisko = "Jurkiewicz", Pesel = "92102201347", Identyfikator = "101", Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };
            pracownik p3 = new pracownik { Imie = "Anna", Nazwisko = "Dobrowolska", Pesel = "92031507772", Identyfikator = "102", Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };
            pracownik p4 = new pracownik { Imie = "Jakub", Nazwisko = "Grobelczyk", Pesel = " 90070100211", Identyfikator = "103", Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };
            pracownik p5 = new pracownik { Imie = "Wiktor", Nazwisko = "Jagielski", Pesel = " 92031532652", Identyfikator = "104", Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };

            pracownicy Pracownicy = new pracownicy();
            Pracownicy.Dodaj(p1);
            Pracownicy.Dodaj(p2);
            Pracownicy.Dodaj(p3);
            Pracownicy.Dodaj(p4);
            Pracownicy.Dodaj(p5);
            Pracownicy.Zapisz_Pracowników_XML("pracownicy.xml", Pracownicy);
            #endregion
            #region baza klientów
            klient k1 = new klient { Imie = "Witold", Nazwisko = "Adamski", Pesel = "90070142412", Numer_klienta = "200" };
            klient k2 = new klient { Imie = "Paulina", Nazwisko = "Szymańska", Pesel = "92102266738", Numer_klienta = "201" };
            klient k3 = new klient { Imie = "Adam", Nazwisko = "Winnicki", Pesel = "91072235964 K", Numer_klienta = "202" };
            klient k4 = new klient { Imie = "Radosław", Nazwisko = "Leszczyński", Pesel = "93112225023", Numer_klienta = "203" };
            klient k5 = new klient { Imie = "Błażej", Nazwisko = "Tomaszewski", Pesel = "92051613915", Numer_klienta = "204" };

            klienci Klienci = new klienci();
            Klienci.Dodaj(k1);
            Klienci.Dodaj(k2);
            Klienci.Dodaj(k3);
            Klienci.Dodaj(k4);
            Klienci.Dodaj(k5);

            Klienci.Zapisz_Klientów_XML("klienci.xml", Klienci);
            #endregion

            string opcja;
            do
            {
                Console.WriteLine("                                     MENU\n\n  ");
                Console.WriteLine("Proszę wybrać opcję :\n");
                Console.WriteLine("Jestem klientem : k");
                Console.WriteLine("Jestem pracownikiem : p");
                Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec\n");
                opcja = Console.ReadLine();
                if (opcja == "k")
                {
                    Console.WriteLine("Wybrano opcję : klient");
                    klient k = new klient();
                    bool numer=false;
                    do
                    {
                        Console.WriteLine("Proszę o wprowadzenie numeru klienta:");
                        k.Numer_klienta = Console.ReadLine();
                        if (Klienci.sprawdzenie(k))
                        {
                            numer = true;
                            k = Klienci.Pobierz(k.Numer_klienta) as klient;
                            string nazwa = "klient.xml";
                            XmlSerializer serializer = new XmlSerializer(typeof(klient));
                            StreamWriter writer = new StreamWriter(nazwa);
                            serializer.Serialize(writer, k);
                            writer.Close();
                        }
                        else
                            Console.WriteLine("\nWprowadzono niepoprawny numer.\n");
                    }
                    while (numer != true);
                    Console.WriteLine("Zalogowano jako klient:\n" + k);
                    string wybór;
                    do
                    {
                        Console.WriteLine("                                     MENU\n\n");
                        Console.WriteLine("                Jeżeli chcesz wyświetlić naszą ofertę wybierz: oferta");
                        Console.WriteLine("                Jeżeli chcesz zarezerwować samochód wybierz: rezerwuj");
                        Console.WriteLine("                Jeżeli chcesz wypożyczyć samochód wybierz: wypożycz");
                        Console.WriteLine("                Jeżeli chcesz zobaczyć swoją listę aut zarezerwowanych wybierz: lista");
                        Console.WriteLine("                Jeżeli chcesz wyjść wybierz : koniec\n");
                        Console.WriteLine("Twój wybór:");
                        wybór = Console.ReadLine();
                        if (wybór == "oferta")
                        {
                            Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;
                            Console.WriteLine("Wybierz sortowanie:");
                            Console.WriteLine("Jeżeli chcesz sortować po klasie samochodu wybierz: klasa");
                            Console.WriteLine("Jeżeli chcesz sortować po modelu samochodu wybierz: model");
                            Console.WriteLine("Jeżeli chcesz sortować po cenie samochodu wybierz: cena");
                            Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                            string wybór_sortowania;
                            do
                            {
                                wybór_sortowania = Console.ReadLine();
                                if (wybór_sortowania == "klasa")
                                {
                                    Console.WriteLine("SORTOWANIE PO KLASIE:");
                                    Oferta.Sortuj_po_klasie_samochodu();
                                    Console.WriteLine(Oferta);
                                    Console.ReadKey();
                                    break;
                                }
                                else if (wybór_sortowania == "model")
                                {
                                    Console.WriteLine("SORTOWANIE PO MODELU:");
                                    Oferta.Sortuj_po_modelu_samochodu();
                                    Console.WriteLine(Oferta);
                                    Console.ReadKey();
                                    break;
                                }
                                else if (wybór_sortowania == "cena")
                                {
                                    Console.WriteLine("SORTOWANIE PO CENIE:");
                                    Oferta.Sortuj_po_cenie();
                                    Console.WriteLine(Oferta);
                                    Console.ReadKey();
                                    break;
                                }
                                else if (wybór_sortowania == "koniec")
                                    break;
                            }
                            while (wybór_sortowania != "koniec");

                        }
                        else if (wybór == "rezerwuj")
                        {
                            Console.WriteLine("Wybierz samochodów do rezerwacji:");
                            rezerwacja r1 = new rezerwacja();
                            r1.wybór_samochodu_do_rezerwacji(Oferta, k);
                            oferta.ZapiszXML("zapis.xml", Oferta);
                        }
                        else if (wybór == "wypożycz")
                        {
                            Console.WriteLine("Wybierz samochodów do wypożyczenia:");
                            wypożyczanie w1 = new wypożyczanie();
                            w1.wypożycz(w1.wybór_samochodu_do_wypożyczenia(Oferta, k), Oferta);
                            oferta.ZapiszXML("zapis.xml", Oferta);
                        }
                        else if (wybór == "lista")
                        {
                            k.Rezerwacje_klienta(Oferta);
                        }
                        else if (wybór == "koniec")
                            break;
                        else
                        {
                            Console.WriteLine("Nie wybrano żadnej z opcji");
                        }
                    }
                    while (wybór != "koniec");
                }
                else if (opcja == "p")
                {
                    Console.WriteLine("Wybrano opcję : pracownik");
                    pracownik p = new pracownik();
                    bool numer = false;
                    do
                    {
                        Console.WriteLine("Proszę o wprowadzenie identyfikatora:");
                        p.Identyfikator = Console.ReadLine();
                        if (Pracownicy.sprawdzenie(p))
                        {
                            numer = true;
                            p = Pracownicy.Pobierz(p.Identyfikator) as pracownik;
                            string nazwa = "pracownik.xml";
                            XmlSerializer serializer = new XmlSerializer(typeof(pracownik));
                            StreamWriter writer = new StreamWriter(nazwa);
                            serializer.Serialize(writer, p);
                            writer.Close();
                        }
                        else
                            Console.WriteLine("\nWprowadzono niepoprawny identyfikator.\n");
                    }
                    while (numer != true);
                    Console.WriteLine("Proszę o wprowadzenie hasła:");
                    string hasło;
                    do
                    {
                        hasło = Console.ReadLine();
                        if (hasło == "programowanie")
                        {
                            Console.WriteLine("Poprawe hasło, zapraszamy.\n");
                            Console.WriteLine("Zalogowano się do systemu jako:\n" + p);
                            string wybór;
                            do
                            {
                                Console.WriteLine("                                     MENU\n\n");
                                if (p.Stanowisko1 == pracownik.Stanowisko.kierownik)
                                {
                                    Console.WriteLine("                Jeżeli chcesz dodać pracownika wybierz: dodajp");
                                    Console.WriteLine("                Jeżeli chcesz usunąć pracownika wybierz: usuńp");
                                    Console.WriteLine("                Jeżeli chcesz wyśwetlić listę pracowników wybierz: listap");
                                }
                                Console.WriteLine("                Jeżeli chcesz dodać samochód do oferty wybierz: dodaj");
                                Console.WriteLine("                Jeżeli chcesz usunąć samochód z oferty wybierz: usuń");
                                Console.WriteLine("                Jeżeli chcesz wyświetlić naszą ofertę wybierz: oferta");
                                Console.WriteLine("                Jeżeli chcesz wyśwetlić listę klientów wybierz: lista");
                                Console.WriteLine("                Jeżeli chcesz dodać nowego klienta wybierz: dodajk");
                                Console.WriteLine("                Jeżeli chcesz usunąć klienta wybierz: usuńk");
                                Console.WriteLine("                Jeżeli chcesz wyjść wybierz : koniec");
                                Console.WriteLine("Twój wybór:");
                                wybór = Console.ReadLine();
                                if (wybór == "dodaj")
                                {
                                    int k = 1 + Oferta.Ilość_samochodów_do_wypożyczenia;
                                    samochody d = new samochody();
                                    string klasa;
                                    Console.WriteLine("Wprowadź klasę samochodu:\n");
                                    do
                                    {
                                        klasa = Console.ReadLine();
                                        if (klasa == "A")
                                        { d.Klasa1 = samochody.klasa.A; break; }
                                        if (klasa == "B")
                                        { d.Klasa1 = samochody.klasa.B; break; }
                                        if (klasa == "C")
                                        { d.Klasa1 = samochody.klasa.C; break; }
                                        if (klasa == "D")
                                        { d.Klasa1 = samochody.klasa.D; break; }
                                        if (klasa == "E")
                                        { d.Klasa1 = samochody.klasa.E; break; }
                                        if (klasa == "F")
                                        { d.Klasa1 = samochody.klasa.F; break;}
                                        if (klasa == "G")
                                        { d.Klasa1 = samochody.klasa.G; break;}
                                        if (klasa == "H")
                                        { d.Klasa1 = samochody.klasa.H; break;}
                                        if (klasa == "I")
                                        { d.Klasa1 = samochody.klasa.I; break;}
                                        if (klasa == "K")
                                        { d.Klasa1 = samochody.klasa.K; break;}
                                        else
                                            Console.WriteLine("Proszę wybrać klasę A, B, C, D, E, F, G, H, I lub K");
                                    }
                                    while ((klasa != "A") || (klasa != "B") || (klasa != "C") || (klasa != "D") || (klasa != "E") || (klasa != "F") || (klasa != "G") || (klasa != "H") || (klasa != "I") || (klasa != "K"));
                                    string marka;
                                    Console.WriteLine("Wprowadź markę samochodu:\n");
                                    do
                                    {
                                        marka = Console.ReadLine();
                                        if (marka == "Alfa Romeo")
                                        { d.Marka1 = samochody.marka.Alfa_Romeo; break; }
                                        if (marka == "Audi")
                                        { d.Marka1 = samochody.marka.Audi; break; }
                                        if (marka == "BMW")
                                        { d.Marka1 = samochody.marka.BMW; break; }
                                        if (marka == "Chevrolet")
                                        { d.Marka1 = samochody.marka.Chevrolet; break; }
                                        if (marka == "Chrysler")
                                        { d.Marka1 = samochody.marka.Chrysler; break; }
                                        if (marka == "Citroen")
                                        { d.Marka1 = samochody.marka.Citroen; break; }
                                        if (marka == "Fiat")
                                        { d.Marka1 = samochody.marka.Fiat; break; }
                                        if (marka == "Ford")
                                        { d.Marka1 = samochody.marka.Ford; break; }
                                        if (marka == "Honda")
                                        { d.Marka1 = samochody.marka.Honda; break; }
                                        if (marka == "Hyundai")
                                        { d.Marka1 = samochody.marka.Hyundai; break; }
                                        if (marka == "Kia")
                                        { d.Marka1 = samochody.marka.Kia; break; }
                                        if (marka == "Opel")
                                        { d.Marka1 = samochody.marka.Opel; break; }
                                        if (marka == "Porshe")
                                        { d.Marka1 = samochody.marka.Porshe; break; }
                                        if (marka == "Renault")
                                        { d.Marka1 = samochody.marka.Renault; break; }
                                        if (marka == "Skoda")
                                        { d.Marka1 = samochody.marka.Skoda; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać markę: Alfa_Romeo, Audi, BMW, Chevrolet, Chrysler, Citroen, Fiat, Ford, Honda, Hyundai, Kia, Opel, Porshe, Renault lub Skoda");
                                    }
                                    while ((marka != "Alfa Romeo") || (marka != "Audi") || (marka != "BMW") || (marka != "Chevrolet") ||
                                           (marka != "Chrysler") || (marka != "Citroen") || (marka != "Fiat") || (marka != "Ford") ||
                                           (marka != "Honda") || (marka != "Hyundai") || (marka != "Kia") || (marka != "Opel") ||
                                           (marka != "Porshe") || (marka != "Renault") || (marka != "Skoda"));
                                    Console.WriteLine("Wprowadź model:\n");
                                    d.Model1 = Console.ReadLine();
                                    string silnik;
                                    Console.WriteLine("Wprowadź rodzaj silnika:\n");
                                    do
                                    {
                                        silnik = Console.ReadLine();
                                        if (silnik == "benzynowy")
                                        { d.Silnik1 = samochody.silnik.benzynowy; break; }
                                        if (silnik == "diesel")
                                        { d.Silnik1 = samochody.silnik.diesel; break; }
                                        if (silnik == "elektryczny")
                                        { d.Silnik1 = samochody.silnik.elektryczny; break; }
                                        if (silnik == "hybrydowy")
                                        { d.Silnik1 = samochody.silnik.hybrydowy; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać silnik benzynowy, diesel, elektryczny lub hybrydowy");

                                    }
                                    while (silnik != "benzynowy" || silnik != "diesel" || silnik != "elektryczny" || silnik != "hybrydowy");
                                    string skrzynia;
                                    Console.WriteLine("Wprowadź rodzaj skrzyni biegów: \n");
                                    do
                                    {
                                        skrzynia = Console.ReadLine();
                                        if (skrzynia == "manualna")
                                        { d.Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna; break; }
                                        if (skrzynia == "automatyczna")
                                        { d.Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać skrzynie biegów automatyczna lub manualna");

                                    }
                                    while (skrzynia != "automatyczna" || skrzynia != "manualna");
                                    string nadwozie;
                                    Console.WriteLine("Wprowadź rodzaj nadwozia:\n");
                                    do
                                    {
                                        nadwozie = Console.ReadLine();
                                        if (nadwozie == "combi")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi; break; }
                                        if (nadwozie == "hatchback")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback; break; }
                                        if (nadwozie == "sedan")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan; break; }
                                        if (nadwozie == "fastback")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.fastback; break; }
                                        if (nadwozie == "coupe")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.coupe; break; }
                                        if (nadwozie == "kabriolet")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.kabriolet; break; }
                                        if (nadwozie == "liftback")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.liftback; break; }
                                        if (nadwozie == "pickup")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.pickup; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać rodzaj nadwozia combi, hatchback, sedan, fastback, coupe, kabriolet, liftback lub pickup");

                                    }
                                    while ((nadwozie != "combi") || (nadwozie != "hatchback") || (nadwozie != "sedan") || (nadwozie != "fastback") || (nadwozie != "coupe") || (nadwozie != "kabriolet") || (nadwozie != "liftback") || (nadwozie != "pickup"));
                                    int rok_produkcji;
                                    Console.WriteLine("Wprowadź rok produkcji: \n");
                                    do
                                    {
                                        rok_produkcji = int.Parse(Console.ReadLine());
                                        if (rok_produkcji > 1900)
                                        { d.Rok_produkcji1 = rok_produkcji; break; }
                                        else
                                            Console.WriteLine("Proszę wprowadzić poprawną datę produkcji samochodu!");
                                    }
                                    while (rok_produkcji <= 1900);
                                    string podział_cenowy;
                                    Console.WriteLine("Wprowadź podział ze względu na cenę:\n");
                                    do
                                    {
                                        podział_cenowy = Console.ReadLine();
                                        if (podział_cenowy == "tani")
                                        { d.Podział_cenowy1 = samochody.podział_cenowy.tani; break; }
                                        if (podział_cenowy == "popularny")
                                        { d.Podział_cenowy1 = samochody.podział_cenowy.popularny; break; }
                                        if (podział_cenowy == "luksusowy")
                                        { d.Podział_cenowy1 = samochody.podział_cenowy.luksusowy; break; }
                                        if (podział_cenowy == "sportowy")
                                        { d.Podział_cenowy1 = samochody.podział_cenowy.sportowy; break; }
                                        if (podział_cenowy == "superluksusowy")
                                        { d.Podział_cenowy1 = samochody.podział_cenowy.superluksusowy; break; }
                                        if (podział_cenowy == "supersportowy")
                                        { d.Podział_cenowy1 = samochody.podział_cenowy.supersportowy; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać podział tani, popularny, luksusowy, sportowy, superluksusowy lub  supersportowy");

                                    }
                                    while (podział_cenowy != "tani" || podział_cenowy != "popularny" || podział_cenowy != "luksusowy" || podział_cenowy != "sportowy" || podział_cenowy != "superluksusowy" || podział_cenowy != "supersportowy");
                                    d.Wycena();
                                    Oferta.Dodaj(d);

                                    oferta.ZapiszXML("zapis.xml", Oferta);
                                }
                                else if (wybór == "usuń")
                                {
                                    Oferta.Usuń(Oferta.wybór_samochodu_do_usunięcia());

                                    oferta.ZapiszXML("zapis.xml", Oferta);
                                }
                                else if (wybór == "oferta")
                                {
                                    Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;
                                    Console.WriteLine("Wybierz sortowanie:");
                                    Console.WriteLine("Jeżeli chcesz sortować po klasie samochodu wybierz: klasa");
                                    Console.WriteLine("Jeżeli chcesz sortować po modelu samochodu wybierz: model");
                                    Console.WriteLine("Jeżeli chcesz sortować po cenie samochodu wybierz: cena");
                                    Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                                    string wybór_sortowania;
                                    do
                                    {
                                        wybór_sortowania = Console.ReadLine();
                                        if (wybór_sortowania == "klasa")
                                        {
                                            Console.WriteLine("SORTOWANIE PO KLASIE:");
                                            Oferta.Sortuj_po_klasie_samochodu();
                                            Console.WriteLine(Oferta);
                                        }
                                        else if (wybór_sortowania == "model")
                                        {
                                            Console.WriteLine("SORTOWANIE PO MODELU:");
                                            Oferta.Sortuj_po_modelu_samochodu();
                                            Console.WriteLine(Oferta);
                                        }
                                        else if (wybór_sortowania == "cena")
                                        {
                                            Console.WriteLine("SORTOWANIE PO CENIE:");
                                            Oferta.Sortuj_po_cenie();
                                            Console.WriteLine(Oferta);
                                        }

                                        else if (wybór_sortowania == "koniec")
                                            break;
                                    }
                                    while (wybór_sortowania != "koniec");
                                }
                                else if (wybór == "listak")
                                {
                                    Console.WriteLine(Klienci);
                                }
                                else if (wybór == "dodajk")
                                {
                                    Klienci.Zapisz_Klientów_XML("klienci.xml", Klienci);
                                }
                                else if (wybór == "usuńk")
                                {
                                    Klienci.Zapisz_Klientów_XML("klienci.xml", Klienci);
                                }
                                if (p.Stanowisko1 == pracownik.Stanowisko.kierownik)
                                {
                                    if (wybór == "dodajp")
                                    {
                                        pracownik p6 = new pracownik();
                                        Console.WriteLine("\nPodaj imie nowego pracownika: ");
                                        p6.Imie = Console.ReadLine();
                                        Console.WriteLine("\nPodaj nazwisko nowego pracownika: ");
                                        p6.Nazwisko = Console.ReadLine();
                                        Console.WriteLine("\nPodaj PESEL nowego pracownika: ");
                                        p6.Pesel = Console.ReadLine();
                                        Console.WriteLine("\nPodaj identyfikator nowego pracownika: ");
                                        p6.Identyfikator = Console.ReadLine();
                                        string stanowisko;
                                        do
                                        {
                                            Console.WriteLine("Podaj stanowisko nowego pracownika: (kierownik lub zwykły_pracownik)");
                                            stanowisko = Console.ReadLine();
                                            if (stanowisko == "kierownik")
                                                p6.Stanowisko1 = pracownik.Stanowisko.kierownik;
                                            else if (stanowisko == "zwykły_pracownik")
                                                p6.Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik;
                                            else
                                                Console.WriteLine("Prosze wybrac : kierownik lub zwykły_pracownik");

                                        }
                                        while (stanowisko != "kierownik" && stanowisko != "zwykły_pracownik");

                                        Pracownicy.Dodaj(p6);
                                    }

                                    if (wybór == "usuńp")
                                    {
                                        Pracownicy.Usuń(Pracownicy.wybór_pracownika_do_usunięcia());
                                    }
                                    if (wybór == "listap")
                                    {
                                        Console.WriteLine(Pracownicy);
                                    }
                                }
                                else if (wybór == "koniec")
                                    break;
                                else
                                {
                                    Console.WriteLine("Nie wybrano żadnej z opcji");
                                }
                            }
                            while (wybór != "koniec");

                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Podano błędne hasło\nSpróbuj jeszcze raz.\n");
                        }
                    }
                    while (hasło != "programowanie");
                }
                else if (opcja == "koniec")
                    break;
                else
                {
                    Console.WriteLine("Proszę wybrać ,k' lub ,p' lub 'koniec'.");
                }
            }
            while (opcja != "koniec");
            Console.ReadKey();
        }

    }

}



