using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_Shape
{
    public class Circle : Shape, IGeometricObject
    {
        private const double PI = 3.14;
        private double _radius;
        public double Radius { get { return _radius; } set { _radius = value;} }

        public Circle()
        {
            _radius = 1;
        }

        public Circle(double getRadius)
        {
            _radius = getRadius;
        }

        public Circle(double getRadius, string getColor, bool isFilled) : base(getColor, isFilled)
        {
            color = getColor;
            _radius = getRadius;
            this.isFilled = isFilled;

        }

        /// <summary>
        /// Gets the area of the circle
        /// </summary>
        /// <returns></returns>

        public double getArea()
        {
            if (_radius > 0)
            {
                return PI * _radius;
            }
            else
            {
                Console.WriteLine("The radius is wrong");
                return 0;
            }
            
        }

        /// <summary>
        /// Gets the perimeter of the circle 
        /// </summary>
        /// <returns></returns>

        public double getPerimeter()
        {
            if (_radius > 0)
            {
                return 2 * PI * _radius;
            }
            else
            {
                Console.WriteLine("The radius is wrong");
                return 0;
            }
        }

        public override string ToString()
        {
                return $"A Circle with radius = {_radius}, which is a subclass of {base.ToString()}";

        }
    }
}
