namespace Homework6;

public class Circle : Point
{
    private readonly double _radius;

    private const double pi = Math.PI;

    public Circle() : this(0, 0, 1, "black", true) { }

    public Circle(double x, double y, double radius, string color, bool visibility) : base(x, y, color, visibility)
    {
        _radius = radius;
    }

    public override double Square()
    {
        return _radius * _radius * pi;
    }

    public override void Print()
    {
        Console.WriteLine($"Position: ({CoordinateX},{CoordinateY}), Radius: {_radius}, color: {Color}, visibility: {Visibility}");
    }
}
