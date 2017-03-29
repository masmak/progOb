using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._3
{
    class Apple : ITelefon
    {
        public void stworzTelefon()
        {
            Telefon telefon = new Telefon();
            telefon.zalozObudowe("Apple");
            telefon.wlozEkran("Apple");
            Console.WriteLine("Stworzono Apple.");
        }
    }
}
