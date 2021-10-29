using System;
using System.Collections;

namespace Hashtable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new hash table.

            // Add some elements to the hash table.
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!ht.ContainsKey("cplus"))
            {
                ht.Add("cplus", "c++");
                Console.WriteLine("Value added for key = \"cplus\": {0}", ht["cplus"]);
            }

            // When you use foreach to enumerate hash table elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            // To get the values alone, use the Values property.
            ICollection valueColl = ht.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for hash table values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            ICollection keyColl = ht.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for hash table keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\n Remove(\"vb\")");
            ht.Remove("vb");

            if (!ht.ContainsKey("vb"))
            {
                Console.WriteLine("Key \"vb\" is not found.");
            }

        }
    }
}
