using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace po_projekt
{
    public class klienci
    {
        int liczba_klientów;
        public List<klient> Klienci = new List<klient>();

        public int Liczba_klientów { get => liczba_klientów; set => liczba_klientów = value; }

        public void Dodaj(klient k)
        {
            Klienci.Add(k);
            Liczba_klientów++;
        }
        public void Usuń(klient k)
        {
            Klienci.Remove(k);
            Liczba_klientów--;
        }
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
        public void Zapisz_Klientów_XML(string nazwa, klienci k)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(klienci));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, k);
            writer.Close();
        }

        public object Odczytaj_Klientów_XML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(klienci));
            StreamReader reader = new StreamReader(nazwa);
            klienci k = serializer.Deserialize(reader) as klienci;
            reader.Close();
            return k;
        }


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