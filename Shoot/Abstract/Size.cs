using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    public class Size
    {
        public int x = 0;
        public int y = 0;
        public Size(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Size(){ }

        public float getFloatX()
        {
            return (float)x;
        }
        public float getFloatY()
        {
            return (float)y;
        }

        public Size copy()
        {
            return new Size(x, y);
        }
    }
}
