using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    public class Mancala: Cup
    {
        public Coordinate[] mancalaCoordinates = new Coordinate[49];
        //public int mancalaNumber;
        //Stack<Marble> marbles;
        //public short marbleCount;
        public Mancala()
        {
            marbleCount = 0;
            marbles = new Stack<Marble>();
            for (int i = 0; i < 48; i++)
            {
                mancalaCoordinates[i] = new Coordinate();
            }
        }
    }
}
