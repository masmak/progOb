using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_1
{
    class Samochod
    {
        public string Marka;
        public int LiczbaKol;
        public double Predkosc;
        public string Kolor;
        public int Rocznik;

        public Samochod(string Marka, int LiczbaKol)
        {
            Predkosc = 0;
            Kolor = "Czarny";
            Rocznik = 2016;
            this.Marka = Marka;
            this.LiczbaKol = LiczbaKol;
        }

        public void Jedz(double Predkosc)
        {
            if(Predkosc > 0)
            {
                Console.WriteLine(Marka + " jedzie z prędkością " + Predkosc);
            }
        }
        
        public void Hamuj()
        {
            Predkosc = 0;
        }

        public void ileNaLiczniku()
        {
            Console.WriteLine("Na liczniku " + Predkosc);
        }

        public void wypisz()
        {
            Console.WriteLine(Kolor + " samochód marki " + Marka + " jedzie z prędkością " + Predkosc);
            Console.WriteLine("Domyślna ilość kół używanych jednocześnie w samochodzie to " + LiczbaKol);
        }

    }
}
