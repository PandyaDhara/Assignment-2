using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any Characterv : ");
            char ch=Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine("Vowel Number",ch);
            }
            else
            {
                Console.WriteLine("Constant Number ",ch);
            }
        }
    }
}
