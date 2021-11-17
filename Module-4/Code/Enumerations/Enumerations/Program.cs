using System;

namespace Enumerations
{
    class Program
    {
        // making an enumerator 'month'
        public enum month
        {

            // following are the data members
            jan = 1,
            feb = 2,
            mar = 3,
            apr = 4,
            may = 5

        }
        static void Main(string[] args)
        {
            // getting the integer values of data members..
            Console.WriteLine("The value of jan in month enum is " + (int)month.jan);
            Console.WriteLine("The value of feb in month enum is " + (int)month.feb);
            Console.WriteLine("The value of mar in month enum is " + (int)month.mar);
            Console.WriteLine("The value of apr in month enum is " + (int)month.apr);
            Console.WriteLine("The value of may in month enum is " + (int)month.may);

            /*Output
             * The value of jan in month enum is 1
               The value of feb in month enum is 2
               The value of mar in month enum is 3
               The value of apr in month enum is 4
               The value of may in month enum is 5
            */

        }
    }
}
