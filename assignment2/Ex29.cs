using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Month : ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch(a)
            { 
                case 1:
                        Console.WriteLine("January");
                        break;
                case 2:
                        Console.WriteLine("Febaruary");
                        break;

                case 3:
                        Console.WriteLine("March");
                        break;
                case 4:
                        Console.WriteLine("April");
                        break;
                case 5:
                        Console.WriteLine("May");
                        break;
                case 6:
                        Console.WriteLine("June");
                        break;
                case 7:
                        Console.WriteLine("Julay");
                        break;
                case 8: 
                        Console.WriteLine("August");
                        break;
                case 9  :
                        Console.WriteLine("September");
                        break;
                case 10:
                        Console.WriteLine("Octomber");
                        break;
                case 11:
                        Console.WriteLine("November");
                        break;
                case 12:
                        Console.WriteLine("December");
                        break;
            }
        }
    }
}
