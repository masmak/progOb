using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._2
{
    public class KontoBankowe
    {
        public string Imie;
        public string Nazwisko;
        public string NrKonta;
        public double Fundusze;
        private int id;
        public string status;

        static int tmp = 1;

        public KontoBankowe(string Imie, string Nazwisko, string NrKonta, double Fundusze)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.NrKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.id = tmp;
            this.status = "Aktywne";
            tmp++;
        }

        public void Wplac(double kwota)
        {
            Zmien(this.Fundusze + kwota);
        }

        private void Zmien(double fundusze)
        {
            this.Fundusze = fundusze;
        }

        public double AktualnyStanKonta()
        {
            return this.Fundusze;
        }
        public void Wyplac(double kwota)
        {
            if (kwota <= this.Fundusze)
                Zmien(this.Fundusze - kwota);
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public void TransferujKwote(double kwota, KontoBankowe konto)
        {
            this.Fundusze -= kwota;
            konto.Wplac(kwota);
        }

    }
}
