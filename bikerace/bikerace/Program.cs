using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikerace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorvel = int.Parse(Console.ReadLine());
            int seniorvel = int.Parse(Console.ReadLine());
            string kindroad = Console.ReadLine();
            double taksajuniors = 0;
            double taksaseniors = 0;


            if (kindroad.ToLower() == "trail")
            {
                taksajuniors = 5.50;
                taksaseniors = 7;
                double totainc = ((taksajuniors * juniorvel) + (taksaseniors * seniorvel));



                double ttinc = totainc * 0.95;

                Console.WriteLine("{0:f2}", ttinc);




            }


            else if (kindroad.ToLower() == "cross-country")
            {
                if (juniorvel + seniorvel >= 50)
                {
                    taksajuniors = 8 * 0.75;
                    taksaseniors = 9.5 * 0.75;
                }
                else
                {
                    taksajuniors = 8;
                    taksaseniors = 9.5;
                }
                double totainc = (taksajuniors * juniorvel + taksaseniors * seniorvel);


                double ttinc = totainc * 0.95;

                Console.WriteLine("{0:f2}", ttinc);
            }
            else if (kindroad.ToLower() == "downhill")
            {
                taksajuniors = 12.25;
                taksaseniors = 13.75;
                double totainc = (taksajuniors * juniorvel + taksaseniors * seniorvel);



                double ttinc = totainc * 0.95;

                Console.WriteLine("{0:f2}", ttinc);


            }


            else if (kindroad.ToLower() == "road")
            {
                taksajuniors = 20;
                taksaseniors = 21.50;
                double totainc = (taksajuniors * juniorvel + taksaseniors * seniorvel);



                double ttinc = totainc * 0.95;

                Console.WriteLine("{0:f2}", ttinc);




            }



        }

    }




}

