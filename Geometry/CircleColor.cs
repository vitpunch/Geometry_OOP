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
        public Pen Pen;
        public CircleColor(int CenterX, int CenterY, int Radius, Color Color)
            : this(new Pixel(CenterX, CenterY), Radius, Color)
        {
        }
        public CircleColor(Pixel Center, int Radius, Color Color)
            :base(Center, Radius)
        {
            Pen = new Pen(Color);
        }
        public CircleColor(Pixel Center, Pixel AnyDotOnCircle, Color Color)
            : this(Center, Center.Distance(AnyDotOnCircle), Color)
        {
        }
    }
}
