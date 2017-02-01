using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washer
{
    class Washer
    {
        public string Program { get; set; }
        public string Duration { get; set; }

        public bool On { get; set; }


        //turn on

        public void TurnOn()
        {
            On = !On;
        }

        public void PrintData()
        {
            Console.WriteLine("Washer is on: " + On);
            Console.WriteLine("Program is: " + Program + "," + " and it takes: " + Duration);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning washer off...");
            Console.WriteLine("Washer is on: " + On);
        }


    }
}
