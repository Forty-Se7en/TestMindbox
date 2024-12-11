using GeometryCalculator.Contracts;
using GeometryCalculator.Figures;

namespace GeometryCalculator
{
    public static class Geometry
    {
        public static double GetArea<T>(T figure) where T : IHasArea => figure.GetArea();
    }

}
