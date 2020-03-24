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

        SnowMan SnowMan1;
        SnowManColor SnowMan2;

        Pixel A, B, C, D, E, O;


        public GraphicObjects()
        {
            InitializeComponent();
            Init();
            Draw();
        }
        private void Init()
        {

            SnowMan1 = new SnowMan();
            SnowMan2 = new SnowManColor(new Pixel(400, 650));

            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
        }
        private void Draw()
        {
            Draw(SnowMan1.SnowMan3);
            Draw(SnowMan2.SnowMan3);

            Picture.Image = bmp;
        }
        private void Draw(Shape[] Shape)
        {
            for (int i=0;i<Shape.Length;i++)
                Draw(Shape[i]);
        }
        private void Draw(Shape Shape)
        {
            if(Shape.GetType()==typeof(Circle))
                Draw((Circle)Shape);
            if (Shape.GetType() == typeof(CircleColor))
                Draw((CircleColor)Shape);
            if (Shape.GetType() == typeof(Line))
                Draw((Line)Shape);
            if (Shape.GetType() == typeof(LineColor))
                Draw((LineColor)Shape);
            if (Shape.GetType() == typeof(Box))
                Draw((Box)Shape);
            if (Shape.GetType() == typeof(BoxColor))
                Draw((BoxColor)Shape);
        }
        private void Draw(LineColor ColorLine)
        {
            graph.DrawLine(ColorLine.pen, ColorLine.start.x, ColorLine.start.y, ColorLine.end.x, ColorLine.end.y);
        }
        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.start.x, line.start.y, line.end.x, line.end.y);
        }
        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.firstCorner.x, box.firstCorner.y, box.width, box.height);
        }
        private void Draw(BoxColor ColorBox)
        {
            graph.DrawRectangle(ColorBox.Pen, ColorBox.firstCorner.x, ColorBox.firstCorner.y, ColorBox.width, ColorBox.height);
        }
        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.leftUpCorner .x,circle.leftUpCorner.y, circle.width, circle.height);
        }
        private void Draw(CircleColor ColorCircle)
        {
            graph.DrawEllipse(ColorCircle.pen, ColorCircle.leftUpCorner.x, ColorCircle.leftUpCorner.y, ColorCircle.width, ColorCircle.height);
        }
    }
}
