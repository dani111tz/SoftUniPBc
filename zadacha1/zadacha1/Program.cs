using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialspeed = double.Parse(Console.ReadLine());
            double FirsTimeinMinutes = double.Parse(Console.ReadLine());
            double SecondTimeinminutes = double.Parse(Console.ReadLine());
            double ThirdTimeinminutes = double.Parse(Console.ReadLine());
            double FirtsDistance = initialspeed * FirsTimeinMinutes / 60;
            double Seconddistance = initialspeed * 1.1 * SecondTimeinminutes / 60;
            double Thirddistance = initialspeed * 1.1 * 0.95 * ThirdTimeinminutes / 60;
            double totaldistance = FirtsDistance + Seconddistance + Thirddistance;
            Console.WriteLine("{0:F}", totaldistance);

        }
    }
}
