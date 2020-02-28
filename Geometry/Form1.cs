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
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line Line1;
        Line Line2;
        Box Box1;

        public GraphicObjects()
        {
            InitializeComponent();
            Init();
            Draw();
        }
        private void Init()
        {
            Line1 = new Line(100,100,200,10);
            Line2 = new Line(200,10,300,100);
            Box1 = new Box(100, 100, 300, 300);

            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
        }
        private void Draw()
        {
            
            graph.DrawRectangle(pen, 100, 100, 200, 200);
            Draw(Line1);
            Draw(Line2);
            Draw(Box1);
            Picture.Image = bmp;
        }
        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }
        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.x1, box.x1, box.width, box.height);
        }
    }
}
