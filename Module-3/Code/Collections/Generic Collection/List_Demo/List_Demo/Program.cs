using System;
using System.Collections.Generic;

namespace List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list.
            List<int> lst = new List<int>();

            // Add some values to the list.
            lst.Add(99);
            lst.Add(2040);
            lst.Add(45);
            lst.Add(67);

            //display elements of the list
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            //Constains() method Determines whether an element 
            //is in the List or not
            if (lst.Contains(2040))
            {
                Console.WriteLine("\nelement found \n");
            }
            else
            {
                Console.WriteLine("\nelement not found \n");
            }

            //Sort() method Sorts the elements in the entire List
            lst.Sort();
            Console.WriteLine("Sorted Array");
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            int index = lst.BinarySearch(99);
            if (index > 0)
            {
                Console.WriteLine("\nElement found at position {0}", index);
            }
            else
            {
                Console.WriteLine("\nElement not found");
            }

            //Copies the elements of the List to a new array.
            int[] output = lst.ToArray();
            Console.WriteLine("\n Array from list");
            foreach (int myarray in output)
            {
                Console.WriteLine(myarray);
            }

            //Removes a range of elements from the List
            Console.WriteLine("\nRemoveRange(2, 2)");
            lst.RemoveRange(2, 2);

            Console.WriteLine();
            foreach(int mylst in lst)
            {
                Console.WriteLine(mylst);
            }

            //Removes all elements from the List.
            lst.Clear();
            Console.WriteLine("\nAfter clearing the list");
            foreach (int mylst in lst)
            {
                Console.WriteLine(mylst);
            }


        }
    }
}
