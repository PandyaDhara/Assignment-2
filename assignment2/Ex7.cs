using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;

            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");    
        }
    }
}
