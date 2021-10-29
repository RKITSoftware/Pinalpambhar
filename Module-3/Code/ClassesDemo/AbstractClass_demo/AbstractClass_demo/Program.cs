using AbstractClass_demo;
using System;

namespace AbstractClass_demo
{
    class Program: Customer
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.FirstName = "Pinal";
            p.LastName = "Pambhar";
            p.FullName();
        }

        public override void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }
}
