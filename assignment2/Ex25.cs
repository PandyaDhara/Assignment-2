using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter IDNO : ");
            int idno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name  :");
            string nm =(Console.ReadLine());
            Console.Write("Enter Unit Cosumed : ");
            int unit = Convert.ToInt32(Console.ReadLine());
            if(unit>=100)
            {
                double amt = 1;
                if (unit <= 199)
                {
                    Console.WriteLine("Net Amount Paid by Customer : "+unit*1.20,amt);
                }
                else if (unit > 200 && unit < 400)
                {
                     //amt = 1.20 * 199 + (unit - 200) * 1.50;
                     Console.WriteLine("Ner Amount Paid by Customer : " + unit*1.50,amt);
                }
                else if (unit > 400 && unit < 600)
                {
                     //amt = 1.20 * 199 + 1.50 * 200 + (unit - 400) * 1.80;
                    Console.WriteLine("Ner Amount Paid by Customer : " +unit*1.80,amt);
                }
                else
                { 
                     //amt = 1.20 * 199 + 1.50 *200 + 1.80 *200 + (unit - 600) * 2.00;
                    Console.WriteLine("Ner Amount Paid by Customer : " +unit*2.00,amt);
                }
                //double charge = amt * unit;
                if (amt < 400)
                {
                    double surchage = amt * 0.15;
                    double netamt = amt + surchage;

                    Console.WriteLine("Amount Charges :",amt);
                    Console.WriteLine("Surchage Amount  : ",surchage);
                    Console.WriteLine("Net Amount Paid by Customer :",netamt);
                }
            }
        }
    }
}
