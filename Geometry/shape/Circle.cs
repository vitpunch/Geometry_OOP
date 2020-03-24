using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle : Shape
    {
        public int width,height;
        public Pixel leftUpCorner;
        public Circle(int centerX, int centerY, int radius)
            : this(new Pixel(centerX, centerY), radius)
        {
        }
        public Circle(Pixel center, int radius)
        {
            leftUpCorner = new Pixel (center.x-radius,center.y-radius);
            width = radius * 2;
            height = radius * 2;
        }
        public Circle(Pixel center, Pixel anyDotOnCircle)
            :this(center, center.Distance(anyDotOnCircle))
        {
        }
    }
}