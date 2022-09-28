using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Both Are Qual");
            }
            else
            {
                Console.WriteLine("Both Are Not Qual");
            }
        }
    }
}
