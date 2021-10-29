using System;

namespace SealedClass_Demo
{
    // Sealed class
    sealed class SealedClass
    {

        // Addition Method
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    //class Program: SealedClass; this cannot be done
    class Program  
    {
        static void Main(string[] args)
        {
            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
}
