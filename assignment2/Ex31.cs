using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Muktiplication");
            Console.WriteLine("4.Division");

            Console.Write("Enter Your Choice : ");
            int c = Convert.ToInt32(Console.ReadLine());

            switch (c)
            { 
                case 1:
                    Console.WriteLine("A + B : {0} ", a + b,c);
                    break;

                case 2:
                    Console.WriteLine("A - B : {0} ",a - b,c);
                    break;

                case 3:
                    Console.WriteLine("A * B : {0} ",a * b,c);
                    break;

                case 4:
                    Console.WriteLine("A / B : {0} ",a / b,c);
                    break; 

            }

        
        }
    }
}
