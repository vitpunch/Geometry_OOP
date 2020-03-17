using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class ColorBox
    {
        public int width, height;
        public Pixel FirstCorner, OppositeCorner;
        public Pen Pen;
        public ColorBox(Pixel FirstCorner, Pixel OppositeCorner, Color Color)
        {
            this.FirstCorner = FirstCorner;
            this.OppositeCorner = OppositeCorner;
            Pen = new Pen(Color);
            VerifyCoord();
        }

        public ColorBox(int x1, int y1, int x2, int y2, Color Color)
            : this(new Pixel(x1, y1), new Pixel(x2, y2), Color)
        {
        }
        void VerifyCoord()
        // проверка и преобразование входящих координат. Расчёт width и Height
        // FirstCorner становится верхним левым
        // OppositeCorner - правым нижним
        {
            if (FirstCorner.x > OppositeCorner.x)
            {
                int Temp = OppositeCorner.x;
                OppositeCorner.x = FirstCorner.x;
                FirstCorner.x = Temp;
            }
            if (FirstCorner.y > OppositeCorner.y)
            {
                int Temp = OppositeCorner.y;
                OppositeCorner.y = FirstCorner.y;
                FirstCorner.y = Temp;
            }
            width = Math.Abs(OppositeCorner.x - FirstCorner.x);
            height = Math.Abs(OppositeCorner.y - FirstCorner.y);
        }
    }
}
