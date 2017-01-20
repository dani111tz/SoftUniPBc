using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var q = double.Parse(Console.ReadLine());
            double pprice = 0;
            if (product == "coffee")
            { 
                if (town == "Sofia")
                {
                    pprice = 0.50;
                }
                if (town == "Plovdiv")
                {
                    pprice = 0.40;
                }
                if (town == "Varna")
                {
                    pprice = 0.45;
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    pprice = 0.80;
                }
                if (town == "Plovdiv")
                {
                    pprice = 0.70;
                }
                if (town == "Varna")
                {
                    pprice = 0.70;
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    pprice = 1.20;
                }
                if (town == "Plovdiv")
                {
                    pprice = 1.15;
                }
                if (town == "Varna")
                {
                    pprice = 1.10;
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    pprice = 1.45;
                }
                if (town == "Plovdiv")
                {
                    pprice = 1.30;
                }
                if (town == "Varna")
                {
                    pprice = 1.35;
                }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    pprice = 1.60;
                }
                if (town == "Plovdiv")
                {
                    pprice = 1.50;
                }
                if (town == "Varna")
                {
                    pprice = 1.55;
                }
                
            }
            Console.WriteLine(  pprice *q);
        }
    }
}
