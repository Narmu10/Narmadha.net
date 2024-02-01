using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parameter(name: "Narm", age :10);
        }
        public static void Parameter(string name, int age)
        {
            Console.WriteLine(name +" "+ age);
            /*Console.WriteLine(age);*/
            Console.ReadKey();
        }
    }
}
