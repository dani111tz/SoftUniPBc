﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delsost
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            double p11 = p1 / n * 100;
            double p22 = p2 / n * 100;
            double p33 = p3 / n * 100;

            Console.WriteLine("{0:F2}%",p11);
            Console.WriteLine("{0:F2}%", p22);
            Console.WriteLine("{0:F2}%", p33);
        }
    }
}
