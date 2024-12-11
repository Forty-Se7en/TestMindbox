using GeometryCalculator;
using GeometryCalculator.Figures;
using static System.Console;

UseCircle1();
UseCircle2();

UseTriangle1();
UseTriangle2();

ReadLine();

void UseCircle1()
{
    var radius = 10.7;
    var area = Geometry.GetArea(Circle.Create(radius));
    WriteLine($"Area of circle with radius of {radius} is {area:.###}\n");
}

void UseCircle2()
{
    var radius = 8.5;
    var circle = Circle.Create(radius);
    var area = circle.GetArea();
    WriteLine($"Area of circle with radius of {radius} is {area:.###}\n");
}

void UseTriangle1()
{
    var triangle = Triangle.Create(14, 10, 11);
    var area = Geometry.GetArea(triangle);
    bool isRight = triangle.IsRightAngled;
    WriteLine($"Area of triangle with sides [{triangle.A}, {triangle.B}, {triangle.C:.###}] " +
              $"is {area:.###}" +
              $"\nIs right-angled: {isRight}\n");
}

void UseTriangle2()
{
    var sideA = 14.5;
    var sideB = 10.2;
    var sideC = 11;
    var area = Triangle.GetAreaBySides(sideA, sideB, sideC);
    bool isRight = Triangle.IsRightAngledBySides(sideA, sideB, sideC, 00000.1);
    WriteLine($"Area of triangle with sides [{sideA}, {sideB}, {sideC:.###}] " +
              $"is {area:.###}" +
              $"\nIs right-angled: {isRight}\n");
}



