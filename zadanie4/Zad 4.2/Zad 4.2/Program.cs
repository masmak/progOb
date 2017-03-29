using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwyklyTelefon zwyklyTelefon = new ZwyklyTelefon();
            zwyklyTelefon.pokazTyp();
            zwyklyTelefon.wybierzNumer();
            zwyklyTelefon.wyslijWiadomosc();

            Smartphone smartphone = new Smartphone(zwyklyTelefon, "smartphone");
            smartphone.pokazTyp();
            smartphone.wybierzNumer();
            smartphone.wyslijWiadomosc();
            smartphone.zrobZdjecie();
            smartphone.wlaczMuzyke();

            Console.ReadKey();
        }
    }

    public interface ITelefon
    {
        void wybierzNumer();
        void wyslijWiadomosc();
        void pokazTyp();
    }
}
