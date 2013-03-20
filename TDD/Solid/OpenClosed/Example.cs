using System.Collections.Generic;
using System.Drawing;

namespace Example
{
    public class Shape
    {
        public enum ShapeType { circle, square };

        public ShapeType Type { get; private set; }

        public Shape(ShapeType shapeType)
        {
            Type = shapeType;
        }
    };

    public class Circle : Shape
    {
        double radius;
        Point center;

        public Circle(Point center, double radius)
            : base(ShapeType.circle)
        {
            this.radius = radius;
            this.center = center;
        }
    };

    public class Square : Shape
    {
        double side;
        Point topLeft;

        public Square(Point topLeft, double side)
            : base(ShapeType.square)
        {
            this.side = side;
            this.topLeft = topLeft;
        }
    };

    public class Drawing
    {
        private void DrawSquare(Square square)
        {
        }

        private void DrawCircle(Circle circle)
        {
        }

        private void DrawAllShapes(List<Shape> shapes, int n)
        {
            foreach (Shape shape in shapes)
            {
                switch (shape.Type)
                {
                    case Shape.ShapeType.circle:
                        DrawCircle(shape as Circle);
                        break;
                    case Shape.ShapeType.square:
                        DrawSquare(shape as Square);
                        break;
                }
            }
        }
    }


}
