using System;

namespace StructDemo
{

        public enum Colors { Red,Blue=844,Yellow,green}

   





    struct Book
    {
        public int bookid;
        public string bookname;

        //public Book(int bid,string bnm)
        //{
        //    bookid = bid;
        //    bookname = bnm;
        //}

        public void Print()
        {
            Console.WriteLine("Bookid =" + bookid + " Book Name = " + bookname);
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Book b;//= new Book(101, "C# black book");
            //b.bookid = 101;
            //b.bookname = "C# Black Book";
            //0.b.Print();
            //Console.WriteLine("Hello World!");
            Colors c = Colors.green;
            Console.WriteLine((int)c);
            
        }
    }
}
