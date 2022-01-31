﻿using System;

namespace Operator_Oload
{
    class Student
    {
        public int marks;
        public Student(int m)
        {
            marks = m;
        }

        public int getMarks()
        {
            return marks;
        }

        static public Student operator +(Student s1, Student s2)
        {
            Student res = new Student(0);
            res.marks = s1.marks + s2.marks;
            return res;
        }

        static public bool operator >(Student s1, Student s2)
          {
            if (s1.marks > s2.marks)
                return true;
            else
                return false;
          }

        static public bool operator <(Student s1, Student s2)
        {
            if (s1.marks < s2.marks)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(75);
            Student s2 = new Student(89);
            Student s3 = s1 + s2;
            Console.WriteLine(s3.getMarks());

            if(s1>s2)
            {
                Console.WriteLine("Marks of s1 greater than marks of s2");
            }
            else
            {
                Console.WriteLine("Marks of s1 less than marks of s2");
            }

        }
    }
}
