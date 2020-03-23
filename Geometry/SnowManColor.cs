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
        public new CircleColor Head, Chest, Tummy;
        public new BoxColor LeftLeg, RightLeg;
        public new LineColor LeftArm, RightArm;
        public SnowManColor()
            :this(new Pixel(160,600))
        {            
        }
        
        public SnowManColor(Pixel BeginCoordinate)
            :base(BeginCoordinate)
        {
            Head = new CircleColor(OB, RB, Color.Green);
            Chest = new CircleColor(OA, RA,Color.Red);
            Tummy = new CircleColor(OC, RC,Color.Orange);
            LeftLeg = new BoxColor(K, L, Color.Aquamarine);
            RightLeg = new BoxColor(M, N,Color.Blue);
            LeftArm = new LineColor(D, E, Color.Red);
            RightArm = new LineColor(F, J, Color.Brown);
        }
    }
}
