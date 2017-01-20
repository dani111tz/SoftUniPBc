using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOLLEYBALL
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var numholidays = int.Parse(Console.ReadLine());
            var weekendshometown = int.Parse(Console.ReadLine());
            double weekendsinsofiaplay = (48 - weekendshometown) * 3.0 / 4;
            double playholidaysplayinsf = numholidays * 2.0 / 3;

            var totalplay = weekendsinsofiaplay + playholidaysplayinsf + weekendshometown;
            if (year == "leap")
            {
                Console.WriteLine(Math.Floor(totalplay = (totalplay * 1.15)));
            }
            else Console.WriteLine(Math.Floor(totalplay));

        }
    }
}
