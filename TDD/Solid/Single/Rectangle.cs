using System.Drawing;
using System.Windows.Forms;

public class Rectangle
{
    private Point point; 
    private float height;
    private float width; 

    public Rectangle(Point point, float height, float width)
    {
        this.point = point; 
        this.height = height;
        this.width = width; 
    }

    public float Area()
    {
        return height*width; 
    }

    public void DrawRectangle(PaintEventArgs eventArgs)
    {
        Pen blackPen = new Pen(Color.Black, 3);
        
        // Create location and size of rectangle.
        float x = point.X;
        float y = point.Y;

        // Draw rectangle to screen.
        eventArgs.Graphics.DrawRectangle(blackPen, x, y, width, height);
    }
}
