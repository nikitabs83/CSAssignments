using System;

namespace PolymorphismExample
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle :Shape
    {
        double radius;
        public Circle(double r)
        {
            radius = r;
        }

        public override double CalculateArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }
    }

    class Rectangle:Shape
    {
        double length, breadth;
        public Rectangle(double l,double b)
        {
            length = l;
            breadth = b;
        }

        public override double CalculateArea()
        {
            double area = length * breadth;
            return area;
        }
    }

    class Program
    {
        public void CallCalculateArea(Shape s)
        {
            if (s.GetType() == typeof(Circle))
            {
                Console.WriteLine("Area of Circle "+s.CalculateArea());
            }
            else if(s.GetType()==typeof(Rectangle))
            {
                Console.WriteLine("Area of Rectangle is " + s.CalculateArea());
            }
        }
        static void Main(string[] args)
        {
            Shape s = new Circle(4.6);
            Shape s1 = new Rectangle(7, 6);
            Program p = new Program();
            p.CallCalculateArea(s);
            p.CallCalculateArea(s1);
            Console.WriteLine(s);
            Console.WriteLine(s1);

        }
    }
}
