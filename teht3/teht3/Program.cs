using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv Tv1 = new Tv();
            Tv1.Off = true;
            Tv1.Channel = 1;
            Tv1.Output = "Tv";

            Tv Tv2 = new Tv();
            Tv2.Off = true;
            Tv2.Channel = 9;
            Tv2.Output = "HDMI";

            //print data
            Tv1.PrintData();
            Tv2.PrintData();
            Console.ReadLine();

        }
    }
}
