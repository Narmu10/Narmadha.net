using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.ReadLine();
            sbyte a = 11;
            Console.WriteLine("sbyte");
            Console.WriteLine("a = " + a);
            Console.WriteLine("type of variable = " + a.GetType());
            Console.WriteLine("size of sbyte = " + sizeof(sbyte));
            Console.WriteLine("Min value of sbyte = " + sbyte.MinValue);
            Console.WriteLine("Max value of sbyte = " + sbyte.MaxValue);
            Console.ReadLine();

        }
    }
}
