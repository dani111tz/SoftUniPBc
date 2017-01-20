using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apprice
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallroomarea = double.Parse(Console.ReadLine());
            double kitchearea = double.Parse(Console.ReadLine());
            double priceforsquaremeter= double.Parse(Console.ReadLine());

            double bathroom = smallroomarea / 2;
           double secondroom = smallroomarea * 1.1;
            double thirdroom = secondroom * 1.1;
            double totalarea = smallroomarea + kitchearea + bathroom + secondroom + thirdroom;
            double sumtotalarea = totalarea * 1.05;
            double priceap = sumtotalarea * priceforsquaremeter;
            Console.WriteLine("{0:F2}", priceap);
        }
    }
}
