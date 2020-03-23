﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class BoxColor : Box 
    {
        public Pen Pen;
        public BoxColor(Pixel FirstCorner, Pixel OppositeCorner, Color Color)
            :base(FirstCorner,OppositeCorner)
        {
            Pen = new Pen(Color);
            VerifyCoord();
        }

        public BoxColor(int x1, int y1, int x2, int y2, Color Color)
            : this(new Pixel(x1, y1), new Pixel(x2, y2), Color)
        {
        }
    }
}
