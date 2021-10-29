using System;
using System.Collections;

namespace Stack_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Stack.
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            // Displays the properties and values of the Stack.
            Console.WriteLine("Count:    {0}", stk.Count);
            Console.Write("Values:\t");
            PrintValues(stk);

            //remove element from the stack
            Console.Write("Values:\t");
            stk.Pop();
            PrintValues(stk);
        }

        #region Method:PrintValues
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write("{0}  ", obj);
            }
            Console.WriteLine();
        }
        #endregion Method:PrintValues
    }
}
