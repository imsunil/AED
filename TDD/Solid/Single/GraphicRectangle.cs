using System.Drawing;
using System.Windows.Forms;

public class GraphicRectangle
{
    private Point point;
    private RectangleModel model; 

    public GraphicRectangle(Point point, RectangleModel model)
    {
        this.point = point;
        this.model = model; 
    }

    public void DrawRectangle(PaintEventArgs eventArgs)
    {
        Pen blackPen = new Pen(Color.Black, 3);

        eventArgs.Graphics.DrawRectangle(blackPen, 
            point.X, point.Y, 
            model.Width, model.Height);
    }
}

