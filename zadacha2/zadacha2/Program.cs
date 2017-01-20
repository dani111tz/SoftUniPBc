using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            double SabraniPari = double.Parse(Console.ReadLine());
            double ShrirochinaPod = double.Parse(Console.ReadLine());
            double DuljinainaPod = double.Parse(Console.ReadLine());
            double StranaTriygylnik = double.Parse(Console.ReadLine());
            double VisochinaTriygylnik = double.Parse(Console.ReadLine());
            double CenaEdnaPlochka = double.Parse(Console.ReadLine());
            double SumaMaistor = double.Parse(Console.ReadLine());

            double PloshtnaPoda = ShrirochinaPod * DuljinainaPod;
            double PloshtEdnaPlochka = StranaTriygylnik * VisochinaTriygylnik / 2;
            double NeobhodimiPlochki = (Math.Ceiling(PloshtnaPoda / PloshtEdnaPlochka)) + 5;
            double ObshtaSuma = NeobhodimiPlochki * CenaEdnaPlochka + SumaMaistor;
            double Diff = Math.Abs(SabraniPari - ObshtaSuma);

            if (SabraniPari >= ObshtaSuma)
            {
                Console.WriteLine("{0:F2} lv left.",Diff);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.",Diff);
            }




        }
    }
}
