using GeometryCalculator.Contracts;

namespace GeometryCalculator.Figures;

public sealed class Triangle : IHasArea
{
    public const double Tolerance = 0.000000001;

    public double A { get; }

    public double B { get; }

    public double C { get; }

    private bool? _isRightAngled = null;
    private double? _area = null;

    public bool IsRightAngled
    {
        get
        {
            _isRightAngled ??= IsRightAngledBySides(A, B, C);
            return (bool)_isRightAngled;
        }
    }

    private Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public static Triangle Create(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Triangle side must be greater than 0");
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Bad sides, impossible to create triangle");

        return new Triangle(a, b, c);
    }

    #region IHasArea
    public double GetArea()
    {
        _area ??= Triangle.GetAreaBySides(A, B, C);
        return (double)_area;
    }
    #endregion

    public static bool IsRightAngledBySides(double a, double b, double c, double tolerance = Tolerance)
    {
        var sizes = new double[] { a, b, c };
        Array.Sort(sizes);
        return (Math.Abs(Math.Pow(sizes[2], 2) - (Math.Pow(sizes[1], 2) + Math.Pow(sizes[0], 2))) <
                    Tolerance);
    }

    public static double GetAreaBySides(double a, double b, double c)
    {
        // Формула Герона
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
