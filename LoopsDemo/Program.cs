using System;

namespace LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //char c;
            //do
            //{
            //    Console.WriteLine("Enter a character");
            //    c = Convert.ToChar(Console.ReadLine());
            //    Console.WriteLine("Entered character is " + c);
            //}
            //while(c!='N' && c!='n');



            for (int i = 1; i <= 20; i++)
            {
                if(i%5==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //int i = 11;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 11;
            //do
            //{
            //    Console.Write(i + "\t");
            //    i++;
            //}
            //while (i <= 10);

        }
    }
}
