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
    public class ShapeTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            Circle circle = new Circle(2, "red", true);
            string expected = "A Shape with color red and filled";

            //Act
            string actual = circle.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}