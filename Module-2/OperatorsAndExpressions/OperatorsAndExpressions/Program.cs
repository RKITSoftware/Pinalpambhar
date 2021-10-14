using System;

namespace OperatorsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* sum = a + b + c; This is called expression
              where sum, a, b, c all are called operands 
              and +, = are called operators
             */

            #region LocalVariables
            int value1;
            int value2;
            bool isEven;
            #endregion LocalVariables

            #region Take_Inputs
            Console.Write("Enter 1st value to perform Various Operations = ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd value to perform Various Operations = ");
            value2 = Convert.ToInt32(Console.ReadLine());

            //This will Put Blank Line in Console
            Console.WriteLine(" ");
            #endregion Take_Inputs

            #region Arithmetic Operators
            Console.WriteLine("Arithmetic Operators");

            //Arithmetic Add
            Console.WriteLine("Addition of {0} + {1} = {2}", value1, value2, (value1 + value2));

            //Arithmetic Subtract
            Console.WriteLine("Subtraction of {0} - {1} = {2}", value1, value2, (value1 - value2));

            //Arithmetic Increment operator
            Console.WriteLine("Increment of {0} is {1}", value1, (++value1));

            //Arithmetic Decrement operator
            Console.WriteLine("Decrement of {0} is {1}", value2, (--value2));

            //This will Put Blank Line in Console
            Console.WriteLine(" ");

            #endregion Arithmetic Operators

            #region Relational Operators
            Console.WriteLine("Relational Operators");

            //Relational double Equals, less than and greater than 
            if (value1 == value2)
            {
                Console.WriteLine("{0} and {1} are not equal", value1, value2);
            }
            else if (value1 < value2)
            {
                Console.WriteLine("{0} is less than {1}", value1, value2);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", value1, value2);
            }

            //This will Put Blank Line in Console
            Console.WriteLine(" ");
            #endregion Relational Operators

            #region Logical Operators
            Console.WriteLine("Logical Operators");

            //Logical AND
            if ((value1 != value2) && (value1 > value2))
            {
                Console.WriteLine("{0} is greater than {1}", value1, value2);
            }

            //This will Put Blank Line in Console
            Console.WriteLine(" ");
            #endregion Logical Operators

            #region Bitwise Operators
            Console.WriteLine("Bitwise Operators");

            /* Below values are for understanding
             * value1 = 60 = 0011 1100 
             * value2 = 13 = 0000 1101
             * 
            Bitwise AND 
             * 0 0 = 0
             * 0 1 = 0
             * 1 0 = 0
             * 1 1 = 1
             * Now, let's do AND of 60,13
             * 0011 1100
             *     &
             * 0000 1101
             * ----------
             * 0000 1100 = 12
             */

            Console.WriteLine("ANDing of {0} & {1} is {2}", value1, value2, (value1 & value2));

            //This will Put Blank Line in Console
            Console.WriteLine(" ");
            #endregion Bitwise Operators

            #region Miscellaneous Operators
            Console.WriteLine("Miscellaneous Operators");

            //Miscellaneous ternary (? :) Operator
            isEven = (value1 % 2 == 0) ? true : false;

            if (isEven)
            {
                Console.WriteLine("{0} is Even", value1);
            }
            else
            {
                Console.WriteLine("{0} is Odd", value1);
            }
            #endregion Miscellaneous Operators
        }
    }
}
