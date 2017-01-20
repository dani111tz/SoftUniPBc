using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double workdays = double.Parse(Console.ReadLine());
            double earnedmomeyperday = double.Parse(Console.ReadLine());
            double levdolarrate = double.Parse(Console.ReadLine());

            double monthsalary = workdays * earnedmomeyperday*levdolarrate;
            double yearlysalary = monthsalary * 12 + monthsalary * 2.5;
            double netyearlysalary = yearlysalary * 0.75;
            double epd = netyearlysalary / 365;
            Console.WriteLine("{0:F2}",epd);
            


        }
    }
}
