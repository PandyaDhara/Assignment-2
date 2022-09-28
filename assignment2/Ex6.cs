using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex6
    {
        static void Main()
        {
            Console.Write("Enter Redius : ");
            int a = Convert.ToInt32(Console.ReadLine());
            double  surface = 4 * 3.14 * a*a;
            Console.WriteLine(" display the surface : {0}", surface);
            double sphere = 1.33 * 3.14 *a * a * a;
            Console.WriteLine(" volume of the sphere : {0}", sphere);

        }
    }
}
