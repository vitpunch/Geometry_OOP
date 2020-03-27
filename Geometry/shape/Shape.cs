using System.Drawing;

namespace Geometry
{
    class Shape
    {
        public Shape()
        {     
            pen = new Pen(Color.Blue);
        }
        protected Graphics graph;
        protected Pen pen;
        public void SetGraphics(Graphics graph)
        {
            this.graph = graph;
        }        
    }
}
