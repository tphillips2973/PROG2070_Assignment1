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
        //Circle class instance
        public Circle circle = new Circle();

        public CircleTest()
        {
            //circleRadius = 1;
        }

        [Test]
        public void GetRadiusTest_Given1_ResultIs1()
        {
            //Arrange
            circle.SetRadius(1);

            //Act
            int radius = circle.GetRadius();

            //Assert
            Assert.AreEqual(1, radius);
        }

        [Test]
        public void SetRadiusTest_Given1_ResultIs1()
        {
            //Arrange
            circle.GetRadius();

            //Act
            circle.SetRadius(1);

            //Assert
            //Assert.AreEqual(1, radius);
        }
    }
}
