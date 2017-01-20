using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fv
{
    class Program
    {
        static void Main(string[] args)
        {
            var product =Console.ReadLine();
            Boolean fruit= (product== "banana"|| product == "apple" || product == "grapes" || product == "kiwi" || product == "cherry"|| product == "lemon" || product ==" grapes");
            Boolean vegetable = (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot");

            if (fruit)
            {
                Console.WriteLine("fruit");
            }
            else if (vegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
