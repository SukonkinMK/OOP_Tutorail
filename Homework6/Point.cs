namespace Homework6;

public class Point : Figure
{
    private double _coordinateX;

    private double _coordinateY;

    public double CoordinateX
    {
        get { return _coordinateX; }
    }

    public double CoordinateY
    {
        get { return _coordinateY; }
    }

    public Point() : this(0, 0, "black", true) { }

    public Point(double x, double y, string color, bool visibility) : base(color, visibility)
    {
        _coordinateX = x;
        _coordinateY = y;
    }

    /// <summary>
    /// Передвижение положение фигуры по вертикали
    /// </summary>
    /// <param name="distance">Величина сдвига</param>
    /// <param name="direction">Направление сдвига</param>
    public override void Move(double distance, Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                _coordinateY += distance;
                break;
            case Direction.Down:
                _coordinateY -= distance;
                break;
            case Direction.Left:
                _coordinateX -= distance;
                break;
            case Direction.Right:
                _coordinateX += distance;
                break;
        }
    }

    public override void Print()
    {
        Console.WriteLine($"Position: ({_coordinateX},{_coordinateY}), color: {Color}, visibility: {Visibility}");
    }

    public override double Square()
    {
        return 0;
    }
}
