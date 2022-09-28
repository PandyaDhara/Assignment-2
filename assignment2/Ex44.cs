using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex44
    {
        static void Main()
        {
            int[] arr1 = new int[100];
            int i, c = 0;
            Console.Write("Enter Size Of Array : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < a; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Enter Value Will be Inserted: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < a; i++)
                Console.WriteLine("{0}", arr1[i]);
            for (i = 0; i < a; i++)
            {
                if (b < arr1[i])
                {
                    c = i;
                    break;
                }
                for (i = a; i >= c; i--)
                    arr1[i] = arr1[i - 1];
                arr1[c] = b;
                Console.Write("After Insert the Value :\n ");
                for (i = 0; i <= a; i++)
                    Console.Write("{0} ", arr1[i]);
                Console.Write("\n");
            }

            //}
            //public static void Main()
            //{
            //    int[] arr1 = new int[10];
            //    int i, n, p = 0, inval;
            //    Console.Write("\n\nInsert New value in the sorted array :\n");
            //    Console.Write("-----------------------------------------\n");

            //    Console.Write("Input the size of array : ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    /* Stored values into the array*/
            //    Console.Write("Input {0} elements in the array in ascending order:\n", n);
            //    for (i = 0; i < n; i++)
            //    {
            //        Console.Write("element - {0} : ", i);
            //        arr1[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.Write("Input the value to be inserted : ");
            //    inval = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("The exist array list is :\n ");
            //    for (i = 0; i < n; i++)
            //        Console.Write("{0} ", arr1[i]);
            //    /* Determine the position where the new value will be insert.*/
            //    for (i = 0; i < n; i++)
            //        if (inval < arr1[i])
            //        {
            //            p = i;
            //            break;
            //        }
            //    /* move all data at right side of the array */
            //    for (i = n; i >= p; i--)
            //        arr1[i] = arr1[i - 1];
            //    /* insert value at the proper position */
            //    arr1[p] = inval;

            //    Console.Write("\n\nAfter Insert the list is :\n ");
            //    for (i = 0; i <= n; i++)
            //        Console.Write("{0} ", arr1[i]);
            //    Console.Write("\n");
            //}
        }
    }
}