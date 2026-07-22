using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lab2
{
    // Serialization class - must be public for XML serialization
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public void Display()
        {
            Console.WriteLine($"  ID: {Id}");
            Console.WriteLine($"  Name: {Name}");
            Console.WriteLine($"  Department: {Department}");
            Console.WriteLine($"  Salary: ${Salary:F2}");
        }
    }

    internal class SerializationDemo
    {
        /*
        static void Main(string[] args)
        {
            

            // Create an employee object
            Employee original = new Employee
            {
                Id = 101,
                Name = "Saugat Thapa",
                Department = "Computer Science",
                Salary = 85000.50
            };

            // 1. JSON Serialization
            Console.WriteLine("1. JSON Serialization:");
            string jsonFile = "employee.json";
            
            Console.WriteLine("   Original object:");
            original.Display();

            // Serialize to JSON
            string jsonString = JsonSerializer.Serialize(original, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFile, jsonString);
            Console.WriteLine($"\n   JSON written to '{jsonFile}':");
            Console.WriteLine(jsonString);

            // Deserialize from JSON
            string readJson = File.ReadAllText(jsonFile);
            Employee deserializedJson = JsonSerializer.Deserialize<Employee>(readJson);
            Console.WriteLine("   Deserialized from JSON:");
            deserializedJson.Display();
            Console.WriteLine();

            // 2. XML Serialization
            Console.WriteLine("2. XML Serialization (using XmlSerializer):");
            string xmlFile = "employee.xml";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            using (StreamWriter writer = new StreamWriter(xmlFile))
            {
                xmlSerializer.Serialize(writer, original);
            }
            Console.WriteLine($"   XML written to '{xmlFile}':");
            Console.WriteLine(File.ReadAllText(xmlFile));

            // Deserialize from XML
            Employee deserializedXml;
            using (StreamReader reader = new StreamReader(xmlFile))
            {
                deserializedXml = (Employee)xmlSerializer.Deserialize(reader);
            }
            Console.WriteLine("   Deserialized from XML:");
            deserializedXml.Display();
            Console.WriteLine();

            // 3. Binary Serialization using custom format (StreamWriter/Reader)
            Console.WriteLine("3. Custom Binary-style Serialization:");
            string binaryFile = "employee.dat";

            using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFile, FileMode.Create)))
            {
                writer.Write(original.Id);
                writer.Write(original.Name);
                writer.Write(original.Department);
                writer.Write(original.Salary);
            }
            Console.WriteLine($"   Binary data written to '{binaryFile}'");

            Employee deserializedBinary = new Employee();
            using (BinaryReader reader = new BinaryReader(File.Open(binaryFile, FileMode.Open)))
            {
                deserializedBinary.Id = reader.ReadInt32();
                deserializedBinary.Name = reader.ReadString();
                deserializedBinary.Department = reader.ReadString();
                deserializedBinary.Salary = reader.ReadDouble();
            }
            Console.WriteLine("   Deserialized from binary file:");
            deserializedBinary.Display();
            Console.WriteLine();

            // Verify all three match
            Console.WriteLine("Verification: All deserialized objects match original?");
            Console.WriteLine($"  JSON match:    {deserializedJson.Id == original.Id && deserializedJson.Name == original.Name}");
            Console.WriteLine($"  XML match:     {deserializedXml.Id == original.Id && deserializedXml.Name == original.Name}");
            Console.WriteLine($"  Binary match:  {deserializedBinary.Id == original.Id && deserializedBinary.Name == original.Name}");

            // Clean up
            File.Delete(jsonFile);
            File.Delete(xmlFile);
            File.Delete(binaryFile);
            Console.WriteLine("\n4. Cleanup: Temporary files deleted.");
        }
        */
    }
}
