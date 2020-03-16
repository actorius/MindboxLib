using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLib;

namespace MindboxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsCircleSizeEqual()
        {
            var radius = 10;
            var ExpectedASize = Math.PI * Math.Pow(radius, 2);
            var circle = new CircleShape(radius);
            var aSize = AreaCalculator.GetAreaSize(circle);
            Assert.AreEqual(ExpectedASize, aSize);
        }
        [TestMethod]
        public void IsTriangleSizeEqual()
        {
            double a = 14, b = 15, c = 12;
            var triangle = new TriangleShape(a, b, c);
            var p = 1 / 2 * (a + b + c);
            var ExpectedASize = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            var aSize = AreaCalculator.GetAreaSize(triangle);
            Assert.AreEqual(ExpectedASize, aSize);
        }
        [TestMethod]
        public void IsTriangleSquareAngle()
        {
            double a = 30, b = 50, c = 40;
            var triangle = new TriangleShape(a, b, c);

            var isSquareAngle = triangle.IsSquareAngle;
            Assert.AreEqual(true, isSquareAngle);
        }
        [TestMethod]
        public void IsTriangleNotSquareAngle()
        {
            double a = 8, b = 7, c = 9;
            var triangle = new TriangleShape(a, b, c);

            var isSquareAngle = triangle.IsSquareAngle;
            Assert.AreEqual(false, isSquareAngle);
        }
    }
}
