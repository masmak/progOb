using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._2
{
    public interface IBohater
    {
        void BijWroga();
        void SprawdzHp();

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            
            Wojownik Boromir = new Wojownik(Bohater.Rasa.Człowiek);
            Rzezimieszek Legolas = new Rzezimieszek(Bohater.Rasa.Elf);
            Rzezimieszek Sam = new Rzezimieszek(Bohater.Rasa.Hobbit);

            Legolas.BijWroga();
            Sam.BijWroga();
            Boromir.RzucToporem();
            Boromir.SprawdzHp();
            Sam.SprawdzHp();
            Legolas.SprawdzHp();

            Console.WriteLine("Drużyna pierścienia pokonała wroga!");
            Console.ReadLine();
        }
    }
}
