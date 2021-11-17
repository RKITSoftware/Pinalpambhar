using System;
using System.Collections;

namespace Multiple_Inheritance
{
    // Interface 1
    interface lang
    {
        void languages();
    }

    // Parent class 1
    class language : lang
    {

        // Providing the implementation
        // of languages() method
        public void languages()
        {

            // Creating ArrayList
            ArrayList My_list = new ArrayList();

            // Adding elements in the
            // My_list ArrayList
            My_list.Add("C");
            My_list.Add("C++");
            My_list.Add("C#");
            My_list.Add("Java");

            Console.WriteLine("Languages: \n");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }

    // Interface 2
    interface cour
    {
        void courses();
    }

    // Parent class 2
    class course : cour
    {

        // Providing the implementation
        // of courses() method
        public void courses()
        {

            // Creating ArrayList
            ArrayList My_list = new ArrayList();

            // Adding elements in the
            // My_list ArrayList
            My_list.Add("System Design");
            My_list.Add("Fork Python");
            My_list.Add("DSA");
            My_list.Add("Fork Java");

            Console.WriteLine("\nCourses: \n");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
    // Child class
    class multiple : lang, cour
    {

        // Creating objects of Geeks1 and Geeks2 class
        language obj1 = new language();
        course obj2 = new course();

        public void languages()
        {
            obj1.languages();
        }

        public void courses()
        {
            obj2.courses();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of GeeksforGeeks class
            multiple obj = new multiple();
            obj.languages();
            obj.courses();
        }
    }
}
/* Output
 * Languages:
 * 
 * C
 * C++
 * C#
 * Java
 *
 * Courses:
 * 
 * System Design
 * Fork Python
 * Geeks Classes DSA
 * Fork Java
 */
