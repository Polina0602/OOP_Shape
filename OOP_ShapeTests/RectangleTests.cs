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
    public class RectangleTests
    {
        [TestMethod()]
        public void getAreaTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2, 5);
            var expected = 10;

            //Act
            var actual = rectangle.getArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getPerimeterTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2, 5);
            var expected = 14;

            //Act
            var actual = rectangle.getPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2, 5, "white", true);
            var expected = "A Rectangle with width = 2 and length = 5, which is a subclass of A Shape with color white and filled";
            
            //Act
            var actual = rectangle.ToString();

            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}