﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class Song
    {
        public string SongName { get; set; }
        public double Leingth { get; set; }

        public override string ToString()
        {
            return SongName + ", " + Leingth;
        }
    }
}
