using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Store Into Araay :");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0,i;
            int[] arr = new int[10];
            for ( i = 0; i < n; i++)
            {
                Console.Write("Element - {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in Array : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum Of All Elements In Array : {0}",sum);
        }
    }
}
