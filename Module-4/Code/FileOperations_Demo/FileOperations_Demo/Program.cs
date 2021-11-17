using System;
using System.IO;

namespace FileOperations_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\RKIT\Module-4\MyTest.txt";
            string destinationFile = @"D:\RKIT\Module-4\MyTestCopy.txt";
            string MovedPath = @"D:\RKIT\Module-4\Code\MyTestCopy.txt";

            #region Create File
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            #endregion Create File

            #region Append File
            //Append new string to the file
            //Environment.NewLine is used to add newline
            string appendText = "My Name is Pinal Pambhar" + Environment.NewLine;
            File.AppendAllText(path, appendText);
            #endregion Append File

            #region Read File
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                //check availability of file
                if (File.Exists(path))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist!");
                }
            }
            #endregion Read File

            #region Copy File
            // Copy text files.

            try
            {
                File.Copy(path, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            #endregion Copy File           

            #region Move File
            try
            {
                // Moving the file file.txt to location C:\gfg.txt
                File.Move(path, MovedPath);
                Console.WriteLine("Moved");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            #endregion Move File            

            #region Delete File
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(MovedPath))
                {
                    // If file found, delete it    
                    File.Delete(MovedPath);
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
            #endregion Delete File
        }
    }
}

/* Output
 * 
 * Hello
 * And
 * Welcome
 * My Name is Pinal Pambhar
 * Moved
 * File deleted.
*/
