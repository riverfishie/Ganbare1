using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganbare1
{
    class face
    {


        public void showFace()
        {
            //string space1 = " ";
            //string space5 = "     ";
            //string space2 = "  ";
            //string space3 = "   ";
            //string space10 = "          ";
            //string space9 = "         ";
            //string dot = ".";

            //string firstline = space10 + dot + space10;
            //string secondline = space5 + dot + space9 + dot;
            //string thirdline = space2 + dot + space10 + space5 + dot;
            //string fourthline = dot + space5 + dot + space5 + space1 + dot;
            //string fifthline = dot + space10 + space9 + dot;
            //string sixthline = space2 + dot + space3 + dot + dot + dot + dot + dot + dot + dot + dot + dot + space3 + dot;
            //string seventhline = space5 + dot + space5 + dot;

            //string alllines = firstline + secondline + thirdline + fourthline + fifthline + sixthline + seventhline + firstline;

            //Console.WriteLine(space10 + dot + space10); // line 1
            //Console.WriteLine(space5 + dot + space9 + dot); //line 2
            //Console.WriteLine(space2 + dot + space10 + space5 + dot); //line 3
            //Console.WriteLine(dot + space5 + dot + space5 + space1 + dot + space1 + space5 + dot); //line 4
            //Console.WriteLine(dot + space10 + space9 + dot); //line 5
            //Console.WriteLine(space2 + dot + space2 + space1 + dot + dot + dot + dot + dot + dot + dot + dot + dot + space3 + dot); //line 6
            //Console.WriteLine(space5 + dot + space9 + dot); //line7
            //Console.WriteLine(space10 + dot + space10); //line8


            //Console.WriteLine(dot);
            //Console.WriteLine(space1);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(dot);
            //}

            //Console.WriteLine(alllines);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write(space1);
            //}
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.Write(dot);                  //Line 1
            //}
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write(space1) ;
            //}

            ////

            //Console.WriteLine();

            ////
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.Write(space1);
            //}
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.Write(dot);                  //Line 1
            //}
            //for (int i = 0; i <= 8; i++)
            //{
            //    Console.Write(space1);
            //}
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.Write(dot);                  //Line 1
            //}



            string space = " ";
            string dot = ".";
            string o = "O";

            int i = 7;

            while (i != 0) 
            { 
                //1
                if (i == 7)
                {
                    for (int p = 0; p < 5; p++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);
                    Console.Write(dot);
                    Console.Write(dot);
                    Console.Write(dot);
                    i--;

                }

                Console.WriteLine();

                //2
                if (i == 6)
                {
                    for (int q = 0; q < 3; q++)
                    {
                        Console.Write(space);
                    }
                    Console.Write(dot);

                    for (int q = 0; q < 6; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);
                    i--;
                }

                Console.WriteLine();

                //3
                if (i == 5)
                {
                    for (int q = 0; q <= 0; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);

                    for (int q = 0; q <= 9; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);
                    i--;

                }

                //4
                Console.WriteLine();

                if (i == 4)
                {
                    for (int q = 0; q <= 0; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);

                    for (int q = 0; q <= 1; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(o);

                    for (int q = 0; q <= 3; q++)
                    {
                        Console.Write(space);
                    }
                    Console.Write(o);

                    for (int q = 0; q <= 1; q++)
                    {
                        Console.Write(space);
                    }
                    Console.Write(dot);

                    i--;

                }

                Console.WriteLine();
                //5
                if (i == 3)
                {
                    Console.Write(dot);

                    for (int q = 0; q < 2; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);

                    for (int q = 0; q < 2; q++)
                    {
                        Console.Write(space);
                    }

                    Console.Write(dot);

                    for (int q = 0; q < 3; q++)
                    {
                        Console.Write(space);
                    }
                    Console.Write(dot);

                    for (int q = 0; q < 2; q++)
                    {
                        Console.Write(space);
                    }
                    Console.Write(dot);

                    i--;
                }

                Console.WriteLine();
                //6
                if (i == 2)
                {  
                    Console.Write(dot);
                    for (int q = 0; q < 2; q++)
                    {
                        Console.Write(space);
                    }
                    for (int q = 0; q < 3; q++)
                    {
                        Console.Write(dot);
                    }
                    for (int q = 0; q < 1; q++)
                    {
                        Console.Write(space);
                    }
                    for (int q = 0; q < 3; q++)
                    {
                        Console.Write(dot);
                    }
                    for (int q = 0; q < 2; q++)
                    {
                        Console.Write(space);
                    }
                    Console.Write(dot);

                    i--;
                }
                Console.WriteLine();
                //7
                if (i == 1)
                {
                    for (int q = 0; q < 2; q++)
                    {
                        Console.Write(space);
                    }
                    for (int q = 0; q < 10; q++)
                    {
                        Console.Write(dot);
                    }

                    i--;
                }
                else
                {
                    Console.WriteLine("???????");
                }

                i = 7;



                Console.WriteLine();
                Console.ReadLine();
            }

        }

    }
}
