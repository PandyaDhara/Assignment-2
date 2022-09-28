using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e19
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.Write("Enter Roll No :");
            int rn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            string nm = Console.ReadLine();
            Console.Write("Enter Mark Of Physics :  ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mark Of Chemstriy :  ");
            int che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mark Of Com. Appl. : ");
            int app = Convert.ToInt32(Console.ReadLine());
            int tot = phy + che + app;
            Console.WriteLine("Total Marks : {0} ", tot);
            float per = tot /3.0f;
            Console.WriteLine("Precentages : {0}", per);
            if (per > 80)
            {
                Console.WriteLine("Devision : First ");
            }
            else if (per > 60)
            {
                Console.WriteLine("Devision : Second ");
            }
            else
            {
                Console.WriteLine("Devision : Fail ");
            }
        }
    }
}
