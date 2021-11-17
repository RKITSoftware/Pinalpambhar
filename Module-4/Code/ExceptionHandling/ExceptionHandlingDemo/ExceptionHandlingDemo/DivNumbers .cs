using System;

namespace ExceptionHandlingDemo
{
    class DivNumbers
    {
        int result;

        //constructor for set result value
        DivNumbers()
        {
            result = 0;
        }

        //Method for divide numbers
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2; //this statement can occurre an exception
            }
            //catch handles an exception
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            //finally exceutes wether exception occurres or not
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
        }
    }
}

/*output
 * Exception caught: System.DivideByZeroException: Attempted to divide by zero.
 * Result: 0
 */
