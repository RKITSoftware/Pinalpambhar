using System;

namespace internalAccessModifier
{
    // Declare class Complex as internal
    public class Complex
    {

        internal int real;
        internal int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class Complex
            // in separate class but within
            // the same assembly
            Complex c = new Complex();

            // Accessible in class Program
            c.setData(2, 1);
            c.displayData();
        }
    }
}
