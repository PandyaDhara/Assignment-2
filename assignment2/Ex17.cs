using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2E17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Higest Value : {0} ",Math.Max(a,Math.Max(b,c)));
        }
    }
}
