using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washer
{
    class Program
    {
        static void Main(string[] args)
        {
            //washer
            Washer washer = new Washer();
            washer.On = true;
            washer.Duration = "45 minutes";
            washer.Program = "cotton";

            //print data
            washer.PrintData();
            Console.ReadLine();

            //turn washer off
            washer.TurnOn();
            Console.ReadLine();
            washer.TurnOff();
            Console.ReadLine();



        }
    }
}
