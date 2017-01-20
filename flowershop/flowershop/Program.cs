using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            double brmag = double.Parse(Console.ReadLine());
            double brzum = double.Parse(Console.ReadLine());
            double brroses = double.Parse(Console.ReadLine());
            double brcac = double.Parse(Console.ReadLine());
            double pricepresent = double.Parse(Console.ReadLine());
            double pricemag = 3.25;
            double pricezum = 4;
            double pricerose = 3.50;
            double pricecact = 8;
            double tpricemag = brmag * pricemag * 0.95;
            double tpricezum = brzum * pricezum * 0.95;
            double tpricerose = brroses * pricerose * 0.95;
            double tpricecact = brcac * pricecact * 0.95;
            double totalincome = tpricecact + tpricemag + tpricezum + tpricerose;
            double rest = Math.Abs(totalincome - pricepresent);

            if (totalincome>= pricepresent)
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(rest));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(rest));
            }




        }
    }
}

