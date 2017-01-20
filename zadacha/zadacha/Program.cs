using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {

            double brstudents = double.Parse(Console.ReadLine());

            double grouptop = 0;
            double group4do5 = 0;
            double group3do4 = 0;
            double groupless3 = 0;

            double sumocenka = 0;

            

            for (int i = 0; i < brstudents; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());
                sumocenka += ocenka;
                if (ocenka >= 5)
                {
                    grouptop += 1;
                }
                else if (ocenka >= 4 && ocenka <=4.99)
                {
                    group4do5 += 1;
                }
                else if (ocenka >= 3 && ocenka <= 3.99)
                {
                    group3do4 += 1;
                }
                else if (ocenka < 3)
                {
                    groupless3 += 1;
                }
                
            }
            double prgrouptop = grouptop / brstudents * 100;
            double prgroup4do5 = group4do5 / brstudents * 100;
            double prgroup3do4 = group3do4 / brstudents * 100;
            double prgroupless3 = groupless3 / brstudents * 100;

            double average = sumocenka / brstudents ;

            Console.WriteLine("Top students: {0:F2}%", prgrouptop);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", prgroup4do5);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", prgroup3do4);
            Console.WriteLine("Fail: {0:F2}%", prgroupless3);
            Console.WriteLine("Average: {0:F2}", average);

        }
    }
}
