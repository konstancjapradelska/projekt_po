using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace po_projekt
{
    [XmlInclude(typeof(samochody))]
    
    public class oferta : samochody, IOferta
    {
        public LinkedList<samochody> Oferta = new LinkedList<samochody>();
        public List<samochody> lista;
        public int Ilość_samochodów_do_wypożyczenia = 0;


        public oferta()
        {
        }

        public oferta(LinkedList<samochody> oferta)
        {
            Oferta = oferta ?? throw new ArgumentNullException(nameof(oferta));
        }

        public oferta(LinkedList<samochody> oferta, List<samochody> lista, int ilość_samochodów_do_wypożyczenia) : this(oferta)
        {
            this.lista = lista ?? throw new ArgumentNullException(nameof(lista));
            Ilość_samochodów_do_wypożyczenia = ilość_samochodów_do_wypożyczenia;
        }

        public void Dodaj(samochody s)
        {
            Oferta.AddLast(s);
            Ilość_samochodów_do_wypożyczenia++;
        }

        public virtual void Usuń(samochody s)
        {
            Oferta.Remove(s);
            Ilość_samochodów_do_wypożyczenia--;
        }

        public void Wyczysc()
        {
            Oferta.Clear();
            Ilość_samochodów_do_wypożyczenia = 0;
        }

        public int PodajIlosc()
        {
            Console.WriteLine("Ilość samochodów do wypożyczenia: \n"); 
            return Ilość_samochodów_do_wypożyczenia ;
        }

        public samochody wybór_samochodu_do_usunięcia()
        {
            samochody k = new samochody();
            string wybór;
            foreach (samochody element in Oferta)
            {
                Console.WriteLine("Jeżeli chcesz usunąć to auto wybierz: TAK");
                Console.WriteLine(element);
                wybór = Console.ReadLine();
                if (wybór == "TAK")
                {
                    k = element;
                    
                    break;
                }
                else
                    continue;
            }
            return k;
        }

        public static void ZapiszXML(string nazwa, oferta xmloferta)
        {
            xmloferta.lista = new List<samochody>(xmloferta.Oferta);
            XmlSerializer serializer = new XmlSerializer(typeof(List<samochody>));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, xmloferta.lista);
            writer.Close();
        }

        public object OdczytajXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<samochody>));
            StreamReader reader = new StreamReader(nazwa);
            List<samochody> newlist = new List<samochody>();
            newlist = serializer.Deserialize(reader) as List<samochody>;
            reader.Close();
            oferta xmloferta = new oferta();
            xmloferta.Oferta = new LinkedList<samochody>(newlist);
            foreach( samochody s in xmloferta.Oferta)
            {
                if (s.Rezerwacja == 0)
                    xmloferta.Ilość_samochodów_do_wypożyczenia++;
            }
            return xmloferta;
        }

        public void Sortuj_po_klasie_samochodu()
        {
            lista = new List<samochody>(Oferta);
            lista.Sort();
            Oferta = new LinkedList<samochody>(lista);
        }
        public void Sortuj_po_modelu_samochodu()
        {
            lista = new List<samochody>(Oferta);
            lista.Sort(new ModelCOMPARATOR ());
            Oferta = new LinkedList<samochody>(lista);
        }

        public override string ToString()
        {
            int Ilość_samochodów_zarezerwowanych=0;
            foreach (samochody element in Oferta)
            {
                if (element.Rezerwacja == rezerw.Zarezerwowany)
                    Ilość_samochodów_zarezerwowanych++;
            }
            Console.WriteLine( "OFERTA: \n" + "Ilość samochodów do wypożyczenia: \n" + Ilość_samochodów_do_wypożyczenia + "\nIlość zarezerwowanych samochdów: " + Ilość_samochodów_zarezerwowanych + "\nZawartość: \n");
            int count = 0;
            foreach (samochody element in Oferta)
            {
                count++;
                Console.WriteLine($"Samochód #{count}: {element}");
                if (element.Rezerwacja == rezerw.Zarezerwowany)
                {
                    Console.WriteLine("             Zarezerwowano");
                }
            }

            return "";
        }

    }
}

