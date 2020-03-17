using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class ColorCircle
    {
        public int Width, Height;
        public Pixel LeftUpCorner;
        public Pen Pen;
        public ColorCircle(int CenterX, int CenterY, int Radius, Color Color)
            : this(new Pixel(CenterX, CenterY), Radius, Color)
        {
        }
        public ColorCircle(Pixel Center, int Radius, Color Color)
        {
            LeftUpCorner = new Pixel(Center.x - Radius, Center.y - Radius);
            Width = Radius * 2;
            Height = Radius * 2;
            Pen = new Pen(Color);
        }
        public ColorCircle(Pixel Center, Pixel AnyDotOnCircle, Color Color)
            : this(Center, Center.Distance(AnyDotOnCircle), Color)
        {
        }
    }
}
