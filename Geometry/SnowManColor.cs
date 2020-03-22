using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class SnowManColor
    {
        Pixel OB, OA, OC, D, E, J, F, K, L, M, N;
        private int RB, RA, RC;
        public ColorCircle Head, Chest, Tummy;
        public ColorBox LeftLeg, RightLeg;
        public ColorLine LeftArm, RightArm;
        public SnowManColor()
            :this(new Pixel(160,600))
        {            
        }
        
        public SnowManColor(Pixel BeginCoordinate)
        {
            OB = new Pixel(BeginCoordinate.x+20, BeginCoordinate.y-520);
            RB = 80;
            OA = new Pixel(BeginCoordinate.x + 20, BeginCoordinate.y-340);
            RA = 100;
            OC = new Pixel(BeginCoordinate.x + 20, BeginCoordinate.y-120);
            RC = 120;
            D = new Pixel(BeginCoordinate.x -160, BeginCoordinate.y-340);
            E = new Pixel(BeginCoordinate.x -44, BeginCoordinate.y-417);
            J = new Pixel(BeginCoordinate.x + 180, BeginCoordinate.y-340);
            F = new Pixel(BeginCoordinate.x + 84, BeginCoordinate.y-417);
            K = new Pixel(BeginCoordinate.x -60, BeginCoordinate.y);
            L = new Pixel(BeginCoordinate.x -20, BeginCoordinate.y-40);
            M = new Pixel(BeginCoordinate.x + 60, BeginCoordinate.y-40);
            N = new Pixel(BeginCoordinate.x + 100, BeginCoordinate.y);
            Head = new ColorCircle(OB, RB, Color.Green);
            Chest = new ColorCircle(OA, RA,Color.Red);
            Tummy = new ColorCircle(OC, RC,Color.Orange);
            LeftLeg = new ColorBox(K, L, Color.Aquamarine);
            RightLeg = new ColorBox(M, N,Color.Blue);
            LeftArm = new ColorLine(D, E, Color.Red);
            RightArm = new ColorLine(F, J, Color.Brown);
        }
    }
}
