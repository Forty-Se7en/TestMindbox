using GeometryCalculator.Figures;
using Xunit;

namespace Geometry.Tests.CircleTests
{
    public class CircleTests
    {
        private const int Precision = 8;
        private const double AreaOfRadius10 = 314.15926535897933;

        [Fact]
        public void CreateCircle()
        {
            double radius = 5.5;
            var circle = Circle.Create(radius);
            Assert.Equal(5.5, circle.Radius);
        }

        [Fact]
        public void CreateCircleWithZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => Circle.Create(0));
        }

        [Fact]
        public void CreateCircleWithNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => Circle.Create(-2));
        }

        [Fact]
        public void CalcCircleAreaSimple()
        {
            double radius = 10;
            Assert.Equal(AreaOfRadius10, Circle.Create(radius).GetArea(), Precision);
        }

        [Theory]
        [MemberData(nameof(GetRadiusData), parameters: 250)]
        public void CalcCircleAreaWithData(double radius, double expected)
        {
            Assert.Equal(expected, Circle.Create(radius).GetArea(), Precision);
        }

        [Fact]
        public void CalcStaticCircleAreaSimple()
        {
            double radius = 10;
            Assert.Equal(AreaOfRadius10, Circle.GetArea(radius), Precision);
        }

        [Theory]
        [MemberData(nameof(GetRadiusData), parameters: 250)]
        public void CalcStaticCircleAreaWithData(double radius, double expected)
        {
            Assert.Equal(expected, Circle.GetArea(radius), Precision);
        }

        public static IEnumerable<object[]> GetRadiusData(int numTests)
        {
            for (int i = 1; i <= numTests; i++)
            {
                var radius = i * 1.289;
                var area = Math.PI * (radius * radius);
                yield return new object[] { radius, area };
            }
        }
    }
}
