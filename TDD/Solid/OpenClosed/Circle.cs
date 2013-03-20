
using System.Drawing;

public class Circle : Shape
{
    private double radius;
    private Point center;

    public Circle(Point center, double radius)
    {
        this.radius = radius;
        this.center = center;
    }

    public void Draw()
    {
        // draw the shape
    }
}
