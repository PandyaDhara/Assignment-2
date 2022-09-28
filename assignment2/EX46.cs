using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class ex46
    {
        static void Main(string[] args)
        {
            int i, p, n;
            int[] arr1 = new int[50];



            Console.Write("\n\nDelete an element at desired position from an array :\n\n\n");
          

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete: ");
            p = Convert.ToInt32(Console.ReadLine());
           
            i = 0;
            while (i != p - 1)
                i++;
           
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
}
