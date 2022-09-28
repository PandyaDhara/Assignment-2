using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Angle of Triangle : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Angle of Triangle : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Angle of Triangle : ");
            int c = Convert.ToInt32(Console.ReadLine());

            int z = a + b + c;
            if (z == 180)
            {
                Console.WriteLine("Given Value is Corret to Create Triangle");
            }
            else
            {
                Console.WriteLine("Given Value is Not Corret to Create Triangle");
            }
        }
    }
}
