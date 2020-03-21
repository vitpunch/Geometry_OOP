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
    public struct Pixel
    {
        public int x, y;

        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Distance(Pixel OtherPixel)
        {
            int Cathetus1 = this.x - OtherPixel.x;
            int Cathetus2 = this.y - OtherPixel.y;
            return Convert.ToInt32(Math.Sqrt(Cathetus1 * Cathetus1 + Cathetus2 * Cathetus2));
        }
    }
    public partial class GraphicObjects : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line Line1;
        Line Line2;
        ColorLine Line3;
        ColorLine Line4;
        Box Box1;
        ColorBox Box2;
        Circle Circle1;
        ColorCircle Circle2;
        SnowMan SnowMan1;
        SnowMan SnowMan2;

        Pixel A, B, C, D, E, O;


        public GraphicObjects()
        {
            InitializeComponent();
            Init();
            Draw();
        }
        private void Init()
        {
            A = new Pixel(100, 300);
            B = new Pixel(300, 300);
            C = new Pixel(100, 100);
            D = new Pixel(300, 100);
            E = new Pixel(200, 10);
            O = new Pixel(200, 200);



            Line1 = new Line(C, E);
            Line2 = new Line(D, E);

            Box1 = new Box(B, C);
            Box2 = new ColorBox(D, E, Color.Black);

            Circle1 = new Circle(O, 100);
            Circle2 = new ColorCircle(O, 120,Color.Green);

            Line3 = new ColorLine(E, B, Color.Green);
            Line4 = new ColorLine(O, A, Color.Red);

            SnowMan1 = new SnowMan();

            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
        }
        private void Draw()
        {
            Draw(SnowMan1);



            Picture.Image = bmp;
        }

        private void Draw(SnowMan SnowMan)
        {
            Draw(SnowMan.Head);
            Draw(SnowMan.Chest);
            Draw(SnowMan.Tummy);
            Draw(SnowMan.LeftLeg);
            Draw(SnowMan.RightLeg);
            Draw(SnowMan.LeftArm);
            Draw(SnowMan.RightArm);
        }
        private void Draw(ColorLine ColorLine)
        {
            graph.DrawLine(ColorLine.Pen, ColorLine.Start.x, ColorLine.Start.y, ColorLine.End.x, ColorLine.End.y);
        }
        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.Start.x, line.Start.y, line.End.x, line.End.y);
        }
        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.FirstCorner.x, box.FirstCorner.y, box.width, box.height);
        }
        private void Draw(ColorBox ColorBox)
        {
            graph.DrawRectangle(ColorBox.Pen, ColorBox.FirstCorner.x, ColorBox.FirstCorner.y, ColorBox.width, ColorBox.height);
        }
        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.LeftUpCorner .x,circle.LeftUpCorner.y, circle.Width, circle.Height);
        }
        private void Draw(ColorCircle ColorCircle)
        {
            graph.DrawEllipse(ColorCircle.Pen, ColorCircle.LeftUpCorner.x, ColorCircle.LeftUpCorner.y, ColorCircle.Width, ColorCircle.Height);
        }
    }
}
