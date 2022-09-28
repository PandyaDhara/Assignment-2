using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Given Year is Leap Year ");
            }
            else
            {
                Console.WriteLine("Given Year is Not Leap Year ");
            }
        }
    }
}
