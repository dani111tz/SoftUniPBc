using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petsfood2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broidni = int.Parse(Console.ReadLine());
            int leftfood = int.Parse(Console.ReadLine());
            double foodfordogperdaykg = double.Parse(Console.ReadLine());
            double foodforcatperdaykg = double.Parse(Console.ReadLine());
            double foodforturtleperdayg = double.Parse(Console.ReadLine());
            double neededfoodforcatkg = broidni * foodforcatperdaykg;
            double neededfoodfordogkg = broidni * foodfordogperdaykg;
            double neededfoodforturtlekg = broidni * foodforturtleperdayg / 1000;
            double totalfoodneeded = neededfoodforcatkg + neededfoodfordogkg + neededfoodforturtlekg;
            double fooddiff = Math.Abs(totalfoodneeded - leftfood);
            if (totalfoodneeded <= leftfood)
            {

                Console.WriteLine(Math.Floor(fooddiff) + " kilos of food left.");
            }
            else
            {
              
                Console.WriteLine(Math.Ceiling(fooddiff) + " more kilos of food are needed.");
            }
        }
    }
}