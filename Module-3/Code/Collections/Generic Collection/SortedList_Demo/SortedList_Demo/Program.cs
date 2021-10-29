using System;
using System.Collections.Generic;

namespace SortedList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new sorted list of strings, with string keys
            SortedList<string, string> sl = new SortedList<string, string>();

            // Add some elements to the list.
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            // When a program often has to try keys that turn out not to
            // be in the list, TryGetValue can be a more efficient
            // way to retrieve values.
            string value = "";
            if (sl.TryGetValue("ora", out value))
            {
                Console.WriteLine("For key = \"ora\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"ora\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!sl.ContainsKey("ht"))
            {
                sl.Add("ht", "html");
                Console.WriteLine("Value added for key = \"ht\": {0}", sl["ht"]);
            }

            // When you use foreach to enumerate list elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            // To get the values alone, use the Values property.
            IList<string> ilistValues = sl.Values;

            // The elements of the list are strongly typed with the
            // type that was specified for the SortedList values.
            Console.WriteLine();
            foreach (string s in ilistValues)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // The Values property is an efficient way to retrieve
            // values by index.
            Console.WriteLine("\nIndexed retrieval using the Values " +
                "property: Values[2] = {0}", sl.Values[2]);

            // To get the keys alone, use the Keys property.
            IList<string> ilistKeys = sl.Keys;

            // The elements of the list are strongly typed with the
            // type that was specified for the SortedList keys.
            Console.WriteLine();
            foreach (string s in ilistKeys)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // The Keys property is an efficient way to retrieve
            // keys by index.
            Console.WriteLine("\nIndexed retrieval using the Keys " +
                "property: Keys[2] = {0}", sl.Keys[2]);

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"ht\")");
            sl.Remove("ht");

            if (!sl.ContainsKey("ht"))
            {
                Console.WriteLine("Key \"ht\" is not found.");
            }
        }
    }
}
