using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // out parameter
            int i;
            Add(out i);
            Console.WriteLine("Add value: " + i);
            Console.ReadKey();



        }
        public static void Add(out int i)
        {
            i = 30;
            i += i;
        }
    }
}
