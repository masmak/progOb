using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ITelefon Telefon1 = TelefonFactory.StworzObiektTelefon(Marki.Apple);
            ITelefon Telefon2 = TelefonFactory.StworzObiektTelefon(Marki.Samsung);

            Telefon1.stworzTelefon();
            Telefon2.stworzTelefon();

            Console.ReadKey();
        }
    }

    public interface ITelefon
    {
        void stworzTelefon();
    }

    public enum Marki
    {
        Apple, Samsung
    }
}
