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

            //int x = 0;
            //int y;
            //while (x != 3)
            //{

            //    Random rnd = new Random();
            //    y = rnd.Next(1, 11);

            //    Console.WriteLine(y);                                         //Book reference 12

            //    if (y == 10)
            //    {
            //        Console.WriteLine("WIN!!!");                          
            //        Console.ReadLine();
            //        x++;
            //    }
            //    else
            //    {
            //        Console.ReadLine();
            //        x++;
            //    }
            //}

            //Random rnd = new Random();
            //string[] BebeorPoopy = { "Bebe", "Poppy" };

            //int Index = rnd.Next(BebeorPoopy.Length);

            //Console.WriteLine("Bebe or Poppy?    {0}", BebeorPoopy[Index]);


            // Bebe vs Poppy

            //Random rnd = new Random();

            //int poopyHealth, bebeHealth;

            //bebeHealth = 10;
            //poopyHealth = 10;
            //int damage;


            //while (poopyHealth != 0 && bebeHealth != 0)
            //{
            //    damage = rnd.Next(0, 7);
            //    Console.WriteLine("Bebe took " + damage + " damage !");
            //    Console.ReadLine();
            //    bebeHealth -= damage;

            //    damage = rnd.Next(1, 7);
            //    Console.WriteLine("Poppy took " + damage + " damage !");
            //    Console.ReadLine();
            //    poopyHealth -= damage;

            //    if (poopyHealth <= 0)
            //    {
            //        poopyHealth = 0;
            //    }
            //    if (bebeHealth <= 0)                                            // using random class
            //    {
            //        bebeHealth = 0;
            //    }

            //    Console.WriteLine("Bebe health : " + bebeHealth + "/10");
            //    Console.WriteLine("Poppy health : " + poopyHealth + "/10");

            //    Console.ReadLine();

            //}
            //if (bebeHealth != 0 && poopyHealth == 0)
            //{
            //    Console.WriteLine("Beeby win");
            //}
            //if (poopyHealth != 0 && bebeHealth == 0)
            //{
            //    Console.WriteLine("Poopy win");
            //}
            //if (poopyHealth == 0 && bebeHealth == 0)
            //{
            //    Console.WriteLine("Both fainted!");
            //}

            //Straight line distance

            //distance = 

            //Console.WriteLine("Distance between two points");


            //// Enter x1coord
            //Console.WriteLine("Enter x-axis of co-ordinate 1");
            //double x1 = double.Parse(Console.ReadLine());

            ////Enter y1coord
            //Console.WriteLine("Enter y-axis of co-ordinate 1");                           //13
            //double y1 = double.Parse(Console.ReadLine());

            ////Enter x2 coord
            //Console.WriteLine("Enter x-axis of co-ordinate 2");
            //double x2 = double.Parse(Console.ReadLine());

            ////Enter y2 coord
            //Console.WriteLine("Enter y-axis of co-ordinate 2");
            //int y2 = int.Parse(Console.ReadLine());


            ////square root of x1 - x2 "p1"
            //double p1 = (x1 - x2)*(x1 - x2);

            ////square root of y1-y2 "p2"
            //double p2 = (y1 - y2)*(y1 - y2);

            ////p1+p2 "sum"
            //double sum = p1 + p2;

            //// sqrt of sum = distance
            //sum = Math.Sqrt(sum);

            //Console.WriteLine("Distance between : ");
            //Console.WriteLine(sum);

            //Console.WriteLine("Hypopotomos Getter");
            //Console.ReadLine();

            //double a, b, c;

            ////Length 1
            //a = double.Parse(Console.ReadLine());


            ////Length 2
            //b = double.Parse(Console.ReadLine());

            ////A *A                                                    //14

            ////B*B

            ////SQRT OF A+B

            //c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b,2));

            //Console.WriteLine("Rhino = " + c);
            //double angle, length, opposite;

            ////Enter angle
            //Console.WriteLine("Enter angle of a right angled triangle : ");
            //angle = double.Parse(Console.ReadLine());

            ////Length of adjacent 
            //Console.WriteLine("Enter length of adjacent side of triangle : ");            //15
            //length = Double.Parse(Console.ReadLine());

            ////Turn angle into radians
            ////tan of the angle
            //angle = Math.Tan(angle * Math.PI / 180);

            ////Divide (times) by adjacent

            //opposite = angle * length;

            //Console.WriteLine("Length of opposite side : " + opposite);

            //double y, x, w, z;

            //x = 1;
            //w = 20;
            //y = 5;
            //z = 1;

            //y = Math.Pow(Math.Sin(Math.PI / 2 * x) + Math.Cos(Math.PI * 3 / 2 * w), 3) / Math.Sqrt(Math.Tan(2 * Math.PI / 3 * w) - Math.Sin(Math.PI / 2 * x)) + 6;

            //Console.WriteLine(y);

            //Console.WriteLine(y / z);

            //Enter int 1 

            //Enter int 2                               //16

            //int q = 17;

            //int r = 5;


            ////Quotient 
            //Console.WriteLine(q / r);
            ////Remainder 
            //Console.WriteLine(q % r);



            //int d = 4135;

            //int firstd = d / 1000; //1

            //Console.WriteLine(firstd); //print 4

            //int remainderd = d % 1000;

            ////Console.WriteLine(remainderd); //print 135

            //int next = remainderd / 100; //2


            //Console.WriteLine(next); //print 1                        //17

            //int nextagain = remainderd % 100; 

            ////Console.WriteLine(nextagain); //print 35

            //int third = nextagain / 10; //3

            //Console.WriteLine(third);

            //int nexttt = nextagain % 10; //4

            //Console.WriteLine(nexttt);

            //int last = nexttt;


            //Enter elapsed time in seconds
            //Console.WriteLine("Enter a bunch of seconds lol");
            //int s = int.Parse(Console.ReadLine());

            //int sec, min, hrs, day, r;

            //sec = 60;
            //min = 60;
            //hrs = 3600;
            //day = 86400;

            //// Days = divide by 86400
            //Console.WriteLine(s / day + " Days");                      //18
            //r = s % day;

            //// Hours = divide by 3600
            //Console.WriteLine(r / hrs + " Hours");
            //r = r % hrs;

            //// Minutes = divide by 60
            //Console.WriteLine(r / min + " Minutes"); // 11 mins
            //r = r % min;

            ////669
            //Console.WriteLine(r % sec + " Seconds");


            // Enter 3 digit number

            //int n, l, o, p;

            //n = int.Parse(Console.ReadLine());

            ////Reverse it 

            //l = n % 100; // 95
            //o = l % 10; //5 //FIRST                                  //19
            //p = l / 10; //9 //SECOND
            //n = n / 100; //400 //LAST

            ////Console.WriteLine(l + "L");
            ////Console.WriteLine(o + "o");
            ////Console.WriteLine(p + "P");
            ////Console.WriteLine(n + "n");

            //Console.WriteLine(o + "" + p + "" + n);

            //

            //prompt to enter number
            //int number = int.Parse(Console.ReadLine());

            ////Get last digit 
            //number = number % 10;                                           //20
            ////Times last digit by 8

            //number = number * 8;
            ////Displays sum

            //Console.WriteLine(number);


            //input number
            //int number = int.Parse(Console.ReadLine());                       //21

            //number = 1 - number % 2;

            //Console.WriteLine(number);



            // enter amount of money to get from bank

            //need least amount of notes that can give

            //int amount, r, usd1, usd10, usd20, usd5;

            //Console.Write("Enter amount of money to withdraw: ");

            //amount = Int32.Parse(Console.ReadLine());

            //usd20 = (int)(amount / 20);

            //r = amount % 20;

            //usd10 = (int)(r / 10);                                            //22

            //r = r % 10;

            //usd5 = (int)(r / 5);

            //usd1 = r % 5;

            //Console.Write(usd20 + " note(s) of $20 " + usd10 + " note(s) of $10 ");

            //Console.WriteLine(usd5 + " note(s) of $5 and " + usd1 + " note(s) of $1");


            //Enter name

            //string name = "Salmon";

            ////Name backwards 

            //char s = name[0];
            //char a = name[1];
            //char l = name[2];                                     //23
            //char m = name[3];
            //char o = name[4];
            //char n = name[5];

            //string stringname = "" + n + o + m + l + a + s;

            //Console.WriteLine(stringname);

            // one string = first + last name input 
            //string name = "Salmon Almon";

            //string firstname = name.Substring(0, 6);
            //string lastname = name.Substring(7);

            //Console.WriteLine(lastname + " " + firstname);

            //separate first and last name 

            //swaps them

            //string firstname = Console.ReadLine();

            //string nam = firstname.Substring(0, 3);               //24

            //Random random = new Random();

            //int num1 = random.Next(1, 10);
            //int num2 = random.Next(1, 10);
            //int num3 = random.Next(1, 10);

            //Console.WriteLine(nam + num1 + num2 + num3);

            //


            // Sleeps until Christmas

            //Input which day of year it is

            //Input how long u sleep hours

            //Turn to ints

            // do 360 - days

            // days - 1 = sleeps

            // sleeps into hours

            //sleeps / how long sleep a day

            //Display how many 

            //bool one, two;
            //int a, b, c;
            //a = 5;
            //b = 2;
            //c = 7;

            //one = (3 * a + b / 47 - c * b / a > 23) && (b != 5);              //25


            //two = (a * b - c / 2 + 21 * c < 3) || (a >= 5);

            //Console.WriteLine(two);
            //Console.WriteLine(one);


            //between ages of 9 and 12

            //int input = 10;

            //if ( input >= 9 && input <= 12)
            //{
            //    Console.WriteLine("blahblahblahblah");
            //}

            ////Enter number

            //int number = int.Parse(Console.ReadLine());

            ////if number  positibe = true display "positive"                       //26

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");                                        //27
            //}

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //if (number1 % 2 == 0 && number2 % 2 == 0)
            //{
            //    Console.WriteLine("Both Even");                                   //28
            //}

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //if (number1 > 0 && number2 > 0)
            //{
            //    Console.WriteLine("Both Positive");                                   //29
            //}

            //int age = int.Parse(Console.ReadLine());

            //if (age > 14)
            //{
            //    Console.WriteLine("You can drive a car in Kansas (USA)");                    //30
            //}


            //string input = (Console.ReadLine());

            //if (input == input.ToUpper())
            //{
            //    Console.WriteLine("upper :(");                                        //31 + 32
            //}

            //if (input.Length >= 20)
            //{
            //    Console.WriteLine("hehe many letter");
            //}

            //Enter 4 numbers, if one is negative, display there is a negative

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int number3 = int.Parse(Console.ReadLine());
            //int number4 = int.Parse(Console.ReadLine());
            //int number5 = 0;

            //if (!(number1 >= 0)) {
            //    number5++;
            //}
            //if (!(number2 >= 0))
            //{
            //    number5++;
            //}
            //if (!(number3 >= 0))                                                      //33
            //{
            //    number5++;
            //}
            //if (!(number4 >= 0))
            //{
            //    number5++;
            //}

            //if (!(number5 == 1)) 
            //{
            //Console.WriteLine(number5 + " numbers you gave were negative!");
            //}
            //else
            //{
            //    Console.WriteLine(number5 + " number you gave was negative");
            //}


            //Enter two numbers

            // if 1 > 2 swap the values

            //Display numbers, in ascending order


            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //int number3;

            //if (number1 > number2)
            //{
            //    number3 = number2;
            //    number2 = number1;
            //    number1 = number3;                                                    //34
            //}

            //if (number1 > number2)
            //{
            //    Console.WriteLine(number2 + " is number 2");
            //    Console.WriteLine(number1 + " is number 1");
            //} 
            //else
            //{
            //    Console.WriteLine(number1 + " is number 1");
            //    Console.WriteLine(number2 + " is number 2");
            //}



            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int number3 = int.Parse(Console.ReadLine());                              //35
            //int number4;

            //number4 = (number1 + number2 + number3) / 3;

            //if (number4 > 60)
            //{
            //    Console.WriteLine("wowwwww heatwaaaave");
            //}

            Console.ReadLine();

            







        }

    }
}
