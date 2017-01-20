using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excellent
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sum = a+b+c;
            var sp = (sum % 60).ToString("00");
            var fp = sum / 60;
            Console.WriteLine(fp+":"+sp);
            
        }
    }
}

