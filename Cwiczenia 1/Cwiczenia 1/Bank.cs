using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_1
{
    class Bank
    {
        public string Nazw;
        public string NumerKonta;
        private double Fundusze;
        private int id = 0;
        private bool doUsuniecia = false;

        public Bank(string Nazw, string NumerKonta, double Fundusze)
        {
            this.Nazw = Nazw;
            this.NumerKonta = NumerKonta;
            this.Fundusze = Fundusze;
            id++;
        }

        public void wplac(double kwota)
        {
            if (kwota > 0)
                Fundusze += kwota;
            else
                Console.WriteLine("Nie wplacamy ujemnych monet coleszko");
        }

        public void wyplac(double kwota)
        {
            if (kwota <= Fundusze)
                Fundusze -= kwota;
            else
                Console.WriteLine("Brak wystarczajacej ilosci srodkow na koncie");
        }

        private void usun()
        {
            if (Fundusze == 0)
                doUsuniecia = true;
            else
                Console.WriteLine("Nie wolno. Masz jeszcze piniadze na koncie");
        }

        private void potwierdzUsun()
        {
            if (doUsuniecia == true)
            {
                Nazw = "";
                NumerKonta = "";
            }
        }

        private void zmienFundusze(double odsetki)
        {
            Fundusze *= (100 + odsetki);
        }
    }
}
