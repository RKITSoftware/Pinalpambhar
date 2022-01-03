using Newtonsoft.Json;
using System;

namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmp = new Employee()
            {
                EmployeeId = 1,
                Name = "Pinal"
            };

            // Convert Employee object to JOSN string format
            string jsonData = JsonConvert.SerializeObject(objEmp);
            Console.WriteLine(jsonData);

            string json = @"{
                              'Name': 'Pinal',
                              'EmployeeId': 1
                            }";
            //deserialize JSON Object
            Employee ObjEmployee = JsonConvert.DeserializeObject<Employee>(json);
            Console.Write(ObjEmployee.Name);
        }
    }
}
