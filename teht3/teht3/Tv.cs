using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Tv
    {
        public int Channel { get; set; }
        public string Output { get; set; }

        public bool Off { get; set; }

        //turn on

        public void TurnOff()
        {
            Off = !Off;
        }

        public void ChangeChannel()
        {
            Channel++;

        }

        public void PrintData()
        {
            Console.WriteLine("TV is on: " + Off);
            Console.WriteLine("Channel is: " + Channel);
            Console.WriteLine("Output is: " + Output);
        }


    }
}
