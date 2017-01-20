using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softunitrasport
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbergroups = int.Parse(Console.ReadLine());

            int groupcar = 0;
            int groupminibus = 0;
            int groupsmallbus = 0;
            int grouplargebus = 0;
            int grouptrain = 0;

            int sumpasengers = 0;

            for (int i = 0; i < numbergroups; i++)
            {
                int numberpasengers = int.Parse(Console.ReadLine());
                 sumpasengers += numberpasengers;
                if (numberpasengers <= 5)
                {
                    groupcar += numberpasengers;
                }
                else if (numberpasengers >= 6 && numberpasengers <= 12)
                {
                    groupminibus += numberpasengers;
                }
                else if (numberpasengers >= 13 && numberpasengers <= 25)
                {
                    groupsmallbus += numberpasengers;
                }
                else if (numberpasengers >=26 && numberpasengers <= 40)
                {
                    grouplargebus += numberpasengers;
                }
                else if (numberpasengers >= 41)
                {
                    grouptrain  += numberpasengers;
                }
              }
                int prgroupcar = groupcar / sumpasengers * 100;
                int prgroupminibus = groupminibus / sumpasengers * 100;
                int prgroupsmall = groupsmallbus / sumpasengers * 100;
                int prgrouplarge = grouplargebus / sumpasengers * 100;
                int prgrouptrain = grouptrain / sumpasengers * 100;

                Console.WriteLine(prgroupcar + "%");
                Console.WriteLine(prgroupminibus + "%");
                Console.WriteLine(prgroupsmall + "%");
                Console.WriteLine(prgrouplarge + "%");
                Console.WriteLine(prgrouptrain + "%");

            }
        }
    
}
