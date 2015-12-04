using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public class Cup
    {
        Coordinate[] coordinates = new Coordinate[21];
        short marbleCount;
        Stack<Marble> marbles;

        public Cup()
        {
            marbleCount = 4;
            marbles = new Stack<Marble>();
        }
    }
}
