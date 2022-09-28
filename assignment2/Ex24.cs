using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Cost Value : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sell Value : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                int c = a - b;
                Console.WriteLine("Your Lose Amount : {0}",c);
            }
            else if (a < b)
            {
                int c = b - a;
                Console.WriteLine("Your Profit Amount : {0}",c);
            }
            else
            {
                Console.WriteLine("You have no Any Profit or Lose");
            }
        }
    }
}
