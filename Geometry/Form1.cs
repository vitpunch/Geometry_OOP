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
            bmp = new Bitmap(Picture.Width, Picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
        }
        private void Draw()
        {
            
            graph.DrawRectangle(pen, 100, 100, 200, 200);
            Draw(Line1);
            Draw(Line2);
            Picture.Image = bmp;
        }
        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }
    }
}
