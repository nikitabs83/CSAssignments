﻿using System;

namespace passbyValref
{
    class MathClass
    {
        public void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 nos");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values before swapping x= {0} and Y = {1}", x, y);

            MathClass obj = new MathClass();
            obj.Swap(ref x, ref y);

            Console.WriteLine("Values after swapping x= {0} and Y = {1}", x, y);



        }
    }
}
