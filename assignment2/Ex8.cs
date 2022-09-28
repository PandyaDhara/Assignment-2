using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E8
{
    class Program
    {
        public static void Main()
        {
            int n1, n2;
            bool bothEven;
            bool bothOdd;
            Console.Write("Input First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            if (bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)))
            {
                Console.WriteLine("there're numbers bothEven");
            }

            else if (bothOdd = ((n1 % 2 != 0) && (n2 % 2 != 0)))
            {
                Console.WriteLine("there's a number bothOdd");
            }

            else
            {
                Console.WriteLine("both not same");
            }
        }
    }
}




       
