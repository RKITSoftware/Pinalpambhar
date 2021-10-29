using System;
using System.Collections.Generic;

namespace Queue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nDequeuing '{0}'", q.Dequeue());
            Console.WriteLine("Peek shows top element of the queue: {0}", q.Peek());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(q.ToArray());

            Console.WriteLine("\nContents of the copied queue");
            foreach (string sub in queueCopy)
            {
                Console.WriteLine(sub);
            }

            // Create an array the size of the queue and copy the
            // elements of the queue, starting at the 0th index
            string[] array2 = new string[q.Count];
            q.CopyTo(array2, 0);

            Console.WriteLine("\nContents of the array copied from queue");
            foreach (string myarray in queueCopy)
            {
                Console.WriteLine(myarray);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"c++\") = {0}",queueCopy.Contains("c++"));

            Console.WriteLine("queueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("queueCopy.Count = {0}", queueCopy.Count);
        }
    }
}
