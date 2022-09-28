using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Temperature :");
            int tem = Convert.ToInt32(Console.ReadLine());
            if (tem < 0)
            {
                Console.WriteLine("Freezing Weather");
            }
            else if(tem >=0 && tem <10)
            {
                Console.WriteLine("Very Cold Weather");
            }
            else if (tem >= 10 && tem < 20)
            {
                Console.WriteLine("Cold Weather");
            }
            else if (tem >= 20 && tem < 30)
            {
                Console.WriteLine("Normal In Temp");
            }
            else if (tem >= 30 && tem < 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Vety hot");
            }
        }
    }
}
