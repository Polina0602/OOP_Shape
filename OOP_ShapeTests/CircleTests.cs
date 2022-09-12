using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OOP_Shape.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void getPerimeterTest()
        {
            //Arrange
            Circle circle = new Circle();
            var expected = 6.28;

            //Act
            var actual = circle.getPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getPerimeterWithParameterTest()
        {
            //Arrange
            Circle circle = new Circle(5);
            var expected = 31.400000000000002;

            //Act
            var actual = circle.getPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getPerimeterWithFullParameterTest()
        {
            //Arrange
            Circle circle = new Circle(5, "white", true);
            var expected = 31.400000000000002;

            //Act
            var actual = circle.getPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getPerimeterWithRadiusZeroTest()
        {
            //Arrange
            Circle circle = new Circle(0);
            var expected = 0;

            //Act
            var actual = circle.getPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getPerimeterWithNegativeRadiusTest()
        {
            //Arrange
            Circle circle = new Circle(-7);
            var expected = 0;

            //Act
            var actual = circle.getPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getAreaTest()
        {
            //Arrange
            Circle circle = new Circle();
            var expected = 3.14;

            //Act
            var actual = circle.getArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getAreaWithOneParameterTest()
        {
            //Arrange
            Circle circle = new Circle(5);
            var expected = 15.700000000000001;

            //Act
            var actual = circle.getArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getAreaWithAllParametersTest()
        {
            //Arrange
            Circle circle = new Circle(5, "white", true);
            var expected = 15.700000000000001;

            //Act
            var actual = circle.getArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getAreaWithRadiusZeroTest()
        {
            //Arrange
            Circle circle = new Circle(0);
            var expected = 0;

            //Act
            var actual = circle.getArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getAreaithNegativeRadiusTest()
        {
            //Arrange
            Circle circle = new Circle(-7);
            var expected = 0;

            //Act
            var actual = circle.getArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange 
            Circle circle = new Circle(5, "blue", false);

            var expected = "A Circle with radius = 5, which is a subclass of A Shape with color blue and not filled";
            //Act
            var actual = circle.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}