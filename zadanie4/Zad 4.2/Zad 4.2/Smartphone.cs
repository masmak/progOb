using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._2
{
    class Smartphone : Dekorator
    {
        private string rodzaj;


        public Smartphone(ZwyklyTelefon zwyklyTelefon, string rodzaj) : base(zwyklyTelefon)
        {
            this.rodzaj = rodzaj;
            this._zwyklyTelefon = zwyklyTelefon;
        }

        public void zrobZdjecie()
        {
            Console.WriteLine("Pstryk");
        }

        public void pokazTyp()
        {
            Console.WriteLine("Typ telefonu - "+this.rodzaj);
        }

        public void wlaczMuzyke()
        {
            Console.WriteLine("Pfc Kszc Pfc Kszc.");
        }


    }
}
