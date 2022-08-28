using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    public class Rectangle : Shape, IGeometricObject
    {
        private double _width;
        private double _length;

        public double Width { get { return _width; } set { _width = value; } }
        public double Length { get { return _length; } set { _length = value; } }

        public Rectangle()
        {
            _width = 1;
            _length = 1;
        }

        public Rectangle(double getWidth, double getLength)
        {
            _width = getWidth;
            _length = getLength;
        }

        public Rectangle(double getWidth, double getLengt, string getColor, bool isFilled) : base(getColor, isFilled)
        {
            _width = getWidth;
            _length = getLengt;
            color = getColor;
            this.isFilled = isFilled;
        }

        /// <summary>
        /// Gets the area of the rectangle
        /// </summary>
        /// <returns></returns>

        public double getArea()
        {
            if (_length > 0 && _width > 0)
            {
                return _length * _width;
            }
            else 
            {
                Console.WriteLine("The width or the length is wrong");
                return 0;
            }
        }

        /// <summary>
        /// Gets the perimeter of the rectangle
        /// </summary>
        /// <returns></returns>
        /// 
        public double getPerimeter()
        {
            if (_length > 0 && _width > 0)
            {
                return 2 * (_width + _length);
            }
            else 
            {
                Console.WriteLine("The width or the length is wrong");
                return 0;
            }
        }

        public override string ToString()
        {
            return $"A Rectangle with width = {_width} and length = {_length}, which is a subclass of {base.ToString()}";

        }
    }
}
