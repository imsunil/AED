using System;

public class RectangleModel
{
    public float Height { get; private set; }
    public float Width { get; private set; }

    public RectangleModel(float height, float width)
    {
        Height = height;
        Width = width; 
    }

    public float Area()
    {
        return Height * Width;
    }
}