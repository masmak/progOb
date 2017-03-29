using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._2
{
    class ZwyklyTelefon : ITelefon
    {
        public void wybierzNumer()
        {
            Console.WriteLine("*Sygnał*");
        }
        public void wyslijWiadomosc()
        {
            Console.WriteLine("SMS");
        }
        public void pokazTyp()
        {
            Console.WriteLine("Typ telefonu - Zwykły Telefon.");
        }
    }
}
