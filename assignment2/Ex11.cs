using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Given Numebr is Even");
            }
            else
            {
                Console.WriteLine("Given Numebr is Odd");
            }
        }
    }
}
