using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganbare1
{
    class Alogrithm1
    {
        public void AlogrithmMethod() 
        {

            //Calcylator
            Console.WriteLine("3 Number Calculator!!!!");

            Console.WriteLine("What do you want to do?");

            string userinput = Console.ReadLine();

            Console.WriteLine("OK!!!");

            Console.WriteLine();

            Console.WriteLine("Number Pls");

            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number Pls");

            int no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number Pls");

            int no3 = Int32.Parse(Console.ReadLine());

            int sum = no1 + no2 + no3;
            int minus = no1 - no2 - no3;
            int divide = no1 / no2 / no3;
            int times = no1 * no2 * no3;
            var arr = new int[] { no1, no2, no3 };
            double avg = Queryable.Average(arr.AsQueryable());

            if (no1 != 0 && no2 != 0 && no3 != 0)
            {
                if (userinput == "+")
                {
                    Console.WriteLine("TOTAL = " + sum);
                }
                if (userinput == "-")
                {
                    Console.WriteLine("TOTAL = "+ minus);
                }
                if (userinput == "*")
                {
                    Console.WriteLine("TOTAL = " + times);
                }
                if (userinput == "/")
                {
                    Console.WriteLine("TOTAL = " + divide);
                }
            }

            Console.ReadLine();

            Console.WriteLine("Do you want to know the average just for fun lol");

            string huh = Console.ReadLine();

            if (huh == "y")
            {
                Console.WriteLine("AVERAGE: " + avg);
            }
            else if (huh == "n")
            {
                Console.WriteLine("Aw okay :(....");
            }

            Console.ReadLine();
        }


    }
}
