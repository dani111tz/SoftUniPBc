using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxnumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MaxValue;


            for (int i = 0; i < n; i++)

            {
                var num = int.Parse(Console.ReadLine());
                
                if (num < max)
                {
                    max = num;
                }

            }
            Console.WriteLine(max);
        }
    }
}
