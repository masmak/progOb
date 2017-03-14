using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._3
{
    abstract class Pilkarz : Osoba
    {
        protected string pozycja;
        protected string klub;
        protected int liczbaGoli = 0;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko, dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.pozycja = pozycja;
            this.klub = klub;
        }
    }
}
