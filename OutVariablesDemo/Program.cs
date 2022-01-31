using System;

namespace OutVariablesDemo
{
    class Rectangle
    {
        public void Calculate(double l,double b,out double area,out double perimeter)
        {
            area = l * b;
            perimeter = 2 * (l + b);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //LINQ
            var x="nikita";
            var y = 10;
            x = "90";
            Rectangle r = new Rectangle();
            double l, b, a, p;
            Console.WriteLine("Enter Length and breadth");
            l = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            r.Calculate(l, b, out a, out p);
            Console.WriteLine("Area is " + a);
            Console.WriteLine("Perimeter is " + p);

        }
    }
}
