using System;

namespace String_Methods_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string copy
            // using the Copy method
            // to copy the value of str1
            // into str2
            string str1 = "Hello";
            string str2 = string.Copy(str1);
            Console.WriteLine(str2);
            #endregion string copy

            #region string Equals
            // Equals(string) method return false
            // because the given strings are not equal
            string strEqual1 = "Hello";
            string strEqual2 = "World";
            Console.WriteLine(strEqual1.Equals(strEqual2));
            #endregion string Equals

            #region string IndexOf
            //IndexOf() will return first occurrence index of specified character
            //if character not found in given string then return -1
            string a = "Hello";
            int b = a.IndexOf('l');
            int c = a.IndexOf('p');
            Console.WriteLine("Index of l & p is : "+ b + c);
            #endregion string IndexOf

            #region string replace
            //Replace method wiil replace given substring to specified string
            string strReplace1 = "Helloo";
            string strReplace2 = strReplace1.Replace("oo", "World");
            Console.WriteLine("Origional string is : "+ strReplace1);
            Console.WriteLine("Replaced string is : "+ strReplace2);
            #endregion string replace

            #region string Trim
            //Trim will remove all the extra white space from string
            string strTrim1 = "Hello world  ";
            string strTrim2 = strTrim1.Trim();
            Console.WriteLine("Trimed string is: "+ strTrim2);
            #endregion string Trim

            #region string contains
            //contains return true if a particular substring is present inside a given string
            string strcontain1 = "HelloWorld";
            string strcontain2 = "World";
            Console.WriteLine(strcontain1.Contains(strcontain2));
            #endregion string contains

            #region string UpperCase, LowerCase
            string strName = "Pinal Pambhar";
            //ToUpper() converts the string in uppercase.
            Console.WriteLine("Uppercase : " + strName.ToUpper());

            //ToLower() converts the string in uppercase.
            Console.WriteLine("Lowercase : " + strName.ToLower());
            #endregion string UpperCase, LowerCase
        }
    }
}
