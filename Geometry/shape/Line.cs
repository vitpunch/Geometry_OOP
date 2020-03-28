using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Line : Shape
    {
        public Pixel start, end;
        public Line(int startX, int startY, int endX, int endY)
            : this(new Pixel(startX, startY), new Pixel(endX, endY))
        {
        }
        public Line(Pixel start, Pixel end)
        {
            this.start = start;
            this.end = end;
        }
        public Line(Pixel start, Pixel end,Color color)
            :this(start, end)
        {
            pen = new Pen(color);
        }
        override public void Draw()
        {
            graph.DrawLine(pen, start.x+position.x, start.y+position.y, end.x+position.x, end.y+position.y);
        }
    }
}
