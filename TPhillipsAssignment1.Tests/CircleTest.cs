using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TPhillipsAssignment1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        private int circleRadius;

        public CircleTest()
        {
            circleRadius = 1;
        }

        public int GetRadius()
        {
            return circleRadius;
        }

        public void SetRadius(int radius)
        {
            circleRadius = radius;
        }

        [Test]
        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * circleRadius;
            circumference = Math.Round(circumference, 2);
            return circumference;
        }

        [Test]
        public double GetArea()
        {
            double area = Math.PI * (circleRadius * circleRadius);
            area = Math.Round(area, 2);
            return area;
        }

        [Test]
        public void checkRadius()
        {
            Circle circle = new Circle();
            int x = 0;

            //Act
            //x = circle.SetRadius(1);
            x = circle.SetRadius(1);

            //Assert
            Assert.AreEqual(x, circle.SetRadius(1));
        }
    }
}
