using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._2
{
    class Wojownik : Bohater
    {
        public Wojownik(Rasa rasa)
        {
            this.hp = 300;
            this.atak = 50;
            this.rasa = rasa;
        }
        public void RzucToporem()
        {
            Console.WriteLine("Obrażenia od toporu : 150.");
        }
    }
}
