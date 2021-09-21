using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganbare1
{
    class Program
    {
        static void Main(string[] args)
        {
            //words words = new words();
            //words.showWords();

            //face face = new face();

            //face.showFace();

            //Alogrithm1 alogrithm = new Alogrithm1();          //book reference 1

            //alogrithm.AlogrithmMethod();

            //foreach (string type in Pokemon.types) 
            //{

            //    Console.Write(type + " " );
            //    Console.Write(type);
            //}

            //string firstName = Console.ReadLine();            //book reference 2
            //string lastName = Console.ReadLine();

            //Console.WriteLine(firstName + " " + lastName);

            //Console.ReadLine();

            //string a, b, c;

            //a = "hello";

            //b = "world";                                                  //Book reference 3

            //c = a;

            //a = b;

            //b = c;

            //Console.WriteLine(a + b);

            //int a, b;

            //a = Int32.Parse(Console.ReadLine());
            //b = Int32.Parse(Console.ReadLine());

            //a = a + b; // a = 1 + 2                                                 //Book reference 4

            //b = a - b; // b = 3 - 2

            //a = a - b; // a = 3 = 1

            //Console.WriteLine("A = " + a + " B = " + b);

            //Console.WriteLine("Rectangle Area Calculator!");


            //Console.WriteLine("Enter Length : ");

            //int length = Int32.Parse(Console.ReadLine());
            //// enter length

            //Console.WriteLine("Enter height : ");                                   // Book reference 5

            //int height = Int32.Parse(Console.ReadLine());
            ////enter height 

            ////display area
            //int area = length * height;

            //Console.WriteLine("area is " + area);

            // A = pi*r*2



            //double pi = Math.PI;

            //Console.WriteLine("CIRCLE AREA!!!");

            //Console.WriteLine("Radius pls : ");

            //double r = double.Parse(Console.ReadLine());                        // Book reference 6

            //double area = Math.PI * r * r;

            //Console.WriteLine("Area : " + area);



            // Fuel Economy 

            // MPG = MILES DRIVEN / GALLONS OF GAS USED 

            //enter miles driven 

            //Console.WriteLine("MILES PER GALLON - FUEL ECONOMY");
            //Console.WriteLine("Enter miles driven : ");

            //double miles = double.Parse(Console.ReadLine());

            ////enter gallons of gas used
            //Console.WriteLine("Enter gallons of gas used : ");

            //double gallons = double.Parse(Console.ReadLine());

            //// mpg = miles / gallons                                          //Book reference 7

            //double mpg = miles / gallons;

            //Console.WriteLine("miles per gallon : " + mpg);

            //if (mpg > 100)
            //{
            //    Console.WriteLine("Your fuel economy is good!");
            //}

            //else
            //{
            //    Console.WriteLine("Your fuel economy is bad :(.....");
            //}
            //Display mpg
            //


            //Console.WriteLine("Calculate Distance Travelled!!!!!!");

            ////Enter acceleration
            //double acc = double.Parse(Console.ReadLine()); //m/s*2

            ////Enter time car travelled
            //double time = double.Parse(Console.ReadLine()); //s                   //Book reference 8

            ////Calc distance travelled

            //double distance = 0.5 * acc * time * time ; //m

            ////Displays distance travelled 

            //Console.WriteLine(distance + "m");



            ////Kelvin to Fahrenheit
            //Console.WriteLine("Fahrenheit to Kelvin");

            //Console.WriteLine("Enter temperature in Fahrenheit");
            ////Enter temp in degrees F
            //double f = double.Parse(Console.ReadLine());                          // Book reference 9

            //double k = (f + 459.67) / 1.8;
            //// k = (f + 459.67) / 1.8

            ////Display ans + Kelvin
            //Console.WriteLine(f + " degree(s) fahrenheit is " + k + " Kelvin");


            //VAT

            //VAT = 19% = /0.81

            //const double VAT = 1.19;
            //Console.WriteLine("WORK OUT PRICE AFTER VAT!!!!!");

            ////enter starting price
            //double start = double.Parse(Console.ReadLine());                    // Book reference 10

            //// calc after price with VAT
            //double final = start * VAT;

            ////Display after price
            //Console.WriteLine("FINAL PRICE IS " + final);




            //SALES DISCOUNT

            //Enter price of item
            //Console.WriteLine("Enter original price");
            //double ori = double.Parse(Console.ReadLine());

            ////Enter offered discount %
            //Console.WriteLine("Enter offered discount % (out of 100)");
            //double per = double.Parse(Console.ReadLine());

            ////Calculate -- original price                                       //Book reference 11

            //per = per / 100 + 1;
            //// number /100
            ////number +1

            ////number * original price

            //double final = per * ori;
            ////Display new price

            //Console.WriteLine("discounted price is : £" + final );

            int x = 0;

            while (x != 4)
            {

                Random rnd = new Random();
                int y = rnd.Next(1, 10);

                Console.WriteLine(y);

                if (y == 10)
                {
                    Console.WriteLine("WIN!!!");
                }
                if (x == 0)
                {
                    Console.WriteLine("TRY AGAIN:(( Three more attempts");
                    x++;
                }
                if (x == 1)
                {
                    Console.WriteLine("TRY AGAIN:(( Three more attempts");
                    x++;
                }
                if (x == 2)
                {
                    Console.WriteLine("TRY AGAIN:(( Three more attempts");
                    x++;
                }

            }

            Console.ReadLine();







        }

    }
}
