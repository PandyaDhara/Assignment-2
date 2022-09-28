using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex40
    {
        static void Main()
        {
            int[] arr1 = new int[100];
           // int[] arr2 = new int[100];
            Console.Write("Enter Size Of Array : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                //arr2[i] = -1;
            }
            int max = arr1[0];
            int min = arr1[0];
            for (int i = 1; i < a; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("Minimum element is : {0}\n", min);
        }
    }
}
