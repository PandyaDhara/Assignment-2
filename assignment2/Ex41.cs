using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex41
    {
        static void Main()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int j=0, k=0;
            Console.Write("Enter Size Of Array : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < a; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : ");
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nThe Odd elements are :");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
            
        }
    }
}
