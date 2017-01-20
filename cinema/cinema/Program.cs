using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            double price = 0;
            if (cat == "Premiere")
            {
                price = 12;
            }
            else if (cat == "Normal")
            {
                price = 7.50;
            }
            else if (cat == "Discount")
            {
                price = 5;
            }
            Console.WriteLine(price * rows * columns);
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace cinema
    {
        class Program
        {
            static void Main(string[] args)
            {
                var cat = Console.ReadLine();
                var rows = int.Parse(Console.ReadLine());
                var columns = int.Parse(Console.ReadLine());
                double price = 0;
                if (cat == "Premiere")
                {
                    price = 12;
                }
                else if (cat == "Normal")
                {
                    price = 7.50;
                }
                else if (cat == "Discount")
                {
                    price = 5;
                }
                var result = (price * rows * columns);
                Console.WriteLine("{0:f2}", result);



            }
        }



    }
}


