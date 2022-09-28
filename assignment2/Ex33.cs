using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Store Into Araay :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[10];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element - {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Elements in Revers");
            for (int i = n-1; i >= 0; i--)
			{
			        Console.Write("{0} ", arr[i]);
			}
            Console.WriteLine();
        }
    }
}
