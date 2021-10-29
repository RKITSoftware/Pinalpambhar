using System;
using System.Collections;

namespace Queue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Queue.
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            // Displays the properties and values of the Queue.
            Console.WriteLine("Count:    {0}", q.Count);
            Console.Write("Values:");
            PrintValues(q);

            //peek returns the oldest element that is at the start of the 
            //Queue but does not remove
            Console.WriteLine("oldest element:    {0}", q.Peek());

            //Dequeue removes the oldest element from the start of the Queue.
            q.Dequeue();

            Console.Write("Values:");
            PrintValues(q);
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
