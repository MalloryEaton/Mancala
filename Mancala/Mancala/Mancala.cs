using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public class Mancala
    {
        Coordinate[] coordinates = new Coordinate[49];
        Stack<Marble> marbles;
        short marbleCount;
        public Mancala()
        {
            marbleCount = 0;
            marbles = new Stack<Marble>();
        }
    }
}
