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
            Draw(SnowMan1);
            Draw(SnowMan2);

            Picture.Image = bmp;
        }
        private void Draw(SnowManColor SnowManColor)
        {
            Draw(SnowManColor.Head);
            Draw(SnowManColor.Chest);
            Draw(SnowManColor.Tummy);
            Draw(SnowManColor.LeftLeg);
            Draw(SnowManColor.RightLeg);
            Draw(SnowManColor.LeftArm);
            Draw(SnowManColor.RightArm);
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
        private void Draw(LineColor ColorLine)
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
        private void Draw(BoxColor ColorBox)
        {
            graph.DrawRectangle(ColorBox.Pen, ColorBox.FirstCorner.x, ColorBox.FirstCorner.y, ColorBox.width, ColorBox.height);
        }
        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.LeftUpCorner .x,circle.LeftUpCorner.y, circle.Width, circle.Height);
        }
        private void Draw(CircleColor ColorCircle)
        {
            graph.DrawEllipse(ColorCircle.Pen, ColorCircle.LeftUpCorner.x, ColorCircle.LeftUpCorner.y, ColorCircle.Width, ColorCircle.Height);
        }
    }
}
