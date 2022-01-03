using System.IO;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressDetails details = new AddressDetails();
            details.HouseNo = 4;
            details.StreetName = "Ayodhya";
            details.City = "Rajkot";

            serialize(details);

            XmlSerializer deserializer = new XmlSerializer(typeof(AddressDetails));
            TextReader reader = new StreamReader(@"D:\XmlSerialization.xml");
            object obj = deserializer.Deserialize(reader);
            AddressDetails XmlData = (AddressDetails)obj;
            reader.Close();

        }

        static public void serialize(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (TextWriter writer = new StreamWriter(@"D:\XmlSerialization.xml"))
            {
                serializer.Serialize(writer, details);
            }

        }
    }
}
