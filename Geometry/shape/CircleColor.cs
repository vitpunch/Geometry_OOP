using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class CircleColor : Circle
    {
        public Pen pen;
        public CircleColor(int centerX, int centerY, int radius, Color color)
            : this(new Pixel(centerX, centerY), radius, color)
        {
        }
        public CircleColor(Pixel center, int radius, Color color)
            :base(center, radius)
        {
            pen = new Pen(color);
        }
        public CircleColor(Pixel center, Pixel anyDotOnCircle, Color color)
            : this(center, center.Distance(anyDotOnCircle), color)
        {
        }
    }
}
