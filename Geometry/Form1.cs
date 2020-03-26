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
        Pen pen;

        Shape[] snowMan;

        public GraphicObjects()
        {
            InitializeComponent();
            Init();


        }
        private void Init()
        {
            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);

            InitSnowMan1();
            Draw(snowMan);
            Picture.Image = bmp;
        }
        public void InitSnowMan1()
        {
            Pixel OB, OA, OC, D, E, J, F, K, L, M, N; 
            int RB, RA, RC;
            

            Pixel beginCoordinate = new Pixel(200, 650);
            snowMan = new Shape[7];


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

            snowMan[0] = new Circle(OB, RB);
            ((Circle)snowMan[0]).SetGraphics(graph);
            ((Circle)snowMan[0]).SetPen(pen);
            snowMan[1] = new Circle(OA, RA);
            ((Circle)snowMan[1]).SetGraphics(graph);
            ((Circle)snowMan[1]).SetPen(pen);
            snowMan[2] = new Circle(OC, RC);
            ((Circle)snowMan[2]).SetGraphics(graph);
            ((Circle)snowMan[2]).SetPen(pen);
            snowMan[3] = new Box(K, L);
            ((Box)snowMan[3]).SetGraphics(graph);
            ((Box)snowMan[3]).SetPen(pen);
            snowMan[4] = new Box(M, N);
            ((Box)snowMan[4]).SetGraphics(graph);
            ((Box)snowMan[4]).SetPen(pen);
            snowMan[5] = new Line(D, E);
            ((Line)snowMan[5]).SetGraphics(graph);
            ((Line)snowMan[5]).SetPen(pen);
            snowMan[6] = new Line(F, J);
            ((Line)snowMan[6]).SetGraphics(graph);
            ((Line)snowMan[6]).SetPen(pen);
        }    
        private void Draw(Shape[] shape)
        {
            for (int i=0;i<shape.Length;i++)
                Draw(shape[i]);
        }
        private void Draw(Shape Shape)
        {
            if(Shape.GetType()==typeof(Circle))
                ((Circle)Shape).Draw();
            if (Shape.GetType() == typeof(Line))
                ((Line)Shape).Draw();
            if (Shape.GetType() == typeof(Box))
                ((Box)Shape).Draw();
        }
    }
}