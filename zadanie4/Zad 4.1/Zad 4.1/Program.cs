using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Uczelnia UWM = Uczelnia.utworzObiekt(new DateTime(2017, 6, 25, 13, 55, 17));
            Uczelnia Stanford = Uczelnia.utworzObiekt(new DateTime(2017, 7, 30, 15, 15, 18));

            UWM.RekrutujStudentow();
            Stanford.RekrutujStudentow();

            Console.ReadKey();

        }
    }

    class Uczelnia
    {
        private static Uczelnia _obiekt;
        private DateTime DataRekrutacji;

        private Uczelnia() { }

        public static Uczelnia utworzObiekt(DateTime dataRekrutacji)
        {
            if (_obiekt == null)
            {
                _obiekt = new Uczelnia();
                _obiekt.DataRekrutacji = dataRekrutacji;
            }
            return _obiekt;
        }

        public void RekrutujStudentow()
        {
            Console.WriteLine("Rekrutacja odbywa sie: " + this.DataRekrutacji);
        }
    }
}
