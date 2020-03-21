using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class SnowMan
    {
        Pixel OB, OA, OC, D, E, J, F, K, L, M, N;
        int RB, RA, RC;
        public Circle Head, Chest, Tummy;
        public Box LeftLeg, RightLeg;
        public Line LeftArm, RightArm;
        public SnowMan()
        {
            OB = new Pixel(180, 120);
            RB = 80;
            OA = new Pixel(180, 300);
            RA = 100;
            OC = new Pixel(180, 520);
            RC = 120;
            D = new Pixel(20, 300);
            E = new Pixel(116, 223);
            J = new Pixel(340, 300);
            F = new Pixel(244, 223);
            K = new Pixel(100, 640);
            L = new Pixel(140, 600);
            M = new Pixel(220, 600);
            N = new Pixel(260, 640);
            Head = new Circle(OB, RB);
            Chest = new Circle(OA, RA);
            Tummy = new Circle(OC, RC);
            LeftLeg = new Box(K, L);
            RightLeg = new Box(M, N);
            LeftArm = new Line(D, E);
            RightArm = new Line(F, J);
        }
        
    }
}
