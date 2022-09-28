using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class ex47
    {
        static void Main(string[] args)
        {
            int n, i, j = 0, l, l2;
            int[] arr1 = new int[50];

            Console.Write("\n\nFind the second largest element in an array :\n\n\n");
           
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            l = 0;

            for (i = 0; i < n; i++)
            {
                if (l < arr1[i])
                {
                    l = arr1[i];
                    j = i;
                }
            }
          
            l2 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (l2 < arr1[i])
                    {
                        l2 = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", l2);
        }
    }
}
