using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class ex54
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] a = new int[10, 10];
            int[] r = new int[10];
            int[] c = new int[10];

            Console.Write("\n\nFind sum of row and column of a Matrix:\n ");

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", a[i, j]);
                Console.Write("\n");
            }

          
            for (i = 0; i < n; i++)
            {
                r[i] = 0;
                for (j = 0; j < n; j++)
                    r[i] = r[i] + a[i, j];
            }

           
            for (i = 0; i < n; i++)
            {
                c[i] = 0;
                for (j = 0; j < n; j++)
                    c[i] = c[i] + a[j, i];
            }

            Console.Write("The sum of row and column of the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}    ", a[i, j]);
                Console.Write("{0}    ", r[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < n; j++)
            {
                Console.Write("{0}   ", c[j]);
            }
            Console.Write("\n\n"); 
        }
    }
}
