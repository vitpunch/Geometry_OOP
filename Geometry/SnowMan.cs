using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class SnowMan
    {
        public Pixel OB, OA, OC, D, E, J, F, K, L, M, N;
        public int RB, RA, RC;
        public Circle Head, Chest, Tummy;
        public Box LeftLeg, RightLeg;
        public Line LeftArm, RightArm;
        public SnowMan()
            :this(new Pixel(160,600))
        {            
        }
        
        public SnowMan(Pixel BeginCoordinate)
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
