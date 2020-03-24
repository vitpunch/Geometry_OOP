using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class LineColor : Line 
    {
        public Pen pen;

        public LineColor(int startX, int startY, int endX, int endY, Color color)
            : this(new Pixel(startX, startY), new Pixel(endX, endY), color)
        {
        }
        public LineColor(Pixel start, Pixel end, Color color)
            :base(start,end)
        {
            pen = new Pen(color);
        }
    }
}
