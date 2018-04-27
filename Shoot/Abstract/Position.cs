using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    public class Position
    {
        public int x = 0;
        public int y = 0;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Position(){}

        public float getFloatX()
        {
            return (float)x;
        }
        public float getFloatY()
        {
            return (float)y;
        }

        public Position copy()
        {
            return new Position(x, y);
        }
    }
}
