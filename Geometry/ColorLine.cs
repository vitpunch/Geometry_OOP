using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class ColorLine
    {
        public Pixel Start, End;
        public Pen Pen;

        public ColorLine(int StartX, int StartY, int EndX, int EndY, Color Color)
            : this(new Pixel(StartX, StartY), new Pixel(EndX, EndY), Color)
        {
        }
        public ColorLine(Pixel Start, Pixel End, Color Color )
        {
            Pen = new Pen(Color);
            this.Start = Start;
            this.End = End;
        }
    }
}
