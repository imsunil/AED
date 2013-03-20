using System.Drawing;

public class Square : Shape
{
    double side;
    Point topLeft;

    public Square(Point topLeft, double side)
    {
        this.side = side;
        this.topLeft = topLeft;
    }

    public void Draw()
    {
        // draw the shape
    }
}

