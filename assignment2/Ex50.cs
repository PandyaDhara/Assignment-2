using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class ex50
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] a1 = new int[50, 50];
            int[,] b1 = new int[50, 50];
            int[,] c1 = new int[50, 50];

            Console.Write("\n\naddition of two Matrices : ");
            
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    a1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    b1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", a1[i, j]);
            }

            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", b1[i, j]);
            }
           
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    c1[i, j] = a1[i, j] + b1[i, j];
            Console.Write("\nThe Addition of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", c1[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
