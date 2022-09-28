using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Height : ");
            int hei = Convert.ToInt32(Console.ReadLine());

            if (hei < 150)
            {
                Console.WriteLine("The Person is Dwarf");
            }
            else if (hei == 150)
            {
                Console.WriteLine("The Person is Average Height");
            }
            else
            {
                Console.WriteLine("The Person is Tall ");
            }

        }
    }
}