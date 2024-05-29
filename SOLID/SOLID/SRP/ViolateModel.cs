using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class Square
    {
        public int length;
        public Square(int length)
        {
            this.length = length;
        }
    }

    internal class Circle
    {
        public decimal radius;

        public Circle(decimal radius)
        {
            this.radius = radius;
        }
    }

    internal class AreaCalculator
    {
        public decimal[] shape;
        public AreaCalculator(decimal[] shape)
        {
            this.shape = shape;
        }
    }
}
