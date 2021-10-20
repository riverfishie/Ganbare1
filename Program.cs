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

            //input a + b

            //int a, b;

            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            ////display the one that is larger                                      //36

            //if ( a > b )
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}

            //enter a positive int

            //int number = int.Parse(Console.ReadLine());

            //if even - say even 

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");                                    //37
            //}
            //else if (number % 2 != 0)
            //{
            //    Console.WriteLine("odd");
            //}
            //if odd - say odd


            //enter pay rate 

            //int rate = int.Parse(Console.ReadLine());

            ////enter hours

            //int hours = int.Parse(Console.ReadLine());

            //if (hours > 40)
            //{
            //    //calcs hours that are over 40
            //    int over = hours - 40;
            //    //hours * rate = what get for hours under or equal to 40
            //    int basepay = hours * rate;
            //    //grosspay is the basepay + 1.5 of rate * the hours over
            //    int grosspay = basepay + ((rate * 3 / 2) * over);

            //    Console.WriteLine(grosspay);
            //}
            //else
            //{
            //    int grosspay = hours * rate;                                      //38

            //    Console.WriteLine(grosspay);
            //}

            //if over 40 , over = hours - 40

            // hours * 40 


            // hours over * pay and a half (over / 2 * 3)

            //Display gross pay for week 



            //int x = int.Parse(Console.ReadLine());

            //int w = x * 3 - 15;

            //int z = (w + 7) * (x + 4) - 10;                                   //39

            //if (w > x && z > x)
            //{
            //    x = x++;
            //    int y = x / 2 + 4;
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    int y = x / 4 + 2;
            //    Console.WriteLine(y);
            //}

            // enter team name 1

            //string team1 = Console.ReadLine();

            ////Enter team name 2

            //string team2 = Console.ReadLine();

            ////enter score for team 1

            //int score1 = int.Parse(Console.ReadLine());                           //40

            ////enter score for team 2 

            //int score2 = int.Parse(Console.ReadLine());

            ////display winner

            //if (score1 > score2)
            //{
            //    Console.WriteLine(team1 + " is winner!");
            //}
            //else
            //{
            //    Console.WriteLine(team2 + " is winner!");
            //}

            //enter number

            //int number = int.Parse(Console.ReadLine());

            //if (number % 6 != 0)
            //{
            //    Console.WriteLine(number + " is not a multiple of 6");                //41
            //}
            //else
            //{
            //    Console.WriteLine(number + " is a multiple of 6");
            //}

            //number % 6 != 0

            //Not multiple of 6 







            //Enter a number

            //int number = int.Parse(Console.ReadLine());

            ////if the number is multiple of 4, say so

            //if (number % 4 == 0)
            //{
            //    Console.WriteLine(number + " is multiple of 4");                                      //42
            //}

            //else
            //{
            //    int times = number / 4;
            //    int remainder = number % times;

            //    Console.WriteLine(number + " = " + times + " x " + 4 + " + " + remainder);
            //}

            // if not, show the number, quotient, and remainder

            // 4

            //number that 4 times by = int number / 4

            //remainder = number % number that 4 times by 




            //Enter 3 ints lenghts of triangle

            //int len1 = int.Parse(Console.ReadLine());
            //int len2 = int.Parse(Console.ReadLine());
            //int len3 = int.Parse(Console.ReadLine());

            ////display if the 3 lengths can make up a triangle

            //if (len1 > (len2 + len3) || len2 > (len1 + len3) || len3 > (len1 + len2))                     //43
            //{
            //    Console.WriteLine("cannot triangle!");
            //}
            //else
            //{
            //    Console.WriteLine("can triangle :)...");
            //}
            //// if one side is more than sum of two others, and two side is more than sum of two others,
            //// and three side is more than sum of two others, cannot be a valid triangle
            ////else it is a valid triangle


            //Enter three numbers

            //int len1 = int.Parse(Console.ReadLine());                                                         //44
            //int len2 = int.Parse(Console.ReadLine());
            //int len3 = int.Parse(Console.ReadLine());

            ////displays if can be a right angled triangle or not

            ////if a*a + b*b == c*c , triangle yes

            //if (len1*len1 + len2*len2 == len3*len3)
            //{
            //    Console.WriteLine("yes triangle... :)");
            //}
            //else
            //{
            //    Console.WriteLine("no!!!!!");
            //}
            //else....no


            ////Enter integer between 0-999

            //int number = int.Parse(Console.ReadLine());

            ////counts the amount of digits it has

            //if ((number / 10) == 0)
            //{
            //    Console.WriteLine(number + " is one Digit");                                                  //45
            //}
            //else if ((number / 100) == 0)
            //{
            //    Console.WriteLine(number + " this one is two digits");
            //}
            //else if ((number / 1000) == 0)
            //{
            //    Console.WriteLine(number + " three!!!!!!!!");
            //}

            ////Displays
            ///
            //double a, y;

            //a = Double.Parse(Console.ReadLine());

            //if (a < 1)
            //{
            //    y = 5 + a;
            //    Console.WriteLine(y);
            //}
            //else if (a < 5)
            //{
            //    y = 23 / a;
            //    Console.WriteLine(y);
            //}
            //else if (a < 10)
            //{
            //    y = 5 * a;
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.WriteLine("Error!");
            //}


            //team names 
            //string name1 = Console.ReadLine();
            //string name2 = Console.ReadLine();

            //int score1 = int.Parse(Console.ReadLine());
            //int score2 = int.Parse(Console.ReadLine());                           //46

            ////scores for each

            ////displays winner

            //if (score1 > score2)
            //{
            //    Console.WriteLine(name1 + " Winner");
            //}
            //else if (score2 > score1)
            //{
            //    Console.WriteLine(name2 + " Winner");
            //}
            //else if (score1 == score2)
            //{
            //    Console.WriteLine("tie.......:(");
            //}
            //and displays tie if both are tie





            //Enter integer between -9999 + 9999

            //int number = int.Parse(Console.ReadLine());

            //////Counts the amount of digits 

            //if ((number <= 0 && number >= -9) || (number >= 0 && number <= 9))
            //{
            //    Console.WriteLine("1 digit");
            //}
            //else if ((number <= -9 && number >= -99) || (number >= 9 && number <= 99))
            //{
            //    Console.WriteLine("2 digit");
            //}
            //else if ((number <= -99 && number >= -999) || (number >= 99 && number <= 999))
            //{
            //    Console.WriteLine("3 digit");
            //}
            //else if ((number <= -999 && number >= -9999) || (number >= 999 && number <= 9999))                            //47
            //{
            //    Console.WriteLine("4 digits");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid!!");
            //}

            //You entered an N digit number!



            //4 options of conversion 
            //error if not one is selected

            //Console.WriteLine("Select a currency to exchange");

            //Console.WriteLine("1. GBP to EUR");
            //Console.WriteLine("2. GBP to USD");
            //Console.WriteLine("3. GBP to JPY");                                               //48
            //Console.WriteLine("4. GBP to CAD");

            //double eur, usd, jpy, cad;

            //eur = 1.17;
            //usd = 1.36;
            //jpy = 151.23;
            //cad = 1.72;

            //int selection = int.Parse(Console.ReadLine());

            //int number = int.Parse(Console.ReadLine());

            //switch (selection)
            //{
            //    case 1:

            //        Console.WriteLine("€ " + number * eur);

            //        break;

            //    case 2:
            //        Console.WriteLine("$ " + number * usd);
            //        break;

            //    case 3:
            //        Console.WriteLine( number * jpy + " ¥ ");                                 //49
            //        break;

            //    case 4:
            //        Console.WriteLine("$ " + number * cad);
            //        break;

            //    default:
            //        Console.WriteLine("waaaaa");
            //        break;
            //}
            //EUR - 0.87
            //GBP - 0.78
            //JPY - 108.55
            //CAD - 1.33

            //INPUT AMOUNT TO CONVERT

            //CONVERT

            //PRINT

            //Months

            //int index = int.Parse(Console.ReadLine());                        //50

            //int selectedmonth = index - 1;

            //if (selectedmonth > 12)
            //{
            //    selectedmonth = 12;
            //}


            //string[] months = new string[] { "January", "February", "March", "May", "April", "June", "July", "August", "September", "October", "November", "December", "BAD!!!!!!!!" };


            //if (index == 12 || index == 1 || index == 2)
            //{
            //    Console.WriteLine("The winter month of ....");
            //}
            //else if (index == 3 || index == 4 || index == 5)
            //{
            //    Console.WriteLine("The spring month of ....");
            //}
            //else if ( index == 6 || index == 7 || index == 8 )
            //{                                                                             //51
            //    Console.WriteLine("The summer month of ....");
            //}
            //else if (index == 9 || index == 10 || index == 11)
            //{
            //    Console.WriteLine("The autumn month of ....");
            //}
            //else
            //{
            //    Console.WriteLine("The dumdum month of .... ");
            //}


            //Console.WriteLine(months[selectedmonth]);


            //string number = (Console.ReadLine());

            ////split the number into two values the first number and the second number by the point 

            //string[] numbers = number.Split('.');

            //int ahhhh = int.Parse(numbers[0]);
            //int ahhhh2 = int.Parse(numbers[1]);

            //string first = "0";

            //if (ahhhh == 1) 
            //{

            //    first = "one";
            //}
            //else if (ahhhh == 2)
            //{

            //    first = "two";
            //}
            //else if (ahhhh == 3)
            //{

            //    first = "three";
            //}
            //else if (ahhhh == 4)
            //{

            //    first = "four";
            //}
            //else if (ahhhh == 5)
            //{

            //    first = "five";
            //}
            //else if (ahhhh == 6)
            //{

            //    first = "six";
            //}
            //else if (ahhhh == 7)
            //{

            //    first = "seven";
            //}
            //else if (ahhhh == 8)
            //{

            //    first = "eight";
            //}
            //else if (ahhhh == 9)
            //{

            //    first = "nine";
            //}
            //else if (ahhhh == 0)
            //{

            //    first = "zero";
            //}

            //string second = "0";

            //if (ahhhh2 == 1)
            //{

            //    second = "one";
            //}
            //else if (ahhhh2 == 2)
            //{

            //    second = "two";
            //}
            //else if (ahhhh2 == 3)
            //{

            //    second = "three";
            //}
            //else if (ahhhh2 == 4)
            //{

            //    second = "four";
            //}
            //else if (ahhhh2 == 5)
            //{

            //    second = "five";
            //}
            //else if (ahhhh2 == 6)
            //{

            //    second = "six";
            //}
            //else if (ahhhh2 == 7)
            //{

            //    second = "seven";
            //}
            //else if (ahhhh2 == 8)                                             //52
            //{

            //    second = "eight";
            //}
            //else if (ahhhh2 == 9)
            //{

            //    second = "nine";
            //}
            //else if (ahhhh2 == 0)
            //{

            //    second = "zero";
            //}


            //Console.WriteLine(first + " point " + second);

            //enter lengths of three sides of triangle

            //check if can be a triangle

            //then see if it is an equilateral triangle, a right angled triangle, or an unspecified form of triangle


            //int len1 = int.Parse(Console.ReadLine());                                                         //53
            //int len2 = int.Parse(Console.ReadLine());
            //int len3 = int.Parse(Console.ReadLine());

            //displays if can be a right angled triangle or not

            //if a*a + b*b == c*c , triangle yes

            //if (len1 == len2 && len2 == len3)
            //{
            //    Console.WriteLine("Equal....:)");
            //}
            //else if (len1 * len1 + len2 * len2 == len3 * len3)
            //{
            //    Console.WriteLine("yes triangle... :)");
            //}
            //else if (len1 + len2 > len3 && len2 + len3 > len1 && len3 + len1 > len2)                    //54
            //{
            //    Console.WriteLine("no!!!!!");
            //}
            //else
            //{
            //    Console.WriteLine("huh......");
            //}

            //int x = int.Parse(Console.ReadLine());                                                    //55

            //int y = 50;

            //if ( x / 2 > 10)
            //{
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    x = x / 3;
            //    y = x + 4;

            //    Console.WriteLine(y);

            //}


            //int x = int.Parse(Console.ReadLine());                                                    

            //int y = 1;

            //if ( x != 100)
            //{
            //    y = int.Parse(Console.ReadLine());

            //    if (x < y)
            //    {
            //        x = x - 3;                                                              //56
            //        y = x + 4;
            //    }
            //    else
            //    {
            //        x = x / 3 + 5;
            //        y = x + 20;
            //    }
            //}
            //Console.WriteLine(x + "" + y);

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //int a = 0;

            //if (x % y != 1 && y % x != 1)
            //{
            //    Console.WriteLine("Invalid");                                               //57
            //}
            //else if (x % y == 1)
            //{
            //    a = 10;
            //}
            //else if (y % x == 1)
            //{
            //    a = 20;
            //}

            //Console.WriteLine(a);


            //int a, x, y;

            //y = Int32.Parse(Console.ReadLine());
            //x = Int32.Parse(Console.ReadLine());

            //if (y > 0)
            //{
            //    a = x * 4 * y + 1;
            //}
            //else
            //{                                                                              //58
            //    a = x * 2 * y + 6;
            //}
            //Console.WriteLine(y);
            //Console.WriteLine(a);

            //Enter two numbers
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 && b % 2 == 0)
            //{
            //    Console.WriteLine("Both even!");
            //}
            //else if  (a % 2 != 0 && b % 2 != 0)                                                //59     
            //{
            //    Console.WriteLine("Both odd!");
            //}
            //else
            //{
            //    Console.WriteLine("meh...");
            //}

            //if both are odd or both are even, say so

            //else doesn't say anything special

            //double gtol = 3.785;

            //////convert gallon to liter
            //////convert liter to gallon

            //Console.WriteLine("1. Convert gallons to liters");
            //Console.WriteLine("2. Convert liters to gallons");
            ////Prompt user to enter 1 or 2 

            //int selection = int.Parse(Console.ReadLine());

            ////enter quantity

            //double quantity = double.Parse(Console.ReadLine());

            //if (selection == 1)
            //{
            //    Console.WriteLine(quantity * gtol + " Liters");                                   //60
            //}
            //else if (selection == 2)
            //{
            //    if (quantity < 0)
            //    {
            //        Console.WriteLine(quantity / gtol + " Gallons");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Positive number plsss");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //1g = 3.785l

            //Calcs and displays the value


            //Enter vehicle type
            //Console.WriteLine("Enter vehicle type");
            //string type = Console.ReadLine().ToUpper();

            //if (type != "M" && type != "C" && type != "T")
            //{
            //    Console.WriteLine("Valid vehicle type plsss");
            //}
            //else
            //{
            //    switch (type)
            //    {
            //        case "M":
            //            Console.WriteLine("$1 pls");                                  //61
            //            break;
            //        case "C":
            //            Console.WriteLine("$2 pls");
            //            break;
            //        case "T":
            //            Console.WriteLine("$4 plsss");
            //            break;

            //        default:
            //            Console.WriteLine("huh....");
            //            break;
            //    }
            //}

            //Displays price to pay

            //if not car, motorbike, or truck - error message displayed


            //User enter number

            //string error = "error";

            //Console.WriteLine("Number pls");

            //int fnumber = int.Parse(Console.ReadLine());

            ////Enter type of operation

            //string op = Console.ReadLine();

            ////Enter second number

            //int snumber = int.Parse(Console.ReadLine());

            ////Calculate and display result

            //switch (op)
            //{
            //    case "+":
            //        Console.WriteLine(fnumber + snumber);                             //62
            //        break;
            //    case "-":
            //        Console.WriteLine(fnumber - snumber);
            //        break;
            //    case "/":
            //        if (snumber != 0)
            //        {
            //            Console.WriteLine(fnumber / snumber);
            //        }
            //        else { Console.WriteLine(error); }

            //        break;

            //    case "*":
            //        Console.WriteLine(fnumber * snumber);
            //        break;
            //}



            //Finding the value of y

            //formula = 

            // y = (5 + x) / x + (x + 9) / (x - 4)


            //Input value of x 

            //int x = int.Parse(Console.ReadLine());
            //int y;

            //while ( x == 0 || x == 4)
            //{
            //    Console.WriteLine("Input number that isn't 0 or 4 -___- ");                       //63
            //    x = int.Parse(Console.ReadLine());
            //}

            //y = (5 + x) / x + (x + 9) / (x - 4);

            //Console.WriteLine(y);

            // find value of y AGAIN

            // IF x >= 0 formula : y = ( 7 + x ) / ( x - 3 ) + ( 3 - x ) / x 
            // else if x < 0, y = 40x / ( x - 5 ) + 3 
            // ( x is always less than 0 for
            // this, so don't need to watch out for it


            //int x = int.Parse(Console.ReadLine());

            //int y;

            //if (x >= 0 && x != 0 && x - 3 != 0)
            //{
            //    y = (7 + x) / (x - 3) + (3 - x) / x;                                                  //64
            //    Console.WriteLine(y);
            //}
            //else if (x < 0)
            //{
            //    y = (40 * x) / (x - 5) + 3;
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.WriteLine("Perhaps you tried to divide by 0....");
            //}

            // ax + b = 0

            // solved for x : x = -b / a

            //get a and b

            //Console.WriteLine("Enter a and b");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int x;


            ////if a is not 0, x = - b /a
            //if (a != 0)
            //{

            //    x = -b / a;
            //    //write x 
            //    Console.WriteLine(x);
            //}

            //// a first needs to not be 0, else cannot be performed (write undefined)                      //65
            //else if ( a == 0 )
            //{
            //    if (b != 0)
            //    {
            //        Console.WriteLine("Undefined");
            //    }
            //    else
            //    {
            //        //if a is 0 and b is 0, the result is indeterminate (write indeterminate form)
            //        Console.WriteLine("Indeterminate form");
            //    }
            //}

            //Quadratic Equation

            // ax ^ 2 + bx + c = 0

            //double a, b, c, x;

            //Console.WriteLine("Enter a , b , c ");

            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            //c = double.Parse(Console.ReadLine());

            //// if a, b , and c all = 0 : write indeterminate form

            //if (a == 0 && b == 0 && c == 0)
            //{
            //    Console.WriteLine("Indeterminate Form");
            //}
            //// if a, b = 0 but c != 0 : write undefined 
            //else if (a == 0 && b == 0 && c != 0)
            //{
            //    Console.WriteLine("Undefined");
            //}
            //// if a = 0 and b != 0 : write x = -(c / b)
            //else if (a == 0 && b != 0)
            //{
            //    x = -(c / b);
            //    Console.WriteLine(x);
            //}
            //// if a != 0 : introduce D. D = b^2 - 4 * a * c                               //66
            //double D = b * b - 4 * a * c; ;
            //if (a != 0)
            //{
            //    // if D < 0 : write complex roots
            //    if (D < 0)
            //    {
            //        Console.WriteLine("Complex Roots...");
            //    }
            //    else if (D != 0 && D > 0)
            //    // if D >= 0 + if D > 0, two solutions ///1/// = ( - b + sqrt.D ) / ( 2 * a ) ///2/// = ( - b - sqrt.D ) / ( 2 * a ) write both
            //    {
            //        x = -b + Math.Sqrt(D) / 2 * a;
            //        Console.WriteLine("x1 = " + x);
            //        x = -b - Math.Sqrt(D) / 2 * a;
            //        Console.WriteLine("x2 = " + x);                             //this part needs revision (DONE)
            //    }
            //    // if D >= 0 && D = 0,  x = ( - b ) / ( 2 * a ) write 
            //    else if (D == 0)
            //    {
            //        x = -b / 2 * a;
            //        Console.WriteLine(x);
            //    }
            //}


            //enter number

            //double number = double.Parse(Console.ReadLine());

            //// calculates and displays its square root
            //if ( number > 0)
            //{
            //    number = Math.Sqrt(number);                                             //67 REVIEW EXERCISE 23.6 - 1
            //}
            //else
            //// error if it is a negative number
            //{
            //    Console.WriteLine("error");
            //}


            //BMI TABLE VERSION 2


            //User enter height and weight 

            //float h = float.Parse(Console.ReadLine());
            ////67.913

            //float w = float.Parse(Console.ReadLine());
            ////168.7

            ////BMI = (weight - 703) / (height^2)

            //float BMI = (w * 703) / (h * h);

            //if (BMI < 15)
            //{
            //    Console.WriteLine("Very severely underweight");                       //68
            //}
            //else if (15 <= BMI && 16 > BMI)
            //{
            //    Console.WriteLine("Severely underweight");
            //}
            //else if (16 <= BMI && 18.5 > BMI)
            //{
            //    Console.WriteLine("Underweight");
            //}
            //else if (18.5 <= BMI && 25 > BMI)
            //{
            //    Console.WriteLine("Normal weight");
            //}
            //else if (25 <= BMI && 30 > BMI)
            //{
            //    Console.WriteLine("Overweight");
            //}
            //else if (30 <= BMI && 35 > BMI)
            //{
            //    Console.WriteLine("Severely overweight");
            //}
            //else if (BMI >= 35)
            //{
            //    Console.WriteLine("Very severely overweight");
            //}
            //else
            //{
            //    Console.WriteLine("Error.. Something you wrote must have been wrong....");
            //}

            ////display BMI 

            //// < 15 v s underweight

            //// 15 <= BMI < 16 s underweight

            //// 16 <= BMI < 18.5 underweight

            //// 18.5 <= BMI < 25 normal

            ////25 <= BMI < 30 overweight 

            ////30 <= BMI 35 < s overweight

            //// 35 <= BMI v s overweight

            //user enters 4 numbers

            //Calculates their sum
            //int x = 4;
            //int hmm = 0;

            //while (x > 0)
            //{
            //    int uhh;
            //    uhh = int.Parse(Console.ReadLine());                                                      //69

            //    hmm = uhh + hmm;
            //    x--;

            //}
            //Console.WriteLine(hmm);



            //int counter = 0;
            //int sumodd = 0;

            //while (counter < 20)
            //{
            //    int numbers = int.Parse(Console.ReadLine());                                                  //70

            //    if (numbers % 2 != 0)
            //    {
            //        sumodd = numbers + sumodd;
            //    }
            //    counter++;
            //}
            //Console.WriteLine(sumodd);

            //user input how many numbers (n)

            //int counter = int.Parse(Console.ReadLine());

            //int i = 0;

            //int output = 0;

            //while (i < counter)
            //{
            //    int sum = int.Parse(Console.ReadLine());                                                          //71
            //    output += sum;
            //    i++;
            //}

            //Console.WriteLine(output);
            ////enter n amount of numbers

            ////displays their sum



            Console.ReadLine();





        }

    }
}
