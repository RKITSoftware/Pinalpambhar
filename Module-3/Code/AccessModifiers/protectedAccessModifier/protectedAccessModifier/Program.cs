using System;

namespace protectedAccessModifier
{
    class X
    {

        // Member x declared
        // as protected
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    // class Y inherits the
    // class X
    class Y : X
    {

        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();

            // Displaying the value of x
            Console.WriteLine("Value of x is : {0}", obj2.getX());

            // Error: inaccessible due to its protection level
           // Console.WriteLine("Value of x is : {0}", obj1.x);
        }
    }
}
