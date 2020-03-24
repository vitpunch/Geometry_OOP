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

        public Shape[] SnowMan3;
        public SnowMan()
            :this(new Pixel(160,600))
        {            
        }
        
        public SnowMan(Pixel BeginCoordinate)
        {
            SnowMan3 = new Shape[7];


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
            
            SnowMan3[0] = new Circle(OB, RB);
            SnowMan3[1] = new Circle(OA, RA);
            SnowMan3[2] = new Circle(OC, RC);
            SnowMan3[3] = new Box(K, L);
            SnowMan3[4] = new Box(M, N);
            SnowMan3[5] = new Line(D, E);
            SnowMan3[6] = new Line(F, J);
        }
    }
}
