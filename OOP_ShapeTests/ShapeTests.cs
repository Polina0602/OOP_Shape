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
        public class ShapeTest : Shape 
        {
            public ShapeTest()
            {

            }
            public ShapeTest(string Color, bool IsFilled) : base(Color, IsFilled)
            {
            }
        };

        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            ShapeTest shape = new ShapeTest();
            string expected = "A Shape with color green and filled";

            //Act
            string actual = shape.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ToStringWithParametersTest()
        {
            // Arrange
            ShapeTest shape = new ShapeTest("red", false);
            string expected = "A Shape with color red and not filled";

            //Act
            string actual = shape.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}