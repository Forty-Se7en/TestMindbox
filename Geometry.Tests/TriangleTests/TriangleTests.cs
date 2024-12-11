using GeometryCalculator.Figures;
using Xunit;

namespace Geometry.Tests.TriangleTests
{
    public class TriangleTests
    {
        [Fact]
        public void CreateUsualTriangleA()
        {
            var sideA = 14.5;
            var sideB = 10.2;
            var sideC = 11;
            var triangle = Triangle.Create(sideA, sideB, sideC);
            Assert.Equal(14.5, triangle.A);
        }

        [Fact]
        public void CreateUsualTriangleB()
        {
            var sideA = 14.5;
            var sideB = 10.2;
            var sideC = 11;
            var triangle = Triangle.Create(sideA, sideB, sideC);
            Assert.Equal(10.2, triangle.B);
        }

        [Fact]
        public void CreateUsualTriangle()
        {
            var sideA = 14.5;
            var sideB = 10.2;
            var sideC = 11;
            var triangle = Triangle.Create(sideA, sideB, sideC);
            Assert.Equal(11, triangle.C);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(10, 0, 3.5)]
        [InlineData(3.5, 0, 2)]
        [InlineData(3.5, 3, -2)]
        [InlineData(-3.5, -4, -2)]
        [InlineData(10, 20, 30)]
        public void CreateTriangleWithBadArgs(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Triangle.Create(a, b, c));
        }


        [Fact]
        public void CheckRightAngledTriangle()
        {
            var triangle = Triangle.Create(6, 8, 10);
            Assert.Equal(true, triangle.IsRightAngled);
        }

        [Fact]
        public void CheckNotRightAngledTriangle()
        {
            var triangle = Triangle.Create(6, 8, 11);
            Assert.Equal(false, triangle.IsRightAngled);
        }

        [Theory]
        [MemberData(nameof(TriangleTestData.GetNonRightTriangleSidesData), MemberType = typeof(TriangleTestData))]
        public void CheckNotRightAngledTriangleWithData(double a, double b, double c)
        {
            var triangle = Triangle.Create(a, b, c);
            Assert.False(triangle.IsRightAngled);
        }

        [Theory]
        [MemberData(nameof(TriangleTestData.GetNonRightTriangleSidesData), MemberType = typeof(TriangleTestData))]
        public void CheckStaticNotRightAngledTriangleWithData(double a, double b, double c)
        {
            Assert.False(Triangle.IsRightAngledBySides(a, b, c));
        }

        [Theory]
        [MemberData(nameof(TriangleTestData.GetRightTriangleSidesData), MemberType = typeof(TriangleTestData))]
        public void CheckRightAngledTriangleWithData(double a, double b, double c)
        {
            var triangle = Triangle.Create(a, b, c);
            Assert.Equal(true, triangle.IsRightAngled);
        }

        [Fact]
        public void CountTriangleArea()
        {
            var area = Triangle.GetAreaBySides(13, 14, 15);
            Assert.Equal(84, area, 6);
        }

        [Theory]
        [MemberData(nameof(TriangleTestData.GetRightTriangleSidesData), MemberType = typeof(TriangleTestData))]
        public void CountStaticRightAngledTriangleWithData(double a, double b, double c)
        {
            Assert.True(Triangle.IsRightAngledBySides(a, b, c));
        }

    }
}
