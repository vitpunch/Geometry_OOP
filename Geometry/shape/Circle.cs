using System.Drawing;

namespace Geometry
{
    class Circle : Shape
    {
        protected Graphics graph;
        protected Pen pen;
        public int width,height;
        public Pixel leftUpCorner;

        public void SetGraphics(Graphics graph)
        {
            this.graph = graph;
        }
        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }
        public Circle(int centerX, int centerY, int radius)
            : this(new Pixel(centerX, centerY), radius)
        {
        }
        public Circle(Pixel center, int radius)
        {
            leftUpCorner = new Pixel (center.x-radius,center.y-radius);
            width = radius * 2;
            height = radius * 2;
        }
        public Circle(Pixel center, Pixel anyDotOnCircle)
            :this(center, center.Distance(anyDotOnCircle))
        {
        }
        public void Draw()
        {
            graph.DrawEllipse(pen,
                leftUpCorner.x, leftUpCorner.y,
                width, height);
        }
    }
}