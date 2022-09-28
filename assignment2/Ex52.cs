using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2
{
    class ex52
    {
        static void Main(string[] args)
        {
            int i, j, k, r1, c1, r2, c2, sum = 0;

            int[,] a = new int[50, 50];
            int[,] b = new int[50, 50];
            int[,] c = new int[50, 50];

            Console.Write("\n\nMultiplication of two Matrices : ");
          

            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the number of rows of the second matrix :\n");
            Console.Write("Rows : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != r2)
            {
                Console.Write("Mutiplication of Matrix is not possible.");
                Console.Write("\nColumn of first matrix and row of second matrix must be same.");
            }
            else
            {
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nThe First matrix is :\n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}\t", a[i, j]);
                }

                Console.Write("\nThe Second matrix is :\n");
                for (i = 0; i < r2; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}\t", b[i, j]);
                }
               
                for (i = 0; i < r1; i++)
                    for (j = 0; j < c2; j++)
                        c[i, j] = 0;
                for (i = 0; i < r1; i++)    
                {
                    for (j = 0; j < c2; j++)    
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                            sum = sum + a[i, k] * b[k, j];
                        c[i, j] = sum;
                    }
                }
                Console.Write("\nThe multiplication of two matrix is : \n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("{0}\t", c[i, j]);
                    }
                }
            }
            Console.Write("\n\n");
        }
    }
}
