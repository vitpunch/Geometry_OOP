using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle
    {
        public int Width,Height;
        public Pixel LeftUpCorner;
        public Circle(int CenterX, int CenterY, int Radius)
            : this(new Pixel(CenterX, CenterY), Radius)
        {
        }
        public Circle(Pixel Center, int Radius)
        {
            LeftUpCorner = new Pixel (Center.x-Radius,Center.y-Radius);
            Width = Radius * 2;
            Height = Radius * 2;
        }
        public Circle(Pixel Center, Pixel AnyDotOnCircle)
            :this(Center, Center.Distance(AnyDotOnCircle))
        {
        }
    }
}