using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry
{
    class Box: Shape
    {
        public int width, height;
        public Pixel firstCorner, oppositeCorner;
        protected Graphics graph;
        protected Pen pen;
        public void SetGraphics(Graphics graph)
        {
            this.graph = graph;
        }
        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }
        public Box(Pixel firstCorner, Pixel oppositeCorner)
        {
            this.firstCorner = firstCorner;
            this.oppositeCorner = oppositeCorner;
            VerifyCoord();
        }

        public Box(int x1, int y1, int x2, int y2)
            :this(new Pixel(x1,y1),new Pixel (x2,y2))
        {
        }
        public void VerifyCoord()
        // проверка и преобразование входящих координат. Расчёт width и Height
        // FirstCorner становится верхним левым
        // OppositeCorner - правым нижним
        {
            if (firstCorner.x > oppositeCorner.x)
            {
                int Temp = oppositeCorner.x;
                oppositeCorner.x = firstCorner.x;
                firstCorner.x = Temp;
            }
            if (firstCorner.y > oppositeCorner.y)
            {
                int Temp = oppositeCorner.y;
                oppositeCorner.y = firstCorner.y;
                firstCorner.y = Temp;
            }
            width = Math.Abs(oppositeCorner.x - firstCorner.x);
            height = Math.Abs(oppositeCorner.y - firstCorner.y);
        }
        public void Draw()
        {
            graph.DrawRectangle(pen, firstCorner.x, firstCorner.y, width, height);
        }
    }
}
