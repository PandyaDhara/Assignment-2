using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class Ex45
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i, n, p, x;

            Console.Write("\n\nInsert New value in the unsorted array : \n\n\n");
           
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the value to be inserted : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array :\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
           
            for (i = n; i >= p; i--)
                a[i] = a[i - 1];
           
            a[p - 1] = x;


            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", a[i]);
            Console.Write("\n\n");

        }
    }
}
