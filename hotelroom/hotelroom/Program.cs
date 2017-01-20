using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelroom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            double pricestudio = 0;
            double priceapartament = 0;


            if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    pricestudio = 75.20 * 0.7;
                    priceapartament = 68.70 * 0.9;
                }
                else
                {
                    pricestudio = 75.20;
                    priceapartament = 68.70;
                }
            }
            else if (month == "May" || month == "October")
            {
                if (nights > 14)
                {
                    pricestudio = 50 * 0.7;
                    priceapartament = 65 * 0.9;


                }
                else if (nights > 7)
                {
                    pricestudio = 50 * 0.95;
                }
                else
                {
                    pricestudio = 50;
                    priceapartament = 65;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {

                    priceapartament = 77 * 0.90;

                }
                else
                {
                    pricestudio = 76;
                    priceapartament = 77;
                }
            }
            double tprapar = priceapartament * nights;
            double tprstudio = pricestudio * nights;

            Console.WriteLine("Apartment: {0:F2} lv.", tprapar);
            Console.WriteLine("Studio: {0:F2} lv.",tprstudio);
        }
    }
}
