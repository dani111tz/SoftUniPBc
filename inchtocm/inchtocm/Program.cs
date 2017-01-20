using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchtocm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inches =");
            var inch = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters = ");
            var inchtocm= inch*2.54;
            Console.WriteLine(inchtocm);
        }
    }
}
