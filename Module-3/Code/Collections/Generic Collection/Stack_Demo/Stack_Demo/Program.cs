using System;
using System.Collections.Generic;

namespace Stack_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string sub in stk)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine();

            //Removes and returns the object at the top of the Stack
            Console.WriteLine("\nPopping '{0}'", stk.Pop());

            foreach (string sub in stk)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine();

            //Returns the object at the top of the Stack without removing it.
            Console.WriteLine("Top element of the stack: {0}",stk.Peek());

            Console.WriteLine("\nArray copied from stack");
            // Create an array of the size of the stack and copy the
            // elements of the stack, starting at the 0th index
            string[] array1 = new string[stk.Count];
            stk.CopyTo(array1,0);

            foreach(string prolang in array1)
            {
                Console.WriteLine(prolang);
            }
            Console.WriteLine();

            // Create a second stack, using the constructor that accepts an
            // IEnumerable(Of T).
            Stack<string> stack2 = new Stack<string>(array1);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in stack2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nstack2.Contains(\"vb.net\") = {0}",stack2.Contains("vb.net"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }
    }
}
