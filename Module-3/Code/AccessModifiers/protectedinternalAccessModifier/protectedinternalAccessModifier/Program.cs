using System;
using protectedinternalAccessMod;

namespace protectedinternalAccessModifier
{
    class abc
    {
        Parent objp1 = new Parent();
        //not accessible in different assembly and non-derived class
        //objp1.value = 9;

    }
    class Program: Parent
    {
        static void Main(string[] args)
        {
            // Accessing value in another assembly only for derived class
            Program obj3 = new Program();

            // Member value is Accessible
            obj3.value = 9;
            Console.WriteLine("Value = " + obj3.value);
        }
    }
}
