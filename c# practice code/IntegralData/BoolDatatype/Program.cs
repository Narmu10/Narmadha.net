using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine("bool = " + a + " "+"size = " + sizeof(bool));
            Console.WriteLine("Type of variable= " + a.GetType());
            Console.ReadKey();
        }
    }
}
