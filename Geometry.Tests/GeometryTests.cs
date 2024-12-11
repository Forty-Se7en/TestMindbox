using Geo = GeometryCalculator.Geometry;
using GeometryCalculator.Figures;
using Xunit;

namespace Geometry.Tests
{
    public class GeometryTests
    {
        private const int Precision = 8;
        private const double AreaOfRadius100 = 31415.926535897933;

        [Fact]
        public void TestCircleArea()
        {
            double radius = 100.0;
            var figure = Circle.Create(radius);
            double area = Geo.GetArea(figure);
            Assert.Equal(AreaOfRadius100, area, Precision); // comparing with special precision 
        }

        [Fact]
        public void TestCircleAreaWithData()
        {
            double radius = 100.0;
            var figure = Circle.Create(radius);
            double area = Geo.GetArea(figure);
            Assert.Equal(AreaOfRadius100, area, Precision); // comparing with special precision 
        }

    }
}
