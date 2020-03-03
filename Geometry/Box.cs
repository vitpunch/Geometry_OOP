using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry
{
    class Box
    {
        public int x1, y1, x2, y2, width, height;
        public Box(Pixel FirstCornerc, Pixel OppositeCorner)
        {
            if (FirstCornerc.x < OppositeCorner.x)
                x1 = FirstCornerc.x;
            else
                x1 = OppositeCorner.x;
            if (FirstCornerc.y < OppositeCorner.y)
                x1 = FirstCornerc.y;
            else
                x1 = OppositeCorner.y;

            width = Math.Abs(OppositeCorner.x - FirstCornerc.x);
            height = Math.Abs(OppositeCorner.y - FirstCornerc.y);
        }

        public Box(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            width = x2 - x1;
            height = y2 - y1;
        }
    }
}
