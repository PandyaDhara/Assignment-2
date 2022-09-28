using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {   
                Console.WriteLine("Given Numebr is Positive");
            }
            else
            {                
                Console.WriteLine("Given Numebr is Negative");
            }
        }
    }
}
