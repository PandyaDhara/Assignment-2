using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex3
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Opration : ");
            char operation = Convert.ToChar(Console.ReadLine());
            //int c = a + b;
            if (operation == '+')
            {
                Console.WriteLine("{0} + {1} : {2} ",a,b,a+b);
            }
            else if (operation == '-')
            {
                Console.WriteLine("{0} - {1} : {2} ", a, b, a - b);
            }
            else if (operation == '*')
            {
                Console.WriteLine("{0} * {1} : {2} ", a, b, a * b);
            }
            else if (operation == '/')
            {
                Console.WriteLine("{0} / {1} : {2} ", a, b, a / b);
            }
            else
            {
                Console.WriteLine("Please Enter +,-,*,/ Opration");
            }
        }
    }
}
