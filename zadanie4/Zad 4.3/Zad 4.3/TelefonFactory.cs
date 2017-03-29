using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._3
{
    static class TelefonFactory
    {
        public static ITelefon StworzObiektTelefon(Marki marki)
        {
            ITelefon telefon = null;
            switch (marki)
            {
                case Marki.Apple:
                    telefon = new Apple();
                    break;
                case Marki.Samsung:
                    telefon = new Samsung();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("marki", "Błędna marka.");
            }
            return telefon;
        }
    }
}
