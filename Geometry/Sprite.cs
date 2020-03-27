using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Sprite : Shape
    {
        List<Shape> shapes;
        public Sprite()
        {
            shapes = new List<Shape>();
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            shape.SetGraphics(graph);
        }
        public void Clear()
        {
            shapes.Clear();
        }
        public override void Draw()
        {
            foreach (Shape shape in shapes)
                shape.Draw();
        }
    }
}
