using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    // abstract class cannot be instantiated, it can only be inherited
    internal abstract class Shape
    {
        public abstract double Area();
        public abstract void Display();

    }

    internal class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }


        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override void Display()
        {
            Console.WriteLine("Area of Circle is: {0:F4}", Area());
        }
    }

    internal class Square: Shape
    {

        public double side { get; set; }

        internal Square(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }

        public override void Display()
        {
            Console.WriteLine("Area of Square is: {0:F4}", Area());
        }
    }
}
