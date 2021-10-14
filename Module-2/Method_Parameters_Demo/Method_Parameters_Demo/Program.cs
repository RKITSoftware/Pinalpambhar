using System;

namespace Method_Parameters_Demo
{
    class Program
    {
        #region Main Method
        static void Main(string[] args)
        {
            #region Call value type method
            // The value of the parameter
            // is already assigned
            string str1 = "Pinal";
            string str2 = "Pambhar";
            
            // calling addstr method with value type parameter
            string res = addstr(str1, str2);
            Console.WriteLine(res);
            Console.WriteLine("");
            #endregion Call value type method

            #region Call Ref type method
            // Assigning value
            string val = "Dog";

            // Pass as a reference parameter
            CompareValue(ref val);

            // Display the given value
            Console.WriteLine(val);
            Console.WriteLine("");
            #endregion Call Ref type method

            #region Call default type parameter
            detail("XYZ", 123);
            detail("ABC", 456, "B-");
            detail("DEF", 789, "B+", "Software Developer");
            #endregion Call default type parameter
        }
        #endregion Main Method

        #region Value Type Parameter
        public static string addstr(string s1, string s2)
        {
            return s1 + s2;
        }
        #endregion Value Type Parameter

        #region Ref Type Parameter
        static void CompareValue(ref string val1)
        {
            // Compare the value
            if (val1 == "Dog")
            {
                Console.WriteLine("Matched!");
            }

            // Assigning new value
            val1 = "Cat";
        }
        #endregion Ref Type Parameter

        #region Default value parameter
        // This method contains two regular 
        // parameters, i.e. ename and eid
        // And two optional parameters, i.e. 
        // bgrp and dept 
        static public void detail(string ename, int eid, string bgrp = "A+", string dept = "Review-Team")
        {
            Console.WriteLine("Employee name: {0}", ename);
            Console.WriteLine("Employee ID: {0}", eid);
            Console.WriteLine("Blood Group: {0}", bgrp);
            Console.WriteLine("Department: {0}", dept);
            Console.WriteLine("");
        }
        #endregion Default value parameter
    }
}
