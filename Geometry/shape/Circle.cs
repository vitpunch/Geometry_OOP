using System.Drawing;

namespace Geometry
{
    class Circle : Shape
    {       
        public int width,height;
        public Pixel leftUpCorner;
        public Circle(int centerX, int centerY, int radius)
            : this(new Pixel(centerX, centerY), radius)
        {
        }        
        public Circle(Pixel center, Pixel anyDotOnCircle)
            :this(center, center.Distance(anyDotOnCircle))
        {
        }
        public Circle(Pixel center, int radius)
        {
            leftUpCorner = new Pixel(center.x - radius, center.y - radius);
            width = radius * 2;
            height = radius * 2;
        }
        public Circle(Pixel center,int radius,Color color)
            :this(center,radius)
        {
            pen = new Pen(color);
        }
        public Circle(Pixel center, Pixel anyDotOnCircle,Color color)
            : this(center, center.Distance(anyDotOnCircle),color)
        {
        }
        public Circle(int centerX, int centerY, int radius, Color color)
            : this(new Pixel(centerX, centerY), radius, color)
        {
        }
        override public void Draw()
        {
            graph.DrawEllipse(pen,
                leftUpCorner.x+position.x, leftUpCorner.y+position.y,
                width, height);
        }
    }
}