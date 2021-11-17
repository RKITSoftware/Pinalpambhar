using System;

namespace Interface_Demo
{
    interface calc1
    {
        int add(int a, int b);
    }
    interface calc2
    {
        int sub(int x, int y);
    }
    interface calc3
    {
        int mul(int r, int s);
    }
    interface calc4
    {
        int div(int c, int d);
    }

    #region class calculation

    //class is implementing all interface
    class Calculation : calc1, calc2, calc3, calc4
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int mul(int r, int s)
        {
            return r * s;
        }
        public int div(int c, int d)
        {
            return c / d;
        }
    }
    #endregion class calculation
    class Program
    {
        static void Main(string[] args)
        {
            //object of calculation to access calculation class's members
            Calculation c = new Calculation();

            Console.WriteLine("Multiple Inheritance concept Using Interfaces : ");
            Console.WriteLine("Addition: " + c.add(8, 2));
            Console.WriteLine("Substraction: " + c.sub(20, 10));
            Console.WriteLine("Multiplication :" + c.mul(5, 2));
            Console.WriteLine("Division: " + c.div(20, 10));
        }
    }
}
/* Output
 * Multiple Inheritance concept Using Interfaces :
 * Addition: 10
 * Substraction: 10
 * Multiplication :10
 * Division: 2
 */