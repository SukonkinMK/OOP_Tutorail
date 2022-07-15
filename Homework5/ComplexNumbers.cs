namespace Homework5;

public class ComplexNumbers
{
    public int Real { get; set; }
    public int Im { get; set; }

    public ComplexNumbers() : this(0, 0) { }
    public ComplexNumbers(int real, int im)
    {
        Real = real;
        Im = im;
    }

    public static ComplexNumbers operator +(ComplexNumbers lhs, ComplexNumbers rhs)
    {
        return new ComplexNumbers(lhs.Real + rhs.Real, lhs.Im + rhs.Im);
    }
    public static ComplexNumbers operator -(ComplexNumbers lhs, ComplexNumbers rhs)
    {
        return new ComplexNumbers(lhs.Real - rhs.Real , lhs.Im - rhs.Im);
    }
    public static ComplexNumbers operator *(ComplexNumbers lhs, ComplexNumbers rhs)
    {
        return new ComplexNumbers(lhs.Real * rhs.Real - lhs.Im* rhs.Im, lhs.Im* rhs.Real + lhs.Real* rhs.Im);
    }
    public static bool operator ==(ComplexNumbers lhs, ComplexNumbers rhs)
    {
        return lhs.Real == rhs.Real && lhs.Im == rhs.Im;
    }
    public static bool operator !=(ComplexNumbers lhs, ComplexNumbers rhs)
    {
        return lhs.Real != rhs.Real || lhs.Im != rhs.Im;
    }
    public override string ToString()
    {
        return $"{Real} + {Im} * i";
    }
}
