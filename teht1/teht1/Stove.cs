using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stove
{
    class Stove
    {
        //properties
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public bool On { get; set; }


        //method to turn on/off

        public void TurnOn()
        {
            On = !On;
        }

        public void MoreHeat()
        {
            Temperature += 5;
        }

        public void LessHeat()
        {
            Temperature -= 5;
        }

        public void PrintData()
        {
            Console.WriteLine("Stove is on: " + On);
            Console.WriteLine("Temperature is: " + Temperature);

        }
    }
}