using System;

namespace PartialClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of class partial
            PartialClass partial = new PartialClass();
            partial.FirstName = "Pinal";
            partial.LastName = "Pambhar";
            partial.FullName();
        }
    }
}
