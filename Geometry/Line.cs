using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Line
    {
        public Pixel Start, End;

        public Line(int StartX, int StartY, int EndX, int EndY)
            : this(new Pixel(StartX, StartY), new Pixel(EndX, EndY))
        {
        }
        public Line(Pixel Start, Pixel End)
        {
            this.Start = Start;
            this.End = End;
        }
    }
}
