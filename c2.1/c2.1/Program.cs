using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2._1
{

    interface ISamochod
    {
        void WypiszMarke();
        void WypiszSalon();
    }

    class RollsRoyce : ISamochod
    {
        public void WypiszMarke()
        {
            Console.WriteLine("Auto ma markę RollsRoyce");
        }
        public void WypiszSalon()
        {
            Console.WriteLine("Auto pochodzi z salonu RollsRoyce");
        }
    }
    class AstonMartin : ISamochod
    {
        public void WypiszMarke()
        {
            Console.WriteLine("Auto ma markę AstonMartin");
        }
        public void WypiszSalon()
        {
            Console.WriteLine("Auto pochodzi z salonu AstonMartin");
        }
    }
    
    class RangeRover : ISamochod
    {
        public void WypiszMarke()
        {
            Console.WriteLine("Auto ma markę RangeRover");
        }
        public void WypiszSalon()
        {
            Console.WriteLine("Auto pochodzi z salonu RangeRover");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            RollsRoyce r = new RollsRoyce();
            r.WypiszMarke();
            r.WypiszSalon();
            Console.ReadLine();

        }
    }
}
