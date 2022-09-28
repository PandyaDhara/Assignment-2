using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class ex49
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[3, 3];

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n\n\n");
           

           
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", a[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
