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
        public Pen Pen;

        public LineColor(int StartX, int StartY, int EndX, int EndY, Color Color)
            : this(new Pixel(StartX, StartY), new Pixel(EndX, EndY), Color)
        {
        }
        public LineColor(Pixel Start, Pixel End, Color Color)
            :base(Start,End)
        {
            Pen = new Pen(Color);
        }
    }
}
