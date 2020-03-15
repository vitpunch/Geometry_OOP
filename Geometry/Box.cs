using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry
{
    class Box
    {
        public int width, height;
        public Pixel FirstCorner, OppositeCorner;
        public Box(Pixel FirstCorner, Pixel OppositeCorner)
        {
            this.FirstCorner = FirstCorner;
            this.OppositeCorner = OppositeCorner;
            VerifyCoord();
        }

        public Box(int x1, int y1, int x2, int y2)
            :this(new Pixel(x1,y1),new Pixel (x2,y2))
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
