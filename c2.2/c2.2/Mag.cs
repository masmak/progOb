using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._2
{
    class Mag : Bohater
    {
        private int mana;

        public Mag(Rasa rasa)
        {
            this.hp = 50;
            this.atak = 100;
            this.rasa = rasa;
            this.mana = 200;
        }

        public void RzucCzar()
        {
            Console.WriteLine("Obrażenia od czaru: 175.");
        }
    }
}
