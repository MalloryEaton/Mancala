using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public class Mancala
    {
        public Coordinate[] coordinates = new Coordinate[49];
        public int mancalaNumber;
        Stack<Marble> marbles;
        public short marbleCount;
        public Mancala()
        {
            marbleCount = 0;
            marbles = new Stack<Marble>();
            for (int i = 0; i < 49; i++)
            {
                coordinates[i] = new Coordinate();
            }
        }
    }
}
