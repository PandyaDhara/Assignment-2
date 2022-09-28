using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex42
    {
        static void Main()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
           // int[] arr3 = new int[100];
            // int j = 0, k = 0;
            int sort;
            Console.Write("Enter Size Of Array : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < a; i++)
            {
                for (int j = i+1; j < a; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        sort = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = sort;
                    }
                }
            }
            Console.WriteLine("Element Sorted in Acending Order : ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0}",arr1[i]);
            }
        }
    }
}