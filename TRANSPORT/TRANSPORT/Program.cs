using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int numadults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int numnights = int.Parse(Console.ReadLine());
            string kindtransport = Console.ReadLine();
            double priceadults = 0;
            double pricestudents = 0;
            if (kindtransport == "train")

            {
                if (numadults + students >= 50)
                {
                    priceadults = 24.990 * 0.5;
                    pricestudents = 14.990 * 0.5;
                }
                else
                {
                    priceadults = 24.990;
                    pricestudents = 14.990;
                }
            }
            else if (kindtransport == "bus")
            {
                priceadults = 32.50;
                pricestudents = 28.50;
            }
            else if (kindtransport == "boat")
            {
                priceadults = 42.99;
                pricestudents = 39.99;
            }
            else if (kindtransport == "airplane")
            {
                priceadults = 70;
                pricestudents = 50;
            }

                double totalprice = (((students * pricestudents )+ (numadults * priceadults))*2+((numnights)*82.99))* 1.1;
                Console.WriteLine("{0:F2}", totalprice);
            




        }
    }
}
