using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region One Dimensional Array
            Console.WriteLine("One Dimensional Array");

            // declares a 1D Array of string.
            string[] weekDays;

            // allocating memory for days.
            weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",
                                       "Thu", "Fri", "Sat"};

            // Displaying Elements of array
            foreach (string day in weekDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("");
            #endregion One Dimensional Array

            #region MultiDimensional Array
            Console.WriteLine("MultiDimensional Array");

            // Two-dimensional array
            int[,] intarray = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 } };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("2DArray[{0}][{1}]: " + intarray[i, j] , i, j);
                }
            }

            Console.WriteLine("");
            #endregion MultiDimensional Array

            #region Jagged Array
            Console.WriteLine("Jagged Array");

            //String Array to store employee names
            string[] employeeNames = new string[3];
            employeeNames[0] = "Mark";
            employeeNames[1] = "Matt";
            employeeNames[2] = "John";

            //Jagged Array to store employee qualifications
            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelor";
            jaggedArray[0][1] = "Master";
            jaggedArray[0][2] = "Docotrate";

            jaggedArray[1][0] = "Bachelor";

            jaggedArray[2][0] = "Bachelor";
            jaggedArray[2][1] = "Master"; 
            
            //Loop thru and print out elemens of jagged Array
            for(int x = 0; x < jaggedArray.Length; x++)
            {
                Console.WriteLine(employeeNames[x]);
                Console.WriteLine("--------");

                //storing Jagged Array elements into inner Array
                string[] innerArray = jaggedArray[x];

                for (int y = 0; y < innerArray.Length; y++)
                {
                    Console.WriteLine(innerArray[y]);
                }
                Console.WriteLine();
            }

            #endregion Jagged Array
        }
    }
}
