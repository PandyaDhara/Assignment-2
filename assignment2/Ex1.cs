using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex1
    {
        static void Main(string[] args)
        {
            char a, b, c;
            Console.Write("Enter First Letter : ");
            a = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Second Letter : ");
            b = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Third Letter : ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} ", c, b, a);
        }
    }
}