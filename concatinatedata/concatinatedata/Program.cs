using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatinatedata
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn = Console.ReadLine();
            var sn = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are " + fn + " " +sn +","+ " a " + age + "-years old person from " +town+ ".");
        } 
    }
}
