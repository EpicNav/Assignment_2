using NUnit.Framework;
using Assignment_2;

namespace Assignment2_UnitTesting
{
    public class Tests
    {
        [Test]
        public void getLength_ofRectangle()
        {
            // Act
            var expected = 3;
            var calc = new Calculations();

            // Arrange
            calc.SetLength((10 / 2) - 2);

            // Assert
            Assert.AreEqual(expected, calc.GetLength());
        }

        [Test]
        public void getWidth_ofRectangle()
        {
            // Act
            var expected = 8;
            var calc = new Calculations();

            // Arrange
            calc.SetWidth((20 / 2) - 2);

            // Assert
            Assert.AreEqual(expected, calc.GetWidth());
        }

        [Test]
        public void getPerimeter_ofRectangle()
        {
            // Act
            var expected = 22;
            var calc = new Calculations();

            // Arrange
            calc.SetLength((10 / 2) - 2);
            calc.SetWidth((20 / 2) - 2);

            // Assert
            Assert.AreEqual(expected, calc.GetPerimeter());
        }

        [Test]
        public void getArea_ofRectangle()
        {
            // Act
            var expected = 24;
            var calc = new Calculations();

            // Arrange
            calc.SetLength((10 / 2) - 2);
            calc.SetWidth((20 / 2) - 2);

            // Assert
            Assert.AreEqual(expected, calc.GetArea());
        }

    }
}