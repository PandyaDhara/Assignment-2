using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Store Into Araay :");
            int n = Convert.ToInt32(Console.ReadLine());

            int i;
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            for (i = 0; i < n; i++)
            {
                Console.Write("Element - {0} :", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.Write("Elements Are In First Array : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }
            Console.WriteLine();
            Console.Write("Elements Are Copied In Second Array : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.WriteLine();
        }
    }
}
