using System;

namespace ObjectClassExample
{
    class Date
    {
        int day, month, year;
        public Date(int d,int m,int y)
        {
            day = d;
            month = m;
            year = y;

        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

        public override int GetHashCode()
        {
            return day + month + year;
        }

        public override bool Equals(object obj)
        {
            Date d = null;
            if (obj.GetType() == typeof(Date))
            {
                d = (Date)obj;
                if (this.day == d.day && this.month == d.month && this.year == d.year)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }

            else
            {
                Console.WriteLine("Wrong object passed");
                return false;
            }
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(28, 1, 2022);
            Date d2 = new Date(28, 1, 2022);
            if(d1==d2)
            {
                Console.WriteLine("Dates are equal");
            }
            else
            {
                Console.WriteLine("Dates are different");
            }
            Console.WriteLine("*****************************");
            if(d1.Equals(d2))
            {
                Console.WriteLine("Dates are equal");
            }
            else
            {
                Console.WriteLine("Dates are different");
            }
            //Console.WriteLine(d);//ToString method on the object is called
            //Console.WriteLine(d.GetType());
            //Console.WriteLine(d.GetHashCode());
            Console.ReadLine();

        }
    }
}
