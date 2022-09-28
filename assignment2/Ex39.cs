using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex39
    {
        static void Main()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            Console.Write("Enter Size Of Array : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<a; i++)
            {
                Console.Write("Enter Element {0}: ",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = -1;
            }
            for (int i = 0; i < a; i++)
            {
                int ctr = 1;
                for (int j = i + 1; j < a; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        arr2[j] = 0;
                    }
                }

                if (arr2[i] != 0)
                {
                    arr2[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (int i = 0; i < a; i++)
            {
                if (arr2[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], arr2[i]);
                }
            }
        }
    }
}
