namespace Homework5;

public class SimpleFractions
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public SimpleFractions() : this(0, 1) { }
    public SimpleFractions(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Делитель дроби равен нулю");
        }
        if (denominator < 0)
        {
            numerator = -1 * numerator;
            denominator = Math.Abs(denominator);
        }
        int nod = GetNOD(Math.Abs(numerator), Math.Abs(denominator));
        Numerator = numerator / nod;
        Denominator = denominator / nod;
    }

    private static int GetNOD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }
        return Math.Max(a, b);
    }

    public static bool operator ==(SimpleFractions lhs, SimpleFractions rhs)
    {
        return lhs.Numerator == rhs.Numerator && lhs.Denominator == rhs.Denominator;
    }
    public static bool operator !=(SimpleFractions lhs, SimpleFractions rhs)
    {
        return lhs.Numerator != rhs.Numerator || lhs.Denominator != rhs.Denominator;
    }
    public bool Equals(SimpleFractions lhs)
    {
        return this == lhs;
    }

    public static bool operator <(SimpleFractions lhs, SimpleFractions rhs)
    {
        return lhs.Numerator * rhs.Denominator < rhs.Numerator * lhs.Denominator;
    }
    public static bool operator >(SimpleFractions lhs, SimpleFractions rhs)
    {
        return lhs.Numerator * rhs.Denominator > rhs.Numerator * lhs.Denominator;
    }
    public static bool operator <=(SimpleFractions lhs, SimpleFractions rhs)
    {
        return lhs.Numerator * rhs.Denominator <= rhs.Numerator * lhs.Denominator;
    }
    public static bool operator >=(SimpleFractions lhs, SimpleFractions rhs)
    {
        return lhs.Numerator * rhs.Denominator >= rhs.Numerator * lhs.Denominator;
    }
    public static SimpleFractions operator +(SimpleFractions lhs, SimpleFractions rhs)
    {
        return new(lhs.Numerator * rhs.Denominator + rhs.Numerator * lhs.Denominator, lhs.Denominator * rhs.Denominator);
    }
    public static SimpleFractions operator -(SimpleFractions lhs, SimpleFractions rhs)
    {
        return new(lhs.Numerator * rhs.Denominator - rhs.Numerator * lhs.Denominator, lhs.Denominator * rhs.Denominator);
    }
    public static SimpleFractions operator ++(SimpleFractions r)
    {
        return new(r.Numerator + r.Denominator, r.Denominator);
    }
    public static SimpleFractions operator --(SimpleFractions r)
    {
        return new(r.Numerator - r.Denominator, r.Denominator);
    }
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
    public static explicit operator float(SimpleFractions r)
    {
        return (float)r.Numerator / r.Denominator;
    }
    public static explicit operator SimpleFractions(float r)
    {
        return new((int)(r * 1_000_000), 1_000_000);
    }
    public static explicit operator int(SimpleFractions r)
    {
        return r.Numerator / r.Denominator;
    }
    public static explicit operator SimpleFractions(int r)
    {
        return new(r, 1);
    }
    public static SimpleFractions operator *(SimpleFractions lhs, SimpleFractions rhs)
    {
        return new SimpleFractions(lhs.Numerator * rhs.Numerator, lhs.Denominator * rhs.Denominator);
    }
    public static SimpleFractions operator /(SimpleFractions lhs, SimpleFractions rhs)
    {
        if (rhs.Numerator == 0)
            throw new ArgumentException("происходит деление на 0");
        return new SimpleFractions(lhs.Numerator * rhs.Denominator, rhs.Numerator * lhs.Denominator);
    }
    public static int operator %(SimpleFractions lhs, SimpleFractions rhs)
    {
        if (rhs.Numerator == 0)
            throw new ArgumentException("происходит деление на 0");
        return (lhs.Numerator * rhs.Denominator) % (rhs.Numerator * lhs.Denominator);
    }
}
