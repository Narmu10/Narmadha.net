using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializationandDeserialization
{
    [Serializable]
    class Emp
    {
        public int Empid;
        public string Name;
        public Emp(int Empid, string Name)
        {
            this.Empid = Empid;
            this.Name = Name;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        { 
            //this is to see outout in text file
            FileStream file = new FileStream("C:\\Users\\narmadha_anbalagan\\Documents\\Github\\Narmadha.net\\SerializationandDeserialization\\SerializationandDeserialization\\serialization.docx", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            // serialization
            Emp employee = new Emp(2627, "Sparsh");
            format.Serialize(file, employee);
            // can see output here 
            string str=JsonSerializer.Serialize(format);
            Console.WriteLine(str);
            Console.ReadLine();

            //deserialization
            /*Emp emp1 = (Emp)format.Deserialize(file);
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Empid);
            Console.ReadKey();*/
        }
    }
}
