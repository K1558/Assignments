using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    class Elevator
    {
        private readonly int maxfloor = 5;
        private readonly int minfloor = 1;
        private int floor;
        public int Floor
        {
            get {
            return floor;
            }
            set
            {
                if (value <= maxfloor&& value <=minfloor) floor = value;
                else
                {
                    Console.WriteLine("Not a valid floor");
                    floor = maxfloor;
                }
            }
        }

    }
}
