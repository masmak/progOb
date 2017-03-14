using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._2
{
    abstract class Bohater : IBohater
    {
        protected int hp;
        protected int atak;
        protected Rasa rasa;
        public enum Rasa
        {
            Elf,
            Krasnolud,
            Hobbit,
            Człowiek
        }

        public void BijWroga()
        {
            Console.WriteLine("Zadane obrażenia: " + this.atak);
        }
        public void SprawdzHp()
        {
            Console.WriteLine("Poziom hp to: " + this.hp);
        }
    }
}
