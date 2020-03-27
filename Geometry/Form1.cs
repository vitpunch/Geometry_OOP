using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{

    public partial class GraphicObjects : Form
    {
        public Bitmap bmp;
        public Graphics graph;

        Sprite snowMan;

        public GraphicObjects()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);

            InitSnowMan1();
            snowMan.Draw();
            Picture.Image = bmp;
        }
        public void InitSnowMan1()
        {
            Pixel OB, OA, OC, D, E, J, F, K, L, M, N; 
            int RB, RA, RC;
            

            Pixel beginCoordinate = new Pixel(200, 650);
            snowMan = new Sprite();
            snowMan.SetGraphics(graph);


            OB = new Pixel(beginCoordinate.x + 20, beginCoordinate.y - 520);
            RB = 80;
            OA = new Pixel(beginCoordinate.x + 20, beginCoordinate.y - 340);
            RA = 100;
            OC = new Pixel(beginCoordinate.x + 20, beginCoordinate.y - 120);
            RC = 120;
            D = new Pixel(beginCoordinate.x - 160, beginCoordinate.y - 340);
            E = new Pixel(beginCoordinate.x - 44, beginCoordinate.y - 417);
            J = new Pixel(beginCoordinate.x + 180, beginCoordinate.y - 340);
            F = new Pixel(beginCoordinate.x + 84, beginCoordinate.y - 417);
            K = new Pixel(beginCoordinate.x - 60, beginCoordinate.y);
            L = new Pixel(beginCoordinate.x - 20, beginCoordinate.y - 40);
            M = new Pixel(beginCoordinate.x + 60, beginCoordinate.y - 40);
            N = new Pixel(beginCoordinate.x + 100, beginCoordinate.y);

            snowMan.AddShape(new Circle(OB, RB));
            snowMan.AddShape(new Circle(OA, RA, Color.Red));
            snowMan.AddShape(new Circle(OC, RC));
            snowMan.AddShape(new Box(K, L));
            snowMan.AddShape(new Box(M, N,Color.Green));
            snowMan.AddShape(new Line(D, E));
            snowMan.AddShape(new Line(F, J,Color.Orange));
        }    
    
    }
}