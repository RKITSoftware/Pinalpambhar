using System;

namespace Single_Level_Inheritance
{
    public class Employee
    {
        public float salary = 40000;
    }
    public class Programmer : Employee
    {
        public float bonus = 10000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);
        }
    }
}
/* Output
 * Salary: 40000
 * Bonus: 10000
*/
