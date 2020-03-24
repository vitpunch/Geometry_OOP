using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class SnowManColor : SnowMan
    {
        public SnowManColor()
            :this(new Pixel(160,600))
        {            
        }
        
        public SnowManColor(Pixel BeginCoordinate)
            :base(BeginCoordinate)
        {
            SnowMan3 = new Shape[7];

            SnowMan3[0] = new CircleColor(OB, RB, Color.Green);
            SnowMan3[1] = new CircleColor(OA, RA,Color.Red);
            SnowMan3[2] = new CircleColor(OC, RC,Color.Orange);
            SnowMan3[3] = new BoxColor(K, L, Color.Aquamarine);
            SnowMan3[4] = new BoxColor(M, N,Color.Blue);
            SnowMan3[5] = new LineColor(D, E, Color.Red);
            SnowMan3[6] = new LineColor(F, J, Color.Brown);
        }
    }
}
