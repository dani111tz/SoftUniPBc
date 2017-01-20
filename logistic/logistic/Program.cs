using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int brt = int.Parse(Console.ReadLine());
            double loadbus = 0;
            double loadtruck = 0;
            double loadtrain = 0;
            double sumt = 0;
            for (int i = 0; i < brt; i++)
            {
                double tovar = double.Parse(Console.ReadLine());
                sumt = tovar + tovar;
                if (tovar > 0 && tovar <= 3)
                {
                    loadbus = loadbus + loadbus;
                }
                else if (tovar >= 4 && tovar <= 11)
                {
                    loadtruck = loadtruck + loadtruck;
                }
                else if (tovar >= 12)
                {
                    loadtrain = loadtrain + loadtrain;
                }
            }
                double average = (loadbus * 200 + loadtruck * 175 + loadtrain * 120) / sumt;

                double ploadtruck = loadtruck / sumt * 100;
                double ploadtrain = loadtrain / sumt * 100;
                double ploadbus = loadbus / sumt * 100;

                Console.WriteLine("{0:F2}", average);
                Console.WriteLine("{0:f2}%", ploadtruck);
                Console.WriteLine("{0:f2}%", ploadtrain);
                Console.WriteLine("{0:f2}%", ploadbus);

            }
        }
    }
    

