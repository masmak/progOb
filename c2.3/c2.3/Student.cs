using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._3
{
    class Student : Osoba
    {
        private int rok;
        private int nrIndeksu;
        private int grupa;

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.rok = rok;
            this.nrIndeksu = nrIndeksu;
            this.grupa = grupa;
        }

        public void WypiszInfo() { }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
        public void WypiszOceny(string nazwaPrzedmiotu) { }
        public void WypiszOceny() { }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
        public void UsunOceny() { }
        public void UsunOceny(string nazwaPrzedmiotu) { }

    }
}
