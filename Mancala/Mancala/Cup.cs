﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public class Cup
    {
        public Coordinate[] coordinates = new Coordinate[21];
        public int cupNumber;
        short marbleCount;
        Stack<Marble> marbles;

        public Cup()
        {
            cupNumber = -1;
            marbleCount = 4;
            marbles = new Stack<Marble>();
            for (int i = 0; i < 21; i++)
            {
                coordinates[i] = new Coordinate();
            }
        }
    }
}
