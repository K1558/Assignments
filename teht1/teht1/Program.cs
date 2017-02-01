using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stove
{
    class Program
    {
        static void Main(string[] args)
        {

            //stove
            Stove stove = new Stove();
            stove.Temperature = 0;
            stove.On = false;

            //display data
            stove.PrintData();
            Console.ReadLine();

            //turn on
            stove.TurnOn();
            Console.ReadLine();

            //change temperature 
            stove.MoreHeat();

            //display data
            stove.PrintData();
            Console.ReadLine();

        }
    }
}
