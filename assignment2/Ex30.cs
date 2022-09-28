using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Month Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            { 
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month have 31 Days");
                    break;
                case 2:
                    Console.WriteLine("Month have 28 Days");
                    Console.WriteLine("In Leap Year 29 Days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 Days");
                    break;

            }
        }
    }
}
