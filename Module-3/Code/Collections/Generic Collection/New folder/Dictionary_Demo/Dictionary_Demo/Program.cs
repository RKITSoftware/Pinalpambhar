using System;
using System.Collections.Generic;

namespace Dictionary_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of strings, with string keys.
            Dictionary<string, string> dct = new Dictionary<string, string>();

            // Add some elements to the dictionary.
            dct.Add("cs", "cs.net");
            dct.Add("vb", "vb.net");
            dct.Add("or", "oracle");
            dct.Add("cplus", "c++");

            // When a program often has to try keys that turn out not to
            // be in the dictionary, TryGetValue can be a more efficient
            // way to retrieve values.
            string value = "";
            if (dct.TryGetValue("ab", out value))
            {
                Console.WriteLine("For key = \"ab\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"ab\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!dct.ContainsKey("ht"))
            {
                dct.Add("ht", "html");
                Console.WriteLine("Value added for key = \"ht\": {0}",
                dct["ht"]);
            }

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in dct)
            {
                Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);
            }


            // To get the values alone, use the Values property.
            Dictionary<string, string>.ValueCollection valueColl = dct.Values;
            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            Dictionary<string, string>.KeyCollection keyColl = dct.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"or\")");
            dct.Remove("or");

            if (!dct.ContainsKey("or"))
            {
                Console.WriteLine("Key \"or\" is not found.");
            }
        }
    }
}
