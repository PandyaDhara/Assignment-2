using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Grade in Upar Case : ");
            int a=Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;

                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Choice ");
                    break;
            }
        }
    }
}
