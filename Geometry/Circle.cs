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
            this.LeftUpX = CenterX - Radius;
            this.LefUpY = CenterY - Radius;
            this.Width = Radius * 2;
            this.Height = Radius * 2;

        }
    }
}
