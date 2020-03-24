using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Line : Shape
    {
        public Pixel start, end;

        public Line(int startX, int startY, int endX, int endY)
            : this(new Pixel(startX, startY), new Pixel(endX, endY))
        {
        }
        public Line(Pixel start, Pixel end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
