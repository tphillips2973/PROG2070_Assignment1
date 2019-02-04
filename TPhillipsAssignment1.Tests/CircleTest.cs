/*
 * Program Title: PROG2070_TPhillipsAssignment1
 * 
 * Date Modified: 2019/02/04
 * 
 */

using NUnit.Framework;

namespace TPhillipsAssignment1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void GetRadiusTest_Given1_ResultIs1()
        {
            Circle circle = new Circle();
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
            Circle circle = new Circle();
            //Arrange
            circle.GetRadius();

            //Act
            circle.SetRadius(1);

            //Assert
            Assert.AreEqual(1, circle.GetRadius());
        }

        [Test]
        public void GetCircumference_Given3_Return18_85()
        {
            Circle circle = new Circle();

            circle.GetCircumference();

            circle.SetRadius(3);

            Assert.AreEqual(18.85, circle.GetCircumference());
        }

        [Test]
        public void GetArea_Given3_Return28_27()
        {
            Circle circle = new Circle();

            circle.GetArea();

            circle.SetRadius(3);

            Assert.AreEqual(28.27, circle.GetArea());
        }
    }
}
