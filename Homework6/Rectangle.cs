namespace Homework6;

public class Rectangle : Point
{
    private readonly double _height;
    private readonly double _width;

    public Rectangle() : this(0, 0, 1, 1, "black", true) { }

    public Rectangle(double x, double y, double width, double height, string color, bool visibility) : base(x, y, color, visibility)
    {
        _height = height;
        _width = width;
    }
    public override double Square()
    {
        return _height * _width;
    }
    public override void Print()
    {
        Console.WriteLine($"Position: ({CoordinateX},{CoordinateY}), Height: {_height}, Width: {_width}, color: {Color}, visibility: {Visibility}");
    }
}
