using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polecenia do Samochod.cs
            /*
            List<Samochod> ListaSamochodów = new List<Samochod>();
            Samochod honda = new Samochod("honda", 2);
            Samochod ford = new Samochod("ford", 4);
            Samochod suzuki = new Samochod("suzuki", 3);
            ListaSamochodów.Add(honda);
            ListaSamochodów.Add(ford);
            ListaSamochodów.Add(suzuki);
            honda.Jedz(5);
            honda.Hamuj();
            honda.ileNaLiczniku();
            ford.Jedz(50);
            suzuki.Jedz(30);
            suzuki.Hamuj();
            
            foreach(Samochod i in ListaSamochodów)
            {
                i.wypisz();
            }
            */
            // Polecenia do Samochod.cs

            // Polecenia do KontoBankowe.cs
            /*
            KontoBankowe ing1 = new KontoBankowe("Wojciech", "Senetra", "12345", 1000);
            ing1.Sprawdz();
            ing1.Wplac(100);
            ing1.Sprawdz();
            ing1.Wyplac(600);
            ing1.Sprawdz();
            ing1.Odsetki(10);
            ing1.Sprawdz();
            ing1.UsunKonto();
            */
            // Polecenia do KontoBankowe.cs

            // Polecenia do StandardowyCzlowiek.cs
            /*
            List<StandardowyCzlowiek> lista = new List<StandardowyCzlowiek>();
            StandardowyCzlowiek Wojcia = new StandardowyCzlowiek("Wojciech", 24, "Olsztyn");
            StandardowyCzlowiek Iga = new StandardowyCzlowiek("Igor", 24, "Olsztyn");
            StandardowyCzlowiek Kinia = new StandardowyCzlowiek("Kinga", 23, "Dajtki");
            StandardowyCzlowiek Kasia = new StandardowyCzlowiek("Kasia", 24, "New York");
            StandardowyCzlowiek Andi = new StandardowyCzlowiek("Andrzej", 49, "Łysa Góra");
            lista.Add(Wojcia);
            lista.Add(Iga);
            lista.Add(Kinia);
            lista.Add(Kasia);
            lista.Add(Andi);

            int wybor = -1;

            while (wybor != 0)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Wybierz:");
                Console.WriteLine("1 - Srednia wieku wszystkich obiektow.");
                Console.WriteLine("2 - Wszytkie imiona.");
                Console.WriteLine("3 - Uniwersalne dane czlowieka");
                Console.WriteLine("4 - Najczesciej wystepujace miejsce pochodzenia");
                Console.WriteLine("0 - Wyjscie");
                wybor = Convert.ToInt32(Console.ReadLine());
                if (wybor == 1)
                {

                    int suma = 0;
                    foreach (StandardowyCzlowiek czlowiek in lista)
                    {
                        suma += czlowiek.getWiek();
                    }
                    Console.WriteLine("Srednia wieku wynosi: {0}", suma / lista.Count);
                }
                else if (wybor == 2)
                {
                    foreach (StandardowyCzlowiek czlowiek in lista)
                    {
                        Console.WriteLine(czlowiek.getImie());
                    }
                }
                else if (wybor == 3)
                {
                    Console.WriteLine("Ilosc kosci standardowego czlowieka to " + StandardowyCzlowiek.IloscKosci + ", a ilosc chomosomów to " + StandardowyCzlowiek.IloscChromosomow);

                }
                else if (wybor == 4)
                {
                    Dictionary<string, int> listaNajczestszych = new Dictionary<string, int>();
                    string miejscePochodzenia = "";
                    foreach (StandardowyCzlowiek czlowiek in lista)
                    {
                        miejscePochodzenia = czlowiek.getMiejscePochodzenia();
                        if (listaNajczestszych.Keys.Contains(miejscePochodzenia))
                        {
                            listaNajczestszych[miejscePochodzenia]++;

                        }
                        else
                        {
                            listaNajczestszych.Add(miejscePochodzenia, 1);
                        }
                    }
                    Console.WriteLine(listaNajczestszych.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);
                }
                else if (wybor != 0)
                    Console.WriteLine("Zly wybor.");
            }

            */
            // Polecenia do StandardowyCzlowiek.cs


            Console.ReadKey();
        }
    }
}
