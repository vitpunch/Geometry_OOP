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
        override public void Move(Pixel position)
        {
            base.Move(position);
            foreach (Shape shape in shapes)
                shape.Move(position);
        }
        public override void Draw()
        {
            foreach (Shape shape in shapes)
                shape.Draw();
        }
    }
}
