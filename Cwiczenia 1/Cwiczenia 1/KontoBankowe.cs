using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_1
{
    class KontoBankowe
    {

        public string Imie;
        public string Nazwisko;
        public string NrKonta;
        public double Fundusze;
        private int id;

        static int nr = 1;

        public KontoBankowe(string Imie, string Nazwisko, string NrKonta, double Fundusze)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.NrKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.id = nr;
            nr++;
        }

        public void Wplac(double kwota)
        {
            ZmienFundusze(this.Fundusze += kwota);
        }

        private void ZmienFundusze(double fundusze)
        {
            this.Fundusze = fundusze;
        }

        public void UsunKonto()
        {
            if (Fundusze != 0)
                Console.WriteLine("Konto nie jest puste");
            else
                Console.WriteLine("Usunieto");
            
        }
        public void Wyplac(double kwota)
        {
            ZmienFundusze(this.Fundusze -= kwota);
        }

        public void Sprawdz()
        {
            Console.WriteLine("Posiadasz " + Fundusze);
        }

        public void Odsetki(double odsetki)
        {
            this.Fundusze *= (1 + odsetki/100);
        }

    }
}
