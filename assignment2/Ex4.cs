using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex4
    {
        static void Main()
        {
            Console.Write("Enter Redius : ");
            int a = Convert.ToInt32(Console.ReadLine());
            double area = 2 * 3.14 * a;
            Console.WriteLine("Perimeter of Circle : {0}", area);
        }
    }
}
