using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("You Are Aligible for Voting ");
            }
            else
            {
                Console.WriteLine("You Are Not Aligible For Voting ");
            }
        }
    }
}
