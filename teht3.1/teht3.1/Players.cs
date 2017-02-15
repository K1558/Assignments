using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3._1
{
    class Player
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Team { get; set; }
        public int Points { get; set; }
        

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Team + " " + Points;
        }


       

    }
}
