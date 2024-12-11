using GeometryCalculator.Contracts;

namespace GeometryCalculator.Figures
{
    public sealed class Circle : IHasArea
    {
        public double Radius { get; set; }

        private Circle(double radius)
        {
            Radius = radius;
        }

        public static Circle Create(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius value must be greater than 0");
            return new Circle(radius);
        }

        #region IHasArea
        public double GetArea() => GetArea(Radius);
        #endregion

        public static double GetArea(double radius) => Math.PI * Math.Pow(radius, 2);

    }
}
