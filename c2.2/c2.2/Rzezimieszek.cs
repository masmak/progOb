using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._2
{
    class Rzezimieszek : Bohater
    {
        private int energia;

        public Rzezimieszek(Rasa rasa)
        {
            this.hp = 100;
            this.atak = 200;
            this.rasa = rasa;
            this.energia = 50;
        }

    }
}
