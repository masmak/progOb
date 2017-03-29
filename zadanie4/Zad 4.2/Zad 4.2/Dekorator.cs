using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._2
{
    class Dekorator : ITelefon
    {
        protected ZwyklyTelefon _zwyklyTelefon;

        public Dekorator(ZwyklyTelefon zwyklyTelefon)
        {
            this._zwyklyTelefon = zwyklyTelefon;
        }

        public void wybierzNumer()
        {
           _zwyklyTelefon.wybierzNumer();
        }
        public void wyslijWiadomosc()
        {
            _zwyklyTelefon.wyslijWiadomosc();
        }
        public void pokazTyp()
        {
            _zwyklyTelefon.pokazTyp();
        }
    }
}
