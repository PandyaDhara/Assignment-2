using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Angle of Triangle : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Angle of Triangle : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Angle of Triangle : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("The Triangle is Equilateral Triangle");
            }
            else if (a == c || a == b || b == c)
            {
                Console.WriteLine("The Triangle is Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("The Triangle is Scalene Triangle");
            }
        }
    }
}
