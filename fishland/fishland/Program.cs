using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricemackarel = double.Parse(Console.ReadLine());
            double pricecaca = double.Parse(Console.ReadLine());
            double kgpalamud = double.Parse(Console.ReadLine());
            double kgsafrid = double.Parse(Console.ReadLine());
            double kgmidi= double.Parse(Console.ReadLine());
            double pricepalamud = pricemackarel * 1.6;
            double pricesafrid = pricecaca * 1.8;
            double pricemidi = 7.5;
            double totalprice = kgpalamud * pricepalamud + kgsafrid * pricesafrid + kgmidi * pricemidi;
            Console.WriteLine("{0:F2}",totalprice);
        }
      }
    }
    

