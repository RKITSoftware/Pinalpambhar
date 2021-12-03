using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\RKIT\Module-5\serial.txt";

            //serialization
            Employee Objemp = new Employee(1, "Pinal");
            //file stream for for create or open file
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            //binaryformatter object created
            BinaryFormatter formatter = new BinaryFormatter();

            //serializing file stream which contains objemp's data
            formatter.Serialize(stream, Objemp);
            stream.Close();
            Console.WriteLine("File Saved at" + path);

            //deserialization
            //file stream for for create or open file
            FileStream stream1 = new FileStream(path, FileMode.OpenOrCreate);

            //binaryformatter object created
            BinaryFormatter formatter1 = new BinaryFormatter();

            //deserializing file stream which contains objemp's data
            Employee objemployee = (Employee)formatter1.Deserialize(stream1);

            //printing data of deserialized object
            Console.WriteLine("id = " + objemployee.id);
            Console.WriteLine("Name = " + objemployee.name);
        }
    }
}
