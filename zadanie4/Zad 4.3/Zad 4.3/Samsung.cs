using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._3
{
    class Samsung : ITelefon
    {
        public void stworzTelefon()
        {
            Telefon telefon = new Telefon();
            telefon.zalozObudowe("Samsung");
            telefon.wlozEkran("Samsung");
            Console.WriteLine("Stworzono Samsung.");
        }
    }
}
