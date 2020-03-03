using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle
    {
        public int LeftUpX, LefUpY, Width,Height;
        public Circle(int CenterX, int CenterY, int Radius)
        {
            LeftUpX = CenterX - Radius;
            LefUpY = CenterY - Radius;
            Width = Radius * 2;
            Height = Radius * 2;
        }
        public Circle(Pixel Center, int Radius)
        {
            LeftUpX = Center.x - Radius;
            LefUpY = Center.y - Radius;
            Width = Radius * 2;
            Height = Radius * 2;

        }
    }
}
