using System;
using System.Collections.Generic;

namespace Loop_Iteration_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for loop
            Console.WriteLine("illustrate of for loop");

            // Here, x and y are temporary variables to iterate a loop
            // for loop begins when x=1
            // and runs till x <=5
            // It will generate triangle shape
            for (int x = 1; x <= 5; x++)
            {
                // This will starts from 1
                // and ends at the current value of x
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" "); // This will put a blank line in Console
            }
            Console.WriteLine(" "); // This will put a blank line in Console
            #endregion for loop

            #region foreach loop
            Console.WriteLine("illustrate of foreach loop");

            //This lstWeekDays list contains a week days as a string
            List<string> lstWeekDays = new List<string>() {"Sunday", "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday" , "Saturday" };

            foreach (string item in lstWeekDays)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" "); // This will put a blank line in Console
            #endregion foreach loop

            #region while loop
            Console.WriteLine("illustrate of while loop");

            // for loop begins when i=1
            // and runs till i < 10 or i = 9
            int i = 1; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);
                i++; // increment
            }

            Console.WriteLine(" "); // This will put a blank line in Console
            #endregion while loop

            #region do while loop
            Console.WriteLine("illustrate of do-while loop");

            // for loop begins when number=1
            // and runs till number < 5 or number = 4

            int number = 1; // initialization

            do
            {
                Console.WriteLine("number = {0}", number);
                number++;// increment

            } while (number < 5); // condition

            Console.WriteLine(" "); // This will put a blank line in Console
            #endregion do while loop

            #region break
            Console.WriteLine("illustrate of break loop");

            // for loop begins when p=1
            // and runs till p < 10
            int p = 1; // initialization

            while (p < 10) // condition
            {
                // if condition gets true, then break the loop
                if(p == 6)
                {
                    break;
                }
                Console.WriteLine("p = {0}", p);
                p++; // increment
            }

            Console.WriteLine(" "); // This will put a blank line in Console
            #endregion break

            #region continue
            Console.WriteLine("illustrate of continue loop");

            // for loop begins when q=0
            // and runs till q < 8
            int q = 0; // initialization

            while (q < 8) //condition
            {
                q++;
                // if condition gets true, then current iteration will be skip
                if (q == 2)
                    continue;

                Console.WriteLine(q);               
            }

            Console.WriteLine(" "); // This will put a blank line in Console
            #endregion continue
        }
    }
}
