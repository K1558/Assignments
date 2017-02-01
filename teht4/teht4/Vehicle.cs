using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Vechile is " + Name);
            Console.WriteLine("Speed is " + Speed);
            Console.WriteLine("Vehicle has " + Tyres + " tyres");
        }

        public void ToString()
        {
            string str = Convert.ToString(Name + " " + Speed + " " + Tyres);
            Console.WriteLine(str);
        }
    }
}
