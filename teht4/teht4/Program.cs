using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bike = new Vehicle();
            bike.Name = "bike";
            bike.Speed = 20;
            bike.Tyres = 2;

            Vehicle car = new Vehicle();
            car.Name = "car";
            car.Speed = 45;
            car.Tyres = 4;

            Vehicle tricycle = new Vehicle();
            tricycle.Name = "tricycle";
            tricycle.Speed = 10;
            tricycle.Tyres = 3;

            bike.PrintData();
            car.PrintData();
            tricycle.PrintData();
            Console.ReadLine();

            bike.ToString();
            Console.ReadLine();


        }
    }
}

