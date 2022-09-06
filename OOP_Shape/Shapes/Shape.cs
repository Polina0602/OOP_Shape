using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    public abstract class Shape
    {
        protected string color;
        protected bool isFilled;

        public string Color { get { return color; } set { color = value; } }
        public bool IsFilled { get { return isFilled; } set { isFilled = value; } }

        public Shape()
        {
            color = "green";
            isFilled = true;
        }

        public Shape(string getColor, bool getFilled)
        {
            color = getColor;
            isFilled = getFilled;

        }

        public override string ToString()
        {
            if (isFilled)
            {
                return $"A Shape with color {color} and filled";
            }
            else
                return $"A Shape with color {color} and not filled";

        }
    }
}
