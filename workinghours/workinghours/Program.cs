using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace workinghours
{
    class Program
    {
        static void Main(string[] args)
        {   
            double neededhours = double.Parse(Console.ReadLine());
            double daysavailadle = double.Parse(Console.ReadLine());
            double workerswithoverhours = double.Parse(Console.ReadLine());

            double networkighours = daysavailadle * 0.9 * 8;
            double overtime = workerswithoverhours * 2 * daysavailadle;
            double totalwh = networkighours + overtime;
            double diff = Math.Abs(neededhours-totalwh);
           
            if (totalwh < neededhours)
            {
                Console.WriteLine("Not enough time!{0:0} hours needed.",( diff));
            }
             else
            {
                Console.WriteLine("Yes!{0:0} hours left.",(diff));
            }
            
        }
    }
}
 
            