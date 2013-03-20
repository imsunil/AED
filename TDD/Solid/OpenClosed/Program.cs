using System.Collections.Generic;

public class Program
{
    public void DrawAllShapes(List<Shape> shapes)
    {
        foreach (Shape shape in shapes)
        {
            shape.Draw();   
        }
    }
}
