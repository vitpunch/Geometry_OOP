using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public struct Pixel
    {
        public int x, y;
        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Distance(Pixel OtherPixel)
        {
            int Cathetus1 = x - OtherPixel.x;
            int Cathetus2 = y - OtherPixel.y;
            return Convert.ToInt32(Math.Sqrt(Cathetus1 * Cathetus1 + Cathetus2 * Cathetus2));
        }
    }
}
