using System;
using System.Collections;

namespace ArrayList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList.
            ArrayList al = new ArrayList();
            string str = "Pinal Pambhar";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("    Count:    {0}", al.Count);
            Console.WriteLine("    Capacity: {0}", al.Capacity);
            Console.Write("    Values:");
            PrintValues(al);
        }

        #region Method:PrintValues
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write("   {0}", obj);
            }             
            Console.WriteLine();
        }
        #endregion Method:PrintValues
    }
}
