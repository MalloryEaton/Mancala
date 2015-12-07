using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    class AnimationInformation
    {
        public Marble marbleToMove;
        public Coordinate toCoordinate;
        public Coordinate fromCoordinate;
        public AnimationInformation()
        { }
        public AnimationInformation(Marble marble, double toX, double toY, double fromX, double fromY)
        {
            marbleToMove = marble;
            toCoordinate = new Coordinate();
            toCoordinate.X = toX;
            toCoordinate.Y = toY;
            fromCoordinate = new Coordinate();
            fromCoordinate.X = fromX;
            fromCoordinate.Y = fromY;
        }
    }
}
