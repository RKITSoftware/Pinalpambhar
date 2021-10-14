using System;

namespace DateTime_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating TimeSpan object of one month(as 30 days)  
            System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);
            System.DateTime newDate1 = DateTime.Now.Add(duration);
            System.Console.WriteLine(newDate1);

            // Adding days to a date  
            DateTime today = DateTime.Now;
            DateTime newDate2 = today.AddDays(20);
            Console.WriteLine(newDate2);

            // Parsing  
            string dateString = "Thu Oct 14, 2021";
            DateTime dateTime12 = DateTime.Parse(dateString);
            Console.WriteLine(dateTime12.GetType());

            // Date Difference  
            System.DateTime date1 = new System.DateTime(2021, 3, 10, 2, 15, 10);
            System.DateTime date2 = new System.DateTime(2021, 7, 15, 6, 30, 20);

            // diff1 gets 127 days, 04 hours, 15 minutes and 10 seconds.
            System.TimeSpan diff1 = date2.Subtract(date1);
            Console.WriteLine(diff1);

            // Universal Time  
            DateTime objDate = new DateTime(2021, 12, 20, 10, 20, 30);
            Console.WriteLine(objDate.ToUniversalTime());
        }
    }
}
