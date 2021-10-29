using System;

namespace publicAccessModifier
{
    class Program
    {
        class PublicAccessMod
        {
            public int num1;
        }
        static void Main(string[] args)
        {
            PublicAccessMod obj1 = new PublicAccessMod();
            //Direct access to public members  
            obj1.num1 = 100;
            Console.WriteLine("Number one value in main {0}", obj1.num1);
        }
    }
}
