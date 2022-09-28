using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Ex5
    {
        static void Main()
        {
            Console.Write("Enter Distance: ");
            int dis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hours : ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds : ");
            int sec = Convert.ToInt32(Console.ReadLine());

            double timeSec = (hour * 3600) + (min * 60) + sec;
            double meterssec = dis / timeSec;
            double kmhors = (dis / 1000) / (timeSec / 3600);
            double mileshors = kmhors / 1.609;

            Console.WriteLine("Your speed in metres/sec is {0}", meterssec);
            Console.WriteLine("Your speed in km/h is {0}", kmhors);
            Console.WriteLine("Your speed in miles/h is {0}", mileshors);
        }
    }
}
