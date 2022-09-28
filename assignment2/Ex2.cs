using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex2
    {
        static void Main()
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Width : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c=b;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                b--;
            }
        }
    }
}
