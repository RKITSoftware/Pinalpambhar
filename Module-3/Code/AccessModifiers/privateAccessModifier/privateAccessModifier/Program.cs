using System;

namespace privateAccessModifier
{
    class Program
    {
        class PrivateAccessMod
        {
            public int num1;
            int num2;
        }
        static void Main(string[] args)
        {
            PrivateAccessMod ob1 = new PrivateAccessMod();
            //Direct access to public members  
            ob1.num1 = 100;
            //Access to private member is not permitted  
            ob1.num2 = 20;
            Console.WriteLine("Number one value in main {0}", ob1.num1);
            Console.ReadLine();
        }
    }
}
