using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arearectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var fside = x2 - x1
                ;
            var sside = y1 - y2;
            Console.WriteLine(fside*sside);
            Console.WriteLine(2*fside+2*sside);
        }
    }
}
