using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Mark Of Physics :  ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mark Of Chemstriy :  ");
            int che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mark Of Mathematics : ");
            int mat = Convert.ToInt32(Console.ReadLine());
            int tot = phy + che + mat;
            int tot1 = mat + phy;
            if (mat >= 65 && phy >= 55 && che >= 50 && tot>=180 || tot1>=140) 
            {
                  Console.WriteLine("Student Can Eligible for Admission ");
            }
            else
            {
                Console.WriteLine("Student Can't Eligible for Admission ");
            }
            
            ////Console.WriteLine("Total : {0}", tot);
            
            ////Console.WriteLine("MatPhy : {0)", tot1);
            //if(tot>=180 || tot1>=140)
            //{
            //    Console.WriteLine("Student Can Eligible for Admission ");
            //}
            //else
            //{
            //    Console.WriteLine("Student Can't Eligible for Admission ");
            //}
        }
    }
}
