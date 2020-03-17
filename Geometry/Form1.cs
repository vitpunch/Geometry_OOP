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
        Box Box1;
        Circle Circle1;
        Circle Circle2;

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
            Circle1 = new Circle(O, 100);
            Circle2 = new Circle(D, E);

            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
        }
        private void Draw()
        {            
            Draw(Line1);
            Draw(Line2);
            Draw(Box1);
            Draw(Circle1);
            Draw(Circle2);
            Picture.Image = bmp;
        }
        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.Start.x, line.Start.y, line.End.x, line.End.y);
        }
        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.FirstCorner.x, box.FirstCorner.y, box.width, box.height);
        }
        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.LeftUpCorner .x,circle.LeftUpCorner.y, circle.Width, circle.Height);
        }
    }
}
