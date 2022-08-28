using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void getPerimeterTest()
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
        public void getAreaTest()
        {
            //Arrange
            Circle circle = new Circle(5.0);
            var expected = 15.700000000000001;

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