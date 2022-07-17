namespace Homework6;

public abstract class Figure : IFigure
{ 
    private string _color;
    private bool _visibility;
    
    public bool Visibility
    {
        get { return _visibility; }
    }

    public string Color
    {
        get { return _color; }
    }

    /// <summary>
    /// Передвижение положение фигуры по вертикали
    /// </summary>
    /// <param name="distance">Величина сдвига</param>
    /// <param name="direction">Направление сдвига</param>
    public abstract void Move(double distance, Direction direction);

    public void ChangeColor(string color)
    {
        this._color = color;
    }

    public abstract void Print();

    public abstract double Square();

    public Figure() : this("black", true) { }

    public Figure(string color, bool visibility)
    {
        _color = color;
        _visibility = visibility;
    }
}
