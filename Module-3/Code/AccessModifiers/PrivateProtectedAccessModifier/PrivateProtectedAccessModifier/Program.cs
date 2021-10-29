using System;

namespace PrivateProtectedAccessModifier
{
    class Parent
    {
        // Member is declared as private protected
        private protected int value;

        // value is Accessible only inside the class
        public void setValue(int v)
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }

    class Child : Parent
    {
        public void showValue()
        {
            // Trying to access value
            // Inside a derived class

            Console.WriteLine("Value = " + value);
            // value is accessible
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Parent();

            // obj.value = 5;
            // Also gives an error

            // Use public functions to assign
            // and use value of the member 'value'
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());
        }
    }
}
