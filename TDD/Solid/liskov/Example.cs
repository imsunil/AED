using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public interface Shape
    {}

    public class Circle : Shape
    {}

    public class Triangle : Shape
    {}

    public class Program
    {
        public void DrawCircle(Circle circle)
        {   
        }

        public void DrawTriangle(Triangle triangle)
        {         
        }

        public void DrawAllShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                if(shape is Circle)
                    DrawCircle(shape as Circle);
                else if(shape is Triangle)
                    DrawTriangle(shape as Triangle);
            }
        }
    }


}
